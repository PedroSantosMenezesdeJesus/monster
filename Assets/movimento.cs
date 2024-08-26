using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public float speed = 5.0f;
    public float gravity = -9.81f;
    public float jumpHeight = 1.5f;
    public float jumpSpeedMultiplier = 2.0f;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float moveZ = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * moveZ;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (velocity.y > 0)
        {
            controller.Move(Vector3.up * velocity.y * jumpSpeedMultiplier * Time.deltaTime);
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
