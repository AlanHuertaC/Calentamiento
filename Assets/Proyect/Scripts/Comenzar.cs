using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comenzar : MonoBehaviour
{   
    public Text TituloTiempo;
    public Text reloj;
    public Image PanelInstrucciones;
    /*public Text Titulo;
    public Text Instrucciones;

    public Image BotonComenzar;

    public Text TextoBoton;*/
    /*Canvas de Puntuación*/
    public Image PanelPuntuacion;

    // Start is called before the first frame update
    void Awake() {
        TituloTiempo.gameObject.SetActive(false);
        reloj.gameObject.SetActive(false);
        Time.timeScale = 0;    
        PanelPuntuacion.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void comenzar(){
        Debug.Log("Click");
        PanelInstrucciones.gameObject.SetActive(false);
        /*Titulo.gameObject.SetActive(false);
        Instrucciones.gameObject.SetActive(false);
        BotonComenzar.gameObject.SetActive(false);*/
        TituloTiempo.gameObject.SetActive(true);
        reloj.gameObject.SetActive(true);
        Time.timeScale = 1;    
        PanelPuntuacion.gameObject.SetActive(true);    
        Reloj tiempo = GameObject.Find("Reloj").GetComponent<Reloj>();
        tiempo.tiempoMostrarEnSegundos = 0;   
    }
}
