using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sombras : MonoBehaviour
{
    public GameObject figure;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(figure.activeSelf == true)
        {
            this.gameObject.SetActive(true);
            //this.transform.position = new Vector3(figure.transform.position.x,figure.transform.position.y + 0.5f,figure.transform.position.z);
            this.transform.position = new Vector3(figure.transform.position.x,figure.transform.position.y,figure.transform.position.z);
        }
        else
            this.gameObject.SetActive(false);
    }
}
