using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { 
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
        //else
         if (Input.GetKey(KeyCode.S)) {
            transform.Translate(transform.forward * -1 * speed * Time.deltaTime);
        }
         //else
         if (Input.GetKey(KeyCode.A)) {
            transform.Translate(transform.right *  -1 * speed * Time.deltaTime);
        }
         //else
         if (Input.GetKey(KeyCode.D)) {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
    }
}
