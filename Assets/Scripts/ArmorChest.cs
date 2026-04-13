using Unity.VisualScripting;
using UnityEngine;

public class ArmorChest : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Find ALL enemies
            BouncingEnemy[] enemies =
                FindObjectsOfType<BouncingEnemy>();

            // Give armor to all enemies
            foreach (BouncingEnemy enemy in enemies)
            {
                enemy.hasArmor = true;
                Debug.Log("got armor");
            }
        }
    }
}
