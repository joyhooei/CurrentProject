﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyItem : UIBase
{
	public static string ViewName = "BuyItem";
	public	class BuyItemParam
	{
		public	string	itemId;
		public	int		defaultbuyCount;
		public	int		maxCount;
		public	bool	isShowCoinButton;
	}

	public	static	void	OpenWith(BuyItemParam	param)
	{
		BuyItem bi = (BuyItem)UIMgr.Instance.OpenUI_ (ViewName, false);
		bi.RefreshWith (param);
	}

	public	ItemIcon	itemIcon;
	public	CoinButton	coinButton;

	public	Text	itemNameText;
	public	Text	buyCountDescText;
	public	Text	buyCountValueText;
	public	Text	totalDescText;
	public	Text	zuanshiCountText;

	public	Button	cancelButton;
	public	Button	OKButton;

	//public	Image	leftImage;
	//public	Image	rightImage;

	private	ChangeValueByHand	chgValue;
	private	int	maxBuyCount = 1;//最大购买个数
	private	int	price = 0;
	private	string itemId;

	private	int curCount = 1;//当前购买个数
	private	int CurCountAttr
	{
		get{ return curCount;}
		set
		{
			curCount = value;
			if(curCount < 1) 
			{
				curCount = 1;
			}
			if(curCount > maxBuyCount)
			{
				curCount = maxBuyCount;
			}
			buyCountValueText.text = curCount.ToString();
			zuanshiCountText.text = (curCount * price).ToString();
		}
	}

	bool isFirst = true;
	public override void Init()
	{
		if (isFirst)
		{
			isFirst = true;
			FirsInit();
		}

	}
	
	void FirsInit()
	{
		EventTriggerListener.Get (cancelButton.gameObject).onClick = OnCancelButtonClicked;
		EventTriggerListener.Get (OKButton.gameObject).onClick = OnOKButtonClicked;

		chgValue = GetComponent<ChangeValueByHand> ();
		chgValue.callback = OnBuyCountValueChanged;
	}

	public override void Clean()
	{

	}

	public	void	RefreshWith(BuyItemParam	param)
	{
		maxBuyCount = param.maxCount;
		CurCountAttr = param.defaultbuyCount;

		chgValue.maxValue = maxBuyCount;
		chgValue.curValue = curCount;

		itemId = param.itemId;

		ItemStaticData stData = StaticDataMgr.Instance.GetItemData (itemId);
		if (null == stData)
		{
			Logger.LogError(string.Format("can't find itemid {0}  for buy item",itemId));
			return;
		}
		ItemData itemData = new ItemData ();
		itemData.itemId = itemId;
		itemData.count = 1;

		itemIcon.RefreshWithItemInfo (itemData, false);

		price = stData.buyPrice;

		coinButton.gameObject.SetActive (param.isShowCoinButton);

		itemNameText.text = stData.NameAttr;
	}

	void OnBuyCountValueChanged(int value)
	{
		CurCountAttr = value;
	}

	void	OnCancelButtonClicked(GameObject go)
	{
		UIMgr.Instance.CloseUI_ (this);
	}
	
	void	OnOKButtonClicked(GameObject go)
	{
		//购买item
		int needZuanshi = price * curCount;
		if (needZuanshi > GameDataMgr.Instance.PlayerDataAttr.gold) 
		{
			UIIm.Instance.ShowSystemHints(StaticDataMgr.Instance.GetTextByID("没钻石买个毛线！"),
			                              (int)PB.ImType.PROMPT);
			return;
		}

	}
}
