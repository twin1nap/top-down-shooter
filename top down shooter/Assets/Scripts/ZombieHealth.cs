using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    // Declare the health variable
    public int HealthZombie;

    // Start is called before the first frame update
    void Start()
    {
        // Assign a random health value between 3 and 5 
        HealthZombie = Random.Range(3, 6);
    }

    public void TakeDamage(int damage)
    {
        HealthZombie -= damage;

        // Check if health has dropped to 0 or below
        if (HealthZombie <= 0)
        {
            Destroy(gameObject); // Destroy the zombie when health is 0 or less
        }
    }
}
