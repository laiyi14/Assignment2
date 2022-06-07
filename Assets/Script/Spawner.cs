using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Sun;
    public Transform SunStartPoint;
    public bool stopSpawn = false;
    public float spawnTime;
    public float spawnDelay; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSun", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void SpawnSun()
    {
        Instantiate(Sun, SunStartPoint.position, SunStartPoint.rotation);
        if(stopSpawn == true)
        {
            CancelInvoke("SpawnSun");
        }

    }

    //public void SpawnObject()
}
