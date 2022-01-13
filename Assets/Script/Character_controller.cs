using System.Collections;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
   [SerializeField] private float jump = 20f;

   private Rigidbody2D rb;

   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   public void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) 
    {
        rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
    }
    }
}
