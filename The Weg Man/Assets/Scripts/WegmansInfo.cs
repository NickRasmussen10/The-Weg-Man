using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class WegmansInfo : MonoBehaviour
{
    private string foodReq = "Strawberry";
    private string API_KEY = "7fc8d18b16bf434aaa889e6a9e1c89dc";
    private string URL = "";
    private string productNames = "";
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
        writer.WriteLine(req.text);
        writer.Close();
        //responseText.text = req.text;
    }

    public static WegmansInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<WegmansInfo>(jsonString);
    }
}
