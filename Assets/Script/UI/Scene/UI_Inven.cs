using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inven : UI_Scene
{
    enum GameObjects
    {
        Content,
        ScrollView,
        Row,
        Column
    }

    public float _cellSize = 30;
    public float _ratio = 0.1f;
    float _spacingSize;



    public override void Init()
    {
        base.Init();

        
        _spacingSize = _cellSize * _ratio; 


        Bind<GameObject>(typeof(GameObjects));


        ////삭제
        GameObject content = Get<GameObject>((int)GameObjects.Content);
        //foreach (Transform child in content.transform)
        //    //Managers.Resource.Destroy(child.gameObject);

        content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(_cellSize, _cellSize);

        content.GetComponent<GridLayoutGroup>().spacing = new Vector2(_spacingSize, _spacingSize);

        // 실제 인벤토리 정보를 참고해서
        for (int i = 0; i < 8; i++)
        {
            //GameObject item = Managers.UI.MakeSubItem<UI_Inven_Item>(content.transform).gameObject;            
            //UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
            //invenItem.SetInfo($"집행검{i}번");
            //Get<GameObject>((int)GameObjects.ItemNameText).GetComponent<Text>().text = _name;
        }
    }

    public void SetInvenSize()
    {
        GameObject content = Get<GameObject>((int)GameObjects.Content);

        foreach (Transform child in content.transform)
            Managers.Resource.Destroy(child.gameObject);

        //GameObject rowGo = Get<GameObject>((int)GameObjects.Row);

        //TMP_InputField inputField = rowGo.GetComponent<TMP_InputField>();
        //string rowStr = "";

        //if (inputField != null)
        //{
        //    rowStr = inputField.text;
        //    Debug.Log(rowStr);
        //}

        //string rowStr = rowGo.GetComponent<InputField>().text;

        int row = int.Parse(Get<GameObject>((int)GameObjects.Row).GetComponent<TMP_InputField>().text);
        int column = int.Parse(Get<GameObject>((int)GameObjects.Column).GetComponent<TMP_InputField>().text);

        int invenSize = row * column;

        content.GetComponent<RectTransform>().sizeDelta = new Vector2(
             (row * _cellSize) + (row * _spacingSize),
             (column * _cellSize) + (column * _spacingSize));

        float scrollViewX = 400;
        float scrollViewY = 400;
        if ((row * _cellSize) + (row * _spacingSize) < 400)
            scrollViewX = (row * _cellSize) + (row * _spacingSize);

        if ((column * _cellSize) + (column * _spacingSize) < 400)
            scrollViewY = (column * _cellSize) + (column * _spacingSize);

        Get<GameObject>((int)GameObjects.ScrollView).GetComponent<RectTransform>().sizeDelta = new Vector2(
             scrollViewX,
             scrollViewY);

        Debug.Log($"row : {(row * _cellSize) + (row * _spacingSize)}");
        Debug.Log($"column : {(column * _cellSize) + (column * _spacingSize)}");

        for (int i = 0; i < invenSize; i++)
        {
            GameObject go = new GameObject("NewImage");

            go.AddComponent<Image>();

            go.transform.SetParent(content.transform);
        }
           

    }
}
