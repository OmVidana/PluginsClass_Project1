using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutAnimations : MonoBehaviour
{
    public RuntimeAnimatorController[] animations;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.GetComponent<Animator>().runtimeAnimatorController = animations[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animations[1];
        }
        else
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animations[0];
        }
    }
}
