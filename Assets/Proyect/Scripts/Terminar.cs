using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terminar : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TextoTiempo;
    public Text Tiempo;
    public Text Puntuacion;
    public Image PanelPuntuacion;

    public Image PanelFinal;
    public Text PuntuacionFinal;
    public Text TiempoFinal;

    /*Obejetos geometricos*/
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    /*Panel Instrucciones*/
    public Image PanelInstrucciones;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void terminar(){
        Time.timeScale = 0; // Se detiene el tiempo
        ConsultasSQL sql = new ConsultasSQL(); 
        CameraSettings camera = GameObject.Find("LeftEye").GetComponent<CameraSettings>();
        string paciente = camera.idPaciente;
        string especialista = camera.idEspecialista;
        string duracion = Tiempo.text.ToString();
        string puntuacion = Puntuacion.text.ToString();
        sql.insertTratamiento("Calentamiento",puntuacion,duracion,paciente,especialista);
        
        /*Ocultar los tiempos y el canvas de puntuacion*/
        TextoTiempo.gameObject.SetActive(false);
        Tiempo.gameObject.SetActive(false);
        PanelPuntuacion.gameObject.SetActive(false);
        /*Ocultar figuras para que no se pueda interactuar*/
        obj1.gameObject.SetActive(false);
        obj2.gameObject.SetActive(false);
        obj3.gameObject.SetActive(false);

        /*Poner el canvas con el puntaje y tiempo*/
        PuntuacionFinal.text = "Obtuviste una puntuación de " + Puntuacion.text + " puntos"; 
        TiempoFinal.text = "Tu tiempo final fue de: " + Tiempo.text;
        PanelFinal.gameObject.SetActive(true);
        
    }

    public void reiniciar(){
        PanelFinal.gameObject.SetActive(false);
        /*obj1.gameObject.SetActive(true);
        obj2.gameObject.SetActive(true);*/
        obj3.gameObject.SetActive(true);
        obj3.transform.position = new Vector3(-.8f, 1.5f, 4.21f);
        PanelInstrucciones.gameObject.SetActive(true);
        Puntuacion.text = "0";
        
    }
}
