using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCollisionAlgorithm : MonoBehaviour {

    private SphereCollider[] sphereColliders;
    private int count;

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(20);
    }

    void DisableAllSphereCollidersExceptFirst()
    {
        for (int i = 0; i < sphereColliders.Length; i++)
        {
            if (i == 0)
            {
                sphereColliders[i].enabled = true;
            }
            else
            {
                sphereColliders[i].enabled = false;
            }
        }
    }
	// Use this for initialization
	void Start () {
        count = 0;
        sphereColliders = GetComponentsInChildren<SphereCollider>(); // initialize the array bro

        // disable all colliders except first sphere
        DisableAllSphereCollidersExceptFirst();
    }

    // Update is called once per frame
    void Update () {
		for(int i = 0; i < sphereColliders.Length; i++)
        {
            if (!sphereColliders[i].gameObject.activeSelf)
            {
                count++;
            }
        }
        
        if (count == sphereColliders.Length)
        {
            // pauses for 3 seconds
            Waiting();
            
            DisableAllSphereCollidersExceptFirst();
            for(int i = 0; i < sphereColliders.Length; i++)
            {
                sphereColliders[i].gameObject.SetActive(true);
            }
        }
        count = 0;
	}
}
