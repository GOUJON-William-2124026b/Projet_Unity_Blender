using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoire : MonoBehaviour
{
    public string scene;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Victoire")
        {
            SceneManager.LoadScene(scene);
            Destroy(other.gameObject);
        }
    }
}
