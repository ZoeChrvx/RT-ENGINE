using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Resolution : MonoBehaviour
{
    public TMP_Dropdown DResolution;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setResolution()
    {
        switch (DResolution.value)
        {
            case 0:
                Screen.SetResolution(1920, 1080, true);               
                break;

            case 1:
                Screen.SetResolution(1680, 900, true);                
                break;

            case 2:
                Screen.SetResolution(1366, 768, true);
                break;

            case 3:
                Screen.SetResolution(1280, 720, true);
                break;
        }
    }
}
