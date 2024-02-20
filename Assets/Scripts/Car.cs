using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float steerspeed= 270f;
    [SerializeField] float drivespeed= 10f;
    [SerializeField] float boost = 3f;

    void Update()
    {
        float boostamount = Input.GetAxis("boost")*boost*drivespeed*Time.deltaTime;
        float drive = Input.GetAxis("Vertical")*drivespeed*Time.deltaTime+boostamount;
        float steeramount = Input.GetAxis("Horizontal")*steerspeed*Time.deltaTime;
        transform.Rotate(0,0,-steeramount);
        transform.Translate(0,drive,0);
    }
}
