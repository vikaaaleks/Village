using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    float v;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        if(v>0){
            anim.SetBool("step", true);
            if(Input.GetKeyDown("left shift")){
                anim.SetBool("run", true);
            }
            if(Input.GetKeyUp("left shift")){
                anim.SetBool("run", false);
            }
            }else{
                anim.SetBool("step", false);
            }
        }
}