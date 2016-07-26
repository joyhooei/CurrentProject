//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Status.proto
namespace PB
{
    [global::ProtoBuf.ProtoContract(Name=@"errorMask")]
    public enum errorMask
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_ERROR", Value=0)]
      NORMAL_ERROR = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_ERROR", Value=65536)]
      LOGIN_ERROR = 65536,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_ERROR", Value=131072)]
      PLAYER_ERROR = 131072,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_ERROR", Value=196608)]
      MONSTER_ERROR = 196608,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_ERROR", Value=262144)]
      ITEM_ERROR = 262144,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_ERROR", Value=327680)]
      QUEST_ERROR = 327680,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_ERROR", Value=393216)]
      INSTANCE_ERROR = 393216,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_ERROR", Value=458752)]
      MAIL_ERROR = 458752,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ERROR", Value=524288)]
      ALLIANCE_ERROR = 524288,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_ERROR", Value=589824)]
      SHOP_ERROR = 589824,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IM_ERROR", Value=1048576)]
      IM_ERROR = 1048576
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"error")]
    public enum error
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NONE_ERROR", Value=0)]
      NONE_ERROR = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONFIG_ERROR", Value=1)]
      CONFIG_ERROR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ONLINE_MAX_LIMIT", Value=2)]
      ONLINE_MAX_LIMIT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_MAX_LIMIT", Value=3)]
      REGISTER_MAX_LIMIT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_GRAY_STATE", Value=4)]
      SERVER_GRAY_STATE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DATA_BASE_ERROR", Value=5)]
      DATA_BASE_ERROR = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PARAMS_INVALID", Value=6)]
      PARAMS_INVALID = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONFIG_NOT_FOUND", Value=7)]
      CONFIG_NOT_FOUND = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNSUPPORT_ACTION", Value=8)]
      UNSUPPORT_ACTION = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SERVER_ERROR", Value=4096)]
      SERVER_ERROR = 4096
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"PlayerError")]
    public enum PlayerError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_NOT_EXIST", Value=131073)]
      PLAYER_NOT_EXIST = 131073,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER_NICKNAME_EXIST", Value=131074)]
      PLAYER_NICKNAME_EXIST = 131074,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PUID_EXIST", Value=131075)]
      PUID_EXIST = 131075,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COINS_NOT_ENOUGH", Value=131076)]
      COINS_NOT_ENOUGH = 131076,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOLD_NOT_ENOUGH", Value=131077)]
      GOLD_NOT_ENOUGH = 131077,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FATIGUE_NOT_ENOUGH", Value=131078)]
      FATIGUE_NOT_ENOUGH = 131078
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"monsterError")]
    public enum monsterError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_MAX_SIZE", Value=196609)]
      MONSTER_MAX_SIZE = 196609,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MONSTER_NOT_EXIST", Value=196610)]
      MONSTER_NOT_EXIST = 196610,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKILL_POINT_NOT_ENOUGH", Value=196611)]
      SKILL_POINT_NOT_ENOUGH = 196611,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKILL_LEVEL_LIMIT", Value=196612)]
      SKILL_LEVEL_LIMIT = 196612,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAGE_LIMIT", Value=196613)]
      STAGE_LIMIT = 196613,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAGE_LEVEL_NOT_ENOUGH", Value=196614)]
      STAGE_LEVEL_NOT_ENOUGH = 196614,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAGE_CONSUME", Value=196615)]
      STAGE_CONSUME = 196615,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BATTLE_MONSTER_COUNT", Value=196616)]
      BATTLE_MONSTER_COUNT = 196616
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"itemError")]
    public enum itemError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_NOT_FOUND", Value=262145)]
      ITEM_NOT_FOUND = 262145,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_NOT_FOUND", Value=262146)]
      EQUIP_NOT_FOUND = 262146,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_NOT_ENOUGH", Value=262147)]
      ITEM_NOT_ENOUGH = 262147,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_BUY_NOT_ALLOW", Value=262148)]
      ITEM_BUY_NOT_ALLOW = 262148,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ITEM_SELL_NOT_ALLOW", Value=262149)]
      ITEM_SELL_NOT_ALLOW = 262149,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_MAX_LEVEL_ALREADY", Value=262150)]
      EQUIP_MAX_LEVEL_ALREADY = 262150,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_LEVEL_NOT_ENOUGH", Value=262151)]
      EQUIP_LEVEL_NOT_ENOUGH = 262151,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_MAX_STAGE_ALREADY", Value=262152)]
      EQUIP_MAX_STAGE_ALREADY = 262152,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_DRESS_ALREADY", Value=262160)]
      EQUIP_DRESS_ALREADY = 262160,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_NOT_DRESS_OTHER", Value=262161)]
      EQUIP_NOT_DRESS_OTHER = 262161,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_DRESS_OTHER_ALREADY", Value=262162)]
      EQUIP_DRESS_OTHER_ALREADY = 262162,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_NOT_DRESSED", Value=262163)]
      EQUIP_NOT_DRESSED = 262163,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_SLOT_NOT_EMPTY", Value=262164)]
      EQUIP_SLOT_NOT_EMPTY = 262164,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_SLOT_EMPTY", Value=262165)]
      EQUIP_SLOT_EMPTY = 262165,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_GEM_NOT_FOUND", Value=262166)]
      EQUIP_GEM_NOT_FOUND = 262166,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_CAN_NOT_OPEN_SLOT", Value=262167)]
      EQUIP_CAN_NOT_OPEN_SLOT = 262167,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_GEM_MISMATCH", Value=262168)]
      EQUIP_GEM_MISMATCH = 262168,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP_SLOT_NOT_PUNCH", Value=262169)]
      EQUIP_SLOT_NOT_PUNCH = 262169
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"questError")]
    public enum questError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_NOT_ACCEPT", Value=327681)]
      QUEST_NOT_ACCEPT = 327681,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_NOT_COMPLETE", Value=327682)]
      QUEST_NOT_COMPLETE = 327682,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QUEST_NOT_OPEN", Value=327683)]
      QUEST_NOT_OPEN = 327683
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"instanceError")]
    public enum instanceError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_NOT_OPEN", Value=393217)]
      INSTANCE_NOT_OPEN = 393217,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_LEVEL", Value=393218)]
      INSTANCE_LEVEL = 393218,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_COUNT", Value=393219)]
      INSTANCE_COUNT = 393219,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_FATIGUE", Value=393220)]
      INSTANCE_FATIGUE = 393220,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INSTANCE_REVIVE_COUNT", Value=393221)]
      INSTANCE_REVIVE_COUNT = 393221
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"mailError")]
    public enum mailError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_NOT_EXIST", Value=458753)]
      MAIL_NOT_EXIST = 458753,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_NONE", Value=458754)]
      MAIL_NONE = 458754,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_COIN_FULL", Value=458755)]
      MAIL_COIN_FULL = 458755,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MAIL_GOLD_FULL", Value=458756)]
      MAIL_GOLD_FULL = 458756
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"allianceError")]
    public enum allianceError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_LEVEL_NOT_ENOUGH", Value=524289)]
      ALLIANCE_LEVEL_NOT_ENOUGH = 524289,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_ALREADY_IN", Value=524290)]
      ALLIANCE_ALREADY_IN = 524290,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NAME_ERROR", Value=524291)]
      ALLIANCE_NAME_ERROR = 524291,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NAME_EXIST", Value=524292)]
      ALLIANCE_NAME_EXIST = 524292,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ALLIANCE_NOT_JOIN", Value=524293)]
      ALLIANCE_NOT_JOIN = 524293
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"shopError")]
    public enum shopError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_REFRESH_TIMEOUT", Value=589825)]
      SHOP_REFRESH_TIMEOUT = 589825,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_ITEM_ALREADY_BUY", Value=589826)]
      SHOP_ITEM_ALREADY_BUY = 589826,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_REFRESH_MAX_COUNT", Value=589827)]
      SHOP_REFRESH_MAX_COUNT = 589827,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHOP_GOLD2COIN_MAX_COUNT", Value=589827)]
      SHOP_GOLD2COIN_MAX_COUNT = 589827
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"imError")]
    public enum imError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"IM_CHAT_LENGTH", Value=1048577)]
      IM_CHAT_LENGTH = 1048577
    }
  
}