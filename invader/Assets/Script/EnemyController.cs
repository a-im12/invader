using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int dir;
    int height = 0;
    float initY;
    EnemyDirector enemyDirector;
    // Start is called before the first frame update
    void Start()
    {
        enemyDirector = GameObject.Find("EnemyDirector").GetComponent<EnemyDirector>();
        initY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        height = enemyDirector.height;
        dir = enemyDirector.enemyDir;

        transform.Translate(0.005f * dir, 0, 0);
        Vector3 pos = transform.position;
        pos.y = initY - height*0.5f;
        transform.position = pos;

        if (transform.position.x >= 10 || transform.position.x <= -10){
            enemyDirector.enemyDir *= -1;
            // enemyDirector.isDown = true;
            height = enemyDirector.Next(height);

        }

        // if(enemyDirector.isDown){
        //     transform.Translate(0, -0.5f, 0);
        //     enemyDirector.isDown = false;
        // }
    }
}
