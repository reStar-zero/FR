using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public void GoToLevel(int csene)
    {
        SceneManager.LoadScene(csene);
    }
}

