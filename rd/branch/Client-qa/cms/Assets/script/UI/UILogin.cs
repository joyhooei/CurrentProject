﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UILogin : UIBase
{
	public static	string	ViewName = "UILogin";
	public static string AssertName = "ui/login";

	public Button m_LoginButton;
	void Start()
	{
		EventTriggerListener.Get (m_LoginButton.gameObject).onClick = onLoginButtonClicked;
	}

	void  onLoginButtonClicked(GameObject go)
	{
		//Debug.Log ("Login Button Click!!");
		GameEventMgr.Instance.FireEvent (GameEventList.LoginClick);
	}
}
