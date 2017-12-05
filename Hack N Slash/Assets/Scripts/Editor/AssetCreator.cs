using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetCreator : MonoBehaviour {

    [MenuItem("Data Creator/Create Character Data")]
    public static void CreateCharacterData()
    {
        ScriptableObjectUtility.CreateAsset<CharacterData>("CharacterData");
    }
    [MenuItem("Data Creator/Create Pet Data")]
    public static void CreatePetData()
    {
        ScriptableObjectUtility.CreateAsset<PetData>("PetData");
    }

    [MenuItem("Data Creator/Create Enemy Data")]
    public static void CreateEnemyData()
    {
        ScriptableObjectUtility.CreateAsset<EnemyData>("EnemyData");
    }

    [MenuItem("Data Creator/Create Boss Data")]
    public static void CreateBossData()
    {
        ScriptableObjectUtility.CreateAsset<BossData>("BossData");
    }
    [MenuItem("Data Creator/Create character DataBase")]
    public static void CreateCharacterDataBase()
    {
        ScriptableObjectUtility.CreateAsset<CharacterDatabase>("character");
    }
}
