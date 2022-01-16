using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{
    [SerializeField] private Transform spawnPos;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float time;

    private void Start() {
        Repeat();
    }

    private void Repeat() {
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy(){
        yield return new WaitForSeconds(time);
        Instantiate(enemy, spawnPos.position, Quaternion.identity);
    }
}
