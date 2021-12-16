using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharacter : MonoBehaviour
{
    public float jumpForce = 20f;
    bool isGrounded;
    bool jumpPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            jumpPressed = true;
    }

    private void FixedUpdate()
    {
        if(jumpPressed && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            jumpPressed = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Super Mushroom")
            jumpForce = 30;
    }

    private void OnTriggerExit(Collider other)
    {
        jumpForce = 8;
    }
}
