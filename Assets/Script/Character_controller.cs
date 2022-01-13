using System.Collections;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
    bool inAir;
    private Rigidbody2D rb;
    [SerializeField] private int xVelocity = 5;
    [SerializeField] private int yVelocity = 8;
    [SerializeField] private bool isBrouser;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        updatePlayerPosition();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
    }

    private void updatePlayerPosition() 
    {
        float jumpInput = Input.GetAxis("Jump");
        if(isBrouser)
        {
            //get input
            float moveInput = Input.GetAxis("Horizontal");

            //left
            //right
            //jump
            if (moveInput < 0) 
            {
                rb.velocity = new Vector2(-xVelocity, rb.velocity.y);
            } 
            else if (moveInput > 0) 
            {
                rb.velocity = new Vector2(xVelocity, rb.velocity.y);
            }
        }
        if (jumpInput > 0 && !inAir)
        {
            inAir = true;
            rb.velocity = new Vector2(rb.velocity.x, yVelocity);
        }
    }
}
