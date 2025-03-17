using UnityEngine;


public class Heltzombey : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    public int HealthZombie = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            HealthZombie--;

        }
        if (HealthZombie == 0)
        { Destroy(gameObject); }
    }
}