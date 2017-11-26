using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : ScriptableObject {

    [SerializeField]
    List<Item> db = new List<Item>();

    public int DBLenght
    {
        get { return db.Count; }
    }
    public Item GiveItemByID(int id)
    {
        Item answer = new Item();
        foreach (Item item in db.ToArray())
        {
            if (item.iD == id)
                answer = item;
        }
        return answer;
    }

    public Item GiveItemByIndex(int index)
    {
        return db[index];
    }
    public void addItem(Item i)
    {
        db.Add(i);
        SetDirty();
    }
    public void removeItemByIndex(int index)
    {
        db.Remove(db[index]);
    }
    public void removeItem(Item item)
    {
        db.Remove(item);
    }
    public int IdGiver()
    {
        int answer = Random.Range(1000000, 9999999);
        bool Found = false; 
        do
        {
            answer = Random.Range(1000000, 9999999);
            Found = true;
            foreach (Item item in db.ToArray())
            {
                if (answer == item.iD)
                {
                    Found = false;
                    break;
                }

            }

        } while (Found==false);

        return answer;
    }


    public void SetDirty()
    {

#if UNITY_EDITOR
        UnityEditor.EditorUtility.SetDirty(this);
#endif
    }
}
