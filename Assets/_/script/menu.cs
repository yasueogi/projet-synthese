using UnityEngine;
using UnityEngine.SceneManagement;

public class MonScripMenu : MonoBehaviour
{
    public string nomDeLaScene = "starts"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}