using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryBag : MonoBehaviour
{

    private Vector3 bagOriginalPos;
    private Transform bagCurrentPos;
    private Rigidbody bagBody;
    private float timer;

    void Awake()
    {
        bagOriginalPos = this.gameObject.GetComponent<Transform>().position;
        bagCurrentPos = this.gameObject.GetComponent<Transform>();
        bagBody = this.gameObject.GetComponent<Rigidbody>();

    }

    private float Squaring(float x)
    {
        return Mathf.Pow(x, 2);
    }

    private void FixedUpdate()
    {
        Vector3 rePos = new Vector3();
        float squareX = Squaring(bagOriginalPos.x - bagCurrentPos.position.x);
        float squareZ = Squaring(bagOriginalPos.z - bagCurrentPos.position.z);
        float mag = Mathf.Sqrt(squareX + squareZ);

        if (bagCurrentPos.position.x != bagOriginalPos.x)
        {
            rePos.x = (bagOriginalPos.x - bagCurrentPos.position.x) / mag;
        }

        if (bagCurrentPos.position.z != bagOriginalPos.z)
        {
            rePos.z = (bagOriginalPos.z - bagCurrentPos.position.z) / mag;
        }
        bagBody.AddForce(rePos);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
}
