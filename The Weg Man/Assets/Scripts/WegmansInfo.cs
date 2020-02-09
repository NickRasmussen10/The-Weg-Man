using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class WegmansInfo : MonoBehaviour
{
    [Serializable]
    public class ListItem
    {
        public Results[] Results;
    }
    [Serializable]
    public class Results
    {
        public string Names;
    }

    private string foodReq = "Strawberry";
    private string API_KEY = "7fc8d18b16bf434aaa889e6a9e1c89dc";
    private string URL = "";
    private string productNames = "";
    private string jsonString = "";
    string path = "Assets/Scripts/APIResults.txt";
    //public Text responseText;

    public void Request()
    {
        URL = "https://api.wegmans.io/products/search?query=" + foodReq + "&api-version=2018-10-18&subscription-key=" + API_KEY;
        WWW request = new WWW(URL);
        StartCoroutine(Response(request));
    }

    private IEnumerator Response(WWW req)
    {
        yield return req;
        StreamWriter writer = new StreamWriter(path, false);
        writer.Write(req.text);
        writer.Close();
        //responseText.text = req.text;

        using (StreamReader r = new StreamReader(path))
        {
            string json = r.ReadToEnd();
            int n1 = json.IndexOf("\"name\":\"") + "\"name\":\"".Length;
            int n2 = json.IndexOf("\",\"_links");
            string results = json.Substring(n1, n2 - n1);
            Debug.Log(results);
        }
    }
}
