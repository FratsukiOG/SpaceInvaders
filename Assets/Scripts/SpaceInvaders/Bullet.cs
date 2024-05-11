using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] public GameObject bullet;

    public Rigidbody2D rb2;
    public float speed = 20f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb2.velocity = transform.up * speed;
    }

    public void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemyDestroy = collision.GetComponent<Enemy>();
        if (enemyDestroy != null)
        {
            enemyDestroy.Daño(damage);
            Destroy(gameObject);
        }

        
    }
}
