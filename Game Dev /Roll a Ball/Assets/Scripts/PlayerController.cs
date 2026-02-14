using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f; // Variable to control hpw fast the player moves
    public CharacterController controller; // Empty reference to the CharacterController component on the player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>(); // Get the CharaacterCOntroller component attached to the player
    }

    // Update is called once per frame
    void Update()
    {
        float horazontalInput = Input.GetAxis("Horizontal"); // Stores the Horizontal (left/right) input of the player
        float verticalInput = Input.GetAxis("Vertical"); // Stores the Vertical (up/down) input of the player

        Vector3 movement = new Vector3(horazontalInput, 0f, verticalInput); // Calculate the direction the plyer should move based on the input
        movement = transform.TransformDirection(movement); // Convert the direction this means 'forward' will be = direction the player is facing
        movement *= movementSpeed;

        controller.Move(movement * Time.deltaTime); // Moves the cam
    }
}
