// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/connectors/v1/runtime.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Connectors.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/connectors/v1/runtime.proto</summary>
  public static partial class RuntimeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/connectors/v1/runtime.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RuntimeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvY29ubmVjdG9ycy92MS9ydW50aW1lLnByb3RvEhpn",
            "b29nbGUuY2xvdWQuY29ubmVjdG9ycy52MRofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJYChdH",
            "ZXRSdW50aW1lQ29uZmlnUmVxdWVzdBI9CgRuYW1lGAEgASgJQi/gQQL6QSkK",
            "J2Nvbm5lY3RvcnMuZ29vZ2xlYXBpcy5jb20vUnVudGltZUNvbmZpZyLHBAoN",
            "UnVudGltZUNvbmZpZxIYCgtsb2NhdGlvbl9pZBgBIAEoCUID4EEDEhgKC2Nv",
            "bm5kX3RvcGljGAIgASgJQgPgQQMSHwoSY29ubmRfc3Vic2NyaXB0aW9uGAMg",
            "ASgJQgPgQQMSIAoTY29udHJvbF9wbGFuZV90b3BpYxgEIAEoCUID4EEDEicK",
            "GmNvbnRyb2xfcGxhbmVfc3Vic2NyaXB0aW9uGAUgASgJQgPgQQMSHQoQcnVu",
            "dGltZV9lbmRwb2ludBgGIAEoCUID4EEDEkMKBXN0YXRlGAcgASgOMi8uZ29v",
            "Z2xlLmNsb3VkLmNvbm5lY3RvcnMudjEuUnVudGltZUNvbmZpZy5TdGF0ZUID",
            "4EEDEh4KEXNjaGVtYV9nY3NfYnVja2V0GAggASgJQgPgQQMSHgoRc2Vydmlj",
            "ZV9kaXJlY3RvcnkYCSABKAlCA+BBAxIRCgRuYW1lGAsgASgJQgPgQQMiegoF",
            "U3RhdGUSFQoRU1RBVEVfVU5TUEVDSUZJRUQQABIQCghJTkFDVElWRRABGgII",
            "ARISCgpBQ1RJVkFUSU5HEAIaAggBEgoKBkFDVElWRRADEgwKCENSRUFUSU5H",
            "EAQSDAoIREVMRVRJTkcQBRIMCghVUERBVElORxAGOmPqQWAKJ2Nvbm5lY3Rv",
            "cnMuZ29vZ2xlYXBpcy5jb20vUnVudGltZUNvbmZpZxI1cHJvamVjdHMve3By",
            "b2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L3J1bnRpbWVDb25maWdCcAoe",
            "Y29tLmdvb2dsZS5jbG91ZC5jb25uZWN0b3JzLnYxQgxSdW50aW1lUHJvdG9Q",
            "AVo+Y2xvdWQuZ29vZ2xlLmNvbS9nby9jb25uZWN0b3JzL2FwaXYxL2Nvbm5l",
            "Y3RvcnNwYjtjb25uZWN0b3JzcGJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Connectors.V1.GetRuntimeConfigRequest), global::Google.Cloud.Connectors.V1.GetRuntimeConfigRequest.Parser, new[]{ "Name" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Connectors.V1.RuntimeConfig), global::Google.Cloud.Connectors.V1.RuntimeConfig.Parser, new[]{ "LocationId", "ConndTopic", "ConndSubscription", "ControlPlaneTopic", "ControlPlaneSubscription", "RuntimeEndpoint", "State", "SchemaGcsBucket", "ServiceDirectory", "Name" }, null, new[]{ typeof(global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for Connectors.GetRuntimeConfig.
  /// </summary>
  public sealed partial class GetRuntimeConfigRequest : pb::IMessage<GetRuntimeConfigRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetRuntimeConfigRequest> _parser = new pb::MessageParser<GetRuntimeConfigRequest>(() => new GetRuntimeConfigRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetRuntimeConfigRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Connectors.V1.RuntimeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRuntimeConfigRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRuntimeConfigRequest(GetRuntimeConfigRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRuntimeConfigRequest Clone() {
      return new GetRuntimeConfigRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. Resource name of the form:
    /// `projects/*/locations/*/runtimeConfig`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetRuntimeConfigRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetRuntimeConfigRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetRuntimeConfigRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// RuntimeConfig is the singleton resource of each location.
  /// It includes generic resource configs consumed by control plane and runtime
  /// plane like: pub/sub topic/subscription resource name, Cloud Storage location
  /// storing schema etc.
  /// </summary>
  public sealed partial class RuntimeConfig : pb::IMessage<RuntimeConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RuntimeConfig> _parser = new pb::MessageParser<RuntimeConfig>(() => new RuntimeConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RuntimeConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Connectors.V1.RuntimeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RuntimeConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RuntimeConfig(RuntimeConfig other) : this() {
      locationId_ = other.locationId_;
      conndTopic_ = other.conndTopic_;
      conndSubscription_ = other.conndSubscription_;
      controlPlaneTopic_ = other.controlPlaneTopic_;
      controlPlaneSubscription_ = other.controlPlaneSubscription_;
      runtimeEndpoint_ = other.runtimeEndpoint_;
      state_ = other.state_;
      schemaGcsBucket_ = other.schemaGcsBucket_;
      serviceDirectory_ = other.serviceDirectory_;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RuntimeConfig Clone() {
      return new RuntimeConfig(this);
    }

    /// <summary>Field number for the "location_id" field.</summary>
    public const int LocationIdFieldNumber = 1;
    private string locationId_ = "";
    /// <summary>
    /// Output only. location_id of the runtime location. E.g. "us-west1".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LocationId {
      get { return locationId_; }
      set {
        locationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "connd_topic" field.</summary>
    public const int ConndTopicFieldNumber = 2;
    private string conndTopic_ = "";
    /// <summary>
    /// Output only. Pub/Sub topic for connd to send message.
    /// E.g. projects/{project-id}/topics/{topic-id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConndTopic {
      get { return conndTopic_; }
      set {
        conndTopic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "connd_subscription" field.</summary>
    public const int ConndSubscriptionFieldNumber = 3;
    private string conndSubscription_ = "";
    /// <summary>
    /// Output only. Pub/Sub subscription for connd to receive message.
    /// E.g. projects/{project-id}/subscriptions/{topic-id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConndSubscription {
      get { return conndSubscription_; }
      set {
        conndSubscription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "control_plane_topic" field.</summary>
    public const int ControlPlaneTopicFieldNumber = 4;
    private string controlPlaneTopic_ = "";
    /// <summary>
    /// Output only. Pub/Sub topic for control plne to send message.
    /// communication.
    /// E.g. projects/{project-id}/topics/{topic-id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ControlPlaneTopic {
      get { return controlPlaneTopic_; }
      set {
        controlPlaneTopic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "control_plane_subscription" field.</summary>
    public const int ControlPlaneSubscriptionFieldNumber = 5;
    private string controlPlaneSubscription_ = "";
    /// <summary>
    /// Output only. Pub/Sub subscription for control plane to receive message.
    /// E.g. projects/{project-id}/subscriptions/{topic-id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ControlPlaneSubscription {
      get { return controlPlaneSubscription_; }
      set {
        controlPlaneSubscription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "runtime_endpoint" field.</summary>
    public const int RuntimeEndpointFieldNumber = 6;
    private string runtimeEndpoint_ = "";
    /// <summary>
    /// Output only. The endpoint of the connectors runtime ingress.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RuntimeEndpoint {
      get { return runtimeEndpoint_; }
      set {
        runtimeEndpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 7;
    private global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State state_ = global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State.Unspecified;
    /// <summary>
    /// Output only. The state of the location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "schema_gcs_bucket" field.</summary>
    public const int SchemaGcsBucketFieldNumber = 8;
    private string schemaGcsBucket_ = "";
    /// <summary>
    /// Output only. The Cloud Storage bucket that stores connector's schema
    /// reports.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SchemaGcsBucket {
      get { return schemaGcsBucket_; }
      set {
        schemaGcsBucket_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "service_directory" field.</summary>
    public const int ServiceDirectoryFieldNumber = 9;
    private string serviceDirectory_ = "";
    /// <summary>
    /// Output only. The name of the Service Directory service name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServiceDirectory {
      get { return serviceDirectory_; }
      set {
        serviceDirectory_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 11;
    private string name_ = "";
    /// <summary>
    /// Output only. Name of the runtimeConfig resource.
    /// Format: projects/{project}/locations/{location}/runtimeConfig
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RuntimeConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RuntimeConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LocationId != other.LocationId) return false;
      if (ConndTopic != other.ConndTopic) return false;
      if (ConndSubscription != other.ConndSubscription) return false;
      if (ControlPlaneTopic != other.ControlPlaneTopic) return false;
      if (ControlPlaneSubscription != other.ControlPlaneSubscription) return false;
      if (RuntimeEndpoint != other.RuntimeEndpoint) return false;
      if (State != other.State) return false;
      if (SchemaGcsBucket != other.SchemaGcsBucket) return false;
      if (ServiceDirectory != other.ServiceDirectory) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LocationId.Length != 0) hash ^= LocationId.GetHashCode();
      if (ConndTopic.Length != 0) hash ^= ConndTopic.GetHashCode();
      if (ConndSubscription.Length != 0) hash ^= ConndSubscription.GetHashCode();
      if (ControlPlaneTopic.Length != 0) hash ^= ControlPlaneTopic.GetHashCode();
      if (ControlPlaneSubscription.Length != 0) hash ^= ControlPlaneSubscription.GetHashCode();
      if (RuntimeEndpoint.Length != 0) hash ^= RuntimeEndpoint.GetHashCode();
      if (State != global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (SchemaGcsBucket.Length != 0) hash ^= SchemaGcsBucket.GetHashCode();
      if (ServiceDirectory.Length != 0) hash ^= ServiceDirectory.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (LocationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LocationId);
      }
      if (ConndTopic.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ConndTopic);
      }
      if (ConndSubscription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ConndSubscription);
      }
      if (ControlPlaneTopic.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ControlPlaneTopic);
      }
      if (ControlPlaneSubscription.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ControlPlaneSubscription);
      }
      if (RuntimeEndpoint.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RuntimeEndpoint);
      }
      if (State != global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) State);
      }
      if (SchemaGcsBucket.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SchemaGcsBucket);
      }
      if (ServiceDirectory.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ServiceDirectory);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LocationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LocationId);
      }
      if (ConndTopic.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ConndTopic);
      }
      if (ConndSubscription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ConndSubscription);
      }
      if (ControlPlaneTopic.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ControlPlaneTopic);
      }
      if (ControlPlaneSubscription.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ControlPlaneSubscription);
      }
      if (RuntimeEndpoint.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RuntimeEndpoint);
      }
      if (State != global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) State);
      }
      if (SchemaGcsBucket.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SchemaGcsBucket);
      }
      if (ServiceDirectory.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ServiceDirectory);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LocationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocationId);
      }
      if (ConndTopic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConndTopic);
      }
      if (ConndSubscription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConndSubscription);
      }
      if (ControlPlaneTopic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ControlPlaneTopic);
      }
      if (ControlPlaneSubscription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ControlPlaneSubscription);
      }
      if (RuntimeEndpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RuntimeEndpoint);
      }
      if (State != global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (SchemaGcsBucket.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaGcsBucket);
      }
      if (ServiceDirectory.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceDirectory);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RuntimeConfig other) {
      if (other == null) {
        return;
      }
      if (other.LocationId.Length != 0) {
        LocationId = other.LocationId;
      }
      if (other.ConndTopic.Length != 0) {
        ConndTopic = other.ConndTopic;
      }
      if (other.ConndSubscription.Length != 0) {
        ConndSubscription = other.ConndSubscription;
      }
      if (other.ControlPlaneTopic.Length != 0) {
        ControlPlaneTopic = other.ControlPlaneTopic;
      }
      if (other.ControlPlaneSubscription.Length != 0) {
        ControlPlaneSubscription = other.ControlPlaneSubscription;
      }
      if (other.RuntimeEndpoint.Length != 0) {
        RuntimeEndpoint = other.RuntimeEndpoint;
      }
      if (other.State != global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.SchemaGcsBucket.Length != 0) {
        SchemaGcsBucket = other.SchemaGcsBucket;
      }
      if (other.ServiceDirectory.Length != 0) {
        ServiceDirectory = other.ServiceDirectory;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            LocationId = input.ReadString();
            break;
          }
          case 18: {
            ConndTopic = input.ReadString();
            break;
          }
          case 26: {
            ConndSubscription = input.ReadString();
            break;
          }
          case 34: {
            ControlPlaneTopic = input.ReadString();
            break;
          }
          case 42: {
            ControlPlaneSubscription = input.ReadString();
            break;
          }
          case 50: {
            RuntimeEndpoint = input.ReadString();
            break;
          }
          case 56: {
            State = (global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State) input.ReadEnum();
            break;
          }
          case 66: {
            SchemaGcsBucket = input.ReadString();
            break;
          }
          case 74: {
            ServiceDirectory = input.ReadString();
            break;
          }
          case 90: {
            Name = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            LocationId = input.ReadString();
            break;
          }
          case 18: {
            ConndTopic = input.ReadString();
            break;
          }
          case 26: {
            ConndSubscription = input.ReadString();
            break;
          }
          case 34: {
            ControlPlaneTopic = input.ReadString();
            break;
          }
          case 42: {
            ControlPlaneSubscription = input.ReadString();
            break;
          }
          case 50: {
            RuntimeEndpoint = input.ReadString();
            break;
          }
          case 56: {
            State = (global::Google.Cloud.Connectors.V1.RuntimeConfig.Types.State) input.ReadEnum();
            break;
          }
          case 66: {
            SchemaGcsBucket = input.ReadString();
            break;
          }
          case 74: {
            ServiceDirectory = input.ReadString();
            break;
          }
          case 90: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RuntimeConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// State of the location.
      /// </summary>
      public enum State {
        /// <summary>
        /// STATE_UNSPECIFIED.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// INACTIVE.
        /// </summary>
        [global::System.ObsoleteAttribute]
        [pbr::OriginalName("INACTIVE")] Inactive = 1,
        /// <summary>
        /// ACTIVATING.
        /// </summary>
        [global::System.ObsoleteAttribute]
        [pbr::OriginalName("ACTIVATING")] Activating = 2,
        /// <summary>
        /// ACTIVE.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 3,
        /// <summary>
        /// CREATING.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 4,
        /// <summary>
        /// DELETING.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 5,
        /// <summary>
        /// UPDATING.
        /// </summary>
        [pbr::OriginalName("UPDATING")] Updating = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code