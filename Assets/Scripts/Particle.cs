using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject collisionParticle;
    public GameObject triggerParticle;

    //Gets execusted when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {
            //The triggerParticle will be spawned at the location of this object
            //with the same rotation of this object
            Instantiate(triggerParticle, this.transform.position, Quaternion.identity);
        }
    }

    //Gets executed when something collides with this object
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        {
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
