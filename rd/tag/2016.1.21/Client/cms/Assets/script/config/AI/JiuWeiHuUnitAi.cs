﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JiuWeiHuUnitAi : BossAi {

	// Use this for initialization
	void Start () 
	{
	
	}
	//下面这个是弱点提示切换的动画，需要配置在状态切换事件下方
	//BattleController.Instance.GetUIBattle().wpUI.ChangeBatch(2.0f);

	public	override BattleUnitAi.AiAttackResult GetAiAttackResult(GameUnit jiuWeihuUnit)
	{
		BattleUnitAi.AiAttackResult attackResult = new BattleUnitAi.AiAttackResult ();

		//attackStyle todo
		attackResult.attackStyle = BattleUnitAi.AiAttackStyle.PhysicsAttack;

		//spell todo
		Dictionary<string,Spell> jiuWeihuSpellDic = GetUnitSpellList (jiuWeihuUnit);

		Spell useSpell = null;
		jiuWeihuSpellDic.TryGetValue ("attackCutTriStrong", out useSpell);

		attackResult.attackTarget = GetAttackRandomTarget(jiuWeihuUnit);
        if (attackResult.attackTarget == null)
            return null;

        List<string> wpList = null;
		wpList = GetAliveWeakPointList (jiuWeihuUnit);
		int count = 0;
		for(int n = wpList.Count -1 ;n > 0;n--)
		{
			if (wpList[n] == "jiuweihu_ruodian_3")
				count++;
			if (wpList[n] == "jiuweihu_ruodian_5")
				count++;
			if (wpList[n] == "jiuweihu_ruodian_7")
				count++;
			if (wpList[n] == "jiuweihu_ruodian_9")
				count++;
		}

		int i = 1;
		if (GetAttackCount(jiuWeihuUnit) % 10 == 0 && count == 4) 
		{
			jiuWeihuSpellDic.TryGetValue ("bossJiuweihu4", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
		}
		else if(GetAttackCount(jiuWeihuUnit) % 10 == 0 && count == 3) 
		{
			jiuWeihuSpellDic.TryGetValue ("bossJiuweihu3", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
		}
		else if(GetAttackCount(jiuWeihuUnit) % 10 == 0 && count == 2) 
		{
			jiuWeihuSpellDic.TryGetValue ("bossJiuweihu2", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
		}
		else if(GetAttackCount(jiuWeihuUnit) % 10 == 0 && count == 1) 
		{
			jiuWeihuSpellDic.TryGetValue ("bossJiuweihu1", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
		}
		else if(GetAttackCount(jiuWeihuUnit) % 4 == 3 && GetUnitMinHp(jiuWeihuUnit) <= (GetUnitMaxHp(jiuWeihuUnit) * 0.75))
		{
			jiuWeihuSpellDic.TryGetValue ("buffMagic", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
		} 
		else if(GetAttackCount(jiuWeihuUnit) % 4 == 0 && GetUnitMinHp(jiuWeihuUnit) <= (GetUnitMaxHp(jiuWeihuUnit) * 0.75)) 
		{
			jiuWeihuSpellDic.TryGetValue ("magicCureSlight", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
		}

		else if(GetUnitMinHp(jiuWeihuUnit) <= (GetUnitMaxHp(jiuWeihuUnit) * 0.1) && i == 1) 
		{
			jiuWeihuSpellDic.TryGetValue ("defend", out useSpell);
			attackResult.attackTarget = jiuWeihuUnit;
			i--;
		}

		attackResult.useSpell = useSpell;

		return attackResult;
	}

	private List<GameUnit> GetCanAttackList(GameUnit jiuWeihuUnit)
	{
		return BattleUnitAi.Instance.GetOppositeSideFiledList(jiuWeihuUnit);
	}

	private int GetAttackCount(GameUnit jiuWeihuUnit)
	{
		return jiuWeihuUnit.attackCount;
	}

	private Dictionary<string,Spell> GetUnitSpellList(GameUnit battleUnit)
	{
		return battleUnit.spellList;
	}

	private List<Buff> GetUnitBuffList(GameUnit battleUnit)
	{
		return battleUnit.buffList;
	}

	private List<string> GetAliveWeakPointList(GameUnit gUnit)
	{
		List<string> wpList = new List<string> ();

		foreach (KeyValuePair<string,WeakPointRuntimeData> subWp in gUnit.battleUnit.wpGroup.allWpDic)
		{
			WeakPointRuntimeData wpData = subWp.Value;
			if(wpData.HpAttr > 0)
			{
				wpList.Add(subWp.Key);
			}
		}
		return wpList;
	}

	private int GetUnitMaxHp(GameUnit battleUnit)
	{
		return battleUnit.maxLife;
	}

	private int GetUnitMinHp(GameUnit battleUnit)
	{
		return battleUnit.curLife;
	}
}
