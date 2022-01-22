using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealting;
    [SerializeField] private GameObject Dead;
    public float currectHealth{get; private set;}

    private bool dead;

    private void Awake() {
        currectHealth = startingHealting;
    }

    public void TakeDamage(float _damage){
        currectHealth = Mathf.Clamp(currectHealth - _damage, 0, startingHealting);
        if(currectHealth > 0){

        }
        else{
            if(!dead){
                Dead.SetActive(true);
                Time.timeScale = 0f;
                GetComponent<Manager_Windows>().Pause_Game = true;
                dead = true;
            }
        }
    }
}
