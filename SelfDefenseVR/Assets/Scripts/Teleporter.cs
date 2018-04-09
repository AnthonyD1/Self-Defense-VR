using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public GameObject TeleportMarker;
    public Transform Player;
    public float RayLength = 50f;
    public OVRInput.Controller Controller;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, RayLength)) {
            if(hit.collider.tag == "Ground" && OVRInput.Get(OVRInput.Button.Two, Controller)) {
                if (!TeleportMarker.activeSelf) {
                    TeleportMarker.SetActive(true);
                }
                TeleportMarker.transform.position = hit.point;

                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, Controller)) {
                     Player.position = new Vector3(hit.point.x, Player.position.y, hit.point.z);
                }
            } else {
                TeleportMarker.SetActive(false);
            }
        } else {
            TeleportMarker.SetActive(false);
        }

	}


}
