using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    public float RespawnTime;
    public Transform RespawnLocation;


    // Start is called before the first frame update
    public void StartRespawnCoroutine(GameObject go) {
        ToggleObjectForRespawn(go, false);
        go.transform.position = new Vector3(9999, -9999, 9999);

        StartCoroutine(RespawnCoroutine(go));
    }

    IEnumerator RespawnCoroutine(GameObject go)
    {
        yield return new WaitForSeconds(RespawnTime);

        ToggleObjectForRespawn(go, true);
        go.transform.position = RespawnLocation.position;

    }

    // Update is called once per frame
    void ToggleObjectForRespawn(GameObject go, bool toggle)
    {
        go.GetComponent<MeshRenderer>().enabled = toggle;
        go.GetComponent<CharacterController>().enabled = toggle;
    }
}
