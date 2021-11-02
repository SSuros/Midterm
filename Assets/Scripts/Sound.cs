using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip triggerSound;
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(triggerSound);
    }
}
