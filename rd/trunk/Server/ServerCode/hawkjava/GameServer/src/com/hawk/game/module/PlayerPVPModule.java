package com.hawk.game.module;

import org.hawk.app.HawkApp;
import org.hawk.msg.HawkMsg;
import org.hawk.net.protocol.HawkProtocol;
import org.hawk.xid.HawkXID;

import com.hawk.game.entity.MonsterEntity;
import com.hawk.game.entity.PVPDefenceRecordEntity;
import com.hawk.game.entity.PVPRankEntity;
import com.hawk.game.manager.PVPManager;
import com.hawk.game.player.Player;
import com.hawk.game.player.PlayerModule;
import com.hawk.game.protocol.Const;
import com.hawk.game.protocol.HS;
import com.hawk.game.protocol.PVP.HSGetPVPDefenceMonsterRet;
import com.hawk.game.protocol.PVP.HSPVPDefenceRecordRet;
import com.hawk.game.protocol.PVP.HSPVPInfoRet;
import com.hawk.game.protocol.PVP.PVPDefenceRecordData;
import com.hawk.game.protocol.Status;
import com.hawk.game.protocol.Monster.HSMonster;
import com.hawk.game.protocol.Monster.HSMonsterDefence;
import com.hawk.game.protocol.PVP.HSSetPVPDefenceMonster;
import com.hawk.game.protocol.PVP.HSSetPVPDefenceMonsterRet;
import com.hawk.game.util.BuilderUtil;
import com.hawk.game.util.GsConst;

public class PlayerPVPModule extends PlayerModule{
	
	public PlayerPVPModule(Player player) {
		super(player);
		listenProto(HS.code.PVP_MATCH_TARGET_C_VALUE);
		listenProto(HS.code.PVP_SETTLE_C_VALUE);
		listenProto(HS.code.PVP_SET_DEFENCE_MONSTERS_C_VALUE);
		listenProto(HS.code.PVP_GET_DEFENCE_MONSTERS_C_VALUE);
		listenProto(HS.code.PVP_RANK_LIST_C_VALUE);
		listenProto(HS.code.PVP_DEFENCE_RECORD_C_VALUE);
		listenProto(HS.code.PVP_GET_MY_INFO_C_VALUE);
		listenMsg(GsConst.MsgType.PVP_RECORD);
	}
	
	/**
	 * 玩家上线处理
	 * 
	 * @return
	 */
	protected boolean onPlayerLogin() {
		player.getPlayerData().loadPVPDefenceData();	
		player.getPlayerData().loadPVPDefenceRecordData();
		player.getPlayerData().syncPVPDefenceInfo();
		return true;	
	}
	
	/**
	 * 处理玩家下线
	 */
	protected boolean onPlayerLogout() {
		// 更新宠物信息
		HSMonsterDefence.Builder monstersBuilder = HSMonsterDefence.newBuilder();
		if (player.getPlayerData().getPVPDefenceEntity().hasSetDefenceMonsters()) {
			for (HSMonster monster : player.getPlayerData().getPVPDefenceEntity().getMonsterDefenceBuilder().getMonsterInfoList()) {
				MonsterEntity monsterEntity = player.getPlayerData().getMonsterEntity(monster.getMonsterId());
				if (monsterEntity != null) {
					monstersBuilder.addMonsterInfo(BuilderUtil.genMonsterBuilder(monsterEntity, null));
				}
			}
		}
		
		player.getPlayerData().getPVPDefenceEntity().setLevel(player.getLevel());
		player.getPlayerData().getPVPDefenceEntity().setMonsterDefenceBuilder(monstersBuilder);
		player.getPlayerData().getPVPDefenceEntity().notifyUpdate(true);
		return true;
	}
	
	/**
	 * 协议响应
	 * 
	 * @param protocol
	 * @return
	 */
	@Override
	public boolean onProtocol(HawkProtocol protocol) {
		if (protocol.getType() == HS.code.PVP_MATCH_TARGET_C_VALUE) {
	 		HawkMsg msg = HawkMsg.valueOf(GsConst.MsgType.PVP_MATCH_TARGET, HawkXID.valueOf( GsConst.ObjType.MANAGER, GsConst.ObjId.PVP));
	 		msg.pushParam(player);
	 		msg.pushParam(protocol);
			HawkApp.getInstance().postMsg(msg);
			return true;
		}
		else if (protocol.getType() == HS.code.PVP_SETTLE_C_VALUE) {
	 		HawkMsg msg = HawkMsg.valueOf(GsConst.MsgType.PVP_SETTLE, HawkXID.valueOf( GsConst.ObjType.MANAGER, GsConst.ObjId.PVP));
	 		msg.pushParam(player);
	 		msg.pushParam(protocol);
			HawkApp.getInstance().postMsg(msg);
			return true;
		}
		else if (protocol.getType() == HS.code.PVP_RANK_LIST_C_VALUE) {
			HawkMsg msg = HawkMsg.valueOf(GsConst.MsgType.PVP_RANK_LIST, HawkXID.valueOf( GsConst.ObjType.MANAGER, GsConst.ObjId.PVP));
	 		msg.pushParam(player);
	 		msg.pushParam(protocol);
			HawkApp.getInstance().postMsg(msg);
			return true;
		}
		else if (protocol.getType() == HS.code.PVP_SET_DEFENCE_MONSTERS_C_VALUE) {
			onSetDefenceMonsters(protocol);
		}
		else if (protocol.getType() == HS.code.PVP_GET_DEFENCE_MONSTERS_C_VALUE) {
			onGetDefenceMonsters(protocol);
		}
		else if (protocol.getType() == HS.code.PVP_DEFENCE_RECORD_C_VALUE) {
			onGetPVPDefenceRecord(protocol);
		}
		else if (protocol.getType() == HS.code.PVP_GET_MY_INFO_C_VALUE) {
			onGetPVPMyInfo(protocol);
		}
		
		return false;
	}
	
	/**
	 * 设置防守阵容
	 * @param cmd
	 * @return
	 */
	private boolean onSetDefenceMonsters(HawkProtocol cmd) {
		HSSetPVPDefenceMonster protocol = cmd.parseProtocol(HSSetPVPDefenceMonster.getDefaultInstance());

		HSMonsterDefence.Builder monstersBuilder = HSMonsterDefence.newBuilder();
		for (int monsterId : protocol.getMonsterIdList()) {
			MonsterEntity monsterEntity = player.getPlayerData().getMonsterEntity(monsterId);
			if (monsterEntity != null) {
				monstersBuilder.addMonsterInfo(BuilderUtil.genMonsterBuilder(monsterEntity, null));
			}
			else {
				sendError(HS.code.PVP_SET_DEFENCE_MONSTERS_C_VALUE, Status.monsterError.MONSTER_NOT_EXIST_VALUE);
				return true;
			}
		}
		
		if (player.getPlayerData().getPVPDefenceEntity().hasSetDefenceMonsters()) {
			for (HSMonster monster : player.getPlayerData().getPVPDefenceEntity().getMonsterDefenceBuilder().getMonsterInfoList()) {
				MonsterEntity monsterEntity = player.getPlayerData().getMonsterEntity(monster.getMonsterId());
				if (monsterEntity != null) {
					monsterEntity.removeState(Const.MonsterState.IN_PVP_DEFENCE_VALUE);
					monsterEntity.notifyUpdate(true);
				}
			}
		}
		
		for (int monsterId : protocol.getMonsterIdList()) {
			MonsterEntity monsterEntity = player.getPlayerData().getMonsterEntity(monsterId);
			if (monsterEntity != null) {
				monsterEntity.addState(Const.MonsterState.IN_PVP_DEFENCE_VALUE);
				monsterEntity.notifyUpdate(true);
			}
		}
		
		player.getPlayerData().getPVPDefenceEntity().setMonsterDefenceBuilder(monstersBuilder);
		player.getPlayerData().getPVPDefenceEntity().notifyUpdate(true);
		
		HSSetPVPDefenceMonsterRet.Builder response = HSSetPVPDefenceMonsterRet.newBuilder();
		sendProtocol(HawkProtocol.valueOf(HS.code.PVP_SET_DEFENCE_MONSTERS_S_VALUE, response));
		
		return true;
	}
	
	/**
	 * 获取防守阵容
	 * @param cmd
	 * @return
	 */
	private boolean onGetDefenceMonsters(HawkProtocol cmd) {
		HSGetPVPDefenceMonsterRet.Builder response = HSGetPVPDefenceMonsterRet.newBuilder();
		for (HSMonster.Builder monster : player.getPlayerData().getPVPDefenceEntity().getMonsterDefenceBuilder().getMonsterInfoBuilderList()) {
			response.addMonsterId(monster.getMonsterId());
		}
		
		sendProtocol(HawkProtocol.valueOf(HS.code.PVP_GET_DEFENCE_MONSTERS_S_VALUE, response));
		
		return true;
	}
	
	private boolean onGetPVPDefenceRecord(HawkProtocol cmd){
		HSPVPDefenceRecordRet.Builder response = HSPVPDefenceRecordRet.newBuilder();
		
		for (PVPDefenceRecordEntity pvpDefenceRecordEntity : player.getPlayerData().getPVPDefenceRecordList()) {
			PVPDefenceRecordData.Builder pvpDefenceRecordData = PVPDefenceRecordData.newBuilder();
			pvpDefenceRecordData.setAttacker(pvpDefenceRecordEntity.getAttackerName());
			pvpDefenceRecordData.setPoint(pvpDefenceRecordEntity.getPoint());
			pvpDefenceRecordData.setGrade(pvpDefenceRecordEntity.getAttackerGrade());
			pvpDefenceRecordData.setLevel(pvpDefenceRecordEntity.getAttackerLevel());
			pvpDefenceRecordData.setResult(pvpDefenceRecordEntity.getResult());
			
			response.addPvpDefenceRecordList(pvpDefenceRecordData);
			
			if (response.getPvpDefenceRecordListCount() >= GsConst.PVP.PVP_DEFENCE_RECORD_SIZE) {
				break;
			}
		}
		
		sendProtocol(HawkProtocol.valueOf(HS.code.PVP_DEFENCE_RECORD_S_VALUE, response));
		return true;
	}
	
	private boolean onGetPVPMyInfo(HawkProtocol cmd){
		HSPVPInfoRet.Builder response = HSPVPInfoRet.newBuilder();
		PVPRankEntity rankEntity = PVPManager.getInstance().getPVPRankEntity(player.getId());
		if (rankEntity != null) {
			response.setPvpPoint(rankEntity.getPoint());
			response.setPvpRank(rankEntity.getRank() + 1);
		}
		sendProtocol(HawkProtocol.valueOf(HS.code.PVP_GET_MY_INFO_S_VALUE, response));
		return true;
	}
	
	@Override
	public boolean onMessage(HawkMsg msg) {
		if(msg.getMsg() == GsConst.MsgType.PVP_RECORD){
			onPVPRecord(msg);
			return true;
		}
		
		return super.onMessage(msg);
	}
	
	private boolean onPVPRecord(HawkMsg msg) {
		PVPDefenceRecordEntity pvpDefenceRecordEntity = msg.getParam(0);
		player.getPlayerData().addPVPDefenceRecord(pvpDefenceRecordEntity);
		return true;
	}
}
