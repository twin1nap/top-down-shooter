using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow_Player : MonoBehaviour
{
    [SerializeField] public GameObject Target;           
    [SerializeField] public float Speed = 3.25f;        // zombie snelheid
    [SerializeField] public float followRange = 2f;     // Afstand wanneer de zombie gaat volgen
    [SerializeField] public float stopRange = 1f;       // Afstand dat de zombie stopt

    void Update()
    {
        float distance = Vector2.Distance(transform.position, Target.transform.position);

        // checkt of de player dichtbij is
        if (distance <= followRange)
        {
            // normalized gebruik je voor de vectors.
            Vector2 direction = (Target.transform.position - transform.position).normalized;

            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, Speed * Time.deltaTime);

            transform.up = direction;
        }
        // als de speler buiten range is, dan stopt hij met volgen
        else if (distance > stopRange)
        {

        }
    }
}
