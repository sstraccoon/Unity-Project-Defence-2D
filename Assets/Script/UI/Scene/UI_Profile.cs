using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Profile : UI_Scene
{
	public override void Init()
	{
		Managers.UI.SetCanvas(gameObject, false);
	}
}
