using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow_Player : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float Speed = 3.25f;

    void Update()
    {
        // Calculate the direction to the player
        Vector2 direction = (Player.transform.position - transform.position).normalized;

        // Move the zombie towards the player
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);

        // Face the player without rotating in 3D (lock rotation to 2D)
        transform.up = direction;
    }
}
