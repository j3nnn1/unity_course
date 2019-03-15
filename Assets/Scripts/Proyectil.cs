using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")) {

            GameObject.Destroy(collision.gameObject);
            GameObject.Destroy(gameObject);
        }
           
                
                
                
    }
}
