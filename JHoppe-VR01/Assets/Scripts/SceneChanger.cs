using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad = "Escena"; // Cambia esto por el nombre exacto de la escena que quieres cargar
    public InputActionProperty inputAction;

    void OnEnable()
    {
        inputAction.action.Enable();
    }

    void OnDisable()
    {
        inputAction.action.Disable();
    }

    void Update()
    {
        if (inputAction.action.WasPressedThisFrame())
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
