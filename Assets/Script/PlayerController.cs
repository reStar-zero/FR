using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public Transform firstCamera;
    public float smoothTime;
    float smooth;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {   
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        animator.SetFloat("InputMagnitude", Mathf.Max(Mathf.Abs(h), Mathf.Abs(v)));
        Vector3 directionVector = new Vector3(h,0,v).normalized;

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }

        if (directionVector.magnitude > Mathf.Abs(0.05f))
        {
            float rotation = Mathf.Atan2(directionVector.x, directionVector.z) * Mathf.Rad2Deg + firstCamera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref smooth, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);           
        }
        
    }
    
}
