using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfCollide : MonoBehaviour
{
    public AudioSource soundEffect;
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
        Debug.Log("play sound");
        //if(other.gameObject.tag == "WegMan" && shoppingList.Contains(other.gameObject))
        if (other.gameObject.tag == "WegMan")
        {
            
            soundEffect.Play();
        }
    }
}
