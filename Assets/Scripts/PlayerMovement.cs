using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	private Vector3 moveInput;
	private Vector3 moveVelocity;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	//rb.velocity = (h * Vector3.right + v * Vector3.forward) * velocidad + Vector3.up * rb.velocity.y;
	void Update () {
		float lh = Input.GetAxis("Horizontal");
		float lv = Input.GetAxis("Vertical");
		moveInput = new Vector3 (lh, 0f, lv);
		moveVelocity = (lh * Vector3.right + lv * Vector3.forward) * moveSpeed + Vector3.up * rb.velocity.y;//transform.forward * moveSpeed * moveInput.sqrMagnitude;

		Debug.Log ("lh: " + lh);
		Debug.Log ("lv: " + lv);

		Debug.Log ("Update: moveInput: " + moveInput);
		Debug.Log ("Update: moveVelocity: " + moveVelocity);
	}

	void FixedBody(){
		

		Debug.Log ("FixedBody: moveVelocity: " + moveVelocity);
	}
}
