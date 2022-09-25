using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
         float horiz = Input.GetAxis("Horizontal");
         float vert = Input.GetAxis("Vertical");

         Vector2 newVelocity = new Vector2(horiz, vert);
         GetComponent<Rigidbody2D>().velocity = newVelocity * moveSpeed;
    }
}
