using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x < 9.5f){
                transform.Translate(0.01f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            if (transform.position.x > -9.5f){
                transform.Translate(-0.01f, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}