using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemSystemEditorCreate : EditorWindow {

    public const string FOLDER_NAME = "DataBase";
    public const string FILE_NAME = "ItemSystemData.asset";
    public const string FULL_PATH = @"Assets/"+FOLDER_NAME+"/"+FILE_NAME;

    ItemDataBase dataBase;
    static Vector2 WindowSize=new Vector2(1000,300);
    static Vector2 IconButtonSize = new Vector2(50, 50);
    Texture2D ItemIcon;
    Item temp=new Item();


    [MenuItem("Item System/Create Item")]
    public static void InIt()
    {
        ItemSystemEditorCreate window = EditorWindow.GetWindow<ItemSystemEditorCreate>();
        window.minSize = WindowSize; window.maxSize = WindowSize;
        
        window.title = "Item Creator";
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
        GUILayout.BeginVertical("Box");

        GUILayout.BeginHorizontal("Box");

        //DetailPart
        DetailPart();
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal("Box",GUILayout.Height(WindowSize.y *(.5f/ 3)));

       //create BTN
        if(GUILayout.Button("Create Item",GUILayout.ExpandWidth(true),GUILayout.ExpandHeight(true))){
            temp.IdSetter(dataBase.IdGiver());
            dataBase.addItem(temp);
            temp = new Item();
        }

        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }

    


    void DetailPart()
    {
        GUILayout.BeginVertical();


        #region Icon & Detail

        GUILayout.BeginHorizontal();

        #region Icon Part
        
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

        #region Detail Part

        GUILayout.BeginVertical();

        #region Name & Game Object

        GUILayout.BeginHorizontal();

        GUILayout.Label("Item Name:");
        temp.name = GUILayout.TextField(temp.name,GUILayout.Width(200));

        GUILayout.Label("Item Shape:");
        temp.visual = EditorGUILayout.ObjectField(temp.visual, typeof(GameObject))as GameObject;

        GUILayout.EndHorizontal();

        #endregion

        #region Damage , Hit Point & Type
        GUILayout.BeginHorizontal();

        //Damage
        temp.damage = EditorGUILayout.FloatField("Damage:", temp.damage);
        //HitPoint
        temp.hitPoint = EditorGUILayout.FloatField("Hit Point:", temp.hitPoint);
        //type
        temp.itemType = (ItemType)EditorGUILayout.EnumPopup("Item Type:", temp.itemType);

        GUILayout.EndHorizontal();
        #endregion

        GUILayout.EndVertical();

        #endregion


        

        GUILayout.EndHorizontal();

        #endregion


        GUILayout.Label("Item Description:");
        temp.description = EditorGUILayout.TextArea(temp.description, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));


        GUILayout.EndVertical();
    }
   
}
