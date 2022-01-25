using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    GameStatus gameStatus;
    LifeManager lifeManager;
    Ghosts ghosts;

    void Start()
    {
      gameStatus = FindObjectOfType<GameStatus>();
      lifeManager = FindObjectOfType<LifeManager>();
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        lifeManager.ResetLives();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void fail()
    {
        lifeManager.ResetLives();
        SceneManager.LoadScene(4);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
