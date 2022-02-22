// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/video_thumbnail.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/video_thumbnail.proto</summary>
  public static partial class VideoThumbnailReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/video_thumbnail.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoThumbnailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvdmlkZW9fdGh1bWJu",
            "YWlsLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZW51bXMaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ijgEKElZpZGVvVGh1bWJuYWls",
            "RW51bSJ4Cg5WaWRlb1RodW1ibmFpbBIPCgtVTlNQRUNJRklFRBAAEgsKB1VO",
            "S05PV04QARIVChFERUZBVUxUX1RIVU1CTkFJTBACEg8KC1RIVU1CTkFJTF8x",
            "EAMSDwoLVEhVTUJOQUlMXzIQBBIPCgtUSFVNQk5BSUxfMxAFQu0BCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zQhNWaWRlb1RodW1ibmFp",
            "bFByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MTAvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMTAuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMTBcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6",
            "OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.VideoThumbnailEnum), global::Google.Ads.GoogleAds.V10.Enums.VideoThumbnailEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.VideoThumbnailEnum.Types.VideoThumbnail) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines the thumbnail to use for In-Display video ads. Note that
  /// DEFAULT_THUMBNAIL may have been uploaded by the user while thumbnails 1-3 are
  /// auto-generated from the video.
  /// </summary>
  public sealed partial class VideoThumbnailEnum : pb::IMessage<VideoThumbnailEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoThumbnailEnum> _parser = new pb::MessageParser<VideoThumbnailEnum>(() => new VideoThumbnailEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VideoThumbnailEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.VideoThumbnailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoThumbnailEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoThumbnailEnum(VideoThumbnailEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoThumbnailEnum Clone() {
      return new VideoThumbnailEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VideoThumbnailEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VideoThumbnailEnum other) {
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
    public void MergeFrom(VideoThumbnailEnum other) {
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
    /// <summary>Container for nested types declared in the VideoThumbnailEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum listing the possible types of a video thumbnail.
      /// </summary>
      public enum VideoThumbnail {
        /// <summary>
        /// The type has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The default thumbnail. Can be auto-generated or user-uploaded.
        /// </summary>
        [pbr::OriginalName("DEFAULT_THUMBNAIL")] DefaultThumbnail = 2,
        /// <summary>
        /// Thumbnail 1, generated from the video.
        /// </summary>
        [pbr::OriginalName("THUMBNAIL_1")] Thumbnail1 = 3,
        /// <summary>
        /// Thumbnail 2, generated from the video.
        /// </summary>
        [pbr::OriginalName("THUMBNAIL_2")] Thumbnail2 = 4,
        /// <summary>
        /// Thumbnail 3, generated from the video.
        /// </summary>
        [pbr::OriginalName("THUMBNAIL_3")] Thumbnail3 = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
