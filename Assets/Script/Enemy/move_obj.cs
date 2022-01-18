using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obj : MonoBehaviour
{
    public float speed = -3f;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        rb.velocity = new Vector2(speed, 0);
    }
}
