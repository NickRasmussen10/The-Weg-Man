using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<string> foodCollected = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFood(string food) //adds a collected food to the player's collected food list
    {
        foodCollected.Add(food);
        for(int i = 0; i < foodCollected.Count; i++)
        {
            Debug.Log(foodCollected[i]);
        }
    }
}
