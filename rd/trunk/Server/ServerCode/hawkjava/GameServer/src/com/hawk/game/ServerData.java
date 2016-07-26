package com.hawk.game;

import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.atomic.AtomicInteger;

import org.hawk.db.HawkDBManager;
import org.hawk.log.HawkLog;
import org.hawk.os.HawkException;
import org.hawk.os.HawkTime;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

/**
 * 服务器数据
 * 
 * @author hawk
 */
public class ServerData {
	/**
	 * 日志记录器
	 */
	private static final Logger logger = LoggerFactory.getLogger("Server");
	/**
	 * 注册玩家数
	 */
	private AtomicInteger registerPlayer;
	/**
	 * 在线玩家数
	 */
	private AtomicInteger onlinePlayer;
	/**
	 * puid和玩家id的映射表
	 */
	protected Map<String, Integer> puidMap;
	/**
	 * 玩家名和玩家id的映射表
	 */
	protected Map<String, Integer> nameMap;
	/**
	 * 所有玩家列表
	 */
	protected Map<Integer, Integer> playerMap;
	/**
	 * 
	 */
	protected Set<String> rechargeList;
	/**
	 * 在线玩家列表
	 */
	protected Map<Integer, Integer> onlineMap;
	/**
	 * 无效设备
	 */
	protected Map<String, String> disablePhoneMap;
	/**
	 * 上次信息显示时间
	 */
	protected int lastShowTime = 0;

	/**
	 * 全局对象实例
	 */
	private static ServerData instance = null;

	/**
	 * 获取全局实例对象
	 * 
	 * @return
	 */
	public static ServerData getInstance() {
		if (instance == null) {
			instance = new ServerData();
		}
		return instance;
	}

	/**
	 * 构造
	 */
	private ServerData() {
		registerPlayer = new AtomicInteger();
		onlinePlayer = new AtomicInteger();
		puidMap = new ConcurrentHashMap<String, Integer>();
		nameMap = new ConcurrentHashMap<String, Integer>();
		playerMap = new ConcurrentHashMap<Integer, Integer>();
		onlineMap = new ConcurrentHashMap<Integer, Integer>();
		disablePhoneMap = new ConcurrentHashMap<String, String>();
		rechargeList = Collections.synchronizedSet(new HashSet<String>());
		lastShowTime = HawkTime.getSeconds();
	}

	/**
	 * 初始化服务器数据
	 * 
	 * @return
	 */
	public boolean init() {
		// 从db拉取玩家个数
		try {
			HawkLog.logPrintln("load player count from db......");
			long count = HawkDBManager.getInstance().count("select count(*) from PlayerEntity");
			registerPlayer.set((int) count);
		} catch (Exception e) {
			HawkException.catchException(e);
			return false;
		}

		// 从db拉取玩家puid和id的映射表
		try {
			HawkLog.logPrintln("load puid and playerId from db......");
			List<Object> rowInfos = HawkDBManager.getInstance().executeQuery("select puid, id from player");
			for (Object rowInfo : rowInfos) {
				Object[] colInfos = (Object[]) rowInfo;
				addPuidAndPlayerId((String) colInfos[0], (Integer) colInfos[1]);
				addPlayerId((Integer) colInfos[1]);
			}
		} catch (Exception e) {
			HawkException.catchException(e);
			return false;
		}

		//
		try {
			HawkLog.logPrintln("load orderSerial from db......");
			List<Object> rowInfos = HawkDBManager.getInstance().executeQuery("select orderSerial from recharge");
			for (Object rowInfo : rowInfos) {
				addOrderSerial((String)rowInfo);
			}
		} catch (Exception e) {
			HawkException.catchException(e);
			return false;
		}

		
		// 从db拉取玩家name和id的映射表
		try {
			HawkLog.logPrintln("load nickname and playerId from db......");
			List<Object> rowInfos = HawkDBManager.getInstance().executeQuery("select nickname, id from player ");
			for (Object rowInfo : rowInfos) {
				Object[] colInfos = (Object[]) rowInfo;
				addNameAndPlayerId((String) colInfos[0], (Integer) colInfos[1]);
			}
		} catch (Exception e) {
			HawkException.catchException(e);
			return false;
		}

		return true;
	}

	/**
	 * 增加注册玩家数
	 * 
	 * @return
	 */
	public int addRegisterPlayer() {
		return registerPlayer.addAndGet(1);
	}

	/**
	 * 获取注册玩家数
	 * 
	 * @return
	 */
	public int getRegisterPlayer() {
		return registerPlayer.get();
	}

	/**
	 * 增加在线玩家数
	 * 
	 * @return
	 */
	public int addOnlinePlayer() {
		return onlinePlayer.addAndGet(1);
	}

	/**
	 * 获取在线玩家数
	 * 
	 * @return
	 */
	public int getOnlinePlayer() {
		return onlinePlayer.get();
	}

	/**
	 * 通过puid获取玩家id
	 * 
	 * @param puid
	 * @return
	 */
	public int getPlayerIdByPuid(String puid) {
		if (puidMap.containsKey(puid)) {
			return puidMap.get(puid);
		}
		return 0;
	}

	/**
	 * 增加puid和玩家id的映射
	 * 
	 * @param puid
	 * @param playerId
	 */
	public void addPuidAndPlayerId(String puid, int playerId) {
		puidMap.put(puid, playerId);
	}

	/**
	 * 增加name和玩家id的映射
	 * 
	 * @param name
	 * @param playerId
	 */
	public void addNameAndPlayerId(String name, int playerId) {
		nameMap.put(name.toLowerCase(), playerId);
	}

	/**
	 * 增加玩家Id
	 * @param playerId
	 */
	public void addPlayerId(int playerId) {
		playerMap.put(playerId, playerId);
	}

	/**
	 * 是否存在玩家
	 */
	public boolean isExistPlayer(int playerId) {
		return playerMap.containsKey(playerId);
	}

	/**
	 * 获取所有玩家Id
	 */
	public Set<Integer> getAllPlayerIdSet() {
		return playerMap.keySet();
	}

	/**
	 * 增加order
	 * @param 
	 */
	public void addOrderSerial(String orderSerial) {
		rechargeList.add(orderSerial);
	}

	/**
	 * 是否order
	 */
	public boolean isExistOrder(String orderSerial) {
		return rechargeList.contains(orderSerial);
	}
	
	
	/**
	 * 是否存在名字
	 * @param name
	 * @return
	 */
	public boolean isExistName(String name) {
		return nameMap.containsKey(name.toLowerCase());
	}

	/**
	 * 添加在线id
	 * 
	 * @param playerId
	 */
	public void addOnlinePlayerId(int playerId) {
		onlineMap.put(playerId, playerId);
	}

	/**
	 * 移除在线id
	 * 
	 * @param playerId
	 */
	public void removeOnlinePlayerId(int playerId) {
		try {
			onlineMap.remove(playerId);
		} catch (Exception e) {
			HawkException.catchException(e);
		}
	}

	/**
	 * 玩家在线判断
	 * 
	 * @param playerId
	 * @return
	 */
	public boolean isPlayerOnline(int playerId) {
		return onlineMap.containsKey(playerId);
	}

	/**
	 * 添加禁用设备
	 * 
	 * @param phoneInfo
	 */
	public void addDisablePhone(String phoneInfo) {
		disablePhoneMap.put(phoneInfo, phoneInfo);
	}

	/**
	 * 是否为禁用设备
	 * 
	 * @param phoneInfo
	 * @return
	 */
	public boolean isDisablePhone(String phoneInfo) {
		return disablePhoneMap.containsKey(phoneInfo);
	}

	/**
	 * 清空无效设备信息
	 */
	public void clearDisablePhone() {
		disablePhoneMap.clear();
	}

	/**
	 * 打印服务器状态信息
	 */
	public void showServerInfo() {
		// 每分钟显示一个服务器信息
		if (HawkTime.getSeconds() - lastShowTime >= 60) {
			lastShowTime = HawkTime.getSeconds();
			// 记录信息
			logger.info("online user: {}", onlineMap.size());
		}
	}
}
