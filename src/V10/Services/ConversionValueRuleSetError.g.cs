// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/conversion_value_rule_set_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/conversion_value_rule_set_error.proto</summary>
  public static partial class ConversionValueRuleSetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/conversion_value_rule_set_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionValueRuleSetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2NvbnZlcnNpb25f",
            "dmFsdWVfcnVsZV9zZXRfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMC5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "vQQKH0NvbnZlcnNpb25WYWx1ZVJ1bGVTZXRFcnJvckVudW0imQQKG0NvbnZl",
            "cnNpb25WYWx1ZVJ1bGVTZXRFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VO",
            "S05PV04QARIlCiFDT05GTElDVElOR19WQUxVRV9SVUxFX0NPTkRJVElPTlMQ",
            "AhIWChJJTlZBTElEX1ZBTFVFX1JVTEUQAxInCiNESU1FTlNJT05TX1VQREFU",
            "RV9PTkxZX0FMTE9XX0FQUEVORBAEEh4KGkNPTkRJVElPTl9UWVBFX05PVF9B",
            "TExPV0VEEAUSGAoURFVQTElDQVRFX0RJTUVOU0lPTlMQBhIXChNJTlZBTElE",
            "X0NBTVBBSUdOX0lEEAcSMgouQ0FOTk9UX1BBVVNFX1VOTEVTU19BTExfVkFM",
            "VUVfUlVMRVNfQVJFX1BBVVNFRBAIEjAKLFNIT1VMRF9QQVVTRV9XSEVOX0FM",
            "TF9WQUxVRV9SVUxFU19BUkVfUEFVU0VEEAkSLworVkFMVUVfUlVMRVNfTk9U",
            "X1NVUFBPUlRFRF9GT1JfQ0FNUEFJR05fVFlQRRAKEisKJ0lORUxJR0lCTEVf",
            "Q09OVkVSU0lPTl9BQ1RJT05fQ0FURUdPUklFUxALEjUKMURJTUVOU0lPTl9O",
            "T19DT05ESVRJT05fVVNFRF9XSVRIX09USEVSX0RJTUVOU0lPTlMQDBImCiJE",
            "SU1FTlNJT05fTk9fQ09ORElUSU9OX05PVF9BTExPV0VEEA1CgAIKI2NvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZXJyb3JzQiBDb252ZXJzaW9uVmFs",
            "dWVSdWxlU2V0RXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL2Vycm9ycztlcnJv",
            "cnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTAuRXJyb3JzygIf",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjEwXEVycm9yc+oCI0dvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYxMDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleSetErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleSetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleSetErrorEnum.Types.ConversionValueRuleSetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible conversion value rule set errors.
  /// </summary>
  public sealed partial class ConversionValueRuleSetErrorEnum : pb::IMessage<ConversionValueRuleSetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionValueRuleSetErrorEnum> _parser = new pb::MessageParser<ConversionValueRuleSetErrorEnum>(() => new ConversionValueRuleSetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionValueRuleSetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleSetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleSetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleSetErrorEnum(ConversionValueRuleSetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleSetErrorEnum Clone() {
      return new ConversionValueRuleSetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionValueRuleSetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionValueRuleSetErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConversionValueRuleSetErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ConversionValueRuleSetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible conversion value rule set errors.
      /// </summary>
      public enum ConversionValueRuleSetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Two value rules in this value rule set contain conflicting conditions.
        /// </summary>
        [pbr::OriginalName("CONFLICTING_VALUE_RULE_CONDITIONS")] ConflictingValueRuleConditions = 2,
        /// <summary>
        /// This value rule set includes a value rule that cannot be found, has been
        /// permanently removed or belongs to a different customer.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_RULE")] InvalidValueRule = 3,
        /// <summary>
        /// An error that's thrown when a mutate operation is trying to
        /// replace/remove some existing elements in the dimensions field. In other
        /// words, ADD op is always fine and UPDATE op is fine if it's only appending
        /// new elements into dimensions list.
        /// </summary>
        [pbr::OriginalName("DIMENSIONS_UPDATE_ONLY_ALLOW_APPEND")] DimensionsUpdateOnlyAllowAppend = 4,
        /// <summary>
        /// An error that's thrown when a mutate is adding new value rule(s) into a
        /// value rule set and the added value rule(s) include conditions that are
        /// not specified in the dimensions of the value rule set.
        /// </summary>
        [pbr::OriginalName("CONDITION_TYPE_NOT_ALLOWED")] ConditionTypeNotAllowed = 5,
        /// <summary>
        /// The dimensions field contains duplicate elements.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_DIMENSIONS")] DuplicateDimensions = 6,
        /// <summary>
        /// This value rule set is attached to an invalid campaign id. Either a
        /// campaign with this campaign id doesn't exist or it belongs to a different
        /// customer.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN_ID")] InvalidCampaignId = 7,
        /// <summary>
        /// When a mutate request tries to pause a value rule set, the enabled
        /// value rules in this set must be paused in the same command, or this error
        /// will be thrown.
        /// </summary>
        [pbr::OriginalName("CANNOT_PAUSE_UNLESS_ALL_VALUE_RULES_ARE_PAUSED")] CannotPauseUnlessAllValueRulesArePaused = 8,
        /// <summary>
        /// When a mutate request tries to pause all the value rules in a value rule
        /// set, the value rule set must be paused, or this error will be thrown.
        /// </summary>
        [pbr::OriginalName("SHOULD_PAUSE_WHEN_ALL_VALUE_RULES_ARE_PAUSED")] ShouldPauseWhenAllValueRulesArePaused = 9,
        /// <summary>
        /// This value rule set is attached to a campaign that does not support value
        /// rules. Currently, campaign level value rule sets can only be created on
        /// Search, or Display campaigns.
        /// </summary>
        [pbr::OriginalName("VALUE_RULES_NOT_SUPPORTED_FOR_CAMPAIGN_TYPE")] ValueRulesNotSupportedForCampaignType = 10,
        /// <summary>
        /// To add a value rule set that applies on Store Visits/Store Sales
        /// conversion action categories, the customer must have valid Store Visits/
        /// Store Sales conversion actions.
        /// </summary>
        [pbr::OriginalName("INELIGIBLE_CONVERSION_ACTION_CATEGORIES")] IneligibleConversionActionCategories = 11,
        /// <summary>
        /// If NO_CONDITION is used as a dimension of a value rule set, it must be
        /// the only dimension.
        /// </summary>
        [pbr::OriginalName("DIMENSION_NO_CONDITION_USED_WITH_OTHER_DIMENSIONS")] DimensionNoConditionUsedWithOtherDimensions = 12,
        /// <summary>
        /// Dimension NO_CONDITION can only be used by Store Visits/Store Sales value
        /// rule set.
        /// </summary>
        [pbr::OriginalName("DIMENSION_NO_CONDITION_NOT_ALLOWED")] DimensionNoConditionNotAllowed = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
