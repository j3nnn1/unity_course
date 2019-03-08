using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour {

	public float velocidad = 1.0f;
	Rigidbody  rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb == null)
			return;
		
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Debug.Log ("Horizontal " + h);
		Debug.Log ("Vertical " + v);

		//transform.position += h * new Vector3(1.0f, 0.0f, 0.0f);
		// v = d / t
		// como definir los frame por segundos??  no se define, cada pc tiene su rendimiento diferente
		//transform.position += (h * Vector3.right + v * Vector3.forward) * velocidad * Time.deltaTime; no la usamos porque vamos a usar el component rigid body
		//camara y escala?? como evitar que el personaje salga de la camara y el planoo?
		//TAREA implementar camera lateral.. para runner...
		rb.velocity = (h * Vector3.right + v * Vector3.forward) * velocidad + Vector3.up * rb.velocity.y;

		Debug.Log ("h: " + h);
		Debug.Log ("v: " + v);
		Debug.Log ("rb.velocity: " + rb.velocity);
	}
}
