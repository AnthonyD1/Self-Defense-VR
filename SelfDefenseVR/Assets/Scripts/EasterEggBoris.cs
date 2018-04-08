using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggBoris : MonoBehaviour {

    private int hits = 0;
    public GameObject Boris;
    private GameObject BorisHead;

    private void OnTriggerExit(Collider other)
    {
        hits = hits + 1;
        if (hits >= 10)
        {
            Rigidbody BorisBody = Boris.AddComponent<Rigidbody>();
            BorisBody.useGravity = false;
            BoxCollider BorisHeadBox = BorisHead.GetComponent<BoxCollider>();
            BorisHeadBox.isTrigger = false;
        }
    }
}
