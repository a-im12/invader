using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float direction = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.005f * direction, 0, 0);

        if (transform.position.x > 9.5f){
            transform.Translate(0, -0.5f, 0);
            gameObject.SendMessage("CollisionWall");
        }

        if (transform.position.x < -9.5f){
            transform.Translate(0, -0.5f, 0);
            gameObject.SendMessage("CollisionWall");
        }
    }

    void CollisionWall()
    {
        this.direction *= -1;
    }
}
