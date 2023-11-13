using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPT : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private Rigidbody rigidbody;

    [SerializeField]
    private Transform firstCamera;

    [SerializeField]
    private float speed = 2f;

    [SerializeField]
    private float dashForce = 10f;

    [SerializeField]
    private float dashCooldown = 2f;

    [SerializeField]
    private float dashDuration = 0.2f;

    [SerializeField]
    private float smoothTime;

    private float smooth;

    private float lastDash;

    private const float InputThreshold = 0.05f;
    private bool isDashing = false;
    private float dashTimer;

    private Vector3 directionVector;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        HandleMovement();

        if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time > lastDash + dashCooldown)
        {
            Dash();
        }
    }

    private void HandleMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        animator.SetFloat("InputMagnitude", Mathf.Max(Mathf.Abs(h), Mathf.Abs(v)));

        directionVector = new Vector3(h, 0, v).normalized;

        if (directionVector.sqrMagnitude > InputThreshold * InputThreshold)
        {
            SmoothRotate(directionVector);
        }

        rigidbody.velocity = directionVector * speed;
    }

    private void Dash()
    {
        rigidbody.velocity = Vector3.zero;
        rigidbody.AddForce(directionVector * dashForce);
    }

    private void SmoothRotate(Vector3 directionVector)
    {
        float targetAngle = Mathf.Atan2(directionVector.x, directionVector.z) * Mathf.Rad2Deg + firstCamera.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smooth, smoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}