using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementFireball : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector3.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + " has hit " + collision.gameObject.name);
        collision.gameObject.GetComponent<EnemyLife>().DeathEnemy();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 4);
    }
}
