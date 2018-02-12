using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public GameObject spawnOnEnter;
    private GameObject spawned;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>())
        {
            if (!spawned && spawnOnEnter)
            {
                Instantiate(spawnOnEnter, transform.position, transform.rotation);
            }
            ResetToStart.start = transform.position + Vector3.up;
            if(ResetToStart.checkpoint && ResetToStart.checkpoint != this)
            {
                ResetToStart.checkpoint.DestroySpawned();
            }
            ResetToStart.checkpoint = this;
        }
    }

    public void DestroySpawned()
    {
        Destroy(spawned);
    }
}
