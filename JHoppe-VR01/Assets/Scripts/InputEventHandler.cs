using UnityEngine;
using UnityEngine.SceneManagement;

public class InputEventHandler : MonoBehaviour
{
    public string sceneToLoad = "Escena";

    public void OnChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
