using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow_combined : MonoBehaviour
{
    [SerializeField] private bool FollowPlayer;
    [SerializeField] private bool FollowWaypoint;
    [SerializeField] private bool FollowCombined;

    [SerializeField] public float Speed = 3.25f;        // zombie snelheid
    [SerializeField] public GameObject Target;
    [SerializeField] public float followRange = 3f;     // Afstand wanneer de zombie gaat volgen
    //[SerializeField] public float stopRange = 5f;       // Afstand dat de zombie stopt
    
    //follow waypoint
    [SerializeField] Transform[] WayPoints;
    // Index van het huidige waypoint
    private int PointIndex = 0;
    // Minimale afstand tot een waypoint voordat er naar de volgende wordt gegaan
    private float minDistance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        // Zorgt ervoor dat de zombie begint op het eerste waypoint als er waypoints beschikbaar zijn
        if (WayPoints.Length > 0 &&  FollowWaypoint)
        {
            transform.position = WayPoints[PointIndex].position;
        }
        if (FollowCombined)
        {
            FollowWaypoint = true;
            FollowPlayer = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //aftstand tot speler
        float distance = Vector2.Distance(transform.position, Target.transform.position);

        // checkt of de player dichtbij is
        if (distance <= followRange && (FollowPlayer || FollowCombined))
        {
            FollowWaypoint = false;
            // normalized gebruik je voor de vectors.
            Vector2 direction = (Target.transform.position - transform.position).normalized;

            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, Speed * Time.deltaTime);

            //draaien naar de direction(berekend hierboven)
            transform.up = direction;
        }
        // als de speler buiten range is, dan stopt hij met volgen
        else
        {
            if (FollowCombined)
            {
                FollowWaypoint = true; 
                FollowPlayer = false;
            }
        }

        if (FollowWaypoint)
        {
            // Als er geen waypoints zijn, hoeft de zombie niets te doen
            if (WayPoints.Length == 0) return;

            // Beweeg de zombie richting het huidige waypoint met de opgegeven snelheid
            transform.position = Vector2.MoveTowards(transform.position, WayPoints[PointIndex].position, Speed * Time.deltaTime);

            //kijk naar de point
            Vector2 direction = (WayPoints[PointIndex].transform.position - transform.position).normalized;
            transform.up = direction;

            // Controleer of de zombie dichtbij genoeg is bij het huidige waypoint
            if (Vector2.Distance(transform.position, WayPoints[PointIndex].position) < minDistance)
            {
                // Ga naar het volgende waypoint
                PointIndex++;

                // Als het laatste waypoint is bereikt, begin opnieuw bij het eerste waypoint
                if (PointIndex >= WayPoints.Length)
                {
                    PointIndex = 0;
                }
            }
        }
    }
}
