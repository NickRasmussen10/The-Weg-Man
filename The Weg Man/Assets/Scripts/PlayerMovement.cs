using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    [SerializeField] GameObject pref_ragdoll;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.parent = gameObject.transform;
        Camera.main.transform.position = transform.position + (transform.forward * 2.0f) + new Vector3(0.0f, 1.5f, 0.0f);
        Camera.main.transform.rotation = transform.rotation;
        Camera.main.transform.Rotate(Vector3.up, 180);
        anim = GetComponentInChildren<Animator>();
        anim.SetTrigger("Stand");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0.0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);
        transform.Rotate(Vector3.down, Input.GetAxis("Horizontal"));
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.0f)
        {
            anim.SetBool("Rotate", true);
        }
        else
        {
            anim.SetBool("Rotate", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Launch();
        }
    }


   void Launch()
    {
        GameObject ragdoll = Instantiate(pref_ragdoll, transform.position, transform.rotation);
        Camera.main.transform.parent = null;
        Destroy(gameObject);
        
    }
}
