using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheese : MonoBehaviour
{

    GameStatus gameStatus;
    [SerializeField] AudioClip destroySound;
    Level level;
    int soundPlayingCount;

    void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        level = FindObjectOfType<Level>();
        level.CountCheeseLeft();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "pacman")
        {
            Destroy(gameObject);
            gameStatus.AddScore();
            AudioSource.PlayClipAtPoint(destroySound, Camera.main.transform.position);
            level.cheeseEaten();
        }
    }

}
