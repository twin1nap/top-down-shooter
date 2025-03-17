using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Don't forget to include this if you're using SceneManager

public class GameOver : MonoBehaviour
{
    public Button ButtonPlayAgain;
    public Button ButtonQuit;

    void Start()
    {
        // Ensure buttons are assigned correctly if not done in Inspector
        if (ButtonPlayAgain != null)
        {
            ButtonPlayAgain.onClick.AddListener(PlayAgain);
        }
        if (ButtonQuit != null)
        {
            ButtonQuit.onClick.AddListener(QuitBTN);
        }
    }

    private void PlayAgain()
    {
        // Debug log to check if the button click triggers the method
        Debug.Log("STARTING WORKS");
        SceneManager.LoadScene("Level_1");  // Uncomment when ready
    }

    private void QuitBTN()
    {
        // Debug log to check if the button click triggers the method
        Debug.Log("QUITING WORKS");
        Application.Quit();  // Uncomment when ready
    }
}
