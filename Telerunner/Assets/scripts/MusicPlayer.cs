using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private bool playMenuMusic = true;
    void Start()
    {
        if (playMenuMusic)
        {
            GameObject.Find("MenuMusic").GetComponent<MusicScript>().PlayMusic();
        }
        else
        {
            GameObject.Find("GameMusic").GetComponent<MusicScript>().StopMusic();
        }
    }
}
