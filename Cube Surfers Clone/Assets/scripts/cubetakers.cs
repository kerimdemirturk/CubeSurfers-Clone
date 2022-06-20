using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubetakers : MonoBehaviour
{
    GameObject maincube;
    float yHigh=0;
    public AudioSource coin;

    void Start()
    {
        maincube = GameObject.Find("maincube");
    }

    // Update is called once per frame
    void Update()
    {
        maincube.transform.position = new Vector3(maincube.transform.position.x, yHigh, maincube.transform.position.z);
        this.transform.localPosition = new Vector3(0, -yHigh-1, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gamecubes" && other.gameObject.GetComponent<cubemechanics>().is›tTaken()==false)
        {
            yHigh += 0.5f;
            other.gameObject.GetComponent<cubemechanics>().Taken();
            other.gameObject.GetComponent<cubemechanics>().indexCounter(yHigh);
            other.gameObject.transform.parent = maincube.transform;
            Debug.Log(yHigh);
            coin.Play();
        }
    }
    public void Ydecrease()
    {
        yHigh--;
    }
}
