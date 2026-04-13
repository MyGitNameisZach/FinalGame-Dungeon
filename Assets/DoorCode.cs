using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public Transform teleportLocation; // Drag target location here
    public bool hasCoin = false;
    private UIMessage ui;

    void Start()
    {
        ui = FindObjectOfType<UIMessage>();
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && hasCoin)
        {
            Debug.Log(hasCoin);
            other.transform.position = teleportLocation.position;
            ui.ShowMessage("Explore the dungeon");

        }
    }
}
