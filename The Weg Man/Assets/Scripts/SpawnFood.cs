using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] foodList;
    public GameObject[] spawnLocations;
    public List<string> shoppingList;
    public Text listText;
    private GameObject foodToAdd;
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
                foodToAdd = foodList[UnityEngine.Random.Range(0, foodList.Length)];
                Instantiate(foodToAdd, location.transform.position, location.transform.rotation);
                if(!shoppingList.Contains(foodToAdd.name+"(Clone)"))   // check if the food is not already in the shoppingList
                {
                    shoppingList.Add(foodToAdd.name+"(Clone)");    // if the food is not in the list, add it to the shoppingList
                    listText.text += "\n" + foodToAdd.name;
                }
            }

            //int doinYourMom = Random.Range(0,101)
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(shoppingList.Count == 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void UpdateList()
    {
        listText.text = "Shopping List: ";
        foreach (string food in shoppingList)
        {
            listText.text += "\n" + food;
        }
    }
}
