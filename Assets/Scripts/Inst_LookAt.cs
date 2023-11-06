using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inst_LookAt : MonoBehaviour
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
        Vector3 aux = obj_a_observar.transform.position;
        if(aux.y > 3)
        {
            aux.y = 3;
        }
        transform.LookAt(aux);

    }
}
