using UnityEngine;
using System.Collections;

public class ResetToStart : MonoBehaviour {

    public static Vector3 start;
    public static Vector3 originatStart;
    public static Checkpoint checkpoint;

	// Use this for initialization
	void Start () {
        start = transform.position;
        originatStart = transform.position;
        GetToNextLevel.startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if((transform.position.y < -100) || Input.GetKeyDown(KeyCode.R))
        {
            if((start - originatStart).magnitude < 0.1f)
            {
                GetToNextLevel.startTime = Time.time;
            }
            transform.position = start;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<AnchorUpdater>().RemoveAnchor();
        }
	}
}
