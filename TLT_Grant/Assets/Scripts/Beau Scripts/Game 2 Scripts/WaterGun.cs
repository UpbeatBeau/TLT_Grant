using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    public GameObject waterProjectilePrefab; // Assign the water projectile prefab in the Inspector
    public float projectileSpeed = 20f; // Adjust the speed of the projectile
    private Gunfollow gf;

    private void Start()
    {
        gf = GetComponent<Gunfollow>();
    }

    void Update()
    {
        // Check for mouse button press
        if (Input.GetMouseButton(0))
        {
            // Instantiate the water projectile
            GameObject waterProjectile = Instantiate(waterProjectilePrefab, transform.position, transform.rotation);

            // Add force to the projectile to shoot it forward
            Rigidbody rb = waterProjectile.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projectileSpeed;

            //GunMove
            gf.GunMove();
        }
    }
}
