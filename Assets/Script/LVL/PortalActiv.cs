using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActiv : MonoBehaviour
{
    public GameObject objectToActivate; // ������, ������� ����� ������������ ����� �������

    // ���� ����� ����� ���������� ����� ��������� �������
    public void EndDialogue()
    {
        // ���������� ������
        objectToActivate.SetActive(true);
    }
}
