using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    public Vector3 position;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ft = Time.deltaTime;
        this.transform.position += new Vector3(0, speed, 0) * ft;
        
    }
}
