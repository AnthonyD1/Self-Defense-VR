using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToRight : MonoBehaviour {

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
            BorisAnimator.SetBool("HitRightPad", true);

            //bLeftElbow.transform.Rotate(new Vector3(0, -70, 0));

            //bRightElbow.transform.Rotate(new Vector3(0, -70, 0));

            LeftPath.SetActive(true);
            RightPath.SetActive(false);

            BorisAnimator.SetBool("HitLeftPad", false);
        }
    }
}
