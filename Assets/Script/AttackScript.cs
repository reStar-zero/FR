using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private Collider weaponCollider;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

       void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }
    public void AttackColliderOn()
    {
        weaponCollider.enabled = true;
    }
    public void AttackColliderOff()
    {
        weaponCollider.enabled = false;
    }
 }
