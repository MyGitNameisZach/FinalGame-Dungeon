using UnityEngine;

public class Ladder : MonoBehaviour
{
    public Transform teleportLocation; // Drag target location here
    private UIMessage ui;

    void Start()
    {
        ui = FindObjectOfType<UIMessage>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportLocation.position;
            ui.ShowMessage("You found the treasure!!" +
                "Go through the door to end the game!");
        }
    }
}
