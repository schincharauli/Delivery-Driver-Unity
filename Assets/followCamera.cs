using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{

    [SerializeField] GameObject thingToFolllow;

    // Update is called once per frame
    void LateUpdate()

    {
        transform.position = thingToFolllow.transform.position + new Vector3(0, 0, -10);

    }
}
