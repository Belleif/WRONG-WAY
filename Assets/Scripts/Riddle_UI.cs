using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Riddle_UI : MonoBehaviour
{
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {
        textElement.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            textElement.gameObject.SetActive(true);
        } 
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            textElement.gameObject.SetActive(false);
        }
    }
}
