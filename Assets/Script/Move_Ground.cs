using UnityEngine;
using UnityEditor;

public class Move_Ground : MonoBehaviour
{
    [Header("Время перемещения блока")]
    [SerializeField] private float speed= 1.5f;

    [Header("Время перемещения блока")]
    [SerializeField] private float destroy_ground = -11;


    [Header("Объект создания")]
    [SerializeField] private GameObject[] ground;
 
    [SerializeField] private float timeRemaining = 60; 

    private int count;
    public bool timerIsRunning = false;

    private void Start() {
        timerIsRunning = true;
    }

    void Update()
    { 
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                count = 1;  
            } else { 
                timeRemaining = 0;
                timerIsRunning = false;
                count = 2;
            }
            Debug.Log(timeRemaining);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if(transform.position.x <= destroy_ground){
                CreateBlock();
                Destroy(gameObject); 
            }
        }
    }
    private void CreateBlock(){
        GameObject objects = Instantiate(ground[count], new Vector3(10.5f, -5.116193f, 0), Quaternion.identity ) as GameObject;
        objects.name = "ground";
    }
}
