//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Option: light framework (CF/Silverlight) enabled
    
// Generated from: NetObjectJoinUp.proto
namespace Protobuf.Data
{
  [global::ProtoBuf.ProtoContract(Name=@"NetObjectJoinUpData")]
  public partial class NetObjectJoinUpData : global::ProtoBuf.IExtensible
  {
    public NetObjectJoinUpData() {}
    
    private int? _instanceId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"instanceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InstanceId
    {
      get { return _instanceId?? default(int); }
      set { _instanceId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool InstanceIdSpecified
    {
      get { return this._instanceId != null; }
      set { if (value == (this._instanceId== null)) this._instanceId = value ? this.InstanceId : (int?)null; }
    }
    private bool ShouldSerializeInstanceId() { return InstanceIdSpecified; }
    private void ResetInstanceId() { InstanceIdSpecified = false; }
    
    private string _typeName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"typeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName
    {
      get { return _typeName?? ""; }
      set { _typeName = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool TypeNameSpecified
    {
      get { return this._typeName != null; }
      set { if (value == (this._typeName== null)) this._typeName = value ? this.TypeName : (string)null; }
    }
    private bool ShouldSerializeTypeName() { return TypeNameSpecified; }
    private void ResetTypeName() { TypeNameSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}