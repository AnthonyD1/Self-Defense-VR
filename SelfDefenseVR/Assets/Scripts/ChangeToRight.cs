using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToRight : MonoBehaviour {

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
        if (other.gameObject.CompareTag("rightHand")) {
            OVRHaptics.RightChannel.Preempt(hapticsClip);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("rightHand"))
        {
            BorisAnimator.SetBool("HitRightPad", true);

            LeftPath.SetActive(true);
            RightPath.SetActive(false);

            BorisAnimator.SetBool("HitLeftPad", false);
            hasPlayed = false;
        }
    }
}
