//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Quest.proto
// Note: requires additional types generated from: Protocol/Const.proto
namespace PB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuest")]
  public partial class HSQuest : global::ProtoBuf.IExtensible
  {
    public HSQuest() {}
    
    private int _questId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int questId
    {
      get { return _questId; }
      set { _questId = value; }
    }
    private int _progress = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int progress
    {
      get { return _progress; }
      set { _progress = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuestInfoSync")]
  public partial class HSQuestInfoSync : global::ProtoBuf.IExtensible
  {
    public HSQuestInfoSync() {}
    
    private readonly global::System.Collections.Generic.List<HSQuest> _questInfo = new global::System.Collections.Generic.List<HSQuest>();
    [global::ProtoBuf.ProtoMember(1, Name=@"questInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HSQuest> questInfo
    {
      get { return _questInfo; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuestSubmit")]
  public partial class HSQuestSubmit : global::ProtoBuf.IExtensible
  {
    public HSQuestSubmit() {}
    
    private int _questId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int questId
    {
      get { return _questId; }
      set { _questId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuestSubmitRet")]
  public partial class HSQuestSubmitRet : global::ProtoBuf.IExtensible
  {
    public HSQuestSubmitRet() {}
    
    private int _questId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int questId
    {
      get { return _questId; }
      set { _questId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuestAccept")]
  public partial class HSQuestAccept : global::ProtoBuf.IExtensible
  {
    public HSQuestAccept() {}
    
    private readonly global::System.Collections.Generic.List<HSQuest> _quest = new global::System.Collections.Generic.List<HSQuest>();
    [global::ProtoBuf.ProtoMember(1, Name=@"quest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HSQuest> quest
    {
      get { return _quest; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuestUpdate")]
  public partial class HSQuestUpdate : global::ProtoBuf.IExtensible
  {
    public HSQuestUpdate() {}
    
    private readonly global::System.Collections.Generic.List<HSQuest> _quest = new global::System.Collections.Generic.List<HSQuest>();
    [global::ProtoBuf.ProtoMember(1, Name=@"quest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<HSQuest> quest
    {
      get { return _quest; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HSQuestRemove")]
  public partial class HSQuestRemove : global::ProtoBuf.IExtensible
  {
    public HSQuestRemove() {}
    
    private readonly global::System.Collections.Generic.List<int> _questId = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"questId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> questId
    {
      get { return _questId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}