using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generater_enemy : MonoBehaviour
{
    public GameObject[] enemes;
    public List<GameObject> enemyToSpawn = new List<GameObject>();

    int index;

    private void Awake() {
        InitEnemy();
    }
    private void Start() {
        StartCoroutine(SpawnRandomEnemes()); 
    }
    void InitEnemy(){
        index = 0;
        for(int i = 0; i < enemes.Length * 3; i++){
            GameObject obj = Instantiate(enemes[index], transform.position, Quaternion.identity);
            enemyToSpawn.Add(obj);
            enemyToSpawn[i].SetActive (false);
            index++;

            if(index == enemes.Length){
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomEnemes(){
        yield return new WaitForSeconds(Random.Range(1.5f, 4.5f));

        int index = Random.Range(0, enemyToSpawn.Count);

        while(true){
            if(!enemyToSpawn[index].activeInHierarchy){
                enemyToSpawn[index].SetActive(true);
                break;
            }
            else{
                index = Random.Range(0, enemyToSpawn.Count);
            }
        }

        StartCoroutine(SpawnRandomEnemes());
    }
}
