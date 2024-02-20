using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject thecar;

    void LateUpdate()
    {
        transform.position = thecar.transform.position + new Vector3(0,0,-10);
    }
}
