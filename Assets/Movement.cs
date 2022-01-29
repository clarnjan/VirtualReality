using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public float speed = 3.0F;
    public bool isMoving;
    public float minAngle = 30.0F;
    public float maxAngle = 90.0F;
    private CharacterController controller;
    private Transform vrCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        vrCamera = Camera.main.transform;
    }

    void Update()
    {
        if (vrCamera.eulerAngles.x >= minAngle && vrCamera.eulerAngles.x < maxAngle)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            Move();
        }
    }
    void Move()
    {
        Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
        controller.SimpleMove(forward * speed);
    }
}
