using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject obj_a_observar;
    [SerializeField] float velocidad;
    void Start()
    {
        obj_a_observar = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, obj_a_observar.transform.position, velocidad * Time.deltaTime);
    }
}
