using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public GameObject cube;
    public Vector3 offset = new Vector3(4, 0.875f, 0.2f);
    




    void Start()
    {
        



    }

    
    void LateUpdate()
    {
        transform.position = cube.transform.position+offset;
    }

    /*
    public Vector3 offset()
    {
        float cubeposX = (transform.position.x) + (cube.transform.position.x);
        float cubeposY = (transform.position.y) - (cube.transform.position.y);
        Vector3 offset = new Vector3(cubeposX, cubeposY, transform.position.z);
        return offset;
    }
    */
    
}
