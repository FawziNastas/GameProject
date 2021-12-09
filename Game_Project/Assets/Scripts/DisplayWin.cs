using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWin : MonoBehaviour
{

    int count = 0;
    int totalNum;
    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
       endScreen.SetActive(false);
        totalNum = GameObject.FindGameObjectsWithTag("Chicken").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (count == totalNum)
        {
            endScreen.GetComponentInChildren<Text>().text = "Level Complete!";
            endScreen.SetActive(true); 
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        ++count;
    }
}
