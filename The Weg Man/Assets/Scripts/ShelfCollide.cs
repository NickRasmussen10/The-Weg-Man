using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfCollide : MonoBehaviour
{
    public AudioSource soundEffect;
    private float soundTimer = 0.0f;
    private bool startTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startTimer)
        {
            soundTimer += Time.deltaTime;
        }

        if(soundTimer >= 4.0f)
        {
            startTimer = false;
            soundTimer = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("play sound");
        //if(other.gameObject.tag == "WegMan" && shoppingList.Contains(other.gameObject))
        if (other.gameObject.tag == "WegMan" && !startTimer)
        {
            startTimer = true;
            soundEffect.Play();
        }
    }
}
