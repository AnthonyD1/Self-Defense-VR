using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToRightHook : MonoBehaviour {

    public GameObject LeftPath;
    public GameObject RightPath;
    private Animator BorisAnimator;


    private void Awake()
    {
        BorisAnimator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand"))
        {
            BorisAnimator.SetBool("HitRightPad", true);

            LeftPath.SetActive(true);
            RightPath.SetActive(false);

            BorisAnimator.SetBool("HitLeftPad", false);
        }
    }
}
