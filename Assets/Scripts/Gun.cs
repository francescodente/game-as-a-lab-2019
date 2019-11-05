using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Transform shootingPoint;
    [SerializeField]
    private Projectile projectilePrefab;
    [SerializeField]
    private float fireRate;

    private float timeUntilNextShot;

    private void Update()
    {
        timeUntilNextShot -= Time.deltaTime;
    }

    public void TryShooting()
    {
        if (timeUntilNextShot >= 0)
        {
            return;
        }
        timeUntilNextShot = 1 / fireRate;
        Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
    }
}
