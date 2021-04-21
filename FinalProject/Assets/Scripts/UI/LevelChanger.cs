using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public void sceneChanger(int level)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(level);
    }
}