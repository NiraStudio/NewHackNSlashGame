using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item  {
    public string name;
    public string description;
    public ItemType itemType;
    public Sprite icon;
    public Sprite visual;
    public float hitPoint;
    public float damage;
    

}
public enum ItemType
{
    Weapon,HeadArmor,BodyArmor
}
