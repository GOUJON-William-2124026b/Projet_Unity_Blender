using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string scene;
    
    public void sceneSuivante()
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        sceneSuivante(); 
    }
}
