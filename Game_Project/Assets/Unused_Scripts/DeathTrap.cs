using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrap : MonoBehaviour
{
   void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            FindObjectOfType<SceneHandler>().StartRespawnCoroutine(collider.gameObject);
        }
    }
}
