// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PFMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PFMessage.proto</summary>
public static partial class PFMessageReflection {

  #region Descriptor
  /// <summary>File descriptor for PFMessage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PFMessageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9QRk1lc3NhZ2UucHJvdG8ibgoTUEZTZW5jZVRpbWVKc29uRGF0YRIuChJC",
          "b25lQ3VzdG9tRGF0YUxpc3QYASADKAsyEi5TZW5jZVRpbWVCb25lRGF0YRIn",
          "CgxhdHRyaWJ1dGVTZXQYAiABKAsyES5TZW5jZVRpbWVBdHRyU2V0IogBChFT",
          "ZW5jZVRpbWVCb25lRGF0YRIQCghCb25lTmFtZRgBIAEoCRIgCg1Qb3NpdGlv",
          "blZhbHVlGAIgASgLMgkuSnNvblZlYzMSIAoNUm90YXRpb25WYWx1ZRgDIAEo",
          "CzIJLkpzb25WZWMzEh0KClNjYWxlVmFsdWUYBCABKAsyCS5Kc29uVmVjMyIr",
          "CghKc29uVmVjMxIJCgF4GAEgASgCEgkKAXkYAiABKAISCQoBehgDIAEoAiJB",
          "ChBTZW5jZVRpbWVBdHRyU2V0Eg8KB2dsYXNzZXMYASABKAkSDAoEaGFpchgC",
          "IAEoCRIOCgZnZW5kZXIYAyABKAlCAlABYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PFSenceTimeJsonData), global::PFSenceTimeJsonData.Parser, new[]{ "BoneCustomDataList", "AttributeSet" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SenceTimeBoneData), global::SenceTimeBoneData.Parser, new[]{ "BoneName", "PositionValue", "RotationValue", "ScaleValue" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::JsonVec3), global::JsonVec3.Parser, new[]{ "X", "Y", "Z" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SenceTimeAttrSet), global::SenceTimeAttrSet.Parser, new[]{ "Glasses", "Hair", "Gender" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PFSenceTimeJsonData : pb::IMessage<PFSenceTimeJsonData> {
  private static readonly pb::MessageParser<PFSenceTimeJsonData> _parser = new pb::MessageParser<PFSenceTimeJsonData>(() => new PFSenceTimeJsonData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<PFSenceTimeJsonData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PFMessageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PFSenceTimeJsonData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PFSenceTimeJsonData(PFSenceTimeJsonData other) : this() {
    boneCustomDataList_ = other.boneCustomDataList_.Clone();
    attributeSet_ = other.attributeSet_ != null ? other.attributeSet_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PFSenceTimeJsonData Clone() {
    return new PFSenceTimeJsonData(this);
  }

  /// <summary>Field number for the "BoneCustomDataList" field.</summary>
  public const int BoneCustomDataListFieldNumber = 1;
  private static readonly pb::FieldCodec<global::SenceTimeBoneData> _repeated_boneCustomDataList_codec
      = pb::FieldCodec.ForMessage(10, global::SenceTimeBoneData.Parser);
  private readonly pbc::RepeatedField<global::SenceTimeBoneData> boneCustomDataList_ = new pbc::RepeatedField<global::SenceTimeBoneData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::SenceTimeBoneData> BoneCustomDataList {
    get { return boneCustomDataList_; }
  }

  /// <summary>Field number for the "attributeSet" field.</summary>
  public const int AttributeSetFieldNumber = 2;
  private global::SenceTimeAttrSet attributeSet_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::SenceTimeAttrSet AttributeSet {
    get { return attributeSet_; }
    set {
      attributeSet_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as PFSenceTimeJsonData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(PFSenceTimeJsonData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!boneCustomDataList_.Equals(other.boneCustomDataList_)) return false;
    if (!object.Equals(AttributeSet, other.AttributeSet)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= boneCustomDataList_.GetHashCode();
    if (attributeSet_ != null) hash ^= AttributeSet.GetHashCode();
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
    boneCustomDataList_.WriteTo(output, _repeated_boneCustomDataList_codec);
    if (attributeSet_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(AttributeSet);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += boneCustomDataList_.CalculateSize(_repeated_boneCustomDataList_codec);
    if (attributeSet_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(AttributeSet);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(PFSenceTimeJsonData other) {
    if (other == null) {
      return;
    }
    boneCustomDataList_.Add(other.boneCustomDataList_);
    if (other.attributeSet_ != null) {
      if (attributeSet_ == null) {
        AttributeSet = new global::SenceTimeAttrSet();
      }
      AttributeSet.MergeFrom(other.AttributeSet);
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
          boneCustomDataList_.AddEntriesFrom(input, _repeated_boneCustomDataList_codec);
          break;
        }
        case 18: {
          if (attributeSet_ == null) {
            AttributeSet = new global::SenceTimeAttrSet();
          }
          input.ReadMessage(AttributeSet);
          break;
        }
      }
    }
  }

}

public sealed partial class SenceTimeBoneData : pb::IMessage<SenceTimeBoneData> {
  private static readonly pb::MessageParser<SenceTimeBoneData> _parser = new pb::MessageParser<SenceTimeBoneData>(() => new SenceTimeBoneData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SenceTimeBoneData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PFMessageReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SenceTimeBoneData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SenceTimeBoneData(SenceTimeBoneData other) : this() {
    boneName_ = other.boneName_;
    positionValue_ = other.positionValue_ != null ? other.positionValue_.Clone() : null;
    rotationValue_ = other.rotationValue_ != null ? other.rotationValue_.Clone() : null;
    scaleValue_ = other.scaleValue_ != null ? other.scaleValue_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SenceTimeBoneData Clone() {
    return new SenceTimeBoneData(this);
  }

  /// <summary>Field number for the "BoneName" field.</summary>
  public const int BoneNameFieldNumber = 1;
  private string boneName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string BoneName {
    get { return boneName_; }
    set {
      boneName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "PositionValue" field.</summary>
  public const int PositionValueFieldNumber = 2;
  private global::JsonVec3 positionValue_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::JsonVec3 PositionValue {
    get { return positionValue_; }
    set {
      positionValue_ = value;
    }
  }

  /// <summary>Field number for the "RotationValue" field.</summary>
  public const int RotationValueFieldNumber = 3;
  private global::JsonVec3 rotationValue_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::JsonVec3 RotationValue {
    get { return rotationValue_; }
    set {
      rotationValue_ = value;
    }
  }

  /// <summary>Field number for the "ScaleValue" field.</summary>
  public const int ScaleValueFieldNumber = 4;
  private global::JsonVec3 scaleValue_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::JsonVec3 ScaleValue {
    get { return scaleValue_; }
    set {
      scaleValue_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SenceTimeBoneData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SenceTimeBoneData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (BoneName != other.BoneName) return false;
    if (!object.Equals(PositionValue, other.PositionValue)) return false;
    if (!object.Equals(RotationValue, other.RotationValue)) return false;
    if (!object.Equals(ScaleValue, other.ScaleValue)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (BoneName.Length != 0) hash ^= BoneName.GetHashCode();
    if (positionValue_ != null) hash ^= PositionValue.GetHashCode();
    if (rotationValue_ != null) hash ^= RotationValue.GetHashCode();
    if (scaleValue_ != null) hash ^= ScaleValue.GetHashCode();
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
    if (BoneName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(BoneName);
    }
    if (positionValue_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(PositionValue);
    }
    if (rotationValue_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(RotationValue);
    }
    if (scaleValue_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(ScaleValue);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (BoneName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(BoneName);
    }
    if (positionValue_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(PositionValue);
    }
    if (rotationValue_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RotationValue);
    }
    if (scaleValue_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScaleValue);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SenceTimeBoneData other) {
    if (other == null) {
      return;
    }
    if (other.BoneName.Length != 0) {
      BoneName = other.BoneName;
    }
    if (other.positionValue_ != null) {
      if (positionValue_ == null) {
        PositionValue = new global::JsonVec3();
      }
      PositionValue.MergeFrom(other.PositionValue);
    }
    if (other.rotationValue_ != null) {
      if (rotationValue_ == null) {
        RotationValue = new global::JsonVec3();
      }
      RotationValue.MergeFrom(other.RotationValue);
    }
    if (other.scaleValue_ != null) {
      if (scaleValue_ == null) {
        ScaleValue = new global::JsonVec3();
      }
      ScaleValue.MergeFrom(other.ScaleValue);
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
          BoneName = input.ReadString();
          break;
        }
        case 18: {
          if (positionValue_ == null) {
            PositionValue = new global::JsonVec3();
          }
          input.ReadMessage(PositionValue);
          break;
        }
        case 26: {
          if (rotationValue_ == null) {
            RotationValue = new global::JsonVec3();
          }
          input.ReadMessage(RotationValue);
          break;
        }
        case 34: {
          if (scaleValue_ == null) {
            ScaleValue = new global::JsonVec3();
          }
          input.ReadMessage(ScaleValue);
          break;
        }
      }
    }
  }

}

public sealed partial class JsonVec3 : pb::IMessage<JsonVec3> {
  private static readonly pb::MessageParser<JsonVec3> _parser = new pb::MessageParser<JsonVec3>(() => new JsonVec3());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<JsonVec3> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PFMessageReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public JsonVec3() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public JsonVec3(JsonVec3 other) : this() {
    x_ = other.x_;
    y_ = other.y_;
    z_ = other.z_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public JsonVec3 Clone() {
    return new JsonVec3(this);
  }

  /// <summary>Field number for the "x" field.</summary>
  public const int XFieldNumber = 1;
  private float x_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float X {
    get { return x_; }
    set {
      x_ = value;
    }
  }

  /// <summary>Field number for the "y" field.</summary>
  public const int YFieldNumber = 2;
  private float y_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Y {
    get { return y_; }
    set {
      y_ = value;
    }
  }

  /// <summary>Field number for the "z" field.</summary>
  public const int ZFieldNumber = 3;
  private float z_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Z {
    get { return z_; }
    set {
      z_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as JsonVec3);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(JsonVec3 other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
    if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
    if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
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
    if (X != 0F) {
      output.WriteRawTag(13);
      output.WriteFloat(X);
    }
    if (Y != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(Y);
    }
    if (Z != 0F) {
      output.WriteRawTag(29);
      output.WriteFloat(Z);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (X != 0F) {
      size += 1 + 4;
    }
    if (Y != 0F) {
      size += 1 + 4;
    }
    if (Z != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(JsonVec3 other) {
    if (other == null) {
      return;
    }
    if (other.X != 0F) {
      X = other.X;
    }
    if (other.Y != 0F) {
      Y = other.Y;
    }
    if (other.Z != 0F) {
      Z = other.Z;
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
        case 13: {
          X = input.ReadFloat();
          break;
        }
        case 21: {
          Y = input.ReadFloat();
          break;
        }
        case 29: {
          Z = input.ReadFloat();
          break;
        }
      }
    }
  }

}

public sealed partial class SenceTimeAttrSet : pb::IMessage<SenceTimeAttrSet> {
  private static readonly pb::MessageParser<SenceTimeAttrSet> _parser = new pb::MessageParser<SenceTimeAttrSet>(() => new SenceTimeAttrSet());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SenceTimeAttrSet> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PFMessageReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SenceTimeAttrSet() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SenceTimeAttrSet(SenceTimeAttrSet other) : this() {
    glasses_ = other.glasses_;
    hair_ = other.hair_;
    gender_ = other.gender_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SenceTimeAttrSet Clone() {
    return new SenceTimeAttrSet(this);
  }

  /// <summary>Field number for the "glasses" field.</summary>
  public const int GlassesFieldNumber = 1;
  private string glasses_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Glasses {
    get { return glasses_; }
    set {
      glasses_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "hair" field.</summary>
  public const int HairFieldNumber = 2;
  private string hair_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Hair {
    get { return hair_; }
    set {
      hair_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "gender" field.</summary>
  public const int GenderFieldNumber = 3;
  private string gender_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Gender {
    get { return gender_; }
    set {
      gender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SenceTimeAttrSet);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SenceTimeAttrSet other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Glasses != other.Glasses) return false;
    if (Hair != other.Hair) return false;
    if (Gender != other.Gender) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Glasses.Length != 0) hash ^= Glasses.GetHashCode();
    if (Hair.Length != 0) hash ^= Hair.GetHashCode();
    if (Gender.Length != 0) hash ^= Gender.GetHashCode();
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
    if (Glasses.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Glasses);
    }
    if (Hair.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Hair);
    }
    if (Gender.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Gender);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Glasses.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Glasses);
    }
    if (Hair.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Hair);
    }
    if (Gender.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Gender);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SenceTimeAttrSet other) {
    if (other == null) {
      return;
    }
    if (other.Glasses.Length != 0) {
      Glasses = other.Glasses;
    }
    if (other.Hair.Length != 0) {
      Hair = other.Hair;
    }
    if (other.Gender.Length != 0) {
      Gender = other.Gender;
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
          Glasses = input.ReadString();
          break;
        }
        case 18: {
          Hair = input.ReadString();
          break;
        }
        case 26: {
          Gender = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
