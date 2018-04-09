using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToLeft : MonoBehaviour {

    public GameObject LeftPath;
    public GameObject RightPath;
    public GameObject Boris;
    private Animator BorisAnimator;
    private AudioSource punchSound;
    public AudioClip HapticFeedback;
    private bool hasPlayed = false;


    private void Awake()
    {
        BorisAnimator = Boris.GetComponent<Animator>();
        punchSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasPlayed == false) {
            punchSound.Play();
            hasPlayed = true;
        }

        OVRHapticsClip hapticsClip = new OVRHapticsClip(HapticFeedback);
        if (other.gameObject.CompareTag("leftHand")) {
            OVRHaptics.LeftChannel.Preempt(hapticsClip);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand"))
        {

            BorisAnimator.SetBool("HitLeftPad", true);

            LeftPath.SetActive(false);
            RightPath.SetActive(true);

            BorisAnimator.SetBool("HitRightPad", false);
            hasPlayed = false;
        }
    }
}
