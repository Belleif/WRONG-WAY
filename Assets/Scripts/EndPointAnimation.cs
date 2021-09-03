using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointAnimation : MonoBehaviour
{

    public Animator gateAnimator;
    public bool gateIsAnimating = false;

    void Start()
    {
        gateAnimator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gateAnimator.SetBool("gateIsAnimating", true);
        }
    }
}
