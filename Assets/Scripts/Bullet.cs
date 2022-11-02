using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject Enemy;
    public GameObject bullet;
    public GameObject effect;
    public AudioSource Pop;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Pipe>())
        {
            Destroy(bullet);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Pop.Play();
            Destroy(bullet);
            Instantiate(effect, bullet.transform.position, bullet.transform.rotation);
        }

        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Spikes")
        {
            Destroy(bullet);
        }
    }
}