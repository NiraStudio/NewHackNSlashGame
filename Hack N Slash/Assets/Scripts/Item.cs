using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item :MonoBehaviour {
    [SerializeField]
    float hitPoint;
    [SerializeField]
    float damge;
    [SerializeField]
    ItemType itemType;

    void Start()
    {
        switch (itemType)
        {
            case ItemType.Weapon:
                break;
            case ItemType.HandArmors:
                break;
            case ItemType.LegArmors:
                break;
            case ItemType.HeadArmor:
                break;
            case ItemType.BodyArmor:
                break;

        }
    }

}
public enum ItemType
{
    Weapon,HeadArmor,HandArmors,LegArmors,BodyArmor
}
