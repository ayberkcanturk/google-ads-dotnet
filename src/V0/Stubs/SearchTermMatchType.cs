// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/search_term_match_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/search_term_match_type.proto</summary>
  public static partial class SearchTermMatchTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/search_term_match_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SearchTermMatchTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9zZWFyY2hfdGVybV9t",
            "YXRjaF90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVt",
            "cyKRAQoXU2VhcmNoVGVybU1hdGNoVHlwZUVudW0idgoTU2VhcmNoVGVybU1h",
            "dGNoVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIJCgVCUk9B",
            "RBACEgkKBUVYQUNUEAMSCgoGUEhSQVNFEAQSDgoKTkVBUl9FWEFDVBAFEg8K",
            "C05FQVJfUEhSQVNFEAZC7QEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MC5lbnVtc0IYU2VhcmNoVGVybU1hdGNoVHlwZVByb3RvUAFaQmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MC9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYw",
            "LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXPqAiFHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.SearchTermMatchTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.SearchTermMatchTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.SearchTermMatchTypeEnum.Types.SearchTermMatchType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing match types for a keyword triggering an ad.
  /// </summary>
  public sealed partial class SearchTermMatchTypeEnum : pb::IMessage<SearchTermMatchTypeEnum> {
    private static readonly pb::MessageParser<SearchTermMatchTypeEnum> _parser = new pb::MessageParser<SearchTermMatchTypeEnum>(() => new SearchTermMatchTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SearchTermMatchTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.SearchTermMatchTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchTermMatchTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchTermMatchTypeEnum(SearchTermMatchTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchTermMatchTypeEnum Clone() {
      return new SearchTermMatchTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SearchTermMatchTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SearchTermMatchTypeEnum other) {
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
    public void MergeFrom(SearchTermMatchTypeEnum other) {
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
    /// <summary>Container for nested types declared in the SearchTermMatchTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible match types for a keyword triggering an ad, including variants.
      /// </summary>
      public enum SearchTermMatchType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Broad match.
        /// </summary>
        [pbr::OriginalName("BROAD")] Broad = 2,
        /// <summary>
        /// Exact match.
        /// </summary>
        [pbr::OriginalName("EXACT")] Exact = 3,
        /// <summary>
        /// Phrase match.
        /// </summary>
        [pbr::OriginalName("PHRASE")] Phrase = 4,
        /// <summary>
        /// Exact match (close variant).
        /// </summary>
        [pbr::OriginalName("NEAR_EXACT")] NearExact = 5,
        /// <summary>
        /// Phrase match (close variant).
        /// </summary>
        [pbr::OriginalName("NEAR_PHRASE")] NearPhrase = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
