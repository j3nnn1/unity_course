using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour {

	public float velocidad = 1.0f;
	private Rigidbody rb;
    
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (rb == null)
			return;

		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		rb.velocity = (h * Vector3.right + v * Vector3.forward) * velocidad + Vector3.up * rb.velocity.y;
	}
}
