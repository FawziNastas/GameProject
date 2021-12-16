using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenControl : MonoBehaviour
{
    float speed = 3f, delta;
    Vector3[] point = new Vector3 [4];
    Vector3 destination;
    int di = 0;
    // Start is called before the first frame update
    void Start()
    {
        point[0] = transform.position;
        point[1] = new Vector3(point[0].x + 8, point[0].y, point[0].z + 5);
        point[2] = new Vector3(point[0].x + 8, point[0].y, point[0].z + 5);
        point[3] = new Vector3(point[0].x + 13, point[0].y, point[0].z - 3);
        destination = point[di];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = (destination - this.transform.position).normalized * speed * Time.deltaTime;
        Vector3 lookDirection = move + this.transform.position;
        this.transform.LookAt(lookDirection);
        this.transform.position += move;

        delta = (transform.position - destination).magnitude;
        if (delta < 0.1)
        {
            di++;
            destination = point[di % 4];
        }
    }
}
