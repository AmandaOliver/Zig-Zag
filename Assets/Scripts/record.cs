using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class record : MonoBehaviour {
    public Text text;
    
    void setrecord(int record)
    {
        text.text = "Record: " + record.ToString();

    }
    void Start()    {

        setrecord(PlayerPrefs.GetInt("record", 0));
    }
}
