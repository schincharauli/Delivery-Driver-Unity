using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] float destroyTime = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 hasNoPAckageColor = new Color32(1, 1, 1, 1);

    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("we just bumped to the rock");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package is picked");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyTime);

        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
            spriteRenderer.color = hasNoPAckageColor;
        }
    }
}
