using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public float jumpForce = 5f;
    public float forwardForce = 0f;

    private Rigidbody2D rb;
    private bool canJump;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }

    public void Jump(){
        if(canJump){
            canJump = false;
            if(transform.position.x < 0){
                forwardForce = 1f;
            } else {
                forwardForce = 0f;
            }
            rb.velocity = new Vector2(forwardForce, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        canJump = true;
    }
}
