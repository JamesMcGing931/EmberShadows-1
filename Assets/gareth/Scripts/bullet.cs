using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 60;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        // Enemy enemy = hitInfo.GetComponent<Enemy>();
        // if(enemy != null)
        // {
        //     enemy.TakeDamage(damage);
        // }

        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }


}

