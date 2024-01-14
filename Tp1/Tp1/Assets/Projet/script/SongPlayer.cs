using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPlayer : MonoBehaviour
{
    public AudioSource footstep;

    public AudioSource JumpSound;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            footstep.enabled = true;
        }
        else{
            footstep.enabled = false;
        }
        if(Input.GetKey(KeyCode.Space)){
            JumpSound.enabled = true;
            footstep.enabled = false;
        }
        else{
            JumpSound.enabled = false;
        }
    }
}
