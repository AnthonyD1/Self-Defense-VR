using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill1Logic : MonoBehaviour
{

    private Transform[] paths = new Transform[6];
    private Animator BorisAnimator;
    public GameObject path;


    private bool leftHand;
    private int leftCount;
    private int rightCount;
    private int pathCount;

    private string[] leftMoves = { "LeftJab", "LeftHook", "LeftUpperCut" };
    private string[] rightMoves = { "RightJab", "RightHook", "RightUpperCut" };


    private void Awake()
    {
        leftHand = true;
        //paths = GameObject.Find("Path").GetComponentsInChildren<Transform>(); // initialize the paths array
        Transform[] temp;
        temp = path.GetComponentsInChildren<Transform>();
        int i = 0;
        foreach (Transform t in temp) {
            if (t.parent == path.transform) {
                paths[i] = t;
                paths[i].gameObject.SetActive(false);
                i++;
            }
        }

        paths[0].gameObject.SetActive(true);
        BorisAnimator = GetComponent<Animator>();
        leftCount = 0;
        rightCount = 0;
        pathCount = 0;


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand") && leftHand) {

            // if you have reached the end of the array of animations
            if (rightCount > 2) rightCount = 0;
            BorisAnimator.SetBool(rightMoves[rightCount], true); // hit with left hand so next move is right hand


            // if you have reached the end of the array of animations
            if (leftCount > 2) leftCount = 0;
            BorisAnimator.SetBool(leftMoves[leftCount], false);

            leftHand = false;
            leftCount++;


            if (pathCount < paths.Length - 1) {
                paths[pathCount].gameObject.SetActive(false);
                paths[pathCount + 1].gameObject.SetActive(true);
                pathCount++;
            } else {
                // turn off the previous strike path and turn on the next strike path
                paths[pathCount].gameObject.SetActive(false);
                paths[0].gameObject.SetActive(true);
                pathCount = 0;
            }

        } else if (other.gameObject.CompareTag("rightHand") && !leftHand) {
            // if you have reached the end of the array of animations
            if (leftCount > 2) leftCount = 0;
            BorisAnimator.SetBool(leftMoves[leftCount], true); // hit with left hand so next move is right hand

            // if you have reached the end of the array of animations
            if (rightCount > 2) rightCount = 0;
            BorisAnimator.SetBool(rightMoves[rightCount], false);

            leftHand = true;
            rightCount++;

            if (pathCount < paths.Length - 1) {
                paths[pathCount].gameObject.SetActive(false);
                paths[pathCount + 1].gameObject.SetActive(true);
                pathCount++;

            } else {
                // turn off the previous strike path and turn on the next strike path
                paths[pathCount].gameObject.SetActive(false);
                paths[0].gameObject.SetActive(true);
                pathCount = 0;
            }
        }
    }
}