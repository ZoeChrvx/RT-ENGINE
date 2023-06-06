using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public ScoreAndInformation scoreAndInformation;
    public Animator animator;
    public AudioClip deathBubble;
    public GameObject canvas;

    public void Start()
    {
        scoreAndInformation = canvas.GetComponent<ScoreAndInformation>();
    }

    public void DeathEnemy()
    {
        animator.enabled =true;
        AudioManager.instance.PlayClipAt(deathBubble, transform.position);
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        scoreAndInformation.scoreCountEnemy += scoreAndInformation.scoreCountEnemy + 1;
        Invoke("Destroy", 0.5f);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
