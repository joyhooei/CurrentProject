package com.hawk.game.config;

import java.util.ArrayList;
import java.util.List;

import org.hawk.config.HawkConfigBase;
import org.hawk.config.HawkConfigManager;

import com.hawk.game.util.InstanceUtil;

@HawkConfigManager.CsvResource(file = "xml/instanceEntry.csv", struct = "map")
public class InstanceEntryCfg extends HawkConfigBase {

	@Id
	protected final String id;
	protected final String name;
	protected final int chapter;
	protected final int type;
	protected final int difficulty;
	protected final int fatigue;
	protected final int count;
	protected final int level;
	protected final String enemy1;
	protected final String enemy2;
	protected final String enemy3;
	protected final String enemy4;
	protected final String enemy5;
	protected final String enemy6;
	protected final int reward1;
	protected final int reward2;
	protected final int reward3;
	protected final int reward4;
	protected final int reward5;
	protected final int reward6;
	
	// client only
	protected final String desc= null;

	// assemble
	protected List<MonsterCfg> enemyList;
	protected List<RewardCfg> rewardList;

	public InstanceEntryCfg() {
		id = "";
		name = "";
		chapter = 0;
		type = 0;
		difficulty = 0;
		fatigue = 0;
		count = 0;
		level = 0;
		enemy1= enemy2 = enemy3= enemy4 = enemy5= enemy6 = "";
		reward1 = reward2 = reward3 = reward4 = reward5 = reward6 = 0;
	}
	
	@Override
	protected boolean assemble() {
		// 计算InstanceChapter
		InstanceUtil.addInstance(this);
		
		enemyList = new ArrayList<MonsterCfg>();
		rewardList = new ArrayList<RewardCfg>();
		return true;
	}
	
	@Override
	protected boolean checkValid() {
		// 检测敌人是否存在，并建立引用
		if (enemy1 != "") {
			MonsterCfg enemy = HawkConfigManager.getInstance().getConfigByKey(MonsterCfg.class, enemy1);
			if (null == enemy) {
				return false;
			}
			enemyList.add(enemy);
		}
		if (enemy2 != "") {
			MonsterCfg enemy = HawkConfigManager.getInstance().getConfigByKey(MonsterCfg.class, enemy2);
			if (null == enemy) {
				return false;
			}
			enemyList.add(enemy);
		}
		if (enemy3 != "") {
			MonsterCfg enemy = HawkConfigManager.getInstance().getConfigByKey(MonsterCfg.class, enemy3);
			if (null == enemy) {
				return false;
			}
			enemyList.add(enemy);
		}
		if (enemy4 != "") {
			MonsterCfg enemy = HawkConfigManager.getInstance().getConfigByKey(MonsterCfg.class, enemy4);
			if (null == enemy) {
				return false;
			}
			enemyList.add(enemy);
		}
		if (enemy5 != "") {
			MonsterCfg enemy = HawkConfigManager.getInstance().getConfigByKey(MonsterCfg.class, enemy5);
			if (null == enemy) {
				return false;
			}
			enemyList.add(enemy);
		}
		if (enemy6 != "") {
			MonsterCfg enemy = HawkConfigManager.getInstance().getConfigByKey(MonsterCfg.class, enemy6);
			if (null == enemy) {
				return false;
			}
			enemyList.add(enemy);
		}
		
		// 检测奖励是否存在，并建立引用
		if (reward1 != 0) {
			RewardCfg reward = HawkConfigManager.getInstance().getConfigByKey(RewardCfg.class, reward1);
			if (null == reward) {
				return false;
			}
			rewardList.add(reward);
		}
		if (reward2 != 0) {
			RewardCfg reward = HawkConfigManager.getInstance().getConfigByKey(RewardCfg.class, reward2);
			if (null == reward) {
				return false;
			}
			rewardList.add(reward);
		}
		if (reward3 != 0) {
			RewardCfg reward = HawkConfigManager.getInstance().getConfigByKey(RewardCfg.class, reward3);
			if (null == reward) {
				return false;
			}
			rewardList.add(reward);
		}
		if (reward4 != 0) {
			RewardCfg reward = HawkConfigManager.getInstance().getConfigByKey(RewardCfg.class, reward4);
			if (null == reward) {
				return false;
			}
			rewardList.add(reward);
		}
		if (reward5 != 0) {
			RewardCfg reward = HawkConfigManager.getInstance().getConfigByKey(RewardCfg.class, reward5);
			if (null == reward) {
				return false;
			}
			rewardList.add(reward);
		}
		if (reward6 != 0) {
			RewardCfg reward = HawkConfigManager.getInstance().getConfigByKey(RewardCfg.class, reward6);
			if (null == reward) {
				return false;
			}
			rewardList.add(reward);
		}

		return true;
	}
	
	public String getInstanceId() {
		return id;
	}
	
	public String getName() {
		return name;
	}
	
	public int getChapter() {
		return chapter;
	}
	
	public int getType() {
		return type;
	}
	
	public int getDifficult() {
		return difficulty;
	}
	
	public int getFatigue() {
		return fatigue;
	}
	
	public int getCount() {
		return count;
	}
	
	public int getLevel() {
		return level;
	}
	
	public List<MonsterCfg> getEnemyList() {
		return enemyList;
	}
	
	public List<RewardCfg> getRewardList() {
		return rewardList;
	}
	
}
