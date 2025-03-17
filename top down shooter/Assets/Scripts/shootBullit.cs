using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class shootBullit : MonoBehaviour
{
    public GameObject bullit;
    public Transform shootPoint;
    public float speed = 1000f;

    public float fireRate = 0.1f; // Adjust for desired RPM (0.1s = 600 RPM, 0.066s = 900 RPM, 0.08s = 750 RPM)
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        
        if (Input.GetMouseButton(0) && timer >= fireRate)
        {
            timer = 0;

            var tempball = Instantiate(bullit, shootPoint.position, shootPoint.rotation);
            tempball.GetComponent<Rigidbody2D>().AddForce(shootPoint.right * speed);
            Destroy(tempball, 10f);
        }
    }
}
