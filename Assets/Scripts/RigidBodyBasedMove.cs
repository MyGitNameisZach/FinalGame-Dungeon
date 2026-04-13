using TMPro;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class RigidBodyBasedMove : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5f;
    [SerializeField] float accel = 12f;
    [SerializeField] float decel = 16f;
    private UIMessage ui;

    [SerializeField] int score = 0;
    TargetInteractable targetInteractable;
    public TextMeshProUGUI scoreText;
    [SerializeField] DoorCode doorCode;


    Vector2 currentVelocity;
    Rigidbody2D rb;

    float moveX;
    float moveY;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        targetInteractable = GetComponent<TargetInteractable>();
        ui = FindObjectOfType<UIMessage>();
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 dir = new Vector2(moveX, moveY);
        Vector2 targetVelocity = dir * maxSpeed;

        float rate = (dir.sqrMagnitude > 0f) ? accel : decel;

        currentVelocity = Vector2.MoveTowards(
            currentVelocity,
            targetVelocity,
            rate * Time.fixedDeltaTime
        );

        rb.linearVelocity = currentVelocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            score += 1;
            other.gameObject.SetActive(false);
            doorCode.hasCoin = true;
            ui.ShowMessage("Open the door!");
            Debug.Log("Picked up! Score = " + score);
            scoreText.text = "Score: " + score;
        }
    }
}
