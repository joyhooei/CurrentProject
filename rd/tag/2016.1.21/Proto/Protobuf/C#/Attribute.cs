//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol/Attribute.proto
namespace PB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Attr")]
  public partial class Attr : global::ProtoBuf.IExtensible
  {
    public Attr() {}
    
    private int _attrId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"attrId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attrId
    {
      get { return _attrId; }
      set { _attrId = value; }
    }
    private float _attrValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"attrValue", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float attrValue
    {
      get { return _attrValue; }
      set { _attrValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}