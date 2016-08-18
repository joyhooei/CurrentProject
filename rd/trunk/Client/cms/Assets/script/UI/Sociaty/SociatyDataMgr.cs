﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void NetMessageDelegate(ProtocolMessage msg);
public class SociatyDataMgr : MonoBehaviour
{
    public int allianceID = 0;
    public PB.AllianceInfo allianceData = new PB.AllianceInfo();
    public PB.AllianceMember allianceSelfData = new PB.AllianceMember();
    public bool[] hasReceivContributionReword = new bool[3];

    public List<PB.AllianceMember> allianceMemberList = new List<PB.AllianceMember>();
    public int lastSyncAllianceMemberTime = 0;

    public List<PB.AllianceApply> newApplyList = new List<PB.AllianceApply>();

    private NetMessageDelegate callBack = null;
    // Use this for initialization
    void Start ()
    {
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_DATA_S.GetHashCode().ToString(), OnAllianceDataSync);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_SELF_DATA_S.GetHashCode().ToString(),OnSelfAllianceDataSync);

        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_APPLY_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_APPLY_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_CANCLE_APPLY_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_CANCLE_APPLY_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_NOTICE_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_NOTICE_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_CONTRI_REWARD_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_CONTRI_REWARD_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_HANDLE_APPLY_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_HANDLE_APPLY_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_FATIGUE_GIVE_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.AddListener<ProtocolMessage>(PB.code.ALLIANCE_FATIGUE_GIVE_S.GetHashCode().ToString(), OnReceivSociatyMessage);
    }


    void OnDestroy()
    {
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_DATA_S.GetHashCode().ToString(), OnAllianceDataSync);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_SELF_DATA_S.GetHashCode().ToString(),OnSelfAllianceDataSync);

        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_APPLY_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_APPLY_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_CANCLE_APPLY_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_CANCLE_APPLY_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_NOTICE_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_NOTICE_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_CONTRI_REWARD_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_CONTRI_REWARD_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_HANDLE_APPLY_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_HANDLE_APPLY_S.GetHashCode().ToString(), OnReceivSociatyMessage);

        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_FATIGUE_GIVE_C.GetHashCode().ToString(), OnReceivSociatyMessage);
        GameEventMgr.Instance.RemoveListener<ProtocolMessage>(PB.code.ALLIANCE_FATIGUE_GIVE_S.GetHashCode().ToString(), OnReceivSociatyMessage);

    }
	
    //打开公会
    public  void    OpenSociaty(string search = null)
    {
        if(allianceID < 1)
        {
            SociatyList.OpenWith(search);
        }
        else
        {
            SociatyMain.OpenWith();
        }
    }

    public void ClearSociaty()
    {
        allianceMemberList.Clear();
        allianceID = 0;
    }

    void OnAllianceDataSync(ProtocolMessage msg)
    {
        PB.HSAllianceDataRet data = msg.GetProtocolBody<PB.HSAllianceDataRet>();
        if(null != data)
        {
            allianceData = data.allianceData;
        }
    }

    void OnSelfAllianceDataSync(ProtocolMessage msg)
    {
        PB.HSAllianceSelfDataRet selfData = msg.GetProtocolBody<PB.HSAllianceSelfDataRet>();
        if(selfData != null)
        {
            allianceSelfData = selfData.selfData;
            hasReceivContributionReword[0] = (selfData.contributionReward & 1) == 1;
            hasReceivContributionReword[1] = (selfData.contributionReward & 2) == 2;
            hasReceivContributionReword[2] = (selfData.contributionReward & 4) == 4;
        }
    }


    void OnReceivSociatyMessage(ProtocolMessage msg)
    {
        if(null != callBack)
        {
            callBack(msg);
        }
    }

    public  void RequestCancelApply(int allianceId, NetMessageDelegate callBack)
    {
        PB.HSAllianceCancleApply param = new PB.HSAllianceCancleApply();
        param.allianceId = allianceId;
        this.callBack = callBack;

        GameApp.Instance.netManager.SendMessage(PB.code.ALLIANCE_CANCLE_APPLY_C.GetHashCode(), param);
    }


    public  void RequestApply(int allianceId, NetMessageDelegate callBack)
    {
        PB.HSAllianceApply param = new PB.HSAllianceApply();
        param.allianceId = allianceId;
        this.callBack = callBack;

        GameApp.Instance.netManager.SendMessage(PB.code.ALLIANCE_APPLY_C.GetHashCode(), param);
    }


    public bool CheckNotify(string msg)
    {
        return true;
    }

    public void RequestModifyNotify(string newNotify, NetMessageDelegate callBack)
    {
        this.callBack = callBack;
        PB.HSAllianceNotice param = new PB.HSAllianceNotice();
        param.notice = newNotify;
        GameApp.Instance.netManager.SendMessage(PB.code.ALLIANCE_NOTICE_C.GetHashCode(), param);
    }

    public  void    RequestContributionReward(int index, NetMessageDelegate callBack)
    {
        this.callBack = callBack;
        PB.HSAllianceContriReward param = new PB.HSAllianceContriReward();
        param.index = index;
        GameApp.Instance.netManager.SendMessage(PB.code.ALLIANCE_CONTRI_REWARD_C.GetHashCode(), param);
    }

    public void RequestApplyOperate(int playerId,bool accept,bool isAll, NetMessageDelegate callBack)
    {
        this.callBack = callBack;
        PB.HSAllianceHanleApply param = new PB.HSAllianceHanleApply();
        param.accept = accept;
        param.isAll = isAll;
        if(!isAll)
        {
            param.playerId = playerId;
        }
        GameApp.Instance.netManager.SendMessage(PB.code.ALLIANCE_HANDLE_APPLY_C.GetHashCode(), param);
    }

    public void RequestSendHuoli(int playerId, NetMessageDelegate callBack)
    {
        this.callBack = callBack;
        PB.HSAllianceFatigueGive param = new PB.HSAllianceFatigueGive();
        param.targetId = playerId;
        GameApp.Instance.netManager.SendMessage(PB.code.ALLIANCE_FATIGUE_GIVE_C.GetHashCode(), param);
    }

    public  void SetMemberPosition(int playerId,int position)
    {
        foreach(var subMember in allianceMemberList)
        {
            if(subMember.id == playerId)
            {
                subMember.postion = position;
                break;
            }
        }
    }

    public string GetPositionDesc(int position)
    {
        switch(position)
        {
            case 0:
                return StaticDataMgr.Instance.GetTextByID("sociaty_member");
            case 1:
                return StaticDataMgr.Instance.GetTextByID("sociaty_vicechairman");
            case 2:
                return StaticDataMgr.Instance.GetTextByID("sociaty_chairman");
        }
        return "";
    }
}
