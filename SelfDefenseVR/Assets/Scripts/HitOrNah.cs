using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitOrNah : MonoBehaviour {
    public bool leftControllerHit;
    public bool rightControllerHit;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand")) {
            leftControllerHit = true;
        }
        else if (other.gameObject.CompareTag("rightHand")) {
            rightControllerHit = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand")) {
            leftControllerHit = false;
        } else if (other.gameObject.CompareTag("rightHand")) {
            rightControllerHit = false;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
