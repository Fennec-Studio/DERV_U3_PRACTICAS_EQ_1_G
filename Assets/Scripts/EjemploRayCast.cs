using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EjemploRayCast : MonoBehaviour
{
    Transform obj_a_mirar;
    bool isHandsBusy;
    string name_obj_tomar;
    // Start is called before the first frame update
    void Start()
    {
        obj_a_mirar = GameObject.Find("Jugador").transform;
        Ray ray = new Ray(transform.position, transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 destino = obj_a_mirar.position;
        RaycastHit hit;

        bool estado = Physics.Raycast(origen, transform.forward, out hit, 10);

        Debug.DrawRay(origen, transform.forward * hit.distance, Color.cyan);
        if (isHandsBusy)
        {
            if (estado)
            {
                float d = hit.distance;
                //name_obj_tomar = hit.collider.gameObject;
                Debug.Log(hit.distance);
                Debug.DrawRay(origen, transform.forward * hit.distance, Color.cyan);

                if (d > 1)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {

                        //Tomar objeto
                        GameObject obj = hit.collider.gameObject;
                        obj.transform.SetParent(transform);

                        GameObject objPosDestino = GameObject.Find("PosicionManos");
                        obj.transform.position = objPosDestino.transform.position;
                        obj.transform.rotation = objPosDestino.transform.rotation; //esto define la rotacion
                        //obj.transform.localScale = objPosDestino.transform.localScale;
                        obj.transform.localScale = obj.transform.localScale / 2;

                        obj.GetComponent<Rigidbody>().isKinematic = true;
                        obj.GetComponent<Rigidbody>().useGravity = true;

                        isHandsBusy = true;
                    }
                }
            }
            else
            {
                Debug.DrawRay(origen, transform.forward * 10, Color.cyan);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isHandsBusy)
                {
                    //Soltar objeto

                    GameObject objPosDestino = GameObject.Find(name_obj_tomar);
                    objPosDestino.transform.SetParent(null);
                    objPosDestino.GetComponent<Rigidbody>().isKinematic = false;
                    objPosDestino.GetComponent<Rigidbody>().useGravity = true;
                    objPosDestino.transform.localScale = objPosDestino.transform.localScale * 2;
                    isHandsBusy = false;
                }
            }
        }
    }
}
