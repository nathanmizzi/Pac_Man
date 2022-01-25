using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int cheeseLeft;

    LevelLoader levelLoader;

    void Start()
    {
     levelLoader = FindObjectOfType<LevelLoader>();
    }

    public void CountCheeseLeft()
    {
        cheeseLeft++;
    }

    public void cheeseEaten()
    {
        cheeseLeft--;

        if (cheeseLeft <= 0)
        {
            levelLoader.LoadNextScene();
        }
    }

}
