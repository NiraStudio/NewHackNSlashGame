using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcCharacterController : MonoBehaviour {
    public Character character;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
            character.ChangeDirection(1);

        if (Input.GetKeyDown(KeyCode.A))
            character.ChangeDirection(-1);

        if (Input.GetKeyDown(KeyCode.Space))
            character.Attack();
        
	}
}
