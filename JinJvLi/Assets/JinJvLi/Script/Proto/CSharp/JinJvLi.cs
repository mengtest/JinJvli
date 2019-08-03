// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JinJvLi.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace JinJvLi {

  /// <summary>Holder for reflection information generated from JinJvLi.proto</summary>
  public static partial class JinJvLiReflection {

    #region Descriptor
    /// <summary>File descriptor for JinJvLi.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JinJvLiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1KaW5KdkxpLnByb3RvEgdKaW5KdkxpIjcKC1BCX1VzZXJJbmZvEgwKBE5h",
            "bWUYASABKAkSCwoDVUlEGAIgASgJEg0KBUNvbG9yGAMgASgJIigKDFBCX0lQ",
            "QWRkcmVzcxIKCgJJUBgBIAEoCRIMCgRQb3J0GAIgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::JinJvLi.PB_UserInfo), global::JinJvLi.PB_UserInfo.Parser, new[]{ "Name", "UID", "Color" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::JinJvLi.PB_IPAddress), global::JinJvLi.PB_IPAddress.Parser, new[]{ "IP", "Port" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PB_UserInfo : pb::IMessage<PB_UserInfo> {
    private static readonly pb::MessageParser<PB_UserInfo> _parser = new pb::MessageParser<PB_UserInfo>(() => new PB_UserInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PB_UserInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JinJvLi.JinJvLiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_UserInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_UserInfo(PB_UserInfo other) : this() {
      name_ = other.name_;
      uID_ = other.uID_;
      color_ = other.color_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_UserInfo Clone() {
      return new PB_UserInfo(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UID" field.</summary>
    public const int UIDFieldNumber = 2;
    private string uID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UID {
      get { return uID_; }
      set {
        uID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Color" field.</summary>
    public const int ColorFieldNumber = 3;
    private string color_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Color {
      get { return color_; }
      set {
        color_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PB_UserInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PB_UserInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (UID != other.UID) return false;
      if (Color != other.Color) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (UID.Length != 0) hash ^= UID.GetHashCode();
      if (Color.Length != 0) hash ^= Color.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (UID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UID);
      }
      if (Color.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Color);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (UID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UID);
      }
      if (Color.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Color);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PB_UserInfo other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.UID.Length != 0) {
        UID = other.UID;
      }
      if (other.Color.Length != 0) {
        Color = other.Color;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            UID = input.ReadString();
            break;
          }
          case 26: {
            Color = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PB_IPAddress : pb::IMessage<PB_IPAddress> {
    private static readonly pb::MessageParser<PB_IPAddress> _parser = new pb::MessageParser<PB_IPAddress>(() => new PB_IPAddress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PB_IPAddress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JinJvLi.JinJvLiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_IPAddress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_IPAddress(PB_IPAddress other) : this() {
      iP_ = other.iP_;
      port_ = other.port_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_IPAddress Clone() {
      return new PB_IPAddress(this);
    }

    /// <summary>Field number for the "IP" field.</summary>
    public const int IPFieldNumber = 1;
    private string iP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IP {
      get { return iP_; }
      set {
        iP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Port" field.</summary>
    public const int PortFieldNumber = 2;
    private int port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PB_IPAddress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PB_IPAddress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IP != other.IP) return false;
      if (Port != other.Port) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IP.Length != 0) hash ^= IP.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IP.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IP);
      }
      if (Port != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Port);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IP);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PB_IPAddress other) {
      if (other == null) {
        return;
      }
      if (other.IP.Length != 0) {
        IP = other.IP;
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            IP = input.ReadString();
            break;
          }
          case 16: {
            Port = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
