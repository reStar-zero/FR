using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActiv : MonoBehaviour
{
    public GameObject objectToActivate; // Объект, который нужно активировать после диалога

    // Этот метод будет вызываться после окончания диалога
    public void EndDialogue()
    {
        // Активируем объект
        objectToActivate.SetActive(true);
    }
}
