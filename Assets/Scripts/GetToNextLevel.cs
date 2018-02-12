using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GetToNextLevel : MonoBehaviour {
    private bool activated = false;
    public GameObject menuPrefab;
    public static float startTime;
    public static float completionTime;

    void OnTriggerEnter(Collider other)
    {
        if (!activated && other.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>())
        {
            activated = true;
            completionTime = Time.time - startTime;
            Instantiate(menuPrefab);
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                KongregateAPI.api.Submit("Loaded",1);
            }
            Debug.Log("Level " + SceneManager.GetActiveScene().buildIndex);
            KongregateAPI.api.Submit("Level " + SceneManager.GetActiveScene().buildIndex, (int)(completionTime * 100));
        }
    }

    void Update()
    {
        if(activated && Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (activated && Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else if(activated && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
