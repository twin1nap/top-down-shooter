using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamehandeler : MonoBehaviour
{
    private static int health = 100;
    public TextMeshProUGUI health_text;
    public TextMeshProUGUI ammo_text;

    public static int last_level_int;
    public static int zombie_count;
    public int zombieCount = zombie_count;

    // Start is called before the first frame update
    private void Start()
    {
        zombie_count = zombieCount;
    }
    // Update is called once per frame
    void FixedUpdate()
    {



        ammo_text.text = "Ammo: " + shootBullit.Mag.ToString() + "/"  + shootBullit.Ammo.ToString();





        health_text.text = "Health: " + health.ToString();

        if (health <= 0)
        {
            health = 100;
            SceneManager.LoadScene("GameOver");
        }


    }

    private void Update()
    {
        if (zombie_count <= 0 && (SceneManager.GetActiveScene().name != "Between_winning_screen"))
        {
            // Controleer als zombies 0 zijn en of de huidige scène NIET "Between_winning_screen" is

            if (SceneManager.GetActiveScene().name == "Level_3")
            {
                // Als de speler zich in Level 3 bevindt en alle zombies verslagen zijn, laad de winnningscène
                SceneManager.LoadScene("Winning_screen");
            }
            else
            {
                // Sla het huidige scene-index op voordat we de volgende scene laden
                last_level_int = SceneManager.GetActiveScene().buildIndex;
                Debug.Log(last_level_int); // Print de huidige scene-index in de console voor debugging

                // Laad de overgangsscherm naar de tussen scène
                SceneManager.LoadScene("Between_winning_screen");
            }
        }

        //else if (zombieCount <= 0 && SceneManager.GetActiveScene().name == "Level_3")
        //{
        //    SceneManager.LoadScene("Winning_screen");
        //}

    }

    public static void ZombCount_Down()
    {
        zombie_count--;
    }

    // Called when health decreases
    public static void health_down()
    {
        health--;
    }

    public static void load_next_level()
    {
        //was eerst last_level_int++ inside the LoadScene changed to + 1 explained below, other fix is putting the last_level_int++ line before the the LoadScene, seen above the LoadScene commented out 
        //last_level_int++;
        SceneManager.LoadScene(last_level_int + 1);  // last_level_int++ doet pas 1 bij last_level int na het laden van de scene
    }
}
