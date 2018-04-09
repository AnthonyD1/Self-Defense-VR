using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private string sceneName;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("rightHand") || other.gameObject.CompareTag("leftHand"))
        {
            // grabs the name of the parent and use that name to change scenes
            sceneName = this.transform.parent.name;
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }

    }
}
