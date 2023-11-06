using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    [SerializeField] Transform jugador;
    [SerializeField] float velocidad;
    [SerializeField] NotificaTrigger notifica;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Jugador").transform; 
        notifica = GetComponentInChildren<NotificaTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (notifica.detectaJugador)
        {
            transform.LookAt(jugador);
            float distancia = Vector3.Distance(transform.position, jugador.position);
            if(distancia > 2) {
                transform.position = Vector3.MoveTowards(transform.position, jugador.position, velocidad * Time.deltaTime);
            }

        }
    }
}
