using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] foodList;
    public GameObject[] spawnLocations;
    public List<GameObject> shoppingList;
    private GameObject foodToAddToList;
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
                foodToAddToList = foodList[UnityEngine.Random.Range(0, foodList.Length)];
                Instantiate(foodToAddToList, location.transform.position, location.transform.rotation);
                //Debug.Log("Food to Add to List: " + foodToAddToList);
                if (shoppingList.Contains(foodToAddToList) == false)    // check if the food is already on the list
                {
                    shoppingList.Add(foodToAddToList);  // if not already in the list, add it to the shoppingList
                }
          
            }

            //int doinYourMom = Random.Range(0,101)
        }
        PrintList(shoppingList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintList(List<GameObject> foods)
    {
        foreach(GameObject f in foods)
        {
            Debug.Log("Food List:" + f.name);
        }
    }
}
