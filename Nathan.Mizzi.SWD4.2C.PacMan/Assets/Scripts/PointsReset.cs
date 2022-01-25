using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsReset : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI pointsText;
    GameStatus gameStatus;

    void Start()
    {
     gameStatus = FindObjectOfType<GameStatus>();
     gameStatus.ResetGame();
    }
}
