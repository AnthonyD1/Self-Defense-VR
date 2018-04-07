using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "rightHand" || other.gameObject.tag == "leftHand")
        {
            SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
            this.gameObject.ToString();
        }
    }
}