// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/customer_client.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/customer_client.proto</summary>
  public static partial class CustomerClientReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/customer_client.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "Y2xpZW50LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52MC5yZXNvdXJj",
            "ZXMaHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90byK2AQoOQ3VzdG9t",
            "ZXJDbGllbnQSFQoNcmVzb3VyY2VfbmFtZRgBIAEoCRI1Cg9jbGllbnRfY3Vz",
            "dG9tZXIYAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSKgoG",
            "aGlkZGVuGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLkJvb2xWYWx1ZRIqCgVs",
            "ZXZlbBgFIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQoACCiVj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2VzQhNDdXN0b21l",
            "ckNsaWVudFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXM7cmVzb3VyY2Vz",
            "ogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuUmVzb3VyY2VzygIh",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcUmVzb3VyY2Vz6gIlR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjA6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.CustomerClient), global::Google.Ads.GoogleAds.V0.Resources.CustomerClient.Parser, new[]{ "ResourceName", "ClientCustomer", "Hidden", "Level" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between the given customer and a client customer. CustomerClients only
  /// exist for manager customers. All direct and indirect client customers are
  /// included, as well as the manager itself.
  /// </summary>
  public sealed partial class CustomerClient : pb::IMessage<CustomerClient> {
    private static readonly pb::MessageParser<CustomerClient> _parser = new pb::MessageParser<CustomerClient>(() => new CustomerClient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.CustomerClientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClient(CustomerClient other) : this() {
      resourceName_ = other.resourceName_;
      ClientCustomer = other.ClientCustomer;
      Hidden = other.Hidden;
      Level = other.Level;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClient Clone() {
      return new CustomerClient(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the customer client.
    /// CustomerClient resource names have the form:
    /// `customers/{customer_id}/customerClients/{client_customer_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_customer" field.</summary>
    public const int ClientCustomerFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_clientCustomer_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string clientCustomer_;
    /// <summary>
    /// The resource name of the client-customer which is linked to
    /// the given customer. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientCustomer {
      get { return clientCustomer_; }
      set {
        clientCustomer_ = value;
      }
    }

    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 4;
    private static readonly pb::FieldCodec<bool?> _single_hidden_codec = pb::FieldCodec.ForStructWrapper<bool>(34);
    private bool? hidden_;
    /// <summary>
    /// Specifies whether this is a hidden account. Learn more about hidden
    /// accounts
    /// &lt;a href="https://support.google.com/google-ads/answer/7519830">here&lt;/a>.
    /// Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Hidden {
      get { return hidden_; }
      set {
        hidden_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_level_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? level_;
    /// <summary>
    /// Distance between given customer and client. For self link, the level value
    /// will be 0. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerClient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ClientCustomer != other.ClientCustomer) return false;
      if (Hidden != other.Hidden) return false;
      if (Level != other.Level) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (clientCustomer_ != null) hash ^= ClientCustomer.GetHashCode();
      if (hidden_ != null) hash ^= Hidden.GetHashCode();
      if (level_ != null) hash ^= Level.GetHashCode();
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
      if (clientCustomer_ != null) {
        _single_clientCustomer_codec.WriteTagAndValue(output, ClientCustomer);
      }
      if (hidden_ != null) {
        _single_hidden_codec.WriteTagAndValue(output, Hidden);
      }
      if (level_ != null) {
        _single_level_codec.WriteTagAndValue(output, Level);
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
      if (clientCustomer_ != null) {
        size += _single_clientCustomer_codec.CalculateSizeWithTag(ClientCustomer);
      }
      if (hidden_ != null) {
        size += _single_hidden_codec.CalculateSizeWithTag(Hidden);
      }
      if (level_ != null) {
        size += _single_level_codec.CalculateSizeWithTag(Level);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerClient other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.clientCustomer_ != null) {
        if (clientCustomer_ == null || other.ClientCustomer != "") {
          ClientCustomer = other.ClientCustomer;
        }
      }
      if (other.hidden_ != null) {
        if (hidden_ == null || other.Hidden != false) {
          Hidden = other.Hidden;
        }
      }
      if (other.level_ != null) {
        if (level_ == null || other.Level != 0L) {
          Level = other.Level;
        }
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
          case 26: {
            string value = _single_clientCustomer_codec.Read(input);
            if (clientCustomer_ == null || value != "") {
              ClientCustomer = value;
            }
            break;
          }
          case 34: {
            bool? value = _single_hidden_codec.Read(input);
            if (hidden_ == null || value != false) {
              Hidden = value;
            }
            break;
          }
          case 42: {
            long? value = _single_level_codec.Read(input);
            if (level_ == null || value != 0L) {
              Level = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
