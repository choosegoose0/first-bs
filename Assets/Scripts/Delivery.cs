using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 hasNoPackageColor = new Color32(1,1,1,1);
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package")
        {
            if (hasPackage == false)
            {
                Debug.Log("picked up package");
                hasPackage = true;
                Destroy(other.gameObject,destroyDelay);
                spriteRenderer.color = hasPackageColor;
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
                spriteRenderer.color = hasNoPackageColor;
            }
            else
            {
                Debug.Log("dont have the package bozo");
            }
        }
        
    }

}
