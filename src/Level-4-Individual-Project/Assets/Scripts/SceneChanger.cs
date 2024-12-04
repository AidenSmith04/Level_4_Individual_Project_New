using UnityEngine;
using UnityEngine.SceneManagement; // Import Scene Management

public class SceneChanger : MonoBehaviour
{
    // Method to load a scene by name
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Method to load a scene by index
    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
