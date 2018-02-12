using UnityEngine;
using System.Collections;

public class Graple : MonoBehaviour {

    public Rigidbody rigidBody;
    public LayerMask grapleMask;
    public float grapleDistance;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //Time.timeScale = 0.25f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if(Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        //change cross hair color
        if (Physics.Raycast(transform.position, transform.forward, grapleDistance, grapleMask))
        {
            CrossHait.singleton.SetAvalible();
        }else if(Physics.Raycast(transform.position, transform.forward, 10000, grapleMask))
        {
            CrossHait.singleton.SetUnAvalible();
        }
        else
        {
            CrossHait.singleton.SetNormal();
        }
        //Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetMouseButtonDown(0))
        {
            rigidBody.GetComponent<AnchorUpdater>().RemoveAnchor();
            RaycastHit hit;
            if (Physics.Raycast(transform.position,transform.forward,out hit, grapleDistance, grapleMask))
            {
                rigidBody.GetComponent<AnchorUpdater>().NewAnchor(hit);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            rigidBody.GetComponent<AnchorUpdater>().RemoveAnchor();
        }
	}
}
