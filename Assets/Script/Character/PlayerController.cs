using System.Collections;
using System.Collections.Generic;
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
    public float startX = 0;
    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        transform.position = new Vector3(startX, places[currentPosition].position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Le joueur appuie sur la touche Z");
            if (currentPosition > 0){
                currentPosition--; //  ou  currentPosition-=1  ou  currentPosition = currentPosition -1
                transform.position = new Vector3(startX, places[currentPosition].position.y, 0);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Le joueur appuie sur la touche S");
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

    void shoot()
    {
        Instantiate(projectilePrefab, firePosition.position, firePosition.rotation);
    }
}
