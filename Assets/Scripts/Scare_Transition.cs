using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare_Transition : MonoBehaviour
{
    public Animator anim;
    bool isAnimating;

    // Start is called before the first frame update
    void Start()
    {
        isAnimating = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isAnimating == true)
        {
            anim.SetBool("isJumpScared", false);
            isAnimating = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isJumpScared", true);
            isAnimating = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
