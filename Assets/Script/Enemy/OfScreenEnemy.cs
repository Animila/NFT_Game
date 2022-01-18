using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfScreenEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Delete"){ 
            gameObject.SetActive(false);
        }
    }
}
