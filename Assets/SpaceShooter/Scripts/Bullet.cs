using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damageAmount = 10f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteoritos"))
        {
            Meteoritos meteoritos = collision.gameObject.GetComponent<Meteoritos>();

            if (meteoritos != null)
            {
                FindObjectOfType<Score>().AddPoints(10);

                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
