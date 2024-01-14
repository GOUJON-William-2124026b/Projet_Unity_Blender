using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI NbCoin;

    public AudioSource SoundCoin;



    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {
            Coin++;
            NbCoin.text = "Pièce: " + Coin.ToString();
            Debug.Log(Coin);
            SoundCoin.Play();
            Destroy(other.gameObject);

        }
        
    }
}
