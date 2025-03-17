using UnityEngine;
using UnityEngine.SceneManagement;  // Needed for scene loading

public class ZombieManager : MonoBehaviour
{
    private int zombieCount;  // Count of active zombies

    void Start()
    {
        // Count the number of zombies at the start of the game
        zombieCount = GameObject.FindGameObjectsWithTag("Zombie").Length;
        Debug.Log("Initial Zombie Count: " + zombieCount);  // Debugging log to confirm zombie count
    }

    // Call this method when a zombie is destroyed
    public void ZombieDestroyed()
    {
        // Decrease the zombie count when a zombie is destroyed
        zombieCount--;
        Debug.Log("Zombie Destroyed. Remaining Zombies: " + zombieCount);  // Debugging log

        // Check if all zombies are dead
        if (zombieCount == 0)
        {
            Debug.Log("All Zombies Destroyed! Loading Level_2...");
            WinGame();
        }
    }

    void WinGame()
    {
        // Ensure the scene name is correct and is in the build settings
        SceneManager.LoadScene("Level_2");
    }
}
