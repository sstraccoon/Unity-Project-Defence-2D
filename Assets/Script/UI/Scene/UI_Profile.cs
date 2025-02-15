using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Profile : UI_Scene
{
   

    private void Start()
    {
        Init();
    }

    enum Buttons
    {
        Sight_Btn,
        Gold_Btn,
        ATK_Btn,
        DEF_Btn,
        MoveSpeed_Btn,
        GunPower_Btn,
        HP_Btn,
        AttackSpeed_Btn,
        CoolTime_Btn,
        Call_Btn,
    }

    enum TMP_Texts
    {
        Sight_Price,
        Sight_Level,
        Gold_Price,
        Gold_Level,
        ATK_Price,
        ATK_Level,
        MoveSpeed_Price,
        MoveSpeed_Level,
        GunPower_Price,
        GunPower_Level,
        HP_Price,
        HP_Level,
        AttackSpeed_Price,
        AttackSpeed_Level,
        CoolTime_Price,
        CoolTime_Level,
        Call_Price,
        Call_Level,
    }

    public override void Init()
    {
        base.Init();

        Bind<TMP_Text>(typeof(TMP_Texts));
        Bind<Button>(typeof(Buttons));
    }

}


//    void Awake()
//    {
//        Init();
//    }

//    public override void Init()
//    {
//        base.Init();

//        Bind<TMP_Text>(typeof(TMP_Texts));
//        Bind<Button>(typeof(Buttons));

//        Managers.Line.SetTextUI(GetText((int)TMP_Texts.Name), GetText((int)TMP_Texts.Line));

//        BindEvent(GetButton((int)Buttons.Next).gameObject, Conversation, Define.UIEvent.Click);

//        if (!Managers.Line.Conversation())
//        {
//            Managers.Line.Clear(gameObject);
//        }
//    }

//    public void Conversation(PointerEventData data)
//    {
//        if (!Managers.Line.Conversation())
//        {
//            Managers.Line.Clear(gameObject);
//        }
//    }
//}