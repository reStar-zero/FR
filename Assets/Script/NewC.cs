using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewC : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    public Transform firstCamera;
    public float speed = 2f;
    public float smoothTime;
    float smooth;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 directionVector = new Vector3(h, 0, v).normalized;


        if (directionVector.magnitude > Mathf.Abs(0.05f))
        {
            float rotation = Mathf.Atan2(directionVector.x, directionVector.z) * Mathf.Rad2Deg + firstCamera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref smooth, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 move = Quaternion.Euler(0f, rotation, 0f) * Vector3.forward; 

        }
        animator.SetFloat("InputMagnitude", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        rigidbody.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
    }
}
