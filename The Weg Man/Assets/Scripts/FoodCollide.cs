using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollide : MonoBehaviour
{
    public GameObject foodSpawner;
    // Start is called before the first frame update
    void Start()
    {
        foodSpawner = GameObject.Find("Food Spawner");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("pog");
        //if(other.gameObject.tag == "WegMan" && shoppingList.Contains(other.gameObject))
        if(other.gameObject.tag == "WegMan" )
        {
            other.gameObject.GetComponent<PlayerManager>().AddFood(gameObject.name);

            if (foodSpawner.GetComponent<SpawnFood>().shoppingList.Contains(gameObject.name))   // check if the food is not already in the shoppingList
            {
                Debug.Log("hell yeah babey");
                foodSpawner.GetComponent<SpawnFood>().shoppingList.Remove(gameObject.name);
            }

            //foodSpawner.GetComponent<SpawnFood>().shoppingList.Remove(other.gameObject.name + "(Clone)");  // remove the collected food from the list
            foodSpawner.GetComponent<SpawnFood>().UpdateList();
            //foodSpawner.GetComponent<SpawnFood>().shoppingList;  // get the shopping list of the food spawner

            Debug.Log("GAMEOBJECT NAME " + gameObject.name);
            Destroy(gameObject);
        }
    }
}
