using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.forward, out hit, 20f)){
            if(hit.transform.tag == "ObjGeometrico"){
                //hit.transform.gameObject.GetComponent<ObjectController>().TeleportRandomly();
                Debug.DrawRay(transform.position, Vector3.forward*50f, Color.green);
            }else{
                 Debug.DrawRay(transform.position, Vector3.forward * 10f, Color.red);
            }
        }
        
    }
}
