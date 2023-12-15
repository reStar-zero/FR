using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    public GameObject objectToActivate;
    public int enemy;

    public void Kill()
    {
        enemy++;
        if(enemy == 2)
            objectToActivate.SetActive(true);
    }
}
