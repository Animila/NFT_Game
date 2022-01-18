using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_control : MonoBehaviour
{
    [Header("Параметры")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private string playerTag;
    [SerializeField] private float MovingCamera;
    private void Awake() {
        if(this.playerTransform == null)
        {
            if(this.playerTag == "")
            {
                this.playerTag = "Player";
            }

            this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;
        }

        this.transform.position = new Vector3(){
            x = this.playerTransform.position.x,
            y = this.playerTransform.position.y + 1.270094f, 
            z = this.playerTransform.position.z - 1,
        };
    }

    private void Update() {
        if(this.playerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = this.playerTransform.position.x,
                y = this.playerTransform.position.y + 1.270094f, 
                z = this.playerTransform.position.z - 1,
            };

            Vector3 pos = Vector3.Lerp(this.transform.position, target, this.MovingCamera * Time.deltaTime);

            this.transform.position = pos;
        }
    }
}
