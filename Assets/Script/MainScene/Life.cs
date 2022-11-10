using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public List<GameObject> hearts;
    int hp = 3;
    public ChangeScene changeScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Hurt()
    {
        Debug.Log("Aie");
        hp--;
        hearts[hp].SetActive(false);
        if (hp == 0)
        {
            changeScene.LoadDeath();
        }
    }
}
