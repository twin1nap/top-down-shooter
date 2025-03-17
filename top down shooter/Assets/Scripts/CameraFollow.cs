using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Assign the player GameObject in the Inspector

    void Update()
    {
        // if there is no player assigned to the script
        if (player == null) return;

        // Camera follows player exactly
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
