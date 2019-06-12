// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/operating_system_version_operator_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/operating_system_version_operator_type.proto</summary>
  public static partial class OperatingSystemVersionOperatorTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/operating_system_version_operator_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperatingSystemVersionOperatorTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9vcGVyYXRpbmdfc3lz",
            "dGVtX3ZlcnNpb25fb3BlcmF0b3JfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8ilwEKJk9wZXJhdGluZ1N5c3RlbVZlcnNpb25PcGVyYXRvclR5cGVFbnVt",
            "Im0KIk9wZXJhdGluZ1N5c3RlbVZlcnNpb25PcGVyYXRvclR5cGUSDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESDQoJRVFVQUxTX1RPEAISGgoWR1JF",
            "QVRFUl9USEFOX0VRVUFMU19UTxAEQvwBCiFjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEuZW51bXNCJ09wZXJhdGluZ1N5c3RlbVZlcnNpb25PcGVyYXRv",
            "clR5cGVQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEvZW51bXM7ZW51bXOiAgNHQUGqAh1H",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMS5FbnVtc8oCHUdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYxXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6",
            "OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.OperatingSystemVersionOperatorTypeEnum), global::Google.Ads.GoogleAds.V1.Enums.OperatingSystemVersionOperatorTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the type of OS operators.
  /// </summary>
  public sealed partial class OperatingSystemVersionOperatorTypeEnum : pb::IMessage<OperatingSystemVersionOperatorTypeEnum> {
    private static readonly pb::MessageParser<OperatingSystemVersionOperatorTypeEnum> _parser = new pb::MessageParser<OperatingSystemVersionOperatorTypeEnum>(() => new OperatingSystemVersionOperatorTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OperatingSystemVersionOperatorTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.OperatingSystemVersionOperatorTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperatingSystemVersionOperatorTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperatingSystemVersionOperatorTypeEnum(OperatingSystemVersionOperatorTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperatingSystemVersionOperatorTypeEnum Clone() {
      return new OperatingSystemVersionOperatorTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OperatingSystemVersionOperatorTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OperatingSystemVersionOperatorTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OperatingSystemVersionOperatorTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the OperatingSystemVersionOperatorTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of operating system version.
      /// </summary>
      public enum OperatingSystemVersionOperatorType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Equals to the specified version.
        /// </summary>
        [pbr::OriginalName("EQUALS_TO")] EqualsTo = 2,
        /// <summary>
        /// Greater than or equals to the specified version.
        /// </summary>
        [pbr::OriginalName("GREATER_THAN_EQUALS_TO")] GreaterThanEqualsTo = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code