using System.IO;
using UnityEngine;

public class JsonReadWriteSystem : MonoBehaviour
{
    public ScoreAndInformation sAndI;
    public SetVolume setVolume;
    public void SaveToJson()
    {
        Audio audio = new Audio();
        ScoreData data = new ScoreData();

        data.scoreTotal = sAndI.totalPoint;
        data.scoreBonus = sAndI.bonusPoint;
        data.scoreEnemy = sAndI.scoreCountEnemy;
        audio.volume = setVolume.setVolume;

        string json = JsonUtility.ToJson(data, true);
        string jsonVol = JsonUtility.ToJson(audio, true);
        File.WriteAllText(Application.dataPath + "/SaveData.json" + json, jsonVol);
    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
        Audio audio = JsonUtility.FromJson<Audio>(json);
        ScoreData data = JsonUtility.FromJson<ScoreData>(json);

        sAndI.totalPoint = data.scoreTotal;
        sAndI.bonusPoint = data.scoreBonus;
        sAndI.scoreCountEnemy = data.scoreEnemy;
        setVolume.setVolume = audio.volume;
    }
}
