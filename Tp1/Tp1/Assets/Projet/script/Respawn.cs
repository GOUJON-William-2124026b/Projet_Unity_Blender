using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public float threshold;
    public AudioSource SoundRespawn;

    public void Update()
    {
        if(transform.position.y < threshold){
            SoundRespawn.Play();
            transform.position = new Vector3(1.36f, 2.95f, 6.59f);
        }
    }
}
