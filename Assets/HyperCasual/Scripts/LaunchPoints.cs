using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaunchPoints : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab of the projectile to be instantiated
    public Transform target;             // Target to shoot the projectile towards
    public float projectileSpeed = 1f;  // Speed at which the projectile moves
    public List<Transform> spawnPoints;
    bool canSpawn = true;




    private void Start()
    {
        
        InvokeRepeating("LaunchProjectile", 0f, 1.5f);
    }



    private void LaunchProjectile()
    {
        
            int randomIndex = Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[randomIndex];
            // Instantiate the projectile
            GameObject projectile = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);

            // Calculate the direction towards the target
            Vector3 direction = (target.position - projectile.transform.position).normalized;

            // Get the rigidbody component of the projectile
            Rigidbody2D rigidbody = projectile.GetComponent<Rigidbody2D>();

            // Set the velocity of the projectile to shoot it towards the target
            rigidbody.velocity = direction * projectileSpeed*0.5f;


            

            
        
        
    }

   
}
