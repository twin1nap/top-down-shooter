using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollowPath : MonoBehaviour
{
    [SerializeField] Transform[] WayPoints; // Array of waypoints

    public float moveSpeed = 3.25f;
    private int PointIndex = 0; // Start at the first waypoint
    private float minDistance = 0.1f; // Minimum distance to switch to the next waypoint

    void Start()
    {
        // Ensure we start at the first waypoint
        if (WayPoints.Length > 0)
        {
            transform.position = WayPoints[PointIndex].position;
        }
    }

    void Update()
    {
        if (WayPoints.Length == 0) return; // Prevent errors if no waypoints are assigned

        // Move towards the current waypoint
        transform.position = Vector2.MoveTowards(transform.position, WayPoints[PointIndex].position, moveSpeed * Time.deltaTime);

        // Check if the zombie is close enough to switch to the next waypoint
        if (Vector2.Distance(transform.position, WayPoints[PointIndex].position) < minDistance)
        {
            PointIndex++; // Move to the next waypoint

            // Loop back to the first waypoint if we reach the end
            if (PointIndex >= WayPoints.Length)
            {
                PointIndex = 0;
            }
        }
    }
}
