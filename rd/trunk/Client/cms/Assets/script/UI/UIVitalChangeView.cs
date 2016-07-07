﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIVitalChangeView : MonoBehaviour
{
    //TODO: fontsettings have default mat
    public string aniName;
    public Font damageFont;
    public Material damageFontMat;
    public Font healFont;
    public Material healFontMat;
    public Text vitalWnd;
    public Image vitalBackImage;
    public Sprite criticalSprite;
    public Sprite criticalHealSprite;
    public Sprite missSprite;
    public Sprite interruptSprite;
    RectTransform trans;

    //---------------------------------------------------------------------------------------------
    void Awake()
    {
        trans = transform as RectTransform;
    }
    //---------------------------------------------------------------------------------------------
    public void ShowVitalChange(SpellVitalChangeArgs args, RectTransform parent)
    {
        int vitalChange = args.vitalChange;

        //choose font
        trans.SetParent(parent);
        trans.localScale = Vector3.one;
        trans.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        if (args.vitalType == (int)VitalType.Vital_Type_Default)
        {
            vitalWnd.gameObject.SetActive(true);
            if (vitalChange < 0)
            {
                vitalWnd.font = damageFont;
                vitalWnd.material = damageFontMat;
                vitalChange *= -1;
                vitalBackImage.sprite = criticalSprite;
            }
            else
            {
                vitalWnd.font = healFont;
                vitalWnd.material = healFontMat;
                vitalBackImage.sprite = criticalHealSprite;
            }
            vitalBackImage.gameObject.SetActive(args.isCritical == true);
            vitalWnd.text = vitalChange.ToString();
        }
        else if (args.vitalType == (int)VitalType.Vital_Type_Miss)
        {
            vitalBackImage.sprite = missSprite;
            vitalBackImage.gameObject.SetActive(true);
            vitalWnd.gameObject.SetActive(false);
        }
        else if (args.vitalType == (int)VitalType.Vital_Type_Interrupt)
        {
            vitalBackImage.sprite = interruptSprite;
            vitalBackImage.gameObject.SetActive(true);
            vitalWnd.gameObject.SetActive(false);
        }

        //calculate pos
        BattleObject bo = ObjectDataMgr.Instance.GetBattleObject(args.targetID);
        if (bo != null)
        {
            Transform targetTrans = bo.transform;
            GameObject lifebarNode = Util.FindChildByName(bo.gameObject, BattleConst.lifeBarNode);
            if (lifebarNode != null)
            {
                targetTrans = lifebarNode.transform;
            }

            if (args.wpNode != null && args.wpNode.Length > 0)
            {
                GameObject targetNode = Util.FindChildByName(bo.gameObject, args.wpNode);
                if (targetNode != null)
                {
                    targetTrans = targetNode.transform;
                }
            }
            Vector3 pt = BattleCamera.Instance.CameraAttr.WorldToScreenPoint(targetTrans.position);
            float scale = UIMgr.Instance.CanvasAttr.scaleFactor;
            trans.anchoredPosition = new Vector2(pt.x / scale, pt.y / scale);
        }

        //play ani
        if (aniName == null || aniName.Length == 0)
            return;
        Animator animator = gameObject.GetComponent<Animator>();
        if (animator != null)
        {
            animator.Play(aniName);
        }
    }
    //---------------------------------------------------------------------------------------------
    public void OnAnimationFinish()
    {
		//Destroy(gameObject);
		ResourceMgr.Instance.DestroyAsset(gameObject);
    }
    //---------------------------------------------------------------------------------------------
}
