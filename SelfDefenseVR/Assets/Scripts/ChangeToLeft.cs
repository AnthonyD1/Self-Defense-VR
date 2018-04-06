using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToLeft : MonoBehaviour {

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

            BorisAnimator.SetBool("HitLeftPad", true);

            //bLeftElbow.transform.Rotate(new Vector3(0, 70, 0));//t-pose

            //bRightElbow.transform.Rotate(new Vector3 (0, 70, 0));//t-pose

            LeftPath.SetActive(false);
            RightPath.SetActive(true);

            BorisAnimator.SetBool("HitRightPad", false);
        }
    }
}
