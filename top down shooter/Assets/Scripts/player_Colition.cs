using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Colition : MonoBehaviour
{
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (timer > 0.5f)
        {
            timer = 0;
            gamehandeler.health_down();
        }
    }
}
