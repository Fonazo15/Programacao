using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 20f;
    public float projectileLifeTime = 5f;
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            rb.velocity = Camera.main.transform.forward * projectileSpeed;

            Destroy(projectile, projectileLifeTime);
        }
    }
}
