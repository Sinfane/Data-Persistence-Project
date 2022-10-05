using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class ScoreData
{
    public int score;
    public string name;

    public ScoreData(MainManager main)
    {
        name = main.playerName;
        score = main.finalScore;
    }
  
}
