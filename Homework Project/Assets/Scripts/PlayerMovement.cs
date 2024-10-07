using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Rigidbody myRb; 
    public float jumpForce = 5f;
    public float sprintSpeed = 10f; 
    private float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        currentSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = Vector3.zero; // Initialize movement vector

        if (Input.GetKey(KeyCode.W)) // Move forward
            movementDirection += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) // Move backward
            movementDirection += Vector3.back;
        if (Input.GetKey(KeyCode.A)) // Move left
            movementDirection += Vector3.left;
        if (Input.GetKey(KeyCode.D)) // Move right
            movementDirection += Vector3.right;

        // Normalize and move the player
        myRb.MovePosition(transform.position + movementDirection.normalized * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) // Use spacebar for jumping
        {
            myRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftShift)) // Sprint when holding left shift
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = moveSpeed; // Reset to normal speed
        }
         myRb.MovePosition(transform.position + movementDirection.normalized * currentSpeed * Time.deltaTime); 
        }
       
    } 