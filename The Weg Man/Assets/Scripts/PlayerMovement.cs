using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    [SerializeField] List<Rigidbody> ragdollRigidBodies = new List<Rigidbody>();

    [SerializeField] bool startRagdoll = false;

    bool ragdoll = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Rigidbody rb in ragdollRigidBodies)
        {
            if (startRagdoll)
            {
                rb.freezeRotation = false;
            }
            else
            {
                rb.freezeRotation = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0.0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);
        transform.Rotate(Vector3.down, Input.GetAxis("Horizontal"));

        if (Input.GetButtonDown("Jump"))
        {
            ragdoll = !ragdoll;
            if (ragdoll)
            {
                StartCoroutine(Launch());
            }
        }



        if (ragdoll && ragdollRigidBodies[0].freezeRotation)
        {
            foreach (Rigidbody rb in ragdollRigidBodies)
            {
                rb.freezeRotation = false;
            }
        }
        else if(!ragdoll && !ragdollRigidBodies[0].freezeRotation)
        {
            foreach (Rigidbody rb in ragdollRigidBodies)
            {
                rb.freezeRotation = true;
            }
        }
    }


    IEnumerator Launch()
    {
        foreach (Rigidbody rb in ragdollRigidBodies)
        {
            rb.AddForce(-transform.forward * Random.Range(-5.0f, 20.0f), ForceMode.Impulse);
        }

        yield return new WaitForSeconds(1.0f);

        transform.position = ragdollRigidBodies[0].position;
        foreach (Rigidbody rb in ragdollRigidBodies)
        {
            rb.position = Vector3.zero;
        }
    }
}
