using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour {

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "rightHand" || other.gameObject.tag == "leftHand") {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}
