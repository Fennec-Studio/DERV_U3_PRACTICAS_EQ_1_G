using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_Distance : MonoBehaviour
{
    [SerializeField] GameObject obj_a_observar;
    // Start is called before the first frame update
    void Start()
    {
        obj_a_observar = GameObject.Find("Jugador");

    }

    // Update is called once per frame
    void Update()
    {
        //distancia entre dos puntos:
        //d = sqrt(X1-X2)**2 + (Y11-Y2)**2

        //distancia entre dos puntos:
        //d = sqrt(X1-X2)**2 + (Y11-Y2)**2 + (Z1-Z2)**2)...

        float distancia = Vector3.Distance(transform.position,
            obj_a_observar.transform.position
            );
        Debug.Log( "Distancia: " + distancia.ToString() );

    }
}
