using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obj : MonoBehaviour
{
    public bool active_damage = true;
    public float speed = -3f;
    private Rigidbody2D rb;

    [SerializeField] private float damage;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        rb.velocity = new Vector2(speed, 0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(active_damage){
            if(other.tag == "Player"){
                other.GetComponent<Health>().TakeDamage(damage);
            }
        }
    }
}
