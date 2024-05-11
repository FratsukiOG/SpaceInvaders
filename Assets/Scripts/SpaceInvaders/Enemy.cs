using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject deathEffect;
    [SerializeField]public GameObject bulletPrefab;

    public int salud = 1;
    public int enemyScoreValue = 1;

    public Transform firePoint;
    public float fireInterval = 2f;
    private float timer;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireInterval)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void Daño(int damage)
    {
        salud -= damage;
        if(salud <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);

        Puntaje.puntaje++;

        Destroy(gameObject);
    }

}
