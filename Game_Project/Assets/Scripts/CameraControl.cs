using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Mouse X");
        float x = Input.GetAxis("Mouse Y");
        this.transform.eulerAngles += new Vector3(-x, y, 0) * rotationSpeed * Time.deltaTime;
    }
}
