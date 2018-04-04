using System.Collections;
using UnityEngine;

public class PathCollisionAlgorithm : MonoBehaviour
{
    private SphereCollider[] sphereColliders;
    private int count;

    // Use this for initialization
    void Start()
    {
        //count = 0;
        sphereColliders = GetComponentsInChildren<SphereCollider>(); // initialize the array bro

        // disable all colliders except first sphere
        DisableAllSphereCollidersExceptFirst();
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

	// Update is called once per frame
    void Update ()
    {
        /*
		for(int i = 0; i < sphereColliders.Length; i++)
        {
            if (!sphereColliders[i].gameObject.activeSelf)
            {
                count++;
            }
        }
        */
        if (!sphereColliders[sphereColliders.Length - 1].gameObject.activeSelf)
        {
            StartCoroutine("Reset");
        }
	}

    IEnumerator Reset()
    {
        yield return new WaitForSecondsRealtime(.5f);
        for (int i = 0; i < sphereColliders.Length; i++)
        {
            sphereColliders[i].gameObject.SetActive(true);
        }
        DisableAllSphereCollidersExceptFirst();
    }
}
