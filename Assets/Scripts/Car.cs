using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float steerspeed= 270f;
    [SerializeField] float drivespeed= 10f;
    [SerializeField] float boost = 3f;
    float boostMultiplier = 1f;
    float slowMultiplier = 0.6f;

    

    void Update()
    {
        float drive = Input.GetAxis("Vertical")*drivespeed*Time.deltaTime*boostMultiplier;
        float steer = Input.GetAxis("Horizontal")*steerspeed*Time.deltaTime;
        transform.Rotate(0,0,-steer);
        transform.Translate(0,drive,0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boostpad")
         {
            Debug.Log("boosted");
            boostMultiplier = 1.5f;
            
            
         }
    }
}
