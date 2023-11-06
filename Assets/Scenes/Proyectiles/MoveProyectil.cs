using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProyectil : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float fuerza;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * fuerza, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

