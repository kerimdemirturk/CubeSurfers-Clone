using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemechanics : MonoBehaviour
{
    public bool isTaken;
    float cubeindex;
    public cubetakers takers;

    

    
    void Start()
    {
        
        isTaken = false;
    }

    
    void Update()
    {
        if(isTaken==true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -cubeindex*2, 0);

            }
        }
        
        
    }
    public bool is›tTaken()
    {
        return isTaken;
    }
    public void Taken()
    {
        isTaken = true;
    }
    public void indexCounter(float cubeindex)
    {
        this.cubeindex = cubeindex;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="wall")
        {
            takers.Ydecrease();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

}
