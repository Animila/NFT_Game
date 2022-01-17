using System.Collections;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private float speedForce;
    [SerializeField] private bool canJump;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if(Input.GetKey(KeyCode.Space)){
            if(transform.position.x < 0){
                rb.velocity = new Vector2(1f, transform.position.y);
            } else {
                speedForce = 0;
            }
            Jump();
        }
    }
    public void Jump()
    {
        if(canJump){
            canJump = false;
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Enemy"))
        {
            canJump = true;
        }
    }

    // public float moveSpeed;
    // public float jumpForce;

    // private Rigidbody2D rb;

    // public bool groundIn;
    // public LayerMask whatIsGround;
    // private Collider2D myCol;

    // private void Start() {
    //     rb = GetComponent<Rigidbody2D>();

    //     myCol = GetComponent<Collider2D>();
    // }

    // void Update(){
    //     groundIn = Physics2D.IsTouchingLayers(myCol, whatIsGround);
    //     rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    //     if(Input.GetKeyDown(KeyCode.Space)){
    //         Jump();
    //     }
    // }

    // public void Jump(){
    //     rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    // }
    
}
