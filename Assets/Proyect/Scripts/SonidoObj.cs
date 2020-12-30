using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoObj : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioClip sonido;
     AudioSource audio;
    void Start()
    {
         audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Sonidos(){
        //Sonido del pollito
       
        audio.PlayOneShot(sonido);
        audio.Play(); 
    }      
}
