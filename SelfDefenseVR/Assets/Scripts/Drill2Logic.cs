using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill2Logic : MonoBehaviour
{

    private Transform[] paths = new Transform[6];
    private Animator BorisAnimator;
    public GameObject path;


    private int movesCount;
    private int pathCount;
    private string[] moves = { "RightHook", "LeftUpperCut", "LeftJab", "RightJab", "RightHook", "LeftUpperCut", "LeftJab", "LeftHook", "RightHook", "RightUpperCut", "RightJab"};


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

        Activeness(moves.Length - 1, 0);
        BorisAnimator = GetComponent<Animator>();
        movesCount = 0;
        pathCount = 0;


    }

    private void Activeness(int current, int next)
    {
        foreach(Transform p in paths)
        {
            if(p.gameObject.name == moves[current])
            {
                p.gameObject.SetActive(false);
            }

            if(p.gameObject.name == moves[next])
            {
                p.gameObject.SetActive(true);
            }
        }
    }

    private void MovesSwitch()
    {

        if (movesCount == moves.Length - 1) {
            BorisAnimator.SetBool(moves[movesCount], false);
            BorisAnimator.SetBool(moves[0], true);
            Activeness(movesCount, 0);

        } else {

            BorisAnimator.SetBool(moves[movesCount], false);
            BorisAnimator.SetBool(moves[movesCount + 1], true);
            Activeness(movesCount, movesCount + 1);
        }

        movesCount++;
    }

    private void OnTriggerEnter(Collider other)
    {
        // if you have reached the end of the array of animations
        if (movesCount > moves.Length - 1) movesCount = 0;

        if (other.gameObject.CompareTag("leftHand") && moves[movesCount][0] == 'L') {
            Debug.Log(moves[movesCount]);
            MovesSwitch();
        } else if (other.gameObject.CompareTag("rightHand") && moves[movesCount][0] == 'R') {
            Debug.Log(moves[movesCount]);
            MovesSwitch();
        }
    }
}