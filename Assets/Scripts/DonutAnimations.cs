using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (DonutCollitions.livesCharacter > 0 && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animations[1];
        }

        if (DonutCollitions.livesCharacter > 0 && (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)))
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animations[0];
        }

        if (DonutCollitions.livesCharacter == 0)
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animations[3];
        }
    }
}
