using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI totalScore;
    void Start()
    {
        totalScore.text = "  Score : " + (ScoreAndInformation.scoreCountEnemy + ScoreAndInformation.bonusPoint);
    }

    void Update()
    {
        
    }
}
