using System.Collections;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
    [SerializeField] private float jump = 20f;
    bool inAir;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && !inAir) 
        {
            inAir = true;
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        inAir = false;
    }
}
