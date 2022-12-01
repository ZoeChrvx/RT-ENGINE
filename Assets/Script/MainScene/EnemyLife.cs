using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public AudioClip deathBubble;
        public void DeathEnemy()
    {
        AudioManager.instance.PlayClipAt(deathBubble, transform.position);
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        ScoreAndInformation.scoreCountEnemy = ScoreAndInformation.scoreCountEnemy + 1;
        Destroy(gameObject);
    }
}
