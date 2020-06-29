using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float timeBetweenShoots = 0.5f;
    public float speed = 5f;
    public float damageAmount = 10f;

    public GameObject bulletPrefab;
    public Transform bulletOrigin;

    private float timeOfLastShoot;

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void Update()
    {
       if (Time.time > timeOfLastShoot + timeBetweenShoots)
           Shoot();
    }

    public void Damage(float amount)
    {
            Destroy(this.gameObject);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
        timeOfLastShoot = Time.time;
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
