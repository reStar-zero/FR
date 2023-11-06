using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooKAtPlayer : MonoBehaviour
{
    public Transform camera;

    void LateUpdate()
    {
        transform.LookAt(camera);
    }
}
