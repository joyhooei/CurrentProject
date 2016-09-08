//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Statistics.proto
namespace PB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InstanceState")]
  public partial class InstanceState : global::ProtoBuf.IExtensible
  {
    public InstanceState() {}
    
    private string _instanceId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"instanceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string instanceId
    {
      get { return _instanceId; }
      set { _instanceId = value; }
    }
    private int _star;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private int _countDaily = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"countDaily", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int countDaily
    {
      get { return _countDaily; }
      set { _countDaily = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChapterState")]
  public partial class ChapterState : global::ProtoBuf.IExtensible
  {
    public ChapterState() {}
    
    private int _normalTopChapter;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"normalTopChapter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int normalTopChapter
    {
      get { return _normalTopChapter; }
      set { _normalTopChapter = value; }
    }
    private int _normalTopIndex;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"normalTopIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int normalTopIndex
    {
      get { return _normalTopIndex; }
      set { _normalTopIndex = value; }
    }
    private int _hardTopChapter;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"hardTopChapter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hardTopChapter
    {
      get { return _hardTopChapter; }
      set { _hardTopChapter = value; }
    }
    private int _hardTopIndex;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"hardTopIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hardTopIndex
    {
      get { return _hardTopIndex; }
      set { _hardTopIndex = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _normalBoxState = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"normalBoxState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> normalBoxState
    {
      get { return _normalBoxState; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _hardBoxState = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"hardBoxState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> hardBoxState
    {
      get { return _hardBoxState; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RechargeState")]
  public partial class RechargeState : global::ProtoBuf.IExtensible
  {
    public RechargeState() {}
    
    private string _productId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"productId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string productId
    {
      get { return _productId; }
      set { _productId = value; }
    }
    private int _buyTimes;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"buyTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int buyTimes
    {
      get { return _buyTimes; }
      set { _buyTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemState")]
  public partial class ItemState : global::ProtoBuf.IExtensible
  {
    public ItemState() {}
    
    private string _itemId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"itemId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string itemId
    {
      get { return _itemId; }
      set { _itemId = value; }
    }
    private int _useCountDaily;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"useCountDaily", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int useCountDaily
    {
      get { return _useCountDaily; }
      set { _useCountDaily = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HoleState")]
  public partial class HoleState : global::ProtoBuf.IExtensible
  {
    public HoleState() {}
    
    private int _holeId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"holeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int holeId
    {
      get { return _holeId; }
      set { _holeId = value; }
    }
    private bool _isOpen;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"isOpen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isOpen
    {
      get { return _isOpen; }
      set { _isOpen = value; }
    }
    private int _countDaily = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"countDaily", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int countDaily
    {
      get { return _countDaily; }
      set { _countDaily = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TowerState")]
  public partial class TowerState : global::ProtoBuf.IExtensible
  {
    public TowerState() {}
    
    private int _towerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"towerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int towerId
    {
      get { return _towerId; }
      set { _towerId = value; }
    }
    private int _floor;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"floor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int floor
    {
      get { return _floor; }
      set { _floor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSStatisticsInfoSync")]
  public partial class HSStatisticsInfoSync : global::ProtoBuf.IExtensible
  {
    public HSStatisticsInfoSync() {}
    
    private readonly global::System.Collections.Generic.List<InstanceState> _instanceState = new global::System.Collections.Generic.List<InstanceState>();
    [global::ProtoBuf.ProtoMember(1, Name=@"instanceState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<InstanceState> instanceState
    {
      get { return _instanceState; }
    }
  
    private ChapterState _chapterState;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"chapterState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public ChapterState chapterState
    {
      get { return _chapterState; }
      set { _chapterState = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _monsterCollect = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"monsterCollect", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> monsterCollect
    {
      get { return _monsterCollect; }
    }
  
    private int _fatigue;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"fatigue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fatigue
    {
      get { return _fatigue; }
      set { _fatigue = value; }
    }
    private int _fatigueBeginTime;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"fatigueBeginTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fatigueBeginTime
    {
      get { return _fatigueBeginTime; }
      set { _fatigueBeginTime = value; }
    }
    private int _skillPoint;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"skillPoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skillPoint
    {
      get { return _skillPoint; }
      set { _skillPoint = value; }
    }
    private int _skillPointBeginTime;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"skillPointBeginTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skillPointBeginTime
    {
      get { return _skillPointBeginTime; }
      set { _skillPointBeginTime = value; }
    }
    private int _timeStamp = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"timeStamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int timeStamp
    {
      get { return _timeStamp; }
      set { _timeStamp = value; }
    }
    private string _orderServerKey;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"orderServerKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string orderServerKey
    {
      get { return _orderServerKey; }
      set { _orderServerKey = value; }
    }
    private readonly global::System.Collections.Generic.List<RechargeState> _rechargeState = new global::System.Collections.Generic.List<RechargeState>();
    [global::ProtoBuf.ProtoMember(10, Name=@"rechargeState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RechargeState> rechargeState
    {
      get { return _rechargeState; }
    }
  
    private int _monthCardLeft;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"monthCardLeft", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int monthCardLeft
    {
      get { return _monthCardLeft; }
      set { _monthCardLeft = value; }
    }
    private int _gold2CoinTimes;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"gold2CoinTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold2CoinTimes
    {
      get { return _gold2CoinTimes; }
      set { _gold2CoinTimes = value; }
    }
    private HSSyncExpLeftTimes _expLeftTimes;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"expLeftTimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public HSSyncExpLeftTimes expLeftTimes
    {
      get { return _expLeftTimes; }
      set { _expLeftTimes = value; }
    }
    private readonly global::System.Collections.Generic.List<ItemState> _itemState = new global::System.Collections.Generic.List<ItemState>();
    [global::ProtoBuf.ProtoMember(14, Name=@"itemState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ItemState> itemState
    {
      get { return _itemState; }
    }
  
    private int _instanceResetCount;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"instanceResetCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int instanceResetCount
    {
      get { return _instanceResetCount; }
      set { _instanceResetCount = value; }
    }
    private readonly global::System.Collections.Generic.List<HoleState> _holeState = new global::System.Collections.Generic.List<HoleState>();
    [global::ProtoBuf.ProtoMember(16, Name=@"holeState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HoleState> holeState
    {
      get { return _holeState; }
    }
  
    private readonly global::System.Collections.Generic.List<TowerState> _towerState = new global::System.Collections.Generic.List<TowerState>();
    [global::ProtoBuf.ProtoMember(17, Name=@"towerState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TowerState> towerState
    {
      get { return _towerState; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSSyncDailyRefresh")]
  public partial class HSSyncDailyRefresh : global::ProtoBuf.IExtensible
  {
    public HSSyncDailyRefresh() {}
    
    private readonly global::System.Collections.Generic.List<HoleState> _holeState = new global::System.Collections.Generic.List<HoleState>();
    [global::ProtoBuf.ProtoMember(1, Name=@"holeState", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HoleState> holeState
    {
      get { return _holeState; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSSyncMonthlyRefresh")]
  public partial class HSSyncMonthlyRefresh : global::ProtoBuf.IExtensible
  {
    public HSSyncMonthlyRefresh() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSSyncShopRefresh")]
  public partial class HSSyncShopRefresh : global::ProtoBuf.IExtensible
  {
    public HSSyncShopRefresh() {}
    
    private int _shopType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"shopType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int shopType
    {
      get { return _shopType; }
      set { _shopType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSSyncExpLeftTimes")]
  public partial class HSSyncExpLeftTimes : global::ProtoBuf.IExtensible
  {
    public HSSyncExpLeftTimes() {}
    
    private int _doubleExpLeft;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"doubleExpLeft", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int doubleExpLeft
    {
      get { return _doubleExpLeft; }
      set { _doubleExpLeft = value; }
    }
    private int _tripleExpLeft;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"tripleExpLeft", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tripleExpLeft
    {
      get { return _tripleExpLeft; }
      set { _tripleExpLeft = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}