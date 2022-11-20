using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Loot : ScriptableObject
{
    public BoxCollider2D bC2D;
    public Sprite lootSprite;
    public string lootName;
    public int dropChance;
    public int speed;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = Vector3.right * speed;
    }
    public Loot(string lootName, int dropChance)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
    }
}
