using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    [SerializeField] GameObject pref_ragdoll;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0.0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);
        transform.Rotate(Vector3.down, Input.GetAxis("Horizontal"));

        if (Input.GetButtonDown("Jump"))
        {
            Launch();
        }
    }


   void Launch()
    {
        Destroy(gameObject);
        GameObject ragdoll = Instantiate(pref_ragdoll, transform.position, transform.rotation);
    }
}
