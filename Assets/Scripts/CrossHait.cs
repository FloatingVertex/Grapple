using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrossHait : MonoBehaviour {
    public static CrossHait singleton;

    public Image image1;
    public Image image2;
    public Color normal;
    public Color avalible;
    public Color unAvalible;

	// Use this for initialization
	void Start () {
        singleton = this;
	}
	
	public void SetNormal()
    {
        image1.color = normal;
        image2.color = normal;
    }

    public void SetAvalible()
    {
        image1.color = avalible;
        image2.color = avalible;
    }

    public void SetUnAvalible()
    {
        image1.color = unAvalible;
        image2.color = unAvalible;
    }
}
