using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float horizontalRotationSpeed = 100f, verticalRotationSpeed = 50f;
    public Transform player;
    float rotateX, rotateY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateY += Input.GetAxis("Mouse X") * horizontalRotationSpeed * Time.deltaTime;
        rotateX += Input.GetAxis("Mouse Y") * verticalRotationSpeed * Time.deltaTime;
        rotateX = Mathf.Clamp(rotateX, 0f, 40f); //restrict up and down movement for camera

        transform.eulerAngles = new Vector3(-rotateX, rotateY, 0f);

        this.transform.position = player.position;
    }
}
