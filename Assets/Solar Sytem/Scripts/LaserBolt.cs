using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBolt : MonoBehaviour
{
    //public AudioClip laserImpactSound;
    public Transform impactSoundObjectPrefab; 

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Planet")
        {
           //GetComponent<AudioSource>().PlayOneShot(laserImpactSound);
           Instantiate(impactSoundObjectPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
