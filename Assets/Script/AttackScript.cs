using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

       void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0)) animator.SetTrigger("Attack 0");
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            //(Input.GetButtonUp("Fire1"))
            animator.SetBool("Attack", false);
        }
    }
}
