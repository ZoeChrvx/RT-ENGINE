using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToButton : MonoBehaviour
{

    public string targetScene;
    public AudioClip audioClip;


    public void GoTo()
    {
        AudioManager.instance.PlayClipAt(audioClip, transform.position);
        SceneManager.LoadScene(targetScene);
    }
}
