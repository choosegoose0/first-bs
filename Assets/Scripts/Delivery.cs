using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package")
        {
            if (hasPackage == false)
            {
                Debug.Log("picked up package");
                hasPackage = true;
                Destroy(other.gameObject,destroyDelay);
            } 
            else
            {
                Debug.Log("you already have a package");
            }
        }
        
        if (other.tag == "Customer")
        {
            if (hasPackage)
            {
                Debug.Log("package delivered");
                hasPackage = false;
            }
            else
            {
                Debug.Log("dont have the package bozo");
            }
        }
        
    }

}
