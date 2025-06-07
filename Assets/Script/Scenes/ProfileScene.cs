using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileScene : BaseScene
{

    // Start is called before the first frame update
    void Start()
    {

    }

    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Profile;

        Managers.UI.ShowSceneUI<UI_Profile>("Profile/");
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Clear()
    {

    }
}
