using System.Collections;
using UnityEngine;

public class DisableAllExceptFirst : MonoBehaviour
{
    private SphereCollider[] sphereColliders;

    // Use this for initialization
    void Start()
    {
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

    private void OnEnable()
    {
        for (int i = 0; i < sphereColliders.Length; i++) {
            sphereColliders[i].gameObject.SetActive(true);
        }
        DisableAllSphereCollidersExceptFirst();
    }
    // Update is called once per frame
    void Update ()
    {
  
 
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
