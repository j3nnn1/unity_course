using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public float sensibilityX;
    public float sensibilityY;
    public bool hideMouse = true;
    private Quaternion rotationOriginal;
    private float anguloMinimoX = -360;
    private float anguloMaximoX = 360;
    private float anguloMinimoY = -60;
    private float anguloMaximoY = 60;
    private float rotationX;
    private float rotationY;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.freezeRotation = true;
        }
        if (hideMouse)
            Cursor.lockState = CursorLockMode.Locked;
        rotationOriginal = transform.localRotation;
    }
    
    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * sensibilityX;
        rotationY += Input.GetAxis("Mouse Y") * sensibilityY;

        rotationX = LimitarAngulo(rotationX, anguloMinimoX, anguloMaximoX);
        rotationY = LimitarAngulo(rotationY, anguloMinimoY, anguloMaximoY);

        Quaternion newRrotationX = Quaternion.AngleAxis(rotationX, Vector3.up);
        Quaternion  newRotationY = Quaternion.AngleAxis(rotationY, Vector3.left);

        transform.localRotation = rotationOriginal * newRrotationX * newRotationY;
    }

    public float LimitarAngulo(float angulo, float anguloMinimo, float anguloMaximo)
    {
        angulo = angulo % 360;
        return Mathf.Clamp(angulo, anguloMinimo, anguloMaximo);
    }
}
