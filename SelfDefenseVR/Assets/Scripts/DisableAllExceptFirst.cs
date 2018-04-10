using System.Collections;
using UnityEngine;

public class DisableAllExceptFirst : MonoBehaviour
{
    private SphereCollider[] sphereColliders;

    // Use this for initialization
    private void Awake()
    {
        sphereColliders = GetComponentsInChildren<SphereCollider>(); // initialize the array
    }
    
    void Start()
    {
        // disable all colliders except first sphere
        DisableAllSphereCollidersExceptFirst();
    }

    //Makes the user go through the first one in order to "collect" the spheres
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
}
