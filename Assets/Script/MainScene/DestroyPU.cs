using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPU : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectable" || collision.tag == "Powerup0" || collision.tag == "Powerup1" || collision.tag == "Powerup2" )
        {
            Destroy(collision.gameObject);
            Debug.Log("Just destroy");
        }
    }
}
