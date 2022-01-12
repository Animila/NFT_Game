using UnityEngine;
using UnityEditor;

public class Move_Ground : MonoBehaviour
{
    [Header("Время перемещения блока")]
    [SerializeField] private float speed= 1.5f;

    [Header("Время перемещения блока")]
    [SerializeField] private float destroy_ground = -11;

    [Header("Объект создания")]
    [SerializeField] private GameObject ground;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x <= destroy_ground){
            GameObject objects = Instantiate(ground, new Vector3(10.5f, -5.116193f, 0), Quaternion.identity ) as GameObject;
            objects.name = "ground";
            Destroy(gameObject);
        } 
    }
}
