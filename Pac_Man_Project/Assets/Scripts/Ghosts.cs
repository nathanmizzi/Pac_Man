using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghosts : MonoBehaviour
{
    [SerializeField] AudioClip hitSound;

    LifeManager lifeManager;

    void Start()
    {
      lifeManager = FindObjectOfType<LifeManager>();
      var startingposy = transform.position.y;
      var startingposx = transform.position.x;
    }

    public void DeleteGhosts()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    { 
        if (trigger.gameObject.tag == "pacman")
        {
            AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
            lifeManager.Loselife();
        }
    }
}
