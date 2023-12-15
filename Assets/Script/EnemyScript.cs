using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    private int HP = 100;
    private KillCounter counter;
    public Animator animator;
    public Slider healthBar;

    void Update()
    {
        healthBar.value = HP; 
    }
    private void Start()
    {
        counter = FindObjectOfType<KillCounter>();
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if(HP <= 0)
        {
            counter.Kill();
            animator.SetTrigger("Death");
            GetComponent<Collider>().enabled = false;
            healthBar.gameObject.SetActive(false);
            //KillCounter.enemy += 1;
        }
        else
        {
            animator.SetTrigger("Damage");
        }
    }
}
