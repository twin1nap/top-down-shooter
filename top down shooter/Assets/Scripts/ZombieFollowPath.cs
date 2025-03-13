using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollowPath : MonoBehaviour
{
    [SerializeField] Transform[] WayPoints; 

    public float moveSpeed = 3.25f;
    private int PointIndex = 0; 
    private float minDistance = 0.1f;

    void Start()
    {

        if (WayPoints.Length > 0)
        {
            transform.position = WayPoints[PointIndex].position;
        }
    }

    void Update()
    {
        if (WayPoints.Length == 0) return; 

        transform.position = Vector2.MoveTowards(transform.position, WayPoints[PointIndex].position, moveSpeed * Time.deltaTime);


        if (Vector2.Distance(transform.position, WayPoints[PointIndex].position) < minDistance)
        {
            PointIndex++; 


            if (PointIndex >= WayPoints.Length)
            {
                PointIndex = 0;
            }
        }
    }
}
