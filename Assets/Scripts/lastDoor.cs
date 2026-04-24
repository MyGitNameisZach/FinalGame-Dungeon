using UnityEngine;

public class lastDoor : MonoBehaviour
{
    public Transform teleportLocation;
    private UIMessage ui;

    public RestartManager restartManager; // assign in Inspector

    void Start()
    {
        ui = FindObjectOfType<UIMessage>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            restartManager.ShowEndScreen();
        }
    }
}