using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    //public var
    public CharacterData data;
    [Header("Body parts")]
    public GameObject weaponPos;
    public GameObject HeadPos;
    public GameObject ArmorPos;
    public bool rightSided;
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
    Animator anim;
    Dictionary<string, int> equipedItems = new Dictionary<string, int>();


    void Start () {
        GetData();
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        rg.position += Vector2.right * direction * speed * Time.deltaTime;
	}
    public virtual void Jump()
    {
        //animation
        rg.velocity += Vector2.up * 20;
    }
    public virtual void GetHit()
    {

    }
    public virtual void Attack()
    {
        GetComponent<Animator>().SetTrigger("Attack");
    }
    public virtual void Dash()
    {
        rg.velocity += Vector2.right * direction * 10;
        rg.velocity += Vector2.up* 5;
    }
    public virtual void Flip()
    {
        if(direction>0&&!rightSided){
            Vector2 t=transform.localScale;
            t.x*=-1;
            transform.localScale=t;
            rightSided = !rightSided;

        }
        if (direction < 0 && rightSided)
        {
            Vector2 t = transform.localScale;
            t.x *= -1;
            transform.localScale = t;
            rightSided = !rightSided;

        }
    }
    public virtual void Roll()
    {
        rg.velocity = Vector2.zero;
        rg.velocity += Vector2.right*direction*15;
        rg.velocity += Vector2.up * 5;

        this.gameObject.layer = 9;
        anim.SetTrigger("Roll");
    }
   
    public virtual void UseAbility()
    {

    }
    public virtual void ChangeLayer(int LayerNumber)
    {
        gameObject.layer = LayerNumber;
    }
    public virtual void GetData()
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
    public virtual void ChangeClothing(Dictionary<string, int> newClothing)
    {
        equipedItems = newClothing;
    }
    public virtual void ChangeDirection(int dir)
    {
        direction = dir;
        Flip();
    }
}
