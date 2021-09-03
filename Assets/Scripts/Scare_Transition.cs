using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scare_Transition : MonoBehaviour
{
    public Animator anim;
    bool isAnimating;
    public static bool IsInputEnabled = true;
    public static float scareLimit = 0;


    // Start is called before the first frame update
    void Start()
    {
        isAnimating = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAnimating == true)
        {
            anim.SetTrigger("isJumpScared");
            isAnimating = false;
        }
        if (isAnimating == false)
        {
            IsInputEnabled = true;
        }
        if (Scare_Transition.scareLimit > 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetInteger("jumpScareIndex", Random.Range(0, 3));
            anim.SetTrigger("isJumpScared");
            isAnimating = true;
            IsInputEnabled = false;
            scareLimit++;
        }
    }



    private void OnTriggerExit(Collider other)
    {

        Destroy(gameObject);
        
    }
}
