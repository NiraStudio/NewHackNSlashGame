using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pet : MonoBehaviour {

    //public vars
    public PetData data;


    //local vars
    protected string petName;
    protected float damage;
    protected float speed;

	void Start () {
        getData();
	}
	
	void Update () {
		
	}

    public void Attack()
    {

    }

    public void onEnter()
    {

    }

    public void getData()
    {
        petName = data.petName;
        damage = data.damage;
        speed = data.speed;
        
    }

}
