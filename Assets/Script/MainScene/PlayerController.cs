using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fireRate = 0.3f;
    private float nextFire = 0.0f;
    public Transform firePosition;
    public GameObject projectilePrefab;
    public float speed = 5f;
    public List<Transform> places;
    [Range(0,2)]
    public int currentPosition = 1; //La currentPosition est 0 1 ou 2
    public float startX = 0, offsetX = 1;

    void Start()
    {
        //startX = transform.position.x;
        startX = Camera.main.ViewportToWorldPoint(new Vector2(0.1f, 0)).x;// + offsetX;
        transform.position = new Vector3(startX, places[currentPosition].position.y, 0);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            //Debug.Log("Le joueur appuie sur la touche Z");
            if (currentPosition > 0){
                currentPosition--; //  ou  currentPosition-=1  ou  currentPosition = currentPosition -1
                transform.position = new Vector3(startX, places[currentPosition].position.y, 0);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Debug.Log("Le joueur appuie sur la touche S");
            if (currentPosition < 2)
            {
                currentPosition++; //  ou  currentPosition+=1  ou  currentPosition = currentPosition +1
                transform.position = new Vector3(startX, places[currentPosition].position.y, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && Time.time>nextFire)
        {
            nextFire = Time.time + fireRate;
            shoot();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Powerup" )
        {
            Destroy(collision.gameObject);
            ScoreAndInformation.bonusPoint = ScoreAndInformation.bonusPoint + 20;
            fireRate = fireRate / 2;
            GetComponent<SpriteRenderer>().color = Color.blue;
            Invoke("ResetPower", 5);           
        }
        if (collision.tag == "Powerup1")
        {
            Destroy(collision.gameObject);
            ScoreAndInformation.bonusPoint = ScoreAndInformation.bonusPoint + 10;
            GetComponent<SpriteRenderer>().color = Color.green;
            SlowEnemies();
        }
        if (collision.tag == "Powerup2")
        {
            Destroy(collision.gameObject);
            ScoreAndInformation.bonusPoint = ScoreAndInformation.bonusPoint + 30;
        }
    }

    void shoot()
    {
        Instantiate(projectilePrefab, firePosition.position, firePosition.rotation);
    }

    private void ResetPower()
    {
        fireRate = fireRate * 2;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void SlowEnemies()
    {
        EnemyMouv.speedFactor = EnemyMouv.speedFactor / 2;
        Debug.Log("La vitesse est de" + EnemyMouv.speedFactor);
        Invoke("ResetEnemiesSpeed", 5);
    }

    public void ResetEnemiesSpeed()
    {
        EnemyMouv.speedFactor = EnemyMouv.speedFactor * 2;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    //public void Heal()
    //{
    //    Life.hp ++;
    //}
}
