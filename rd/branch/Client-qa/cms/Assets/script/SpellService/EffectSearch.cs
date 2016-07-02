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
        searchPt.camp = searchPtOut.count;
        searchPt.effectID = searchPtOut.effectID;
        base.Init(pt, owner);
    }
    //---------------------------------------------------------------------------------------------
    public override void Apply(int applyTime, float aniDelayTime)
    {
        base.Apply(applyTime);

        Logger.Log("[SpellService]trigger search effect");
        EffectSearchPrototype searchProt = protoEffect as EffectSearchPrototype;
        List<GameUnit> unitList = spellService.GetUnitList(searchProt.camp);
        foreach (GameUnit unit in unitList)
        {
            Effect curEffect = spellService.GetEffect(searchProt.effectID);
            if (curEffect != null)
            {
                curEffect.SetOwnedBuff(ownedBuff);
                curEffect.SetOwnedSpell(ownedSpell);
                curEffect.targetID = unit.pbUnit.guid;
                curEffect.Apply(applyTime);
            }
        }
    }
    //---------------------------------------------------------------------------------------------
}
