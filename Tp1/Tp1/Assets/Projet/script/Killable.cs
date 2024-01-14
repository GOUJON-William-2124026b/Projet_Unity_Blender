using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Killable : MonoBehaviour
{

    public UnityEvent OnDie;

     private void OnTriggerEnter(Collider other) 
     {

        if (other.CompareTag("Player"))
        {

        Killable playerKillable = other.GetComponent<Killable>();
        Respawn playerRespawn = other.GetComponent<Respawn>();
        if(playerKillable != null)
        {
            playerRespawn.Update();
        }
        else
        {
            Debug.Log("Player not killable");
        }

        }
     }

    public void Die()
    {
        if (OnDie != null)
        {
            OnDie.Invoke();
        }       
               
    }

    public void DebugDie()
    {
        Debug.Log("meurt");
        
    }



}
