// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/url_field_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/url_field_error.proto</summary>
  public static partial class UrlFieldErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/url_field_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UrlFieldErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvdXJsX2ZpZWxkX2Vy",
            "cm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnMilQ4K",
            "EVVybEZpZWxkRXJyb3JFbnVtIv8NCg1VcmxGaWVsZEVycm9yEg8KC1VOU1BF",
            "Q0lGSUVEEAASCwoHVU5LTk9XThABEiEKHUlOVkFMSURfVFJBQ0tJTkdfVVJM",
            "X1RFTVBMQVRFEAISKAokSU5WQUxJRF9UQUdfSU5fVFJBQ0tJTkdfVVJMX1RF",
            "TVBMQVRFEAMSJQohTUlTU0lOR19UUkFDS0lOR19VUkxfVEVNUExBVEVfVEFH",
            "EAQSLQopTUlTU0lOR19QUk9UT0NPTF9JTl9UUkFDS0lOR19VUkxfVEVNUExB",
            "VEUQBRItCilJTlZBTElEX1BST1RPQ09MX0lOX1RSQUNLSU5HX1VSTF9URU1Q",
            "TEFURRAGEiMKH01BTEZPUk1FRF9UUkFDS0lOR19VUkxfVEVNUExBVEUQBxIp",
            "CiVNSVNTSU5HX0hPU1RfSU5fVFJBQ0tJTkdfVVJMX1RFTVBMQVRFEAgSKAok",
            "SU5WQUxJRF9UTERfSU5fVFJBQ0tJTkdfVVJMX1RFTVBMQVRFEAkSLgoqUkVE",
            "VU5EQU5UX05FU1RFRF9UUkFDS0lOR19VUkxfVEVNUExBVEVfVEFHEAoSFQoR",
            "SU5WQUxJRF9GSU5BTF9VUkwQCxIcChhJTlZBTElEX1RBR19JTl9GSU5BTF9V",
            "UkwQDBIiCh5SRURVTkRBTlRfTkVTVEVEX0ZJTkFMX1VSTF9UQUcQDRIhCh1N",
            "SVNTSU5HX1BST1RPQ09MX0lOX0ZJTkFMX1VSTBAOEiEKHUlOVkFMSURfUFJP",
            "VE9DT0xfSU5fRklOQUxfVVJMEA8SFwoTTUFMRk9STUVEX0ZJTkFMX1VSTBAQ",
            "Eh0KGU1JU1NJTkdfSE9TVF9JTl9GSU5BTF9VUkwQERIcChhJTlZBTElEX1RM",
            "RF9JTl9GSU5BTF9VUkwQEhIcChhJTlZBTElEX0ZJTkFMX01PQklMRV9VUkwQ",
            "ExIjCh9JTlZBTElEX1RBR19JTl9GSU5BTF9NT0JJTEVfVVJMEBQSKQolUkVE",
            "VU5EQU5UX05FU1RFRF9GSU5BTF9NT0JJTEVfVVJMX1RBRxAVEigKJE1JU1NJ",
            "TkdfUFJPVE9DT0xfSU5fRklOQUxfTU9CSUxFX1VSTBAWEigKJElOVkFMSURf",
            "UFJPVE9DT0xfSU5fRklOQUxfTU9CSUxFX1VSTBAXEh4KGk1BTEZPUk1FRF9G",
            "SU5BTF9NT0JJTEVfVVJMEBgSJAogTUlTU0lOR19IT1NUX0lOX0ZJTkFMX01P",
            "QklMRV9VUkwQGRIjCh9JTlZBTElEX1RMRF9JTl9GSU5BTF9NT0JJTEVfVVJM",
            "EBoSGQoVSU5WQUxJRF9GSU5BTF9BUFBfVVJMEBsSIAocSU5WQUxJRF9UQUdf",
            "SU5fRklOQUxfQVBQX1VSTBAcEiYKIlJFRFVOREFOVF9ORVNURURfRklOQUxf",
            "QVBQX1VSTF9UQUcQHRIgChxNVUxUSVBMRV9BUFBfVVJMU19GT1JfT1NUWVBF",
            "EB4SEgoOSU5WQUxJRF9PU1RZUEUQHxIgChxJTlZBTElEX1BST1RPQ09MX0ZP",
            "Ul9BUFBfVVJMECASIgoeSU5WQUxJRF9QQUNLQUdFX0lEX0ZPUl9BUFBfVVJM",
            "ECESLQopVVJMX0NVU1RPTV9QQVJBTUVURVJTX0NPVU5UX0VYQ0VFRFNfTElN",
            "SVQQIhIyCi5JTlZBTElEX0NIQVJBQ1RFUlNfSU5fVVJMX0NVU1RPTV9QQVJB",
            "TUVURVJfS0VZECcSNAowSU5WQUxJRF9DSEFSQUNURVJTX0lOX1VSTF9DVVNU",
            "T01fUEFSQU1FVEVSX1ZBTFVFECgSLQopSU5WQUxJRF9UQUdfSU5fVVJMX0NV",
            "U1RPTV9QQVJBTUVURVJfVkFMVUUQKRItCilSRURVTkRBTlRfTkVTVEVEX1VS",
            "TF9DVVNUT01fUEFSQU1FVEVSX1RBRxAqEhQKEE1JU1NJTkdfUFJPVE9DT0wQ",
            "KxIUChBJTlZBTElEX1BST1RPQ09MEDQSDwoLSU5WQUxJRF9VUkwQLBIeChpE",
            "RVNUSU5BVElPTl9VUkxfREVQUkVDQVRFRBAtEhYKEklOVkFMSURfVEFHX0lO",
            "X1VSTBAuEhMKD01JU1NJTkdfVVJMX1RBRxAvEhQKEERVUExJQ0FURV9VUkxf",
            "SUQQMBISCg5JTlZBTElEX1VSTF9JRBAxEh4KGkZJTkFMX1VSTF9TVUZGSVhf",
            "TUFMRk9STUVEEDISIwofSU5WQUxJRF9UQUdfSU5fRklOQUxfVVJMX1NVRkZJ",
            "WBAzEhwKGElOVkFMSURfVE9QX0xFVkVMX0RPTUFJThA1Eh4KGk1BTEZPUk1F",
            "RF9UT1BfTEVWRUxfRE9NQUlOEDYSEQoNTUFMRk9STUVEX1VSTBA3EhAKDE1J",
            "U1NJTkdfSE9TVBA4Qu0BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAu",
            "ZXJyb3JzQhJVcmxGaWVsZEVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2Vycm9y",
            "cztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FcnJv",
            "cnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxFcnJvcnPqAiJHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.UrlFieldErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.UrlFieldErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.UrlFieldErrorEnum.Types.UrlFieldError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible url field errors.
  /// </summary>
  public sealed partial class UrlFieldErrorEnum : pb::IMessage<UrlFieldErrorEnum> {
    private static readonly pb::MessageParser<UrlFieldErrorEnum> _parser = new pb::MessageParser<UrlFieldErrorEnum>(() => new UrlFieldErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UrlFieldErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.UrlFieldErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UrlFieldErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UrlFieldErrorEnum(UrlFieldErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UrlFieldErrorEnum Clone() {
      return new UrlFieldErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UrlFieldErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UrlFieldErrorEnum other) {
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
    public void MergeFrom(UrlFieldErrorEnum other) {
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
    /// <summary>Container for nested types declared in the UrlFieldErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible url field errors.
      /// </summary>
      public enum UrlFieldError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The tracking url template is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_TRACKING_URL_TEMPLATE")] InvalidTrackingUrlTemplate = 2,
        /// <summary>
        /// The tracking url template contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_TRACKING_URL_TEMPLATE")] InvalidTagInTrackingUrlTemplate = 3,
        /// <summary>
        /// The tracking url template must contain at least one tag (e.g. {lpurl}),
        /// This applies only to tracking url template associated with website ads or
        /// product ads.
        /// </summary>
        [pbr::OriginalName("MISSING_TRACKING_URL_TEMPLATE_TAG")] MissingTrackingUrlTemplateTag = 4,
        /// <summary>
        /// The tracking url template must start with a valid protocol (or lpurl
        /// tag).
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL_IN_TRACKING_URL_TEMPLATE")] MissingProtocolInTrackingUrlTemplate = 5,
        /// <summary>
        /// The tracking url template starts with an invalid protocol.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_IN_TRACKING_URL_TEMPLATE")] InvalidProtocolInTrackingUrlTemplate = 6,
        /// <summary>
        /// The tracking url template contains illegal characters.
        /// </summary>
        [pbr::OriginalName("MALFORMED_TRACKING_URL_TEMPLATE")] MalformedTrackingUrlTemplate = 7,
        /// <summary>
        /// The tracking url template must contain a host name (or lpurl tag).
        /// </summary>
        [pbr::OriginalName("MISSING_HOST_IN_TRACKING_URL_TEMPLATE")] MissingHostInTrackingUrlTemplate = 8,
        /// <summary>
        /// The tracking url template has an invalid or missing top level domain
        /// extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TLD_IN_TRACKING_URL_TEMPLATE")] InvalidTldInTrackingUrlTemplate = 9,
        /// <summary>
        /// The tracking url template contains nested occurrences of the same
        /// conditional tag (i.e. {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_TRACKING_URL_TEMPLATE_TAG")] RedundantNestedTrackingUrlTemplateTag = 10,
        /// <summary>
        /// The final url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_URL")] InvalidFinalUrl = 11,
        /// <summary>
        /// The final url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_URL")] InvalidTagInFinalUrl = 12,
        /// <summary>
        /// The final url contains nested occurrences of the same conditional tag
        /// (i.e. {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_FINAL_URL_TAG")] RedundantNestedFinalUrlTag = 13,
        /// <summary>
        /// The final url must start with a valid protocol.
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL_IN_FINAL_URL")] MissingProtocolInFinalUrl = 14,
        /// <summary>
        /// The final url starts with an invalid protocol.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_IN_FINAL_URL")] InvalidProtocolInFinalUrl = 15,
        /// <summary>
        /// The final url contains illegal characters.
        /// </summary>
        [pbr::OriginalName("MALFORMED_FINAL_URL")] MalformedFinalUrl = 16,
        /// <summary>
        /// The final url must contain a host name.
        /// </summary>
        [pbr::OriginalName("MISSING_HOST_IN_FINAL_URL")] MissingHostInFinalUrl = 17,
        /// <summary>
        /// The tracking url template has an invalid or missing top level domain
        /// extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TLD_IN_FINAL_URL")] InvalidTldInFinalUrl = 18,
        /// <summary>
        /// The final mobile url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_MOBILE_URL")] InvalidFinalMobileUrl = 19,
        /// <summary>
        /// The final mobile url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_MOBILE_URL")] InvalidTagInFinalMobileUrl = 20,
        /// <summary>
        /// The final mobile url contains nested occurrences of the same conditional
        /// tag (i.e. {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_FINAL_MOBILE_URL_TAG")] RedundantNestedFinalMobileUrlTag = 21,
        /// <summary>
        /// The final mobile url must start with a valid protocol.
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL_IN_FINAL_MOBILE_URL")] MissingProtocolInFinalMobileUrl = 22,
        /// <summary>
        /// The final mobile url starts with an invalid protocol.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_IN_FINAL_MOBILE_URL")] InvalidProtocolInFinalMobileUrl = 23,
        /// <summary>
        /// The final mobile url contains illegal characters.
        /// </summary>
        [pbr::OriginalName("MALFORMED_FINAL_MOBILE_URL")] MalformedFinalMobileUrl = 24,
        /// <summary>
        /// The final mobile url must contain a host name.
        /// </summary>
        [pbr::OriginalName("MISSING_HOST_IN_FINAL_MOBILE_URL")] MissingHostInFinalMobileUrl = 25,
        /// <summary>
        /// The tracking url template has an invalid or missing top level domain
        /// extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TLD_IN_FINAL_MOBILE_URL")] InvalidTldInFinalMobileUrl = 26,
        /// <summary>
        /// The final app url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_APP_URL")] InvalidFinalAppUrl = 27,
        /// <summary>
        /// The final app url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_APP_URL")] InvalidTagInFinalAppUrl = 28,
        /// <summary>
        /// The final app url contains nested occurrences of the same conditional tag
        /// (i.e. {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_FINAL_APP_URL_TAG")] RedundantNestedFinalAppUrlTag = 29,
        /// <summary>
        /// More than one app url found for the same OS type.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_APP_URLS_FOR_OSTYPE")] MultipleAppUrlsForOstype = 30,
        /// <summary>
        /// The OS type given for an app url is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_OSTYPE")] InvalidOstype = 31,
        /// <summary>
        /// The protocol given for an app url is not valid. (E.g. "android-app://")
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_FOR_APP_URL")] InvalidProtocolForAppUrl = 32,
        /// <summary>
        /// The package id (app id) given for an app url is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_PACKAGE_ID_FOR_APP_URL")] InvalidPackageIdForAppUrl = 33,
        /// <summary>
        /// The number of url custom parameters for an resource exceeds the maximum
        /// limit allowed.
        /// </summary>
        [pbr::OriginalName("URL_CUSTOM_PARAMETERS_COUNT_EXCEEDS_LIMIT")] UrlCustomParametersCountExceedsLimit = 34,
        /// <summary>
        /// An invalid character appears in the parameter key.
        /// </summary>
        [pbr::OriginalName("INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_KEY")] InvalidCharactersInUrlCustomParameterKey = 39,
        /// <summary>
        /// An invalid character appears in the parameter value.
        /// </summary>
        [pbr::OriginalName("INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_VALUE")] InvalidCharactersInUrlCustomParameterValue = 40,
        /// <summary>
        /// The url custom parameter value fails url tag validation.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_URL_CUSTOM_PARAMETER_VALUE")] InvalidTagInUrlCustomParameterValue = 41,
        /// <summary>
        /// The custom parameter contains nested occurrences of the same conditional
        /// tag (i.e. {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_URL_CUSTOM_PARAMETER_TAG")] RedundantNestedUrlCustomParameterTag = 42,
        /// <summary>
        /// The protocol (http:// or https://) is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL")] MissingProtocol = 43,
        /// <summary>
        /// Unsupported protocol in URL. Only http and https are supported.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL")] InvalidProtocol = 52,
        /// <summary>
        /// The url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_URL")] InvalidUrl = 44,
        /// <summary>
        /// Destination Url is deprecated.
        /// </summary>
        [pbr::OriginalName("DESTINATION_URL_DEPRECATED")] DestinationUrlDeprecated = 45,
        /// <summary>
        /// The url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_URL")] InvalidTagInUrl = 46,
        /// <summary>
        /// The url must contain at least one tag (e.g. {lpurl}), This applies only
        /// to urls associated with website ads or product ads.
        /// </summary>
        [pbr::OriginalName("MISSING_URL_TAG")] MissingUrlTag = 47,
        /// <summary>
        /// Duplicate url id.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_URL_ID")] DuplicateUrlId = 48,
        /// <summary>
        /// Invalid url id.
        /// </summary>
        [pbr::OriginalName("INVALID_URL_ID")] InvalidUrlId = 49,
        /// <summary>
        /// The final url suffix cannot begin with '?' or '&amp;' characters and must be
        /// a valid query string.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX_MALFORMED")] FinalUrlSuffixMalformed = 50,
        /// <summary>
        /// The final url suffix cannot contain {lpurl} related or {ignore} tags.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_URL_SUFFIX")] InvalidTagInFinalUrlSuffix = 51,
        /// <summary>
        /// The top level domain is invalid, e.g, not a public top level domain
        /// listed in publicsuffix.org.
        /// </summary>
        [pbr::OriginalName("INVALID_TOP_LEVEL_DOMAIN")] InvalidTopLevelDomain = 53,
        /// <summary>
        /// Malformed top level domain in URL.
        /// </summary>
        [pbr::OriginalName("MALFORMED_TOP_LEVEL_DOMAIN")] MalformedTopLevelDomain = 54,
        /// <summary>
        /// Malformed URL.
        /// </summary>
        [pbr::OriginalName("MALFORMED_URL")] MalformedUrl = 55,
        /// <summary>
        /// No host found in URL.
        /// </summary>
        [pbr::OriginalName("MISSING_HOST")] MissingHost = 56,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
