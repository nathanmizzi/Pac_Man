using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI LifeText;
    public static int currentLives;
    public GameObject heart, heart1, heart2;
    GameStatus gameStatus;
    LevelLoader levelLoader;

    void Start()
    {
      currentLives = 3;
      LifeText = FindObjectOfType<TextMeshProUGUI>();
      gameStatus = FindObjectOfType<GameStatus>();
      levelLoader = FindObjectOfType<LevelLoader>();
      gameStatus.showStats();
    }
    void Update()
    {
        if (currentLives == 3)
        {
            heart.SetActive(true);
            heart1.SetActive(true);
            heart2.SetActive(true);
        }
        else if (currentLives == 2)
        {
            heart.SetActive(true);
            heart1.SetActive(true);
            heart2.SetActive(false);
        }
        else if (currentLives == 1)
        {
            heart.SetActive(true);
            heart1.SetActive(false);
            heart2.SetActive(false);
        }
        else if (currentLives == 0)
        {
            heart.SetActive(false);
            heart1.SetActive(false);
            heart2.SetActive(false);
            levelLoader.fail();
            gameStatus.hideStats();
        }
    }

    public void ResetLives()
    {
        gameObject.SetActive(true);
        currentLives = 3;
    }

    public void Loselife()
    {
        currentLives--;
    }
}
