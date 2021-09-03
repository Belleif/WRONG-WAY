using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScareCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Scare_Transition.scareLimit > 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }
    }
}
