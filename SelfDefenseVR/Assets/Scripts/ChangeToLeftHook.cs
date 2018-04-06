using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToLeftHook : MonoBehaviour {

    public GameObject LeftPath;
    public GameObject RightPath;
    private Animator BorisAnimator;


    private void Awake()
    {
        BorisAnimator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rightHand"))
        {

            BorisAnimator.SetBool("HitLeftPad", true);

            LeftPath.SetActive(false);
            RightPath.SetActive(true);

            BorisAnimator.SetBool("HitRightPad", false);
        }
    }
}
