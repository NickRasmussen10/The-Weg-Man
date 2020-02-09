using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SponsorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Stall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Stall()
    {
        yield return new WaitForSeconds(8.0f);
        SceneManager.LoadScene(2);
    }
}
