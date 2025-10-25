using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershooting : MonoBehaviour
{
  
    public Transform shootPoint;        
    public GameObject bulletPrefab;       
    public ParticleSystem muzzleEffect;   // the ParticleSystem on the muzzle


    public float bulletSpeed = 60f;
    public float fireRate = 10f;          // bullets per second

    float _nextFireTime;

    void Update()
    {
       
        if (Input.GetButton("Fire1") && Time.time >= _nextFireTime)
        {
            _nextFireTime = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        // spawn bullet
        GameObject b = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);

        // give it velocity if it has a rigidbody
        if (b.TryGetComponent<Rigidbody>(out var rb))
            rb.velocity = shootPoint.forward * bulletSpeed;

        // play muzzle flash
        if (muzzleEffect) muzzleEffect.Play();
    }
}
