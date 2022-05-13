using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public ParticleSystem partic;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.green);
        RaycastHit hit;
        if(Input.GetButtonDown("Fire1")){
            partic.Play();
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                if(hit.transform.gameObject.tag == "target"){
                   Destroy(hit.transform.gameObject); 
                }
                
            }

        }
    }
}
