using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSet : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GoIdle()
    {
        animator.SetTrigger("idle");
    }

    public void GoWalk()
    {
        animator.SetTrigger("walk");
        Debug.Log("walk");
    }

    public void GoLook()
    {
        animator.SetTrigger("lookaround");
    }

    public void GoHappy()
    {
        animator.SetTrigger("happy");
    }
}
