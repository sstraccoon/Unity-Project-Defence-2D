using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class UI_ProfileButton : UI_Base
{

    enum GameObjects
    {
        Button,
        Level,
        Place,
    }

    string _place;
    string _level;

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));

        _place = Get<GameObject>((int)GameObjects.Place).GetComponent<TMP_Text>().text;
        _level = Get<GameObject>((int)GameObjects.Level).GetComponent<TMP_Text>().text;


        //Debug.Log($"Level : {_level}, Place : {_place}");
        
        
        BindEvent(Get<GameObject>((int)GameObjects.Button), ClickSkill, Define.UIEvent.Click);
    }

    public void ClickSkill(PointerEventData eventData)
    {
        //Debug.Log($"스킬 클릭! {this.name}");
    }
}
