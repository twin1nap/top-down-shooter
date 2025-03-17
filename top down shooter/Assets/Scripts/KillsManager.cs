using System.Collections;
using System.Collections.Generic;

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
        // Check if player has killed 3 zombies
        if (killCount >= 1)
        {
            // Load next scene (can be any scene you want)
            SceneManager.LoadScene("Level_2");
        }
    }

    // This method will be called when a zombie dies
    public static void IncreaseKillCount()
    {
        killCount++;  // Increase the kill count
    }

}
