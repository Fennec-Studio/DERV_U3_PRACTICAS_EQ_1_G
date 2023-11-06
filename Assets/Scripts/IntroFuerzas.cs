using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFuerzas : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float velocidad;
    void Start()
    {
        //AddForceAtPosition cuando la direccion es obtenida de un punto en particulas, una fuerza desde una direccion 
        //AddForce genera la fuerza desde el interior del objeto
        //Impulse equivale a un golpe, es un movimiento instantaneo
        //acceleration acelera sin importar la masa
        //force aceleracion per avanza importando la masa
        //velocityChange lo mismo que impulse pero sin masa
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.right * velocidad, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
     //se ejecuta una vez cada cierta cantidad de tiempo, el cual lo podemos definir nosotros
        //project settings
            //Time
                //Fixed Timestep: 0.02
    {
        //Continuas
        rb.AddForce(transform.right * velocidad, ForceMode.Acceleration);
        rb.AddForce(transform.right * velocidad, ForceMode.Force);

        //Instantaneas
        rb.AddForce(transform.right * velocidad, ForceMode.Impulse);
        rb.AddForce(transform.right * velocidad, ForceMode.VelocityChange);
    }
}
