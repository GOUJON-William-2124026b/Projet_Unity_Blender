using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechant : MonoBehaviour
{   
    public Transform player, spawn;
    public GameObject playerg;

    public AudioSource SoundEnemy;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){

            SoundEnemy.Play();
            playerg.SetActive(false);
            player.position = spawn.position;
            playerg.SetActive(true);
        }
    }
}
