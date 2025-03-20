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

    public void StartScene(string scene_Name)
    {
        SceneManager.LoadScene(scene_Name);
    }

    public void StartGameBTN()
    {
        // Start level 1
        gamehandeler.health = 100;
        shootBullit.Ammo = 90;
        shootBullit.Mag = 30;
        SceneManager.LoadScene("Level_1");
    }
    public void QuitBTN()
    {
        // Stopt de game
        Debug.Log("QUITING WORKS");
        Application.Quit();
    }
}
