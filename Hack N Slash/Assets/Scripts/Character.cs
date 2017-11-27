using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    //public var
    public CharacterData data;


    //local var
    protected string characterName;
    protected float hitPoint;
    protected float speed;
    protected float damage;
    protected float armor;
    protected float criticalChance;
    protected float lifeSteal;

    Rigidbody2D rg;
    Dictionary<int, string> equipedItems = new Dictionary<int, string>();


    void Start () {
        getData();
        rg = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        
	}
    public void Jump()
    {
        //animation
        rg.velocity += Vector2.up * 20;
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
    public void getData()
    {
        characterName = data.characterName;
        damage = data.damage;
        armor = data.armor;
        lifeSteal = data.lifeSteal;
        criticalChance = data.criticalChance;
        speed = data.speed;
        hitPoint = data.hitPoint;
    }
    //change the equiped items
    public void ChangeClothing(Dictionary<int,string> newClothing)
    {
        equipedItems = newClothing;
    }
}
