using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;

public class Meteoritos : MonoBehaviour
{
    public float speed = 5f;
    public float damageAmount = 10f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (player != null)
            {
                player.Damage(damageAmount);
                Destroy(this.gameObject);
            }
        }
    }
}
