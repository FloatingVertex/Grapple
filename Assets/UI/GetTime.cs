using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetTime : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        if (((int)(GetToNextLevel.completionTime * 100) - (((int)GetToNextLevel.completionTime) * 100)) > 9)
        {
            GetComponent<Text>().text = " " + (int)GetToNextLevel.completionTime + "." + ((int)(GetToNextLevel.completionTime * 100) - (((int)GetToNextLevel.completionTime) * 100)) + "s";
        }
        else
        {
            GetComponent<Text>().text = " " + (int)GetToNextLevel.completionTime + ".0" + ((int)(GetToNextLevel.completionTime * 100) - (((int)GetToNextLevel.completionTime) * 100)) + "s";
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
}
