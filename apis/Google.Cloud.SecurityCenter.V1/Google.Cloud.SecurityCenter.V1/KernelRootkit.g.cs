// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/kernel_rootkit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/kernel_rootkit.proto</summary>
  public static partial class KernelRootkitReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/kernel_rootkit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KernelRootkitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEva2VybmVsX3Jvb3Rr",
            "aXQucHJvdG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MSLXAgoN",
            "S2VybmVsUm9vdGtpdBIMCgRuYW1lGAEgASgJEiQKHHVuZXhwZWN0ZWRfY29k",
            "ZV9tb2RpZmljYXRpb24YAiABKAgSLgomdW5leHBlY3RlZF9yZWFkX29ubHlf",
            "ZGF0YV9tb2RpZmljYXRpb24YAyABKAgSIQoZdW5leHBlY3RlZF9mdHJhY2Vf",
            "aGFuZGxlchgEIAEoCBIhChl1bmV4cGVjdGVkX2twcm9iZV9oYW5kbGVyGAUg",
            "ASgIEiQKHHVuZXhwZWN0ZWRfa2VybmVsX2NvZGVfcGFnZXMYBiABKAgSJgoe",
            "dW5leHBlY3RlZF9zeXN0ZW1fY2FsbF9oYW5kbGVyGAcgASgIEiQKHHVuZXhw",
            "ZWN0ZWRfaW50ZXJydXB0X2hhbmRsZXIYCCABKAgSKAogdW5leHBlY3RlZF9w",
            "cm9jZXNzZXNfaW5fcnVucXVldWUYCSABKAhC7AEKImNvbS5nb29nbGUuY2xv",
            "dWQuc2VjdXJpdHljZW50ZXIudjFCEktlcm5lbFJvb3RraXRQcm90b1ABWkpj",
            "bG91ZC5nb29nbGUuY29tL2dvL3NlY3VyaXR5Y2VudGVyL2FwaXYxL3NlY3Vy",
            "aXR5Y2VudGVycGI7c2VjdXJpdHljZW50ZXJwYqoCHkdvb2dsZS5DbG91ZC5T",
            "ZWN1cml0eUNlbnRlci5WMcoCHkdvb2dsZVxDbG91ZFxTZWN1cml0eUNlbnRl",
            "clxWMeoCIUdvb2dsZTo6Q2xvdWQ6OlNlY3VyaXR5Q2VudGVyOjpWMWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.KernelRootkit), global::Google.Cloud.SecurityCenter.V1.KernelRootkit.Parser, new[]{ "Name", "UnexpectedCodeModification", "UnexpectedReadOnlyDataModification", "UnexpectedFtraceHandler", "UnexpectedKprobeHandler", "UnexpectedKernelCodePages", "UnexpectedSystemCallHandler", "UnexpectedInterruptHandler", "UnexpectedProcessesInRunqueue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Kernel mode rootkit signatures.
  /// </summary>
  public sealed partial class KernelRootkit : pb::IMessage<KernelRootkit>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KernelRootkit> _parser = new pb::MessageParser<KernelRootkit>(() => new KernelRootkit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KernelRootkit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.KernelRootkitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KernelRootkit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KernelRootkit(KernelRootkit other) : this() {
      name_ = other.name_;
      unexpectedCodeModification_ = other.unexpectedCodeModification_;
      unexpectedReadOnlyDataModification_ = other.unexpectedReadOnlyDataModification_;
      unexpectedFtraceHandler_ = other.unexpectedFtraceHandler_;
      unexpectedKprobeHandler_ = other.unexpectedKprobeHandler_;
      unexpectedKernelCodePages_ = other.unexpectedKernelCodePages_;
      unexpectedSystemCallHandler_ = other.unexpectedSystemCallHandler_;
      unexpectedInterruptHandler_ = other.unexpectedInterruptHandler_;
      unexpectedProcessesInRunqueue_ = other.unexpectedProcessesInRunqueue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KernelRootkit Clone() {
      return new KernelRootkit(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Rootkit name when available.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unexpected_code_modification" field.</summary>
    public const int UnexpectedCodeModificationFieldNumber = 2;
    private bool unexpectedCodeModification_;
    /// <summary>
    /// True if unexpected modifications of kernel code memory are present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedCodeModification {
      get { return unexpectedCodeModification_; }
      set {
        unexpectedCodeModification_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_read_only_data_modification" field.</summary>
    public const int UnexpectedReadOnlyDataModificationFieldNumber = 3;
    private bool unexpectedReadOnlyDataModification_;
    /// <summary>
    /// True if unexpected modifications of kernel read-only data memory are
    /// present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedReadOnlyDataModification {
      get { return unexpectedReadOnlyDataModification_; }
      set {
        unexpectedReadOnlyDataModification_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_ftrace_handler" field.</summary>
    public const int UnexpectedFtraceHandlerFieldNumber = 4;
    private bool unexpectedFtraceHandler_;
    /// <summary>
    /// True if `ftrace` points are present with callbacks pointing to regions
    /// that are not in the expected kernel or module code range.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedFtraceHandler {
      get { return unexpectedFtraceHandler_; }
      set {
        unexpectedFtraceHandler_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_kprobe_handler" field.</summary>
    public const int UnexpectedKprobeHandlerFieldNumber = 5;
    private bool unexpectedKprobeHandler_;
    /// <summary>
    /// True if `kprobe` points are present with callbacks pointing to regions
    /// that are not in the expected kernel or module code range.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedKprobeHandler {
      get { return unexpectedKprobeHandler_; }
      set {
        unexpectedKprobeHandler_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_kernel_code_pages" field.</summary>
    public const int UnexpectedKernelCodePagesFieldNumber = 6;
    private bool unexpectedKernelCodePages_;
    /// <summary>
    /// True if kernel code pages that are not in the expected kernel or module
    /// code regions are present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedKernelCodePages {
      get { return unexpectedKernelCodePages_; }
      set {
        unexpectedKernelCodePages_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_system_call_handler" field.</summary>
    public const int UnexpectedSystemCallHandlerFieldNumber = 7;
    private bool unexpectedSystemCallHandler_;
    /// <summary>
    /// True if system call handlers that are are not in the expected kernel or
    /// module code regions are present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedSystemCallHandler {
      get { return unexpectedSystemCallHandler_; }
      set {
        unexpectedSystemCallHandler_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_interrupt_handler" field.</summary>
    public const int UnexpectedInterruptHandlerFieldNumber = 8;
    private bool unexpectedInterruptHandler_;
    /// <summary>
    /// True if interrupt handlers that are are not in the expected kernel or
    /// module code regions are present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedInterruptHandler {
      get { return unexpectedInterruptHandler_; }
      set {
        unexpectedInterruptHandler_ = value;
      }
    }

    /// <summary>Field number for the "unexpected_processes_in_runqueue" field.</summary>
    public const int UnexpectedProcessesInRunqueueFieldNumber = 9;
    private bool unexpectedProcessesInRunqueue_;
    /// <summary>
    /// True if unexpected processes in the scheduler run queue are present. Such
    /// processes are in the run queue, but not in the process task list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UnexpectedProcessesInRunqueue {
      get { return unexpectedProcessesInRunqueue_; }
      set {
        unexpectedProcessesInRunqueue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KernelRootkit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KernelRootkit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (UnexpectedCodeModification != other.UnexpectedCodeModification) return false;
      if (UnexpectedReadOnlyDataModification != other.UnexpectedReadOnlyDataModification) return false;
      if (UnexpectedFtraceHandler != other.UnexpectedFtraceHandler) return false;
      if (UnexpectedKprobeHandler != other.UnexpectedKprobeHandler) return false;
      if (UnexpectedKernelCodePages != other.UnexpectedKernelCodePages) return false;
      if (UnexpectedSystemCallHandler != other.UnexpectedSystemCallHandler) return false;
      if (UnexpectedInterruptHandler != other.UnexpectedInterruptHandler) return false;
      if (UnexpectedProcessesInRunqueue != other.UnexpectedProcessesInRunqueue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (UnexpectedCodeModification != false) hash ^= UnexpectedCodeModification.GetHashCode();
      if (UnexpectedReadOnlyDataModification != false) hash ^= UnexpectedReadOnlyDataModification.GetHashCode();
      if (UnexpectedFtraceHandler != false) hash ^= UnexpectedFtraceHandler.GetHashCode();
      if (UnexpectedKprobeHandler != false) hash ^= UnexpectedKprobeHandler.GetHashCode();
      if (UnexpectedKernelCodePages != false) hash ^= UnexpectedKernelCodePages.GetHashCode();
      if (UnexpectedSystemCallHandler != false) hash ^= UnexpectedSystemCallHandler.GetHashCode();
      if (UnexpectedInterruptHandler != false) hash ^= UnexpectedInterruptHandler.GetHashCode();
      if (UnexpectedProcessesInRunqueue != false) hash ^= UnexpectedProcessesInRunqueue.GetHashCode();
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
      if (UnexpectedCodeModification != false) {
        output.WriteRawTag(16);
        output.WriteBool(UnexpectedCodeModification);
      }
      if (UnexpectedReadOnlyDataModification != false) {
        output.WriteRawTag(24);
        output.WriteBool(UnexpectedReadOnlyDataModification);
      }
      if (UnexpectedFtraceHandler != false) {
        output.WriteRawTag(32);
        output.WriteBool(UnexpectedFtraceHandler);
      }
      if (UnexpectedKprobeHandler != false) {
        output.WriteRawTag(40);
        output.WriteBool(UnexpectedKprobeHandler);
      }
      if (UnexpectedKernelCodePages != false) {
        output.WriteRawTag(48);
        output.WriteBool(UnexpectedKernelCodePages);
      }
      if (UnexpectedSystemCallHandler != false) {
        output.WriteRawTag(56);
        output.WriteBool(UnexpectedSystemCallHandler);
      }
      if (UnexpectedInterruptHandler != false) {
        output.WriteRawTag(64);
        output.WriteBool(UnexpectedInterruptHandler);
      }
      if (UnexpectedProcessesInRunqueue != false) {
        output.WriteRawTag(72);
        output.WriteBool(UnexpectedProcessesInRunqueue);
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
      if (UnexpectedCodeModification != false) {
        output.WriteRawTag(16);
        output.WriteBool(UnexpectedCodeModification);
      }
      if (UnexpectedReadOnlyDataModification != false) {
        output.WriteRawTag(24);
        output.WriteBool(UnexpectedReadOnlyDataModification);
      }
      if (UnexpectedFtraceHandler != false) {
        output.WriteRawTag(32);
        output.WriteBool(UnexpectedFtraceHandler);
      }
      if (UnexpectedKprobeHandler != false) {
        output.WriteRawTag(40);
        output.WriteBool(UnexpectedKprobeHandler);
      }
      if (UnexpectedKernelCodePages != false) {
        output.WriteRawTag(48);
        output.WriteBool(UnexpectedKernelCodePages);
      }
      if (UnexpectedSystemCallHandler != false) {
        output.WriteRawTag(56);
        output.WriteBool(UnexpectedSystemCallHandler);
      }
      if (UnexpectedInterruptHandler != false) {
        output.WriteRawTag(64);
        output.WriteBool(UnexpectedInterruptHandler);
      }
      if (UnexpectedProcessesInRunqueue != false) {
        output.WriteRawTag(72);
        output.WriteBool(UnexpectedProcessesInRunqueue);
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
      if (UnexpectedCodeModification != false) {
        size += 1 + 1;
      }
      if (UnexpectedReadOnlyDataModification != false) {
        size += 1 + 1;
      }
      if (UnexpectedFtraceHandler != false) {
        size += 1 + 1;
      }
      if (UnexpectedKprobeHandler != false) {
        size += 1 + 1;
      }
      if (UnexpectedKernelCodePages != false) {
        size += 1 + 1;
      }
      if (UnexpectedSystemCallHandler != false) {
        size += 1 + 1;
      }
      if (UnexpectedInterruptHandler != false) {
        size += 1 + 1;
      }
      if (UnexpectedProcessesInRunqueue != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KernelRootkit other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.UnexpectedCodeModification != false) {
        UnexpectedCodeModification = other.UnexpectedCodeModification;
      }
      if (other.UnexpectedReadOnlyDataModification != false) {
        UnexpectedReadOnlyDataModification = other.UnexpectedReadOnlyDataModification;
      }
      if (other.UnexpectedFtraceHandler != false) {
        UnexpectedFtraceHandler = other.UnexpectedFtraceHandler;
      }
      if (other.UnexpectedKprobeHandler != false) {
        UnexpectedKprobeHandler = other.UnexpectedKprobeHandler;
      }
      if (other.UnexpectedKernelCodePages != false) {
        UnexpectedKernelCodePages = other.UnexpectedKernelCodePages;
      }
      if (other.UnexpectedSystemCallHandler != false) {
        UnexpectedSystemCallHandler = other.UnexpectedSystemCallHandler;
      }
      if (other.UnexpectedInterruptHandler != false) {
        UnexpectedInterruptHandler = other.UnexpectedInterruptHandler;
      }
      if (other.UnexpectedProcessesInRunqueue != false) {
        UnexpectedProcessesInRunqueue = other.UnexpectedProcessesInRunqueue;
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
          case 16: {
            UnexpectedCodeModification = input.ReadBool();
            break;
          }
          case 24: {
            UnexpectedReadOnlyDataModification = input.ReadBool();
            break;
          }
          case 32: {
            UnexpectedFtraceHandler = input.ReadBool();
            break;
          }
          case 40: {
            UnexpectedKprobeHandler = input.ReadBool();
            break;
          }
          case 48: {
            UnexpectedKernelCodePages = input.ReadBool();
            break;
          }
          case 56: {
            UnexpectedSystemCallHandler = input.ReadBool();
            break;
          }
          case 64: {
            UnexpectedInterruptHandler = input.ReadBool();
            break;
          }
          case 72: {
            UnexpectedProcessesInRunqueue = input.ReadBool();
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
          case 16: {
            UnexpectedCodeModification = input.ReadBool();
            break;
          }
          case 24: {
            UnexpectedReadOnlyDataModification = input.ReadBool();
            break;
          }
          case 32: {
            UnexpectedFtraceHandler = input.ReadBool();
            break;
          }
          case 40: {
            UnexpectedKprobeHandler = input.ReadBool();
            break;
          }
          case 48: {
            UnexpectedKernelCodePages = input.ReadBool();
            break;
          }
          case 56: {
            UnexpectedSystemCallHandler = input.ReadBool();
            break;
          }
          case 64: {
            UnexpectedInterruptHandler = input.ReadBool();
            break;
          }
          case 72: {
            UnexpectedProcessesInRunqueue = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
