using UnityEngine;
using UnityEngine.SceneManagement;

public class BouncingEnemy : MonoBehaviour
{
    public float speed = 5f;
    public bool hasArmor = false;

    private UIMessage ui;

    private Rigidbody2D rb;

    void Start()
    {
        ui = FindObjectOfType<UIMessage>();
        rb = GetComponent<Rigidbody2D>();

        // Give it a random starting direction
        Vector2 randomDirection = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;

        rb.linearVelocity = randomDirection * speed;
    }
    void Update()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;

        if (hasArmor)
        {
            ui.showArmor("Armor ON");
        }else
        {
            ui.showArmor("Armor OFF");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
    {
            if (!hasArmor)
            {
                Debug.Log("Game Over!");
                RestartLevel();
            }
            else
            {
                Debug.Log("armor broke");
                hasArmor = false;
            }
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
