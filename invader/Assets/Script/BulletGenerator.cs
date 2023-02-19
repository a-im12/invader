using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Airframe");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bulletPrefab, player.transform.position, Quaternion.identity);
        }
    }
}
