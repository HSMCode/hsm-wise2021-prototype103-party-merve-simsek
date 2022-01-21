using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGlasses : MonoBehaviour
{
    public AudioSource glassesSound;
    void OnTriggerEnter(Collider other)
    {
        glassesSound.Play();
        ScoringSystem.theScore += 150;
        Destroy (gameObject);
    }
}