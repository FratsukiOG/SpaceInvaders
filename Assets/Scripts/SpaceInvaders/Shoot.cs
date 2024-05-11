using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform playerGun;

    [SerializeField] private GameObject playerBullet;

    public float speed = 15f;



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Disparo();
        }
    }

    private void Disparo()
    {
        Instantiate(playerBullet, playerGun.position, playerGun.rotation);
    }

}
