using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Définissez ici ce qui devrait se passer si la collision se produit
        Debug.Log(gameObject.name + " has hit " + collision.gameObject.name);
        collision.gameObject.GetComponent<Life>().Hurt();
        Destroy(gameObject);
        //Definir la fonction LifeLoss(int loss) qui supprime les pv
        Debug.Log(collision.gameObject.name + " loose 1 hp");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //Définissez ici ce qui devrait se passer si la collision s'arrête
        Debug.Log(gameObject.name + " has stopped hitting " + collision.gameObject.name);
    }
}
