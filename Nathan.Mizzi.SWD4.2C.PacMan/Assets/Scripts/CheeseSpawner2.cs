using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner2 : MonoBehaviour
{

    Vector2 cheesePosition, startingPosition;
    GameObject randomCheese;
    [SerializeField] GameObject[] cheese;

    void Start()
    {
        startingPosition = transform.position;
        LoadCheeseFromResources();
        GetRandomCheese();
        SpawnCheese();
    }

    void SpawnCheese()
    {
        Instantiate(randomCheese, cheesePosition, transform.rotation);
    }

    void GetRandomCheese()
    {
        int randomNumber = Random.Range(0, cheese.Length);
        randomCheese = cheese[randomNumber];
    }

    void LoadCheeseFromResources()
    {
        cheese = Resources.LoadAll<GameObject>("Cheese2");
        cheesePosition = transform.position;

    }

}
