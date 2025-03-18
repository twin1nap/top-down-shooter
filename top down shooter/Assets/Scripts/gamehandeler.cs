using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamehandeler : MonoBehaviour
{
    private static int health = 100;
    public TextMeshProUGUI health_text;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {





        health_text.text = "Health: " + health.ToString();

        if (health <= 0)
        {
            health = 100;
            SceneManager.LoadScene("GameOver");
        }

        // Check if there are no zombies left
    }

    // Called when health decreases
    public static void health_down()
    {
        health--;
    }
}
