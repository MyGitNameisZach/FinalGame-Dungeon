using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        // If music already exists, destroy duplicate
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // Keep music playing between scenes
        DontDestroyOnLoad(gameObject);
    }
}