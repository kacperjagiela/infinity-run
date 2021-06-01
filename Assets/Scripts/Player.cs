using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float walkInput;
    public float movementSpeed = 10f;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        walkInput = context.ReadValue<float>();
    }

    void ApplyMovement()
    {
        playerRigidbody.AddForce(Vector3.left * movementSpeed * walkInput);
    }
}
