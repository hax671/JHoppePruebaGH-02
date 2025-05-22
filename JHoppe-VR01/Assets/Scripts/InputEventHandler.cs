using UnityEngine;
using UnityEngine.SceneManagement;

public class InputEventHandler1 : MonoBehaviour
{
    public string sceneToLoad = "NombreDeTuEscena";

    public void OnChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

