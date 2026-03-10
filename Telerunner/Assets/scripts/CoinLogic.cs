using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    Animator anim;
    AudioSource audio;
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
    public int collectCoin()
    {
        anim.SetTrigger("triggerPickup");
        Invoke("DestroyCoin", 0.3f);
        Debug.Log("Coin collected");
        audio.Play();
        return 1;
    }
    void DestroyCoin()
    {
        Destroy(this.gameObject);
    }
}
