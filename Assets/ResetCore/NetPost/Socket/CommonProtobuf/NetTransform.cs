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

// Generated from: NetTransform.proto
// Note: requires additional types generated from: Vector3D.proto
namespace Protobuf.Data
{
  [global::ProtoBuf.ProtoContract(Name=@"NetTransformData")]
  public partial class NetTransformData : global::ProtoBuf.IExtensible
  {
    public NetTransformData() {}
    
    private Vector3DData _localPosition = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"localPosition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Vector3DData LocalPosition
    {
      get { return _localPosition; }
      set { _localPosition = value; }
    }
    private Vector3DData _localEulerAngle = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"localEulerAngle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Vector3DData LocalEulerAngle
    {
      get { return _localEulerAngle; }
      set { _localEulerAngle = value; }
    }
    private Vector3DData _localScale = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"localScale", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Vector3DData LocalScale
    {
      get { return _localScale; }
      set { _localScale = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}