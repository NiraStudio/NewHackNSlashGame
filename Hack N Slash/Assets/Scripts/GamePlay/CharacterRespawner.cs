using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRespawner : MonoBehaviour {
    public CharacterDatabase database;
    public int CharacterId;
	// Use this for initialization
	void Start () {
        RespawnCharacter();
	}

    void RespawnCharacter()
    {
        Instantiate(database.giveCharacterById(CharacterId).shape, transform.position, Quaternion.identity);
    }
	
	
}
