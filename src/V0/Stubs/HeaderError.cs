// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/header_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/header_error.proto</summary>
  public static partial class HeaderErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/header_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeaderErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvaGVhZGVyX2Vycm9y",
            "LnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnMiXQoPSGVh",
            "ZGVyRXJyb3JFbnVtIkoKC0hlYWRlckVycm9yEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEh0KGUlOVkFMSURfTE9HSU5fQ1VTVE9NRVJfSUQQA0LG",
            "AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9yc0IQSGVhZGVy",
            "RXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoC",
            "Hkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYwXEVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.HeaderErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.HeaderErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.HeaderErrorEnum.Types.HeaderError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible header errors.
  /// </summary>
  public sealed partial class HeaderErrorEnum : pb::IMessage<HeaderErrorEnum> {
    private static readonly pb::MessageParser<HeaderErrorEnum> _parser = new pb::MessageParser<HeaderErrorEnum>(() => new HeaderErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HeaderErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.HeaderErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HeaderErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HeaderErrorEnum(HeaderErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HeaderErrorEnum Clone() {
      return new HeaderErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HeaderErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HeaderErrorEnum other) {
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
    public void MergeFrom(HeaderErrorEnum other) {
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
    /// <summary>Container for nested types declared in the HeaderErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible header errors.
      /// </summary>
      public enum HeaderError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The login customer id could not be validated.
        /// </summary>
        [pbr::OriginalName("INVALID_LOGIN_CUSTOMER_ID")] InvalidLoginCustomerId = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
