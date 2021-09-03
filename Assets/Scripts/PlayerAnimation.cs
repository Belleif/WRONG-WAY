using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public Animator animator;
    public bool isAnimating = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isAnimating", true);
            isAnimating = true;
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("isAnimating", true);
            isAnimating = true;
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isAnimating", true);
            isAnimating = true;
        }
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("isAnimating", true);
            isAnimating = true;
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isAnimating", true);
            isAnimating = true;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isAnimating", false);
            isAnimating = false;
        }



    }
}
