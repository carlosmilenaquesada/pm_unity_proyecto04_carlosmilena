using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 1.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (transform.position.y < -10)
        {
            Destroy(gameObject);

        }
        if (transform.position.y > 0) {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        enemyRb.transform.LookAt(new Vector3(player.transform.position.x, 0, player.transform.position.z));

    }
}
