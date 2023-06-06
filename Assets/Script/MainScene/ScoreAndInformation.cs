using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreAndInformation : MonoBehaviour
{

    public TextMeshProUGUI scoreCounter;
    public TextMeshProUGUI addScoreEnemy;
    public TextMeshProUGUI addScoreBonus;
    public int scoreCountEnemy;
    public int bonusPoint;
    public int totalPoint;

    // Start is called before the first frame update
    void Start()
    {
        scoreCountEnemy = 0;
        bonusPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        totalPoint += scoreCountEnemy + bonusPoint;
        scoreCounter.text = string.Format("{0:00}:{1:00}", Time.timeSinceLevelLoad / 60, Time.timeSinceLevelLoad % 60);
        scoreCounter.text = "  Score : " + totalPoint;
        
        addScoreEnemy.text = "Enemy point = " + scoreCountEnemy;
        addScoreBonus.text = "Bonus point = " + bonusPoint;
    }
}
