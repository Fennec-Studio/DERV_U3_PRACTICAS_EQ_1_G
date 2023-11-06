
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaProyectil : MonoBehaviour
{
    GameObject origenProyectil;
    [SerializeField] GameObject proyectil;
    [SerializeField] GameObject Cargador;
    int numP;
    private List<GameObject> proyectiles = new List<GameObject>();
    private int maxProyectiles = 10;

    // Start is called before the first frame update
    void Start()
    {
        numP = 0;
        origenProyectil = GameObject.Find("SpawnBala");

        // Crea 10 proyectiles iniciales y desactívalos
        for (int i = 0; i < maxProyectiles; i++)
        {
            GameObject objProyectil = Instantiate(proyectil, Vector3.zero, Quaternion.identity);
            objProyectil.name = "P" + i.ToString();
            objProyectil.SetActive(false);
            objProyectil.transform.SetParent(origenProyectil.transform);
            proyectiles.Add(objProyectil);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (numP < 10)
            {
                GameObject proyectilActivo = proyectiles[numP];

                proyectilActivo.transform.position = origenProyectil.transform.position;
                proyectilActivo.transform.rotation = origenProyectil.transform.rotation;
                proyectilActivo.SetActive(true);
                numP++;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            numP = 0;
            recargarArmar();
        }
    }

    void recargarArmar()
    {
        Rigidbody cargadorRB;
        cargadorRB = Cargador.GetComponent<Rigidbody>();
        cargadorRB.isKinematic = false;
        for (int i = 0; i < maxProyectiles; i++)
        {
            proyectiles[i].transform.position = origenProyectil.transform.position;
            proyectiles[i].transform.rotation = origenProyectil.transform.rotation;
            proyectiles[i].SetActive(false);
        }
    }
}