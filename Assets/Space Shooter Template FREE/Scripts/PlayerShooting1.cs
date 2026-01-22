using UnityEngine;
using System.Collections;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; 
    public float shootingInterval = 0.2f;
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        if (firePoint != null)
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        }
        else 
        {
             Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}