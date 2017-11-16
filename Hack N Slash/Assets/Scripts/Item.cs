using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item  {
    float hitPoint;
    float damge;
    ItemType itemType;

}
public enum ItemType
{
    Weapon,HeadArmor,HandArmors,BodyArmor
}
