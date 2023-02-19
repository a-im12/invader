using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidGenerator : MonoBehaviour
{
    public GameObject squidPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < 15; i++){
            GameObject go = Instantiate(squidPrefab) as GameObject;
            go.transform.position = new Vector3(-7 + 0.7f * i, 4.0f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
