//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Player.proto
namespace PB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SynPlayerAttr")]
  public partial class SynPlayerAttr : global::ProtoBuf.IExtensible
  {
    public SynPlayerAttr() {}
    
    private int _gold = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private long _coin = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"coin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long coin
    {
      get { return _coin; }
      set { _coin = value; }
    }
    private int _towerCoin = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"towerCoin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int towerCoin
    {
      get { return _towerCoin; }
      set { _towerCoin = value; }
    }
    private int _contribution = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"contribution", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int contribution
    {
      get { return _contribution; }
      set { _contribution = value; }
    }
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _exp = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private int _fatigue = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"fatigue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int fatigue
    {
      get { return _fatigue; }
      set { _fatigue = value; }
    }
    private int _fatigueBeginTime = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"fatigueBeginTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int fatigueBeginTime
    {
      get { return _fatigueBeginTime; }
      set { _fatigueBeginTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerInfo")]
  public partial class PlayerInfo : global::ProtoBuf.IExtensible
  {
    public PlayerInfo() {}
    
    private int _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private string _nickname;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private int _career;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"career", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int career
    {
      get { return _career; }
      set { _career = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _exp;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private int _gold;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private long _coin;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"coin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long coin
    {
      get { return _coin; }
      set { _coin = value; }
    }
    private int _towerCoin;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"towerCoin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int towerCoin
    {
      get { return _towerCoin; }
      set { _towerCoin = value; }
    }
    private int _gender = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gender
    {
      get { return _gender; }
      set { _gender = value; }
    }
    private int _eye = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"eye", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int eye
    {
      get { return _eye; }
      set { _eye = value; }
    }
    private int _hair = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"hair", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hair
    {
      get { return _hair; }
      set { _hair = value; }
    }
    private int _hairColor = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"hairColor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hairColor
    {
      get { return _hairColor; }
      set { _hairColor = value; }
    }
    private int _recharge;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"recharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int recharge
    {
      get { return _recharge; }
      set { _recharge = value; }
    }
    private int _vipLevel;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"vipLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int vipLevel
    {
      get { return _vipLevel; }
      set { _vipLevel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSPlayerKickout")]
  public partial class HSPlayerKickout : global::ProtoBuf.IExtensible
  {
    public HSPlayerKickout() {}
    
    private int _reason;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSPlayerCreate")]
  public partial class HSPlayerCreate : global::ProtoBuf.IExtensible
  {
    public HSPlayerCreate() {}
    
    private string _puid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"puid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string puid
    {
      get { return _puid; }
      set { _puid = value; }
    }
    private string _nickname;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private int _career;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"career", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int career
    {
      get { return _career; }
      set { _career = value; }
    }
    private int _gender;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gender
    {
      get { return _gender; }
      set { _gender = value; }
    }
    private int _eye;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"eye", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int eye
    {
      get { return _eye; }
      set { _eye = value; }
    }
    private int _hair;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"hair", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hair
    {
      get { return _hair; }
      set { _hair = value; }
    }
    private int _hairColor;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"hairColor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hairColor
    {
      get { return _hairColor; }
      set { _hairColor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSPlayerCreateRet")]
  public partial class HSPlayerCreateRet : global::ProtoBuf.IExtensible
  {
    public HSPlayerCreateRet() {}
    
    private int _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private int _palyerID = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"palyerID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int palyerID
    {
      get { return _palyerID; }
      set { _palyerID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSPlayerInfoSync")]
  public partial class HSPlayerInfoSync : global::ProtoBuf.IExtensible
  {
    public HSPlayerInfoSync() {}
    
    private PlayerInfo _info;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public PlayerInfo info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSAssembleFinish")]
  public partial class HSAssembleFinish : global::ProtoBuf.IExtensible
  {
    public HSAssembleFinish() {}
    
    private int _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private int _allianceID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"allianceID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int allianceID
    {
      get { return _allianceID; }
      set { _allianceID = value; }
    }
    private int _contribution;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"contribution", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int contribution
    {
      get { return _contribution; }
      set { _contribution = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}