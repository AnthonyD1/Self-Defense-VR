using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill1Logic : MonoBehaviour
{
    public GameObject LeftPad;
    public GameObject RightPad;

    private Transform[] paths = new Transform[6];
    private Animator BorisAnimator;
    public GameObject path;

    
    private int movesCount;
    private int pathCount;
    private string[] moves = { "LeftJab", "RightJab", "LeftHook", "RightHook", "LeftUpperCut", "RightUpperCut" };


    private void Awake()
    {
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
        movesCount = 0;
        pathCount = 0;


    }

    private void MovesSwitch()
    {
        // decide which animation to play next
        if (movesCount == moves.Length - 1) {
            BorisAnimator.SetBool(moves[movesCount], false);
            BorisAnimator.SetBool(moves[0], true);

        } else {

            BorisAnimator.SetBool(moves[movesCount], false);
            BorisAnimator.SetBool(moves[movesCount + 1], true);
        }

        movesCount++;

        // decide which punch path to show next
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

    private void Update()
    {
        // if you have reached the end of the array of animations
        if (movesCount > moves.Length - 1) movesCount = 0;

        // Get Hook edge case
        if (LeftPad.GetComponent<HitOrNah>().rightControllerHit && moves[movesCount] == "RightHook") {
            MovesSwitch();
        }// get hook edge case
        else if(RightPad.GetComponent<HitOrNah>().leftControllerHit && moves[movesCount] == "LeftHook") {
            MovesSwitch();
        }
        else if (LeftPad.GetComponent<HitOrNah>().leftControllerHit && moves[movesCount][0] == 'L') {
            MovesSwitch();
        } else if (RightPad.GetComponent<HitOrNah>().rightControllerHit && moves[movesCount][0] == 'R') {
            MovesSwitch();
        }
    }
}