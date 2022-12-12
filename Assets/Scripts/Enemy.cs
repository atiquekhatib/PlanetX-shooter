using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Rigidbody2D myBody;
    public SpriteRenderer sprite;
    private string Wall_Tag = "Wall";

    
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    myBody.velocity = new Vector2(speed,myBody.velocity.y);    
    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        if(collsion.gameObject.CompareTag(Wall_Tag))
        {
            Destroy(gameObject);
        }
    }
}
