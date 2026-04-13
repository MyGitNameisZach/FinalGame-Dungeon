using UnityEngine;

public class NoKeyDoor : MonoBehaviour
{
    public Transform teleportLocation; // Drag target location here
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportLocation.position;
        }
    }
}
