using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft;  // assign the amount of time in the editor
    public Text timerText;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime; // decrease the amount of time left
        timerText.text = "Time: " + timeLeft.ToString("F0");    // cast timeLeft to string with no decimal

        if(timeLeft <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
