using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TableauScore : MonoBehaviour
{
    public JsonReadWriteSystem jsonReadWriteSystem;
    public ScoreAndInformation scoreAndInformation;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        jsonReadWriteSystem.LoadFromJson();
        score.text += "Total Score : " + scoreAndInformation.totalPoint + "  // Enemy point : " + scoreAndInformation.scoreCountEnemy + "  // Bonus point : " + scoreAndInformation.bonusPoint;
    }

}
