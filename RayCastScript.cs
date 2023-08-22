using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;
    public float size = 0.1f;
    public float sizeIcreseNumber = 0.05f;

    void Update()
    {
        ray = new Ray(transform.position, (transform.forward * (size * 10)));

        Debug.DrawRay(transform.position, (transform.forward * (size * 10)), Color.yellow);

        size += sizeIcreseNumber;

        if (Physics.Raycast(ray, out hit, (size * 10)))
        {
            size = (hit.point.z - transform.position.z) / 10;
            Debug.Log((hit.point.z - transform.position.z) / 10);
        }
    }
}
