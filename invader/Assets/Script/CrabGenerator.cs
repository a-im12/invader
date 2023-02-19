using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabGenerator : MonoBehaviour
{
    public GameObject clabPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < 15; i++){
            for(int j=0; j < 2; j++){
                GameObject go = Instantiate(clabPrefab) as GameObject;
                go.transform.position = new Vector3(-7 + 0.7f * i, 3.5f - 0.5f * j, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
