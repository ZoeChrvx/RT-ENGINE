using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject meanGuy;
    
    public float spawnerInterval = 3.5f;
    //public List<Transform> spawning;
    public Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(spawnerInterval, meanGuy));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float spawnerInterval, GameObject meanGuy)
    {
        yield return new WaitForSeconds(spawnerInterval);
        GameObject newEnemy = Instantiate(meanGuy, spawnPosition.position, spawnPosition.rotation);
        StartCoroutine(spawnEnemy(spawnerInterval, meanGuy));
    }
}
