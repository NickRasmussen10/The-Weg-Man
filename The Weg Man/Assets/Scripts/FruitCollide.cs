using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollide : MonoBehaviour
{
    [SerializeField] private string fruitName;
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
        if(other.gameObject.tag == "WegMan")
        {
            other.gameObject.GetComponent<PlayerManager>().AddFood(fruitName);
            Destroy(gameObject);
        }
    }
}
