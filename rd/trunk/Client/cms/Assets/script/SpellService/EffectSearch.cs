﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


[Serializable]
public class EffectSearchPrototype : EffectPrototype
{
    public int count;
    public int camp;
    public string effectID;
}

public class EffectSearch : Effect
{
    //---------------------------------------------------------------------------------------------
    public override void Init(EffectPrototype pt, SpellService owner)
    {
        EffectSearchPrototype searchPtOut = pt as EffectSearchPrototype;
        protoEffect = new EffectSearchPrototype();
        EffectSearchPrototype searchPt = protoEffect as EffectSearchPrototype;
        searchPt.count = searchPtOut.count;
        searchPt.camp = searchPtOut.camp;
        searchPt.effectID = searchPtOut.effectID;
        base.Init(pt, owner);
    }
    //---------------------------------------------------------------------------------------------
    public override void Apply(float applyTime, string wpName, float aniDelayTime)
    {
        base.Apply(applyTime, wpName);

        Logger.Log("[SpellService]trigger search effect");
        EffectSearchPrototype searchProt = protoEffect as EffectSearchPrototype;
        UnitCamp casterCamp = spellService.GetUnit(casterID).pbUnit.camp;
        int camp = searchProt.camp;
        if (casterCamp == UnitCamp.Player)
        {
            camp = (camp == (int)UnitCamp.Player) ? camp : (int)(UnitCamp.Enemy);
        }
        else
        {
            camp = (camp == (int)UnitCamp.Player) ? (int)(UnitCamp.Enemy) : (int)(UnitCamp.Player);
        }

        List<BattleObject> boList = spellService.GetUnitList(camp);
        foreach (BattleObject bo in boList)
        {
            if (bo == null || bo.unit.isVisible == false)
                continue;

            List<string> wpList = WeakPointController.Instance.GetAiCanAttackWeakpointList(bo.unit);
            for (int i = 0; i < wpList.Count; ++i)
            {
                Effect curEffect = spellService.GetEffect(searchProt.effectID);
                if (curEffect != null)
                {
                    curEffect.SetOwnedBuff(ownedBuff);
                    curEffect.SetOwnedSpell(ownedSpell);
                    curEffect.targetID = bo.guid;
                    curEffect.Apply(applyTime, wpList[i]);
                }
            }

        }
    }
    //---------------------------------------------------------------------------------------------
}
