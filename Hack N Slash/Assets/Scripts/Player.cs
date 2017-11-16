using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    float hp;
    [SerializeField]
    float speed;
    [SerializeField]
    float damage;
    [SerializeField]
    float armor;
    [SerializeField]
    float criticalChance;
    [SerializeField]
    float lifeSteal;
    [SerializeField]
    float cooldown;
    Dictionary<int, string> equipedItems = new Dictionary<int, string>();
    void Start () {
		
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
