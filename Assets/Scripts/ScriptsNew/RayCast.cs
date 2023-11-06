using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        Vector3 inicioRayo = transform.position;
        RaycastHit hit;
        bool detectacObjeto = Physics.Raycast(inicioRayo, transform.forward, out hit, 4f);
        if (detectacObjeto)
        {
            Debug.DrawRay(inicioRayo, transform.forward * hit.distance, Color.red);
        }
        else {
            Debug.DrawRay(inicioRayo, transform.forward * 4f, Color.yellow);
        }
    }
}
