using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecontroller : MonoBehaviour
{
    public float forwardSpeed = 2.0f;
    public float horizontalSpeed= 2.0f;
    public float horizontal;
    public float Xborder = 2.13f;
    private Vector3 temp; // for holding vector3 sclae value
    private int cubesCounter = 0 ; // count to cubes number for updating cubes size



    void Start()
    {

    }

    void Update()
    {
        borders();
        temp = transform.localScale; //take scale of cubes
        

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
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gamecubes")
        {

            Destroy(other.gameObject);
            cubesCounter += 1; // at every trigger event count +1
            temp.y += cubesCounter; // update scale.y 
            transform.localScale = temp; //equalize scale
 
        }
    }
}
