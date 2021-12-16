using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWin : MonoBehaviour
{

    int count = 0;
    int totalNum;
    public GameObject endScreen;
    public BoxCollider penSize;
    public Camera main, end;
    // Start is called before the first frame update
    void Start()
    {
       endScreen.SetActive(false);
       totalNum = GameObject.FindGameObjectsWithTag("Chicken").Length;
        main.enabled = true;
        end.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (count == totalNum)
        {
            endScreen.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Level Complete!";
            endScreen.SetActive(true);
            main.enabled = false;
            end.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chicken")
        {
            Destroy(other.gameObject);
            Vector3 position = new Vector3(Random.Range(penSize.bounds.min.x, penSize.bounds.max.x), 0, Random.Range(
                penSize.bounds.min.z, penSize.bounds.max.z));
            GameObject chick = Instantiate(other.gameObject, position, Quaternion.identity); //create chicken inside the pen
            if (chick.GetComponent<ChickenControl>() != null)
                Destroy(chick.GetComponent<ChickenControl>());//remove walking script

            chick.AddComponent<Hop>(); //make chickens jump at end
            ++count;
        }
    }
}
