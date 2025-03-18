using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    // Declare the health variable, this is now specific to each zombie
    public static int healthZombie;

    // Start is called before the first frame update
    void Start()
    {
        // Assign a random health value between 3 and 5 for this specific zombie
        healthZombie = 3; //Random.Range(3, 6);
        Debug.Log("Zombie health: " + healthZombie);  // Debugging log for initial health
    }

    // This method is called when a zombie takes damage
    public void TakeDamage(int damage)
    {
        healthZombie -= damage;

        // Log the current health after taking damage (for debugging)
        Debug.Log("Zombie current health: " + healthZombie);

        // Check if health has dropped to 0 or below
        if (healthZombie <= 0)
        {
            // Call the KillsManager to increase the kill count
            //KillsManager.IncreaseKillCount(); //bestaat niet meer
            gamehandeler.ZombCount_Down();

            // Call the KillsManager to reduce the zombie count

            // Destroy this zombie when health is 0 or less
            Destroy(gameObject);
        }
    }
}
