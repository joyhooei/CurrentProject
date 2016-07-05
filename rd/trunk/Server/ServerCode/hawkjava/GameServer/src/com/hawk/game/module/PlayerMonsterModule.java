package com.hawk.game.module;

import java.util.List;
import java.util.Map;

import org.hawk.annotation.MessageHandler;
import org.hawk.annotation.ProtocolHandler;
import org.hawk.app.HawkApp;
import org.hawk.log.HawkLog;
import org.hawk.msg.HawkMsg;
import org.hawk.net.protocol.HawkProtocol;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.hawk.game.entity.MonsterEntity;
import com.hawk.game.entity.StatisticsEntity;
import com.hawk.game.player.Player;
import com.hawk.game.player.PlayerModule;
import com.hawk.game.protocol.Const.RewardReason;
import com.hawk.game.protocol.HS;
import com.hawk.game.protocol.Monster.HSMonster;
import com.hawk.game.protocol.Monster.HSMonsterAdd;
import com.hawk.game.protocol.Monster.HSMonsterBreakRet;
import com.hawk.game.protocol.Monster.HSMonsterCatch;
import com.hawk.game.protocol.Monster.HSMonsterFeed;
import com.hawk.game.protocol.Monster.HSMonsterFeedRet;
import com.hawk.game.protocol.Skill.HSSkill;
import com.hawk.game.protocol.Status;
import com.hawk.game.protocol.Monster.HSMonsterBreak;
import com.hawk.game.util.BuilderUtil;
import com.hawk.game.util.GsConst;
import com.hawk.game.util.ProtoUtil;

/**
 * 怪物模块
 * 
 * @author walker
 */
public class PlayerMonsterModule extends PlayerModule {

	private static final Logger logger = LoggerFactory.getLogger("Protocol");

	public PlayerMonsterModule(Player player) {
		super(player);
	}

	/**
	 * 怪物分解
	 */
	@ProtocolHandler(code = HS.code.MONSTER_BREAK_C_VALUE)
	private boolean onMonsterBreak(HawkProtocol cmd) {
		HSMonsterBreak protocol = cmd.parseProtocol(HSMonsterBreak.getDefaultInstance());
		int hsCode = cmd.getType();
		int monsterId = protocol.getMonsterId();

		MonsterEntity monsterEntity = player.getPlayerData().getMonsterEntity(monsterId);
		if (monsterEntity == null) {
			sendProtocol(ProtoUtil.genErrorProtocol(hsCode, Status.monsterError.MONSTER_NOT_EXIST_VALUE, 1));
			return false;
		}

		// TODO: break logic
		monsterEntity.setInvalid(true);

//		boolean succ = monsterEntity.updateSync();
//		if (succ == false) {
//			sendProtocol(ProtoUtil.genErrorProtocol(hsCode, Status.error.DATA_BASE_ERROR_VALUE, 1));
//			return false;
//		}
		monsterEntity.notifyUpdate(true);

		HSMonsterBreakRet.Builder response = HSMonsterBreakRet.newBuilder();
		response.setStatus(Status.error.NONE_ERROR_VALUE);
		response.setMonsterId(monsterId);
		sendProtocol(HawkProtocol.valueOf(HS.code.MONSTER_BREAK_S, response));
		return true;
	}

	/**
	 * 怪物喂养
	 */
	@ProtocolHandler(code = HS.code.MONSTER_FEED_C_VALUE)
	private boolean onMonsterFeed(HawkProtocol cmd) {
		HSMonsterFeed protocol = cmd.parseProtocol(HSMonsterFeed.getDefaultInstance());
		int hsCode = cmd.getType();
		int monsterId = protocol.getMonsterId();
		int foodMonsterId = protocol.getFoodMonsterId();

		MonsterEntity monsterEntity = player.getPlayerData().getMonsterEntity(monsterId);
		MonsterEntity foodMonsterEntity = player.getPlayerData().getMonsterEntity(foodMonsterId);
		if (monsterEntity == null || foodMonsterEntity == null) {
			sendProtocol(ProtoUtil.genErrorProtocol(hsCode, Status.monsterError.MONSTER_NOT_EXIST_VALUE, 1));
			return false;
		}

		// TODO: feed logic
		int exp = 0;
		int level = 0;
		foodMonsterEntity.setInvalid(true);

//		boolean succ = monsterEntity.updateSync();
//		if (succ == false) {
//			sendProtocol(ProtoUtil.genErrorProtocol(hsCode, Status.error.DATA_BASE_ERROR_VALUE, 1));
//			return false;
//		}
		foodMonsterEntity.notifyUpdate(true);
		monsterEntity.notifyUpdate(true);

		HSMonsterFeedRet.Builder response = HSMonsterFeedRet.newBuilder();
		response.setStatus(Status.error.NONE_ERROR_VALUE);
		response.setMonsterId(monsterId);
		response.setFoodMonsterId(foodMonsterId);
		response.setExp(exp);
		response.setLevel(level);
		sendProtocol(HawkProtocol.valueOf(HS.code.MONSTER_FEED_S, response));
		return true;
	}

	/**
	 * 怪物捕捉
	 */
	@ProtocolHandler(code = HS.code.MONSTER_CATCH_C_VALUE)
	private boolean onMonsterCatch(HawkProtocol cmd) {
		HSMonsterCatch protocol = cmd.parseProtocol(HSMonsterCatch.getDefaultInstance());
		// int hsCode = cmd.getType();
		int playerId = player.getId();
		String cfgId = protocol.getCfgId();
		int stage = protocol.getStage();
		int level = protocol.getLevel();
		int lazy = protocol.getLazy();
		int disposition = protocol.getDisposition();
		List<HSSkill> skillList = protocol.getSkillList();

		// TODO: catch logic 

		MonsterEntity monsterEntity = new MonsterEntity(cfgId, playerId, (byte)stage, (short)level, 0, (byte)lazy, 0, (byte)disposition);
		for (HSSkill skill : skillList) {
			monsterEntity.setSkillLevel(skill.getSkillId(), skill.getLevel());
		}

		return addMonster(RewardReason.CATCH, monsterEntity);
	}

	/**
	 * 奖励怪物
	 */
	@MessageHandler(code = GsConst.MsgType.PRESENT_MONSTER)
	private boolean onMonsterPresent(HawkMsg msg) {
		addMonster(RewardReason.SYS_PRESENT, (MonsterEntity)msg.getParam(0));
		return true;
	}

	// 内部函数--------------------------------------------------------------------------------------

	private boolean addMonster(RewardReason reason, MonsterEntity monsterEntity) {
		if (false == monsterEntity.notifyCreate()) {
			logger.error("database error, create monster entity fail");
			return false;
		}
		player.getPlayerData().setMonsterEntity(monsterEntity);

		HSMonsterAdd.Builder response = HSMonsterAdd.newBuilder();
		HSMonster.Builder monsterData = BuilderUtil.genMonsterBuilder(monsterEntity);
		response.setMonster(monsterData);
		response.setReason(reason);
		sendProtocol(HawkProtocol.valueOf(HS.code.MONSTER_ADD_S, response));
		
		// 统计数据
		StatisticsEntity statisticsEntity = player.getPlayerData().getStatisticsEntity(); 
		boolean update = false;
		
		// collection
		if (false == statisticsEntity.getMonsterCollectSet().contains(monsterEntity.getCfgId())) {
			statisticsEntity.addMonsterCollect(monsterEntity.getCfgId());
			update = true;
		}

		// level
		int level = monsterEntity.getLevel();
		int history = statisticsEntity.getMonsterCountOverLevel(level);
		int cur = player.getPlayerData().getMonsterCountOverLevel(level);
		if (cur > history) {
			statisticsEntity.setMonsterCountOverLevel(level, cur);
			update = true;
		}
		
		history = statisticsEntity.getMonsterMaxLevel();
		if (level > history) {
			statisticsEntity.setMonsterMaxLevel(level);
			update = true;
		}
		
		// stage
		int stage = monsterEntity.getStage();
		history = statisticsEntity.getMonsterCountOverStage(stage);
		cur = player.getPlayerData().getMonsterCountOverStage(stage);
		if (cur > history) {
			statisticsEntity.setMonsterCountOverStage(stage, cur);
			update = true;
		}
		
		history = statisticsEntity.getMonsterMaxStage();
		if (stage > history) {
			statisticsEntity.setMonsterMaxStage(stage);
			update = true;
		}
		
		// count
		history = statisticsEntity.getMonsterMaxCount();
		cur = player.getPlayerData().getMonsterEntityList().size();
		if (cur > history) {
			statisticsEntity.setMonsterMaxCount(cur);
			update = true;
		}
		
		if (true == update) {
			statisticsEntity.notifyUpdate(true);
			
			HawkMsg msg = HawkMsg.valueOf(GsConst.MsgType.STATISTICS_UPDATE, player.getXid());
			msg.pushParam(GsConst.StatisticsType.OTHER_STATISTICS);
			if (false == HawkApp.getInstance().postMsg(msg)) {
				HawkLog.errPrintln("post statistics update message failed: " + player.getName());
			}
		}

		return true;
	}

	@Override
	protected boolean onPlayerLogin() {
		// 加载所有怪物数据
		player.getPlayerData().loadAllMonster();
		// 同步怪物信息
		player.getPlayerData().syncMonsterInfo(0);
		return true;
	}

	@Override
	protected boolean onPlayerLogout() {
		// 重要数据下线就存储
		for (Map.Entry<Integer, MonsterEntity> entry : player.getPlayerData().getMonsterEntityList().entrySet()) {
			entry.getValue().notifyUpdate(false);
		}
		return true;
	}
}
