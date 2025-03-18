using UnityEngine;
using UnityEngine.SceneManagement;

public class KillsManager : MonoBehaviour
{
    public static int killCount = 0; // Track number of kills

    // Start is called before the first frame update
    void Start()
    {
        // Reset the kill count when starting a new level
        killCount = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the current scene name
        string sceneName = SceneManager.GetActiveScene().name;


    }

    // This method will be called when a zombie dies
    public static void IncreaseKillCount()
    {
        killCount++;  // Increase the kill count
        Debug.Log("Kill count: " + killCount);  // Debugging log
    }
}
