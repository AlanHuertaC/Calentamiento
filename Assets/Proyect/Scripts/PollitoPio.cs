using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollitoPio : MonoBehaviour
{
    // Start is called before the first frame update
     //Agregar sonido de disparo 
    public AudioClip sonidoPio;

    public AudioClip sonidoRandom; // :3
    AudioSource audio;
    int count =0;
    public GameObject explosion;
    public GameObject fire;
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
        if(count <10){
            audio.PlayOneShot(sonidoPio);
            audio.Play();
        }else if(count ==10){
            audio.PlayOneShot(sonidoRandom);
            GameObject pollito = GameObject.Find("Chicken");
            Destroy(pollito);
            GameObject exp =  Instantiate(explosion, new Vector3(-4.9f,0,-2.72f), transform.rotation);
            Destroy(exp, 2f);
            //Instantiate(fire, new Vector3(-4.9f,0,-2.72f), transform.rotation);
        }   
        count ++;
    }
}
