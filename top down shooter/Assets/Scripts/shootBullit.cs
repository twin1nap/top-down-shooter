using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class shootBullit : MonoBehaviour
{
    public static int Mag = 30;
    public static int Ammo = 90;
    public GameObject bullit_prefab;
    public Transform shootPoint;
    public float speed = 1000f;
    public TextMeshProUGUI ammoTEXT; 

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
        
        if ((Input.GetMouseButton(0) && timer >= fireRate) && Mag > 0)
        {
            Mag--;

            timer = 0;

            var tempball = Instantiate(bullit_prefab, shootPoint.position, shootPoint.rotation);
            tempball.GetComponent<Rigidbody2D>().AddForce(shootPoint.right * speed);
            Destroy(tempball, 10f);

        }

        else if (Input.GetMouseButton(0) && Mag <= 0 && Ammo > 0) // makes sure there is amo, then reload
        {
            if (!reloading) // checks if reloading is being done
            {
                Debug.Log("test");
                reloading = true; // Start the reaload function
                timer_reload = 0; // Sets the reaload timer on zero
            }
        }

        if (reloading) 
        {
            timer_reload += Time.deltaTime;
            Debug.Log(timer_reload);

            if (timer_reload >= 1.4f) // if reaload time is finished
            {
                Debug.Log("reloaded");

                if (Ammo >= 30) // if there is enough ammo or more then 30
                {
                    Mag += 30; // adds the mag whit 30
                    Ammo -= 30; // removes 30 out of the inventory
                }
                else // when there less then 30 ammo
                {
                    Mag += Ammo; //fills the mag whit the leftover
                    Ammo = 0; // ammo on zero, so it would not go negative
                }

                reloading = false; // stops realoading
            }
        }
    }
}
