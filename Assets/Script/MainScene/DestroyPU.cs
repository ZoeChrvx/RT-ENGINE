using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPU : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            Debug.Log("Just destroy");
        }
    }
}
