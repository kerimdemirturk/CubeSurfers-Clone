using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public GameObject lookpoz;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, lookpoz.transform.position + offset, Time.deltaTime);
    }



}
