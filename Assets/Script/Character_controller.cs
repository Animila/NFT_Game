using System.Collections;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private float forwardForce = 0f;

    private Rigidbody2D rb;
    private bool canJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        Jump();
    }
    private void Jump()
    {

            if(transform.position.x < 0)
                forwardForce = 1f;
            else 
                forwardForce = 0f;

            if(canJump)
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    canJump = false;
                    rb.velocity = new Vector2(forwardForce, jumpForce);
                }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            canJump = true;
    }
}
