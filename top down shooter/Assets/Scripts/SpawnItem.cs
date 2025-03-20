using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPoints;
    float spawnTime;
    private float timer;

    public GameObject ammo;
    public GameObject MedPack;
    private Transform spawnpos;

    private int item_to_spawn_int;
    private GameObject item_to_spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(6f, 10f);
        spawnpos = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
        Debug.Log(spawnpos);
        Debug.Log(spawnTime);
        item_to_spawn_int = Random.Range(0, 2);
        if (item_to_spawn_int == 0)
        {
            item_to_spawn = ammo;
        }
        else
        {
            item_to_spawn = MedPack;
        }
        Debug.Log(item_to_spawn);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTime)
        {
            timer = 0;
            Instantiate(item_to_spawn, spawnpos.position, Quaternion.identity);

            //zodat je van het volgende kan zien
            spawnTime = Random.Range(6f, 10f);
            spawnpos = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
            item_to_spawn_int = Random.Range(0, 2);
            if (item_to_spawn_int == 0)
            {
                item_to_spawn = ammo;
            }
            else
            {
                item_to_spawn = MedPack;
            }
            Debug.Log(spawnTime);
            Debug.Log(spawnpos);
            Debug.Log(item_to_spawn);
        }
    }
}
