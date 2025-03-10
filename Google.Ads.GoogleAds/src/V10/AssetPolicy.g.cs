// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/common/asset_policy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/common/asset_policy.proto</summary>
  public static partial class AssetPolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/common/asset_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetPolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvY29tbW9uL2Fzc2V0X3BvbGlj",
            "eS5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmNvbW1vbhosZ29v",
            "Z2xlL2Fkcy9nb29nbGVhZHMvdjEwL2NvbW1vbi9wb2xpY3kucHJvdG8aO2dv",
            "b2dsZS9hZHMvZ29vZ2xlYWRzL3YxMC9lbnVtcy9wb2xpY3lfYXBwcm92YWxf",
            "c3RhdHVzLnByb3RvGjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMv",
            "cG9saWN5X3Jldmlld19zdGF0dXMucHJvdG8isQIKFEFkQXNzZXRQb2xpY3lT",
            "dW1tYXJ5Ek8KFHBvbGljeV90b3BpY19lbnRyaWVzGAEgAygLMjEuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEwLmNvbW1vbi5Qb2xpY3lUb3BpY0VudHJ5EmAK",
            "DXJldmlld19zdGF0dXMYAiABKA4ySS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTAuZW51bXMuUG9saWN5UmV2aWV3U3RhdHVzRW51bS5Qb2xpY3lSZXZpZXdT",
            "dGF0dXMSZgoPYXBwcm92YWxfc3RhdHVzGAMgASgOMk0uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEwLmVudW1zLlBvbGljeUFwcHJvdmFsU3RhdHVzRW51bS5Q",
            "b2xpY3lBcHByb3ZhbFN0YXR1c0LwAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMC5jb21tb25CEEFzc2V0UG9saWN5UHJvdG9QAVpFZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "MC9jb21tb247Y29tbW9uogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjEwLkNvbW1vbsoCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMFxDb21tb27q",
            "AiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Common.PolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary), global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary.Parser, new[]{ "PolicyTopicEntries", "ReviewStatus", "ApprovalStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains policy information for an asset inside an ad.
  /// </summary>
  public sealed partial class AdAssetPolicySummary : pb::IMessage<AdAssetPolicySummary>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdAssetPolicySummary> _parser = new pb::MessageParser<AdAssetPolicySummary>(() => new AdAssetPolicySummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdAssetPolicySummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Common.AssetPolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdAssetPolicySummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdAssetPolicySummary(AdAssetPolicySummary other) : this() {
      policyTopicEntries_ = other.policyTopicEntries_.Clone();
      reviewStatus_ = other.reviewStatus_;
      approvalStatus_ = other.approvalStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdAssetPolicySummary Clone() {
      return new AdAssetPolicySummary(this);
    }

    /// <summary>Field number for the "policy_topic_entries" field.</summary>
    public const int PolicyTopicEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V10.Common.PolicyTopicEntry> _repeated_policyTopicEntries_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V10.Common.PolicyTopicEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V10.Common.PolicyTopicEntry> policyTopicEntries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V10.Common.PolicyTopicEntry>();
    /// <summary>
    /// The list of policy findings for this asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V10.Common.PolicyTopicEntry> PolicyTopicEntries {
      get { return policyTopicEntries_; }
    }

    /// <summary>Field number for the "review_status" field.</summary>
    public const int ReviewStatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus reviewStatus_ = global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified;
    /// <summary>
    /// Where in the review process this asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus ReviewStatus {
      get { return reviewStatus_; }
      set {
        reviewStatus_ = value;
      }
    }

    /// <summary>Field number for the "approval_status" field.</summary>
    public const int ApprovalStatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus approvalStatus_ = global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified;
    /// <summary>
    /// The overall approval status of this asset, which is calculated based on
    /// the status of its individual policy topic entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus ApprovalStatus {
      get { return approvalStatus_; }
      set {
        approvalStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdAssetPolicySummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdAssetPolicySummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!policyTopicEntries_.Equals(other.policyTopicEntries_)) return false;
      if (ReviewStatus != other.ReviewStatus) return false;
      if (ApprovalStatus != other.ApprovalStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= policyTopicEntries_.GetHashCode();
      if (ReviewStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) hash ^= ReviewStatus.GetHashCode();
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) hash ^= ApprovalStatus.GetHashCode();
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
      policyTopicEntries_.WriteTo(output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
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
      policyTopicEntries_.WriteTo(ref output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
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
      size += policyTopicEntries_.CalculateSize(_repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdAssetPolicySummary other) {
      if (other == null) {
        return;
      }
      policyTopicEntries_.Add(other.policyTopicEntries_);
      if (other.ReviewStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        ReviewStatus = other.ReviewStatus;
      }
      if (other.ApprovalStatus != global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        ApprovalStatus = other.ApprovalStatus;
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
            policyTopicEntries_.AddEntriesFrom(input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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
            policyTopicEntries_.AddEntriesFrom(ref input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V10.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V10.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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
