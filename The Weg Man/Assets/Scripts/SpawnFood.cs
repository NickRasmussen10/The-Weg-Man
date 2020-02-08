using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] foodList;
    public GameObject[] spawnLocations;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting!UwU");
        Debug.Log(UnityEngine.Random.Range(0, 100));
        Debug.Log(spawnLocations);
        if (spawnLocations.Length == 0) {
            Debug.Log("Setting spawn Locs");
            spawnLocations = GameObject.FindGameObjectsWithTag("Food Location");
            Debug.Log(spawnLocations);
        }

        foreach (GameObject location in spawnLocations)
        {
            Debug.Log("For Loop Time");
            if (UnityEngine.Random.Range(0, 100) < 50) {
                Debug.Log("Spawning food");
                Instantiate(foodList[UnityEngine.Random.Range(0, foodList.Length)], location.transform.position, location.transform.rotation);
            }

            //int doinYourMom = Random.Range(0,101)
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
