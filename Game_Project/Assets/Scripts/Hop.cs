using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour
{
    float timer = 0;
    float jumpForce = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Mathf.FloorToInt(timer) % 2 == 0)
            this.transform.position += new Vector3(0, jumpForce, 0) * Time.deltaTime;

        else this.transform.position += new Vector3(0, -jumpForce, 0) * Time.deltaTime;
    }
}
