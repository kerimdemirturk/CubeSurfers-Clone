using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manposition : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float cubeY = GameObject.Find("Cube").GetComponent<BoxCollider>().size.y;
        transform.position = new Vector3(cube.transform.position.x, cubeY, cube.transform.position.z);
    }
}
