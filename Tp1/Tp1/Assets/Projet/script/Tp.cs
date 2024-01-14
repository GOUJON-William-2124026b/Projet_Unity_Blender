using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
        public Transform player, destination;
        public GameObject playerg;
        public AudioSource SoundTp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            SoundTp.Play();
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
        }
    }

    
}
