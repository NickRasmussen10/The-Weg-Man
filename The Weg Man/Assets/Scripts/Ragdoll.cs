using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    [SerializeField] List<Rigidbody> rbs = new List<Rigidbody>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.AddForce(transform.forward * Random.Range(10.0f, 15.0f), ForceMode.Impulse);
        }
    }
}
