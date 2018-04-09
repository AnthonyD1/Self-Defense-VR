using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour {
    
    private bool hasPlayed = false;
    private AudioSource punchSound;

    // Use this for initialization
    void Awake () {
        punchSound = this.gameObject.GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.CompareTag("rightHand") || collision.gameObject.CompareTag("leftHand")) && !hasPlayed)
        {
            punchSound.Play();
            hasPlayed = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("rightHand") || collision.gameObject.CompareTag("leftHand")) hasPlayed = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
