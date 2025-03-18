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
         


        ammo_text.text = "Ammo: " + shootBullit.Mag.ToString();



        health_text.text = "Health: " + health.ToString();

        if (health <= 0)
        {
            health = 100;
            SceneManager.LoadScene("GameOver");
        }


    }

    private void Update()
    {
        if (zombie_count <= 0 && SceneManager.GetActiveScene().name != "Between_winning_screen")
        {
            last_level_int = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene("Between_winning_screen");
        }
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
        SceneManager.LoadScene(last_level_int++);  
    }
}
