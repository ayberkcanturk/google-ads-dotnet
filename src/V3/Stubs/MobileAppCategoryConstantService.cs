// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/mobile_app_category_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/mobile_app_category_constant_service.proto</summary>
  public static partial class MobileAppCategoryConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/mobile_app_category_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MobileAppCategoryConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9tb2JpbGVfYXBw",
            "X2NhdGVnb3J5X2NvbnN0YW50X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYzLnNlcnZpY2VzGkRnb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "My9yZXNvdXJjZXMvbW9iaWxlX2FwcF9jYXRlZ29yeV9jb25zdGFudC5wcm90",
            "bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9j",
            "bGllbnQucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8i",
            "QQojR2V0TW9iaWxlQXBwQ2F0ZWdvcnlDb25zdGFudFJlcXVlc3QSGgoNcmVz",
            "b3VyY2VfbmFtZRgBIAEoCUID4EECMq8CCiBNb2JpbGVBcHBDYXRlZ29yeUNv",
            "bnN0YW50U2VydmljZRLtAQocR2V0TW9iaWxlQXBwQ2F0ZWdvcnlDb25zdGFu",
            "dBJFLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLkdldE1vYmls",
            "ZUFwcENhdGVnb3J5Q29uc3RhbnRSZXF1ZXN0GjwuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMucmVzb3VyY2VzLk1vYmlsZUFwcENhdGVnb3J5Q29uc3RhbnQi",
            "SILT5JMCMhIwL3YzL3tyZXNvdXJjZV9uYW1lPW1vYmlsZUFwcENhdGVnb3J5",
            "Q29uc3RhbnRzLyp92kENcmVzb3VyY2VfbmFtZRobykEYZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tQowCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMu",
            "c2VydmljZXNCJU1vYmlsZUFwcENhdGVnb3J5Q29uc3RhbnRTZXJ2aWNlUHJv",
            "dG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YzL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjMuU2VydmljZXPKAiBHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWM1xTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYzOjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.MobileAppCategoryConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetMobileAppCategoryConstantRequest), global::Google.Ads.GoogleAds.V3.Services.GetMobileAppCategoryConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [MobileAppCategoryConstantService.GetMobileAppCategoryConstant][google.ads.googleads.v3.services.MobileAppCategoryConstantService.GetMobileAppCategoryConstant].
  /// </summary>
  public sealed partial class GetMobileAppCategoryConstantRequest : pb::IMessage<GetMobileAppCategoryConstantRequest> {
    private static readonly pb::MessageParser<GetMobileAppCategoryConstantRequest> _parser = new pb::MessageParser<GetMobileAppCategoryConstantRequest>(() => new GetMobileAppCategoryConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMobileAppCategoryConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.MobileAppCategoryConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMobileAppCategoryConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMobileAppCategoryConstantRequest(GetMobileAppCategoryConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMobileAppCategoryConstantRequest Clone() {
      return new GetMobileAppCategoryConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the mobile app category constant to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMobileAppCategoryConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMobileAppCategoryConstantRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMobileAppCategoryConstantRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code