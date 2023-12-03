using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene("TestScene");
    }
}

