using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject[] meanGuy;
    
    public float spawnerInterval = 3.5f;
    public float spawnDelayAcceleration = 0.1f;
    public float minInterval = 0.5f;
    //public List<Transform> spawning;
    public List<Transform> spawnPositions;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(meanGuy));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(GameObject[] meanGuy)
    {
        yield return new WaitForSeconds(spawnerInterval);
        //spawnPositions aléatoire dans l'intervalle [0; 3[
        int randEnemy = Random.Range(0, meanGuy.Length);
        int rand = Random.Range(0, spawnPositions.Count);
        GameObject newEnemy = Instantiate(meanGuy[randEnemy], spawnPositions[rand].position, spawnPositions[rand].rotation);
        spawnerInterval = Mathf.Max(spawnerInterval -spawnDelayAcceleration, minInterval);
        StartCoroutine(spawnEnemy(meanGuy));
    }
}
