﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{ 
    public BulletController bullet;

    public bool isFiring;

    public float bulletSpeed;
    public float timeBetweenShots;

    private float shotCounter;

    public Transform firePoint;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        shotCounter -= Time.deltaTime;

        if (isFiring)
        {
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.speed = bulletSpeed;
            }
        }
	}
}
