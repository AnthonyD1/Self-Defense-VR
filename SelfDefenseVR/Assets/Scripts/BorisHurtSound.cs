using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorisHurtSound : MonoBehaviour {

    public AudioClip Ow1;
    public AudioClip Ow2;
    public AudioClip Ow3;
    public AudioClip Ow4;
    public AudioClip Ow5;
    public AudioClip Ow6;

    private AudioSource BorisHurt;
    private int hit = 1;

    private void Awake()
    {
        BorisHurt = GetComponent<AudioSource>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("rightHand") || collision.gameObject.CompareTag("leftHand") || collision.gameObject.CompareTag("Katana")) {
            BorisHurt.Stop();
            if (hit == 1) {
                BorisHurt.PlayOneShot(Ow1);
                hit++;
            } else if (hit == 2) {
                BorisHurt.PlayOneShot(Ow2);
                hit++;
            } else if (hit == 3) {
                BorisHurt.PlayOneShot(Ow3);
                hit++;
            } else if (hit == 4) {
                BorisHurt.PlayOneShot(Ow4);
                hit++;
            } else if (hit == 5) {
                BorisHurt.PlayOneShot(Ow5);
                hit++;
            } else if (hit == 6) {
                BorisHurt.PlayOneShot(Ow6);
                hit = 1;
            }
        }
    }
}
