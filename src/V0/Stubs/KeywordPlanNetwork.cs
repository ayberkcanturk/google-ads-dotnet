// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/keyword_plan_network.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/keyword_plan_network.proto</summary>
  public static partial class KeywordPlanNetworkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/keyword_plan_network.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanNetworkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9rZXl3b3JkX3BsYW5f",
            "bmV0d29yay5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMi",
            "fwoWS2V5d29yZFBsYW5OZXR3b3JrRW51bSJlChJLZXl3b3JkUGxhbk5ldHdv",
            "cmsSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEQoNR09PR0xFX1NF",
            "QVJDSBACEh4KGkdPT0dMRV9TRUFSQ0hfQU5EX1BBUlRORVJTEANC7AEKIWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IXS2V5d29yZFBsYW5O",
            "ZXR3b3JrUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zO2VudW1zogIDR0FBqgId",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYw",
            "OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanNetworkEnum), global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanNetworkEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanNetworkEnum.Types.KeywordPlanNetwork) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of keyword plan forecastable network types.
  /// </summary>
  public sealed partial class KeywordPlanNetworkEnum : pb::IMessage<KeywordPlanNetworkEnum> {
    private static readonly pb::MessageParser<KeywordPlanNetworkEnum> _parser = new pb::MessageParser<KeywordPlanNetworkEnum>(() => new KeywordPlanNetworkEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanNetworkEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanNetworkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanNetworkEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanNetworkEnum(KeywordPlanNetworkEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanNetworkEnum Clone() {
      return new KeywordPlanNetworkEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanNetworkEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanNetworkEnum other) {
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
    public void MergeFrom(KeywordPlanNetworkEnum other) {
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
    /// <summary>Container for nested types declared in the KeywordPlanNetworkEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates keyword plan forecastable network types.
      /// </summary>
      public enum KeywordPlanNetwork {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google Search.
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH")] GoogleSearch = 2,
        /// <summary>
        /// Google Search + Search partners.
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH_AND_PARTNERS")] GoogleSearchAndPartners = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
