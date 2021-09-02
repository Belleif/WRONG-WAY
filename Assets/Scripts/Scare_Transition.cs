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
    void Update()
    {
        if(isAnimating == true)
        {
            anim.SetTrigger("isJumpScared");
            isAnimating = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetInteger("jumpScareIndex", Random.Range(0,3));
            anim.SetTrigger("isJumpScared");
            isAnimating = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
