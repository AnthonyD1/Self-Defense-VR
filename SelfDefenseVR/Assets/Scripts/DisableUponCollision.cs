using UnityEngine;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class DisableUponCollision : MonoBehaviour
{
    private SphereCollider sphereCollider;

	// Use this for initialization
	void Start ()
    {
        sphereCollider = this.GetComponent<SphereCollider>();
	}

    private Transform GetNext()
    {
        Transform currentTransform = transform; // me
        Transform parent = transform.parent; // daddy
        var childcount = parent.childCount;
        
        // loop through children until find me, then get next index
        for (int i = 0; i < childcount - 1; i++)
        {
            if (currentTransform == parent.GetChild(i))
            {
                return parent.GetChild(i + 1);
            }
        }
        return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand"))
        {
            this.sphereCollider.enabled = false; // disable collider
            this.sphereCollider.gameObject.SetActive(false);
            

            Transform nextSphere = GetNext();
            if (nextSphere == null) {
                nextSphere.GetComponent<SphereCollider>().enabled = true; // enable next sphere collider
            }
           
            
            
        }
    }
    // Update is called once per frame
    void Update ()
    {
		
	}
}
