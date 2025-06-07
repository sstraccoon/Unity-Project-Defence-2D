using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Button : UI_Popup
{
    //// 클릭 되면 작아지고 놓으면 커지는 효과만 주기로 함.
    //public Vector3 originalScale = new Vector3(1f, 1f, 1f);

    //void Start()
    //{
    //    Init();
    //}

    //public void Init()
    //{
    //    Managers.UI.SetCanvas(gameObject, true);
    //}

    //public virtual void ClosePopupUI()
    //{
    //    Managers.UI.ClosePopupUI(this);
    //}

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log("Click Down Button");
    //    StartCoroutine(GetSmallerScale());

    //}

    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    Debug.Log("Click Up Button");
    //    StartCoroutine(GetBiggerScale());
    //}

    //IEnumerator GetSmallerScale()
    //{
    //    float time = 0.1f;
    //    Vector3 smallScale = originalScale * 0.95f;
    //    yield return ScaleToSize(smallScale, time);

    //}

    //IEnumerator GetBiggerScale()
    //{
    //    float time = 0.1f;
    //    yield return ScaleToSize(originalScale, time);
    //}
    
    //IEnumerator ScaleToSize(Vector3 targetScale, float duration)
    //{
    //    Button myButton = transform.GetComponent<Button>();
    //    Vector3 currentScale = myButton.transform.localScale;
    //    float time = 0;

    //    while (time < duration)
    //    {
    //        myButton.transform.localScale = Vector3.Slerp(currentScale, targetScale, time / duration);
    //        time += Time.deltaTime;
    //        yield return null;
    //    }

    //    myButton.transform.localScale = targetScale;
    //}
}
