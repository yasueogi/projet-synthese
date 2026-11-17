using UnityEngine;
using UnityEngine.SceneManagement;

public class MonScript : MonoBehaviour
{
    public string nomDeLaScene = "loop1"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}