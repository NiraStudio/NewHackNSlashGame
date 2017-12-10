using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Mission  {
    public string missionTask;
    public int amount;
    public RewardType rewardtype;
    public MissionDifficulty missionDifficulty;
    public bool Check()
    {
        return false;
    }
}
public enum MissionDifficulty
{
    Easy,Normal,Hard
}
