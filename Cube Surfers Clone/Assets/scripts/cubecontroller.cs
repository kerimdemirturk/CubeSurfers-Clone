using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubecontroller : MonoBehaviour
{
    public float forwardSpeed = 2.0f;
    public float horizontalSpeed= 2.0f;
    private float horizontal;
    float Xborder = 2.13f;
    
    



    void Start()
    {

    }

    void Update()
    {
        borders();
           

    }

    private void FixedUpdate()
    {
        Moving();
    }

    void Moving()
    {
        horizontal = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        // when moving take horizontal input  as x , take 0 as y and take z as forwardspeed*time.deltatime;
        transform.Translate(horizontal, 0, forwardSpeed*Time.deltaTime);
    }

    void borders()
    {
        if(transform.position.x>Xborder)
        {
            transform.position = new Vector3(Xborder, transform.position.y, transform.position.z);
        }
        if(transform.position.x<-Xborder)
        {
            transform.position = new Vector3(-Xborder, transform.position.y, transform.position.z);
        }
        
        
    }
 
   

    
    

}
