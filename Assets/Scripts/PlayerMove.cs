using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rgbd2d;
    [HideInInspector]
    public Vector3 movementVector;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    private float lastHoriz;

    [SerializeField] float speed = 3f;

    public Animator animator;

    private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
    }

    private void Start()
    {
        lastHorizontalVector = -1f;
        lastVerticalVector = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        if(movementVector.x != 0) 
        {
            lastHorizontalVector = movementVector.x;
        }
        if (movementVector.y != 0) 
        {
            lastVerticalVector = movementVector.y;
        }


        movementVector *= speed;

        rgbd2d.velocity = movementVector;

        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector2 newVelocity = new Vector2(horiz, vert);
        animator.SetFloat("Horizontal", horiz);
        animator.SetFloat("Speed", newVelocity.sqrMagnitude);

        //find last horiz
        
        if (horiz != 0)
        {
            lastHoriz = horiz;
        }
        if (vert != 0)
        {
            animator.SetFloat("Horizontal", lastHoriz);
        }
    }
}
