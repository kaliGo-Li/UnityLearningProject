using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrollingObject : MonoBehaviour
{
    Rigidbody2D rb2d;
    float width;
    float startPosX;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-10, 0);

        width = GetComponent<BoxCollider2D>().size.x;
        Vector3 localScale = transform.localScale;
        width = width * localScale.x;
        startPosX = transform.position.x;
    }

    void Update()
    {
        if(GameControl.instance.gameOver)
        {
            rb2d.velocity = Vector2.zero;
            return;
        }

        if(startPosX - transform.position.x >= width) 
        {
            Vector3 pos = transform.position;
            pos.x = startPosX;
            transform.position = pos;
        }
    }
}
