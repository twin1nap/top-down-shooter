using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class shootBullit : MonoBehaviour
{
    public static int MagazineCapacity = 30;
    public static int AmmoInInventory = 90;
    public GameObject bullit_prefab;
    public Transform shootPoint;
    public float speed = 1000f;

    public float fireRate = 0.1f; // Adjust for desired RPM (0.1s = 600 RPM, 0.066s = 900 RPM, 0.08s = 750 RPM)
    private float timer;

    bool reloading = false;
    float timer_reload;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        
        if ((Input.GetMouseButton(0) && timer >= fireRate) && MagazineCapacity > 0)
        {
            MagazineCapacity--;

            timer = 0;

            var tempball = Instantiate(bullit_prefab, shootPoint.position, shootPoint.rotation);
            tempball.GetComponent<Rigidbody2D>().AddForce(shootPoint.right * speed);
            Destroy(tempball, 10f);

        }

        else if (Input.GetMouseButton(0) && MagazineCapacity <= 0 && AmmoInInventory >= 1)
        {
            if (!reloading)
            {
            Debug.Log("test");
                reloading = true;
                timer_reload = 0;
            }
            
        }
        if (reloading)
        {
            timer_reload += Time.deltaTime;
            Debug.Log(timer_reload);
            if (timer_reload >= 1.4)
            {
                Debug.Log("reloaded");
                MagazineCapacity = 30;
                AmmoInInventory -= 30;
                reloading = false;
            }
        }
    }
}
