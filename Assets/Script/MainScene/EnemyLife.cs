using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public Animator animator;
    public AudioClip deathBubble;
        public void DeathEnemy()
    {
        animator.enabled =true;
        AudioManager.instance.PlayClipAt(deathBubble, transform.position);
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        ScoreAndInformation.scoreCountEnemy = ScoreAndInformation.scoreCountEnemy + 1;
        Invoke("Destroy", 0.5f);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
