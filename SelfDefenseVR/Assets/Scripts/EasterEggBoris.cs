using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggBoris : MonoBehaviour {

    private int hits = 0;
    public GameObject Boris;
    private GameObject BorisHeadBox;
    private AudioSource Squake;

    private void Awake()
    {
        Squake = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hits <= 10) {
            Squake.Play();
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        hits = hits + 1;
        if (hits >= 10)
        {
            Rigidbody BorisBody = Boris.AddComponent<Rigidbody>();
            BorisBody.useGravity = false;
            BorisBody.mass = 0.5f;
            BoxCollider BorisHeadBox = GetComponent<BoxCollider>();
            BorisHeadBox.isTrigger = false;
        }
    }
}
