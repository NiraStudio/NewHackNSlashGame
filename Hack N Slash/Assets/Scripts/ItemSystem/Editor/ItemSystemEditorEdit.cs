using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemSystemEditorEdit : EditorWindow
{
    public const string FOLDER_NAME = "DataBase";
    public const string FILE_NAME = "ItemSystemData.asset";
    public const string FULL_PATH = @"Assets/" + FOLDER_NAME + "/" + FILE_NAME;

    ItemDataBase dataBase,db;
    static Vector2 WindowSize = new Vector2(1100, 500);
    static Vector2 IconButtonSize = new Vector2(50, 50);
    static Vector2 Scrollpos;
    Texture2D ItemIcon;
    Item temp = new Item();
    string searchName="";

    [MenuItem("Item System/Edit Items")]
    public static void InIt()
    {
        ItemSystemEditorEdit window = EditorWindow.GetWindow<ItemSystemEditorEdit>();
        window.minSize = WindowSize; window.maxSize = WindowSize;

        window.title = "Item Editor";
        window.Show();
    }

    void OnEnable()
    {
        dataBase = AssetDatabase.LoadAssetAtPath(FULL_PATH, typeof(ItemDataBase)) as ItemDataBase;

        if (dataBase == null)
        {
            if (!AssetDatabase.IsValidFolder(@"Assets/" + FOLDER_NAME))
                AssetDatabase.CreateFolder(@"Assets", FOLDER_NAME);

            dataBase = new ItemDataBase();
            AssetDatabase.CreateAsset(dataBase, FULL_PATH);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }

    void OnGUI()
    {
        GUILayout.BeginVertical();

        

        EditScroll();


        GUILayout.BeginHorizontal("Box");

        GUILayout.Label("Search item name or ID:");
        searchName = GUILayout.TextField(searchName, GUILayout.Width(500));
        GUILayout.Label("Item Count :"+dataBase.DBLenght);

        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }





    void EditScroll()
    {
        db = new ItemDataBase();
        if (searchName == null)
           db=dataBase;
       else
            for (int i = 0; i < dataBase.DBLenght; i++)
            {
                if (dataBase.GiveItemByIndex(i).name.Contains(searchName) || dataBase.GiveItemByIndex(i).iD.ToString().Contains(searchName))
                    db.addItem(dataBase.GiveItemByIndex(i));
            }
        Scrollpos = GUILayout.BeginScrollView(Scrollpos, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
        for (int i = 0; i < db.DBLenght; i++)
        {
            temp = db.GiveItemByIndex(i);

            GUILayout.BeginVertical("Box");

             
            GUILayout.BeginHorizontal();

            #region icon
            if (temp.icon != null)
                ItemIcon = temp.icon.texture;


            if (GUILayout.Button(ItemIcon, GUILayout.Width(IconButtonSize.x), GUILayout.Height(IconButtonSize.y)))
            {
                EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, 0);
            }
            string commend = Event.current.commandName;
            if (commend == "ObjectSelectorClosed")
            {
                temp.icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
            }

            #endregion


            #region Name ,Shape ,Dmg ,Hp  ,X &type

            GUILayout.BeginVertical();

            #region Name ,Shape
            GUILayout.BeginHorizontal();

            GUILayout.Label("Item Name:", GUILayout.Width(250));
            temp.name = GUILayout.TextField(temp.name, GUILayout.Width(250));

            GUILayout.Label("Item Shape:", GUILayout.Width(200));
            temp.visual = EditorGUILayout.ObjectField(temp.visual, typeof(GameObject), GUILayout.Width(200)) as GameObject;

            if (GUILayout.Button("X", GUILayout.Width(20), GUILayout.Height(20)))
            {
                if (EditorUtility.DisplayDialog("Delete Quality", "Are you sure you want to delete " + temp.name + "?", "Yes", "No"))
                    dataBase.removeItem(temp);
            };

            GUILayout.EndHorizontal();
            #endregion

            #region dmg ,hp, Type
            GUILayout.BeginHorizontal();

            //Damage
            temp.damage = EditorGUILayout.FloatField("Damage:", temp.damage, GUILayout.Width(300));
            //HitPoint
            temp.hitPoint = EditorGUILayout.FloatField("Hit Point:", temp.hitPoint, GUILayout.Width(300));

            temp.itemType = (ItemType)EditorGUILayout.EnumPopup("Item Type:", temp.itemType, GUILayout.Width(300));

            GUILayout.EndHorizontal();
            #endregion

            GUILayout.EndVertical();

            #endregion


            GUILayout.EndHorizontal();


            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("ID: "+temp.iD);
            GUILayout.EndHorizontal();

            GUILayout.Label("Item Description:");
            temp.description = EditorGUILayout.TextArea(temp.description, GUILayout.Height(70), GUILayout.ExpandWidth(true));


            GUILayout.EndVertical();
        }
        GUILayout.EndScrollView();

    }
}
