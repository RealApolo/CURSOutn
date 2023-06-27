using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapaNoel : MonoBehaviour
{
    [SerializeField] private Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("JumpTrigger");
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.Play("Dead");
        }
    }

}
