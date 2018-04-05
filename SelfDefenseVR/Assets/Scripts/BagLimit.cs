using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagLimit : MonoBehaviour {
    private float yPos;
    private Rigidbody bagBody;
    private bool reversed = false; // tracks whether the punching bag is going down or not

	// Use this for initialization
	void Awake () {

        yPos = GameObject.Find("Cylinder.003").GetComponent<Transform>().position.y;
        bagBody = this.gameObject.GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {

        // if the punching bag goes above the top
        if(this.gameObject.GetComponent<Transform>().position.y >= yPos && !reversed)
        {
            // make the punching bag go the other direction
            Vector3 bagvelocity = new Vector3();
            bagvelocity = bagBody.velocity;
            bagBody.velocity = -(bagvelocity/2);
            reversed = true;

        } else if (this.gameObject.GetComponent<Transform>().position.y < yPos && reversed)
        {
            // 
            reversed = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
