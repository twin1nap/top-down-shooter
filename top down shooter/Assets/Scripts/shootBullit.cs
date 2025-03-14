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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            var tempball = Instantiate(bullit, shootPoint.position, shootPoint.rotation);
            tempball.GetComponent<Rigidbody2D>().AddForce(shootPoint.right * speed);
            Destroy(tempball, 10f);
        }
    }
}
