using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirector : MonoBehaviour
{
    public int enemyDir = 1;
    public int height = 0;
    bool isDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void SetDown(bool b){
        isDown = b;
    }

    public int Next(int n) {
        height = n + 1;
        return height;
    }
}
