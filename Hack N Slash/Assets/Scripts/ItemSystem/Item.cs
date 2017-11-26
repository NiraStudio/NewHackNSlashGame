using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item  {
    public string name="";
    public string description="";
    public int iD
    {
        get { return _id; }
    }
    public ItemType itemType=0;
    public Sprite icon=new Sprite();
    public GameObject visual;
    public float hitPoint=0;
    public float damage=0;

    int _id;


    public void IdSetter(int id)
    {
        _id = id;
    }
}
public enum ItemType
{
    Weapon,HeadArmor,BodyArmor
}
