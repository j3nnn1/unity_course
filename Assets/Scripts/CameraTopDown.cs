using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraTopDown : MonoBehaviour
{
	public GameObject player;
	public float distance = 10.0f;
	public float inercia = 1.0f;

	void Start() {
	}
	void Update() {
		
		Vector3 objetivo = player.transform.position + Vector3.up * distance;
		// para ir de forma dura
		//transform.position = objetivo
		// para ir de forma suave
		//interpolacion lineal Lerp posicion inicial, objetivo a donde quieron ir, un delta del tiempo puede ser el tercer parametros
		transform.position = Vector3.Lerp(transform.position, objetivo, Time.deltaTime * inercia);
		transform.rotation = Quaternion.LookRotation();

	}
}

