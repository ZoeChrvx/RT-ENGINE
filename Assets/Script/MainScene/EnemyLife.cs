using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public List<GameObject> drop;
    public int enemy = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeathEnemy()
    {
        Debug.Log("Cheh");
        enemy--;
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        Destroy(gameObject);
        
    }
}
