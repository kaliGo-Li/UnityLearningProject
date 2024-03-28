using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.gameObject.GetComponent<Bird>();
        bird.isDead = true;
        GameControl.instance.OnBirdDied();
        bird.anim.SetTrigger("Die");
    }

}
