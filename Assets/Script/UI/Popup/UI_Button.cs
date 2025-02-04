using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Button : UI_Popup
{
    // 클릭 되면 작아지고 놓으면 커지는 효과만 주기로 함.
    public float reduceScale = 0.5f;
    public float OriginalScale = 1f;

    public void ReduceScale()
    {
        transform.localScale = new Vector3(reduceScale, reduceScale, reduceScale);
    }

    public void RestoreScale()
    {
        transform.localScale = new Vector3(OriginalScale, OriginalScale, OriginalScale);
    }
}
