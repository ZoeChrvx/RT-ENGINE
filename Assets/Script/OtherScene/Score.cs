using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public ScoreAndInformation scoreAndInformation;
    public TextMeshProUGUI totalScore;
    void Start()
    {
        totalScore.text = "  Score : " + (scoreAndInformation.scoreCountEnemy + scoreAndInformation.bonusPoint);
    }

    void Update()
    {
        
    }
}
