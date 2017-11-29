using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    //public var
    public CharacterData data;

    //local var
    protected string characterName;
    protected float speed;
    protected float jumpForce;
    protected float hitPoint;
    protected float damage;
    protected float armor;
    protected float criticalChance;
    protected float lifeSteal;
    int direction;

    Rigidbody2D rg;
    Dictionary<string, int> equipedItems = new Dictionary<string, int>();


    void Start () {
        GetData();
        rg = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        rg.position += Vector2.right * direction * speed * Time.deltaTime;
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
    public void GetData()
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
    public void ChangeClothing(Dictionary<string,int> newClothing)
    {
        equipedItems = newClothing;
    }
    public void ChangeDirection(int dir)
    {
        direction = dir;
    }
}
