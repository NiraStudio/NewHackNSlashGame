using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item  {
    Sprite visual;
    Sprite icon;
    string description;
    string name;
    public float hitPoint;
    public float damage;
    public ItemType itemType;

}
public enum ItemType
{
    Weapon,HeadArmor,HandArmors,BodyArmor
}
