using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public CharacterData data;

    Dictionary<int, string> equipedItems = new Dictionary<int, string>();
    void Start () {
        print(data.damage);
	}
	
	void Update () {
		
	}
    public void Jump()
    {

    }
    public void GetHit()
    {

    }
    public void Attack()
    {

    }
    public void Dash()
    {

    }
    public void Roll()
    {

    }
    public void UseAbility()
    {

    }
    //change the equiped items
    public void ChangeClothing(Dictionary<int,string> newClothing)
    {
        equipedItems = newClothing;
    }
}
