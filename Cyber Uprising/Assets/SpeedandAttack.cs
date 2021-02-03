using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedandAttack : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Moving", true);
        }
        else if (Input.GetKey(KeyCode.W) == false)
        {
            animator.SetBool("Moving", false);
        }


    
    }
}
