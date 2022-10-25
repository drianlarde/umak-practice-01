using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update


    // Initialize the rigidbody
    Rigidbody rb;
    public float speed = 0.1f;
    // isGround initialize
    bool isGround = true;

    void Start() // Start is called before the first frame update
    {
        // Get the rigidbody component from the player
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //If the player presses the space bar then jump 
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            // Add a force to the rigidbody
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
        //if player presses the up arrow key then move forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Add a force to the rigidbody
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        //if player presses the down arrow key then move backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Add a force to the rigidbody
            rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
        }
        //if player presses the left arrow key then move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Add a force to the rigidbody
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        //if player presses the right arrow key then move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Add a force to the rigidbody
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
    }

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    void OnCollisionEnter(Collision collision)
    {
        // If the player collides with the ground
        if (collision.gameObject.tag == "Ground")
        {
            // Set the player's position to the ground's position
            // transform.position = collision.gameObject.transform.position;

            // Debug.Log("Is Collided with Ground");
            isGround = true;
        }
    }

    // OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider
    void OnCollisionExit(Collision collision)
    {
        // If the player collides with the ground
        if (collision.gameObject.tag == "Ground")
        {
            // Set the player's position to the ground's position
            // transform.position = collision.gameObject.transform.position;

            // Debug.Log("Is Collided with Ground");
            isGround = false;
        }
    }
}
