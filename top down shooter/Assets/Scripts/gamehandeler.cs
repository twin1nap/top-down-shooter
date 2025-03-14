using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamehandeler : MonoBehaviour
{
    private static int health = 100;
    public  TextMeshProUGUI health_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        health_text.text = "health: " + health.ToString();
        if (health <= 0)
        {
            Debug.Log("je bent dood :(");
        }
    }

    public static void health_down()
    {
        health--;
    }
}
