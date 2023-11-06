using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REvivir : MonoBehaviour
{
    GameObject jugador;
    GameObject area_inicio;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Jugador");
        area_inicio = GameObject.Find("SpawnPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        if(jugador.transform.position.y < -0.5f)
        {
            jugador.transform.position = area_inicio.transform.position;
        }
        
    }
}
