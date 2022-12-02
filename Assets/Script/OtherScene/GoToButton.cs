using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToButton : MonoBehaviour
{

    public string targetScene;
    public void GoTo()
    {
        SceneManager.LoadScene(targetScene);
    }
}
