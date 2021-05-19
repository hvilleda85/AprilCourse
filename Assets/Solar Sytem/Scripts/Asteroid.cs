using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Transform particleExplosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "LaserBolt")
        {
            Instantiate(particleExplosionPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
