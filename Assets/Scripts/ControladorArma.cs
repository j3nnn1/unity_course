using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorArma : MonoBehaviour
{
    public GameObject proyectil;
    public GameObject canion;
    public float potencia = 10.0f;
    public float tiempoCoolDown = 1.0f;
    private bool canDisparar = true;
    IEnumerator CoolDown()
    { // sirve para hacer un spawner cada N tiempo crear un enemigo. puede ser con while true
        canDisparar = false;
        yield return new WaitForSeconds(tiempoCoolDown);
        canDisparar = true;
    }
    
    void Update()
    {
        bool disparo = Input.GetButton("Fire1"); //si mantengo presionado el click
        //bool disparo = Input.GetButtonDown("Fire1"); solo cuando hago click
        if (disparo && canDisparar)
        {
            GameObject p = GameObject.Instantiate(proyectil, canion.transform.position, canion.transform.rotation);

            Rigidbody rb = p.GetComponent<Rigidbody>();
            StartCoroutine("CoolDown"); //this is a corrutina  always return iEnumerator
            if (rb != null)
                rb.velocity = canion.transform.forward * potencia;
        }
        
    }
}
