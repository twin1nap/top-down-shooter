using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medpack_colition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && gamehandeler.health < 0)
        {
            if (gamehandeler.health + 35 > 100)
            {
                gamehandeler.health = 100;
            }
            else
            {
                gamehandeler.health += 35;
            }
            Destroy(gameObject);
        }
    }
}
