using UnityEngine;
using UnityEngine.UI;

public class Character_Controller : MonoBehaviour
{
    public float jumpForce = 5f;
    public Text coin_text;
    float coins = 0;
    
    private Animator _animator_controller;
    
    private Rigidbody2D rb;
    private bool canJump;

    [SerializeField] private GameObject Shadow;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        _animator_controller = GetComponent<Animator>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }

    public void Jump(){
        if(canJump){
            canJump = false;
            _animator_controller.SetBool("Jumping", true);
            rb.velocity = new Vector2(0f, jumpForce);
            Shadow.transform.localScale = new Vector3 (1.41f, 0.6348f, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Ground"){
            Shadow.transform.localScale = new Vector3 (3.3478f, 0.6348f, 0);
            _animator_controller.SetBool("Jumping", false);
            canJump = true;
        }
        if(other.collider.tag == "Enemy"){
            rb.velocity = new Vector2(0f, 18f);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag == "Coin"){
            coins++;
            coin_text.text = coins.ToString(); 
            Destroy(coll.gameObject);
        }
    }
}
