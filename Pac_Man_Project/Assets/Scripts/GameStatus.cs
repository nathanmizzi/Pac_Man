using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI LifeText;
    [SerializeField] int currentScore;
    [SerializeField] int pointsPerCheeseDestroyed = 1;
    [SerializeField] TextMeshProUGUI score;

    void Awake()
    {
        int gameStatusCnt = FindObjectsOfType<GameStatus>().Length;


        if (gameStatusCnt > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    void Start()
    {
        currentScore = 0;
        score = FindObjectOfType<TextMeshProUGUI>();
        score.text = "Score: " + currentScore.ToString();
    }

    void Update()
    {
    }

    public void hideStats()
    {
      gameObject.SetActive(false);
    }

    public void showStats()
    {
        gameObject.SetActive(true);
    }

    public void AddScore()
    {
        currentScore += pointsPerCheeseDestroyed;
        FindObjectOfType<TextMeshProUGUI>().text = "Score: " + currentScore.ToString();
    }

    public void destroyLifeText()
    {
        Destroy(LifeText);
    }

    public void ResetGame()
    {
        currentScore = 0;
    }

}
