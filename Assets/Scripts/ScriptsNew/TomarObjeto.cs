using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarObjeto : MonoBehaviour
{
    Transform obj_a_mirar;
    bool isHandsBusy = false;
    string name_obj_tomar;
    void Start()
    {
        obj_a_mirar = GameObject.Find("Jugador").transform;
    }
    void Update()
    {
        Vector3 inicioRayo = transform.position;
        RaycastHit hit;
        bool estado = Physics.Raycast(inicioRayo, transform.forward, out hit, 4f);
        Debug.DrawRay(inicioRayo, transform.forward * 4f, Color.cyan);
        if (isHandsBusy)
        {
            if (estado)
            {
                float d = hit.distance;
                Debug.DrawRay(inicioRayo, transform.forward * hit.distance, Color.cyan);
                if (d > 1)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        GameObject obj = hit.collider.gameObject;
                        obj.transform.SetParent(transform);
                        GameObject objPosDestino = GameObject.Find("PosicionManos");
                        obj.transform.position = objPosDestino.transform.position;
                        obj.transform.rotation = objPosDestino.transform.rotation; //esto define la rotacion
                        obj.transform.localScale = obj.transform.localScale / 2;
                        obj.GetComponent<Rigidbody>().isKinematic = true;
                        obj.GetComponent<Rigidbody>().useGravity = true;
                        isHandsBusy = true;
                    }
                }
            }
            else
            {
                Debug.DrawRay(inicioRayo, transform.forward * 10, Color.cyan);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isHandsBusy)
                {
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
