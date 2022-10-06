using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //destroy bullet on impact
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    
    //destroys bullet when it leaves the screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
