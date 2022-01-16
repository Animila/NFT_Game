using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 dir;

    private void Update(){
        transform.Translate(dir * speed, Space.World);
        if(gameObject.transform.position.x < -11){
            Destroy(gameObject);
        }
    }

}
