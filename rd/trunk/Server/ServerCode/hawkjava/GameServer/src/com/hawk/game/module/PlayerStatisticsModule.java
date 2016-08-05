package com.hawk.game.module;

import java.util.Calendar;
import java.util.List;

import org.hawk.config.HawkConfigManager;
import org.hawk.msg.HawkMsg;
import org.hawk.os.HawkTime;

import com.hawk.game.config.InstanceEntryCfg;
import com.hawk.game.config.PlayerAttrCfg;
import com.hawk.game.entity.StatisticsEntity;
import com.hawk.game.log.BehaviorLogger.Action;
import com.hawk.game.player.Player;
import com.hawk.game.player.PlayerModule;
import com.hawk.game.util.GsConst;

/**
 * 统计模块
 * 
 * @author walker
 */
public class PlayerStatisticsModule  extends PlayerModule {

	public PlayerStatisticsModule(Player player) {
		super(player);
	}

	@Override
	protected boolean onPlayerLogin() {
		// 加载统计数据
		StatisticsEntity statisticsEntity = player.getPlayerData().loadStatistics();

		// 首次登陆，初始化数据
		if (statisticsEntity.getLoginCount() == 0) {
			player.onFirstLogin();
		}

		// 登录时更新数据
		player.updateSkillPoint();
		player.updateFatigue();

		statisticsEntity.addLoginCount();
		statisticsEntity.notifyUpdate(true);

		// 同步统计信息
		player.getPlayerData().syncStatisticsInfo();
		return true;
	}

	@Override
	protected boolean onPlayerReconnect(HawkMsg msg) {
		// 登录时更新数据
		player.updateSkillPoint();
		player.updateFatigue();

		// 同步统计信息
		player.getPlayerData().syncStatisticsInfo();
		return true;
	}

	@Override
	protected boolean onPlayerLogout() {
		StatisticsEntity statisticsEntity = player.getPlayerData().getStatisticsEntity();

		Calendar loginTime = player.getEntity().getLoginTime();
		Calendar logoutTime = player.getEntity().getLogoutTime();
		long onlineTime = logoutTime.getTimeInMillis() - loginTime.getTimeInMillis();
		statisticsEntity.addTotalOnlineTime(onlineTime);

		statisticsEntity.notifyUpdate(false);
		return true;
	}

	@Override
	protected boolean onRefresh(List<Integer> refreshIndexList) {
		// 刷新统计数据，保证其它模块刷新时数据时间一致
		StatisticsEntity statisticsEntity = player.getPlayerData().getStatisticsEntity();

		for (int index : refreshIndexList) {
			int mask = GsConst.PlayerRefreshMask[index];
			statisticsEntity.clearAlliancePrayCountDaily();
			
			if (0 != (mask & GsConst.RefreshMask.DAILY )) {
				statisticsEntity.clearAdventureCountDaily();
				statisticsEntity.clearArenaCountDaily();
				statisticsEntity.clearBossrushCountDaily();
				statisticsEntity.clearCoinOrderCountDaily();
				statisticsEntity.clearEquipUpCountDaily();
				statisticsEntity.clearExploreCountDaily();
				statisticsEntity.clearFatigueClaimCountDaily();
				statisticsEntity.clearHardCountDaily();
				statisticsEntity.clearInstanceAllCountDaily();
				statisticsEntity.clearInstanceCountDaily();
				statisticsEntity.clearInstanceResetCountDaily();
				statisticsEntity.clearItemUseCountDaily();
				statisticsEntity.clearMonsterMixCountDaily();
				statisticsEntity.clearQuestCompleteDaily();
				statisticsEntity.clearSkillUpCountDaily();
				statisticsEntity.clearHoleCountDaily();

				statisticsEntity.notifyUpdate(true);
				player.getPlayerData().syncDailyRefreshInfo();

			} else if (0 != (mask & GsConst.RefreshMask.TOWER)) {
				statisticsEntity.clearTowerIndexMap();
				statisticsEntity.notifyUpdate(true);
				player.getPlayerData().syncMonthlyRefreshInfo();
			}
		}

		return true;
	}

}
