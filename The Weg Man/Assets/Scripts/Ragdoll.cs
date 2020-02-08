using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    [SerializeField] GameObject pref_Player; 
    [SerializeField] List<Rigidbody> rbs = new List<Rigidbody>();

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.parent = rbs[0].gameObject.transform;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch()
    {
        foreach (Rigidbody rb in rbs)
        {
            Debug.Log(rb);
            rb.AddForce(-transform.forward * Random.Range(30.0f, 40.0f), ForceMode.Impulse);
        }
        StartCoroutine(RespawnPlayer());
    }

    IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(2.0f);
        GameObject player = Instantiate(pref_Player, rbs[0].transform.position, Quaternion.identity);
        Camera.main.transform.parent = null;
        Destroy(gameObject);
    }
}
