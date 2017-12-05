using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDatabase : ScriptableObject {

    [SerializeField]
    List<CharacterData> database = new List<CharacterData>();

    public CharacterData giveCharacterById(int id)
    {
        foreach (var item in database.ToArray())
        {
            if (item.id == id)
                return item;
        }
        return null;
    }
}
