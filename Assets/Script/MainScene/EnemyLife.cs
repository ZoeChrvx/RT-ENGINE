using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
        public void DeathEnemy()
    {
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        ScoreAndInformation.scoreCountEnemy = ScoreAndInformation.scoreCountEnemy + 1;
        Destroy(gameObject);
    }
}
