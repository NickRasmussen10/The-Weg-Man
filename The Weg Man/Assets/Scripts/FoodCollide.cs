using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("pog");
        if(other.gameObject.tag == "WegMan")
        {
            Debug.Log("ahaa ha");
            other.gameObject.GetComponent<PlayerManager>().AddFood(gameObject.name);
            Debug.Log("GAMEOBJECT NAME " + gameObject.name);
            Destroy(gameObject);
        }
    }
}
