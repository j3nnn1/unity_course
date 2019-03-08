using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidad = 0.1f;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("Update", gameObject);

		if (Input.GetKey("up") == true) {
			transform.Translate (new Vector3 (0, velocidad, 0));
		}
		if (Input.GetKey("down") == true) {
			transform.Translate (new Vector3 (0, -velocidad, 0));
		}
		if (Input.GetKey("left") == true) {
			transform.Translate (new Vector3 (-velocidad, 0, 0));
		}
		if (Input.GetKey("right") == true) {
			transform.Translate (new Vector3 (velocidad, 0, 0));
		}
		if (Input.GetKey("w") == true) {
			transform.Translate (new Vector3 (0, 0, velocidad));
		}
		if (Input.GetKey("s") == true) {
			transform.Translate (new Vector3 (0, 0, -velocidad));
		}
		bool flechaArriba = Input.GetKey("up");
		bool flechaAbajo = Input.GetKey("down");
		bool flechaIzquierda = Input.GetKey("left");
		bool flechaDerecha = Input.GetKey("right");
	}
}
