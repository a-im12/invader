using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidGenerator : MonoBehaviour
{
    public GameObject squidPrefab;
    float px = -6.0f;
    float py = 4.0f;
    int height = 0;
    int width = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (height < 2){
            if (width < 15){
                GameObject go = Instantiate(squidPrefab) as GameObject;
                go.transform.position = new Vector3(px + (0.8f * width), py - (0.5f * height), 0);
                width++;
            }else{
                width = 0;
                height++;
            }
        }
    }
}
