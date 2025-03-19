using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Colition : MonoBehaviour
{
    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            if (timer >= 0.5f)
            {
                gamehandeler.health--;
                Debug.Log("Health decreased! Current health: " + gamehandeler.health);

                timer = 0f;
            }
        }
    }

}
