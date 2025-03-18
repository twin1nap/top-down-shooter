using UnityEngine;

public class bulletColider : MonoBehaviour
{
    // When a bullet collides with a zombie, reduce its health
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            // Access the ZombieHealth script attached to the zombie
            ZombieHealth zombieHealth = collision.gameObject.GetComponent<ZombieHealth>();

            if (zombieHealth != null)
            {
                // Call the TakeDamage method to reduce the zombie's health
                zombieHealth.TakeDamage(1); // Assuming the bullet does 1 damage
            }

            // Destroy the bullet after it collides
            Destroy(gameObject);
            //KillsManager.IncreaseKillCount(); // bestaat niet meer
        }

        // Destroy the bullet if it hits anything other than the player
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
