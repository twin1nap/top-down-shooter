using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartingScreenScipt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public Button ButtonStart;
    public Button ButtonQuit;

    // Update is called once per frame
    void Update()
    {
       

    }

    public void StartScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StartGameBTN()
    {
        // Start level 1
        Debug.Log("STARTING WORKS");
        SceneManager.LoadScene("Level_1");
    }
    public void QuitBTN()
    {
        // Stopt de game
        Debug.Log("QUITING WORKS");
        //Application.Quit();
    }
}
