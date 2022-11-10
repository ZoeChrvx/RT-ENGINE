using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMouv : MonoBehaviour
{
    public float speedX = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouvement = new Vector3(-speedX * Time.deltaTime, 0, 0);
        transform.position += mouvement;
    }
}
