using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    
    private float speed = 5f;
    public Transform cameraPos;
    Vector3 move;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        calculateMovement();
    }

    void calculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 cameraToPlayer = (this.transform.position - cameraPos.position).normalized;
        cameraToPlayer.y = 0; //ignore the y axis 

        move = (cameraToPlayer * verticalInput + cameraPos.transform.right * horizontalInput) * speed;
        Vector3 lookDirection = move + this.transform.position;
        this.transform.LookAt(lookDirection);
    }

    private void FixedUpdate()
    {
        move.y = rigidBody.velocity.y;
        rigidBody.velocity = move;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
