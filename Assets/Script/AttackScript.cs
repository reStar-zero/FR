using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    [SerializeField] private Collider weaponCollider;
    private PlayerController controller;
    private void Awake()
    {
        controller = GetComponent<PlayerController>();        
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
