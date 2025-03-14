using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollowPath : MonoBehaviour
{
    // Array van waypoints waar de zombie naartoe zal bewegen
    [SerializeField] Transform[] WayPoints;

    // Snelheid waarmee de zombie beweegt
    public float moveSpeed = 3.25f;

    // Index van het huidige waypoint
    private int PointIndex = 0;

    // Minimale afstand tot een waypoint voordat er naar de volgende wordt gegaan
    private float minDistance = 0.1f;

    void Start()
    {
        // Zorgt ervoor dat de zombie begint op het eerste waypoint als er waypoints beschikbaar zijn
        if (WayPoints.Length > 0)
        {
            transform.position = WayPoints[PointIndex].position;
        }
    }

    void Update()
    {
        // Als er geen waypoints zijn, hoeft de zombie niets te doen
        if (WayPoints.Length == 0) return;

        // Beweeg de zombie richting het huidige waypoint met de opgegeven snelheid
        transform.position = Vector2.MoveTowards(transform.position, WayPoints[PointIndex].position, moveSpeed * Time.deltaTime);

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
