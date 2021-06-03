using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float walkInput;
    public float movementSpeed = 30f;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        handleMovement();
        handleSpeedUp();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        walkInput = context.ReadValue<float>();
    }

    void handleMovement()
    {
        transform.position = transform.position + new Vector3(-movementSpeed * walkInput * Time.deltaTime, 0, 0);
    }

    void handleSpeedUp()
    {
        transform.position = transform.position + new Vector3(0, 0, -movementSpeed * Time.deltaTime);
    }
}
