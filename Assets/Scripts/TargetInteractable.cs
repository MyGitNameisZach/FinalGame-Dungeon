using UnityEngine;

public class TargetInteractable : MonoBehaviour
{
    public BoxCollider spawnArea;
    public enum InteractableType
    {
        Collectable,
        Trap
    }

    public InteractableType type;
    GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Trigger()
    {
        if(type == InteractableType.Collectable)
        {
            gameManager.TargetCollected();
            
        }
        
    }
    public void Respawn()
    {
        Bounds bounds = spawnArea.bounds;

        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomY = Random.Range(bounds.min.y, bounds.max.y); // 2D uses Y not Z

        transform.position = new Vector3(randomX, randomY, 0f);
    }
}
