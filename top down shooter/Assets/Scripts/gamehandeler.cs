using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamehandeler : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI health_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health_text.text = "health: " + health.ToString();
    }

    void health_down()
    {
        health--;
        health_text.text = "health: " + health.ToString();
    }
}
