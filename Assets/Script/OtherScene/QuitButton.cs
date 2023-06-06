using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public JsonReadWriteSystem jsonReadWriteSystem;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Button>().onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        jsonReadWriteSystem.SaveToJson();
        Debug.Log("Quit Game");
        Application.Quit();   
    }
}
