// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/query_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/query_error.proto</summary>
  public static partial class QueryErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/query_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvcXVlcnlfZXJyb3Iu",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVycm9ycyKTDgoOUXVl",
            "cnlFcnJvckVudW0igA4KClF1ZXJ5RXJyb3ISDwoLVU5TUEVDSUZJRUQQABIL",
            "CgdVTktOT1dOEAESDwoLUVVFUllfRVJST1IQMhIVChFCQURfRU5VTV9DT05T",
            "VEFOVBASEhcKE0JBRF9FU0NBUEVfU0VRVUVOQ0UQBxISCg5CQURfRklFTERf",
            "TkFNRRAMEhMKD0JBRF9MSU1JVF9WQUxVRRAPEg4KCkJBRF9OVU1CRVIQBRIQ",
            "CgxCQURfT1BFUkFUT1IQAxIWChJCQURfUEFSQU1FVEVSX05BTUUQPRIXChNC",
            "QURfUEFSQU1FVEVSX1ZBTFVFED4SJAogQkFEX1JFU09VUkNFX1RZUEVfSU5f",
            "RlJPTV9DTEFVU0UQLRIOCgpCQURfU1lNQk9MEAISDQoJQkFEX1ZBTFVFEAQS",
            "FwoTREFURV9SQU5HRV9UT09fV0lERRAkEhkKFURBVEVfUkFOR0VfVE9PX05B",
            "UlJPVxA8EhAKDEVYUEVDVEVEX0FORBAeEg8KC0VYUEVDVEVEX0JZEA4SLQop",
            "RVhQRUNURURfRElNRU5TSU9OX0ZJRUxEX0lOX1NFTEVDVF9DTEFVU0UQJRIi",
            "Ch5FWFBFQ1RFRF9GSUxURVJTX09OX0RBVEVfUkFOR0UQNxIRCg1FWFBFQ1RF",
            "RF9GUk9NECwSEQoNRVhQRUNURURfTElTVBApEi4KKkVYUEVDVEVEX1JFRkVS",
            "RU5DRURfRklFTERfSU5fU0VMRUNUX0NMQVVTRRAQEhMKD0VYUEVDVEVEX1NF",
            "TEVDVBANEhkKFUVYUEVDVEVEX1NJTkdMRV9WQUxVRRAqEigKJEVYUEVDVEVE",
            "X1ZBTFVFX1dJVEhfQkVUV0VFTl9PUEVSQVRPUhAdEhcKE0lOVkFMSURfREFU",
            "RV9GT1JNQVQQJhIeChpNSVNBTElHTkVEX0RBVEVfRk9SX0ZJTFRFUhBAEhgK",
            "FElOVkFMSURfU1RSSU5HX1ZBTFVFEDkSJwojSU5WQUxJRF9WQUxVRV9XSVRI",
            "X0JFVFdFRU5fT1BFUkFUT1IQGhImCiJJTlZBTElEX1ZBTFVFX1dJVEhfRFVS",
            "SU5HX09QRVJBVE9SEBYSJAogSU5WQUxJRF9WQUxVRV9XSVRIX0xJS0VfT1BF",
            "UkFUT1IQOBIbChdPUEVSQVRPUl9GSUVMRF9NSVNNQVRDSBAjEiYKIlBST0hJ",
            "QklURURfRU1QVFlfTElTVF9JTl9DT05ESVRJT04QHBIcChhQUk9ISUJJVEVE",
            "X0VOVU1fQ09OU1RBTlQQNhIxCi1QUk9ISUJJVEVEX0ZJRUxEX0NPTUJJTkFU",
            "SU9OX0lOX1NFTEVDVF9DTEFVU0UQHxInCiNQUk9ISUJJVEVEX0ZJRUxEX0lO",
            "X09SREVSX0JZX0NMQVVTRRAoEiUKIVBST0hJQklURURfRklFTERfSU5fU0VM",
            "RUNUX0NMQVVTRRAXEiQKIFBST0hJQklURURfRklFTERfSU5fV0hFUkVfQ0xB",
            "VVNFEBgSKwonUFJPSElCSVRFRF9SRVNPVVJDRV9UWVBFX0lOX0ZST01fQ0xB",
            "VVNFECsSLQopUFJPSElCSVRFRF9SRVNPVVJDRV9UWVBFX0lOX1NFTEVDVF9D",
            "TEFVU0UQMBIsCihQUk9ISUJJVEVEX1JFU09VUkNFX1RZUEVfSU5fV0hFUkVf",
            "Q0xBVVNFEDoSLworUFJPSElCSVRFRF9NRVRSSUNfSU5fU0VMRUNUX09SX1dI",
            "RVJFX0NMQVVTRRAxEjAKLFBST0hJQklURURfU0VHTUVOVF9JTl9TRUxFQ1Rf",
            "T1JfV0hFUkVfQ0xBVVNFEDMSPAo4UFJPSElCSVRFRF9TRUdNRU5UX1dJVEhf",
            "TUVUUklDX0lOX1NFTEVDVF9PUl9XSEVSRV9DTEFVU0UQNRIXChNMSU1JVF9W",
            "QUxVRV9UT09fTE9XEBkSIAocUFJPSElCSVRFRF9ORVdMSU5FX0lOX1NUUklO",
            "RxAIEigKJFBST0hJQklURURfVkFMVUVfQ09NQklOQVRJT05fSU5fTElTVBAK",
            "EjYKMlBST0hJQklURURfVkFMVUVfQ09NQklOQVRJT05fV0lUSF9CRVRXRUVO",
            "X09QRVJBVE9SEBUSGQoVU1RSSU5HX05PVF9URVJNSU5BVEVEEAYSFQoRVE9P",
            "X01BTllfU0VHTUVOVFMQIhIbChdVTkVYUEVDVEVEX0VORF9PRl9RVUVSWRAJ",
            "EhoKFlVORVhQRUNURURfRlJPTV9DTEFVU0UQLxIWChJVTlJFQ09HTklaRURf",
            "RklFTEQQIBIUChBVTkVYUEVDVEVEX0lOUFVUEAsSIQodUkVRVUVTVEVEX01F",
            "VFJJQ1NfRk9SX01BTkFHRVIQOxIeChpGSUxURVJfSEFTX1RPT19NQU5ZX1ZB",
            "TFVFUxA/QuoBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3Jz",
            "Qg9RdWVyeUVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L2Vycm9ycztlcnJvcnOi",
            "AgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5FcnJvcnPKAh5Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWOVxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWOTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.QueryErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.QueryErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.QueryErrorEnum.Types.QueryError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible query errors.
  /// </summary>
  public sealed partial class QueryErrorEnum : pb::IMessage<QueryErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryErrorEnum> _parser = new pb::MessageParser<QueryErrorEnum>(() => new QueryErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.QueryErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryErrorEnum(QueryErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryErrorEnum Clone() {
      return new QueryErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryErrorEnum other) {
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
    public void MergeFrom(QueryErrorEnum other) {
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
    /// <summary>Container for nested types declared in the QueryErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible query errors.
      /// </summary>
      public enum QueryError {
        /// <summary>
        /// Name unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Returned if all other query error reasons are not applicable.
        /// </summary>
        [pbr::OriginalName("QUERY_ERROR")] QueryError = 50,
        /// <summary>
        /// A condition used in the query references an invalid enum constant.
        /// </summary>
        [pbr::OriginalName("BAD_ENUM_CONSTANT")] BadEnumConstant = 18,
        /// <summary>
        /// Query contains an invalid escape sequence.
        /// </summary>
        [pbr::OriginalName("BAD_ESCAPE_SEQUENCE")] BadEscapeSequence = 7,
        /// <summary>
        /// Field name is invalid.
        /// </summary>
        [pbr::OriginalName("BAD_FIELD_NAME")] BadFieldName = 12,
        /// <summary>
        /// Limit value is invalid (i.e. not a number)
        /// </summary>
        [pbr::OriginalName("BAD_LIMIT_VALUE")] BadLimitValue = 15,
        /// <summary>
        /// Encountered number can not be parsed.
        /// </summary>
        [pbr::OriginalName("BAD_NUMBER")] BadNumber = 5,
        /// <summary>
        /// Invalid operator encountered.
        /// </summary>
        [pbr::OriginalName("BAD_OPERATOR")] BadOperator = 3,
        /// <summary>
        /// Parameter unknown or not supported.
        /// </summary>
        [pbr::OriginalName("BAD_PARAMETER_NAME")] BadParameterName = 61,
        /// <summary>
        /// Parameter have invalid value.
        /// </summary>
        [pbr::OriginalName("BAD_PARAMETER_VALUE")] BadParameterValue = 62,
        /// <summary>
        /// Invalid resource type was specified in the FROM clause.
        /// </summary>
        [pbr::OriginalName("BAD_RESOURCE_TYPE_IN_FROM_CLAUSE")] BadResourceTypeInFromClause = 45,
        /// <summary>
        /// Non-ASCII symbol encountered outside of strings.
        /// </summary>
        [pbr::OriginalName("BAD_SYMBOL")] BadSymbol = 2,
        /// <summary>
        /// Value is invalid.
        /// </summary>
        [pbr::OriginalName("BAD_VALUE")] BadValue = 4,
        /// <summary>
        /// Date filters fail to restrict date to a range smaller than 31 days.
        /// Applicable if the query is segmented by date.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_TOO_WIDE")] DateRangeTooWide = 36,
        /// <summary>
        /// Filters on date/week/month/quarter have a start date after
        /// end date.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_TOO_NARROW")] DateRangeTooNarrow = 60,
        /// <summary>
        /// Expected AND between values with BETWEEN operator.
        /// </summary>
        [pbr::OriginalName("EXPECTED_AND")] ExpectedAnd = 30,
        /// <summary>
        /// Expecting ORDER BY to have BY.
        /// </summary>
        [pbr::OriginalName("EXPECTED_BY")] ExpectedBy = 14,
        /// <summary>
        /// There was no dimension field selected.
        /// </summary>
        [pbr::OriginalName("EXPECTED_DIMENSION_FIELD_IN_SELECT_CLAUSE")] ExpectedDimensionFieldInSelectClause = 37,
        /// <summary>
        /// Missing filters on date related fields.
        /// </summary>
        [pbr::OriginalName("EXPECTED_FILTERS_ON_DATE_RANGE")] ExpectedFiltersOnDateRange = 55,
        /// <summary>
        /// Missing FROM clause.
        /// </summary>
        [pbr::OriginalName("EXPECTED_FROM")] ExpectedFrom = 44,
        /// <summary>
        /// The operator used in the conditions requires the value to be a list.
        /// </summary>
        [pbr::OriginalName("EXPECTED_LIST")] ExpectedList = 41,
        /// <summary>
        /// Fields used in WHERE or ORDER BY clauses are missing from the SELECT
        /// clause.
        /// </summary>
        [pbr::OriginalName("EXPECTED_REFERENCED_FIELD_IN_SELECT_CLAUSE")] ExpectedReferencedFieldInSelectClause = 16,
        /// <summary>
        /// SELECT is missing at the beginning of query.
        /// </summary>
        [pbr::OriginalName("EXPECTED_SELECT")] ExpectedSelect = 13,
        /// <summary>
        /// A list was passed as a value to a condition whose operator expects a
        /// single value.
        /// </summary>
        [pbr::OriginalName("EXPECTED_SINGLE_VALUE")] ExpectedSingleValue = 42,
        /// <summary>
        /// Missing one or both values with BETWEEN operator.
        /// </summary>
        [pbr::OriginalName("EXPECTED_VALUE_WITH_BETWEEN_OPERATOR")] ExpectedValueWithBetweenOperator = 29,
        /// <summary>
        /// Invalid date format. Expected 'YYYY-MM-DD'.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE_FORMAT")] InvalidDateFormat = 38,
        /// <summary>
        /// Misaligned date value for the filter. The date should be the start of a
        /// week/month/quarter if the filtered field is
        /// segments.week/segments.month/segments.quarter.
        /// </summary>
        [pbr::OriginalName("MISALIGNED_DATE_FOR_FILTER")] MisalignedDateForFilter = 64,
        /// <summary>
        /// Value passed was not a string when it should have been. I.e., it was a
        /// number or unquoted literal.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_VALUE")] InvalidStringValue = 57,
        /// <summary>
        /// A String value passed to the BETWEEN operator does not parse as a date.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_WITH_BETWEEN_OPERATOR")] InvalidValueWithBetweenOperator = 26,
        /// <summary>
        /// The value passed to the DURING operator is not a Date range literal
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_WITH_DURING_OPERATOR")] InvalidValueWithDuringOperator = 22,
        /// <summary>
        /// An invalid value was passed to the LIKE operator.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_WITH_LIKE_OPERATOR")] InvalidValueWithLikeOperator = 56,
        /// <summary>
        /// An operator was provided that is inapplicable to the field being
        /// filtered.
        /// </summary>
        [pbr::OriginalName("OPERATOR_FIELD_MISMATCH")] OperatorFieldMismatch = 35,
        /// <summary>
        /// A Condition was found with an empty list.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_EMPTY_LIST_IN_CONDITION")] ProhibitedEmptyListInCondition = 28,
        /// <summary>
        /// A condition used in the query references an unsupported enum constant.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_ENUM_CONSTANT")] ProhibitedEnumConstant = 54,
        /// <summary>
        /// Fields that are not allowed to be selected together were included in
        /// the SELECT clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_COMBINATION_IN_SELECT_CLAUSE")] ProhibitedFieldCombinationInSelectClause = 31,
        /// <summary>
        /// A field that is not orderable was included in the ORDER BY clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_IN_ORDER_BY_CLAUSE")] ProhibitedFieldInOrderByClause = 40,
        /// <summary>
        /// A field that is not selectable was included in the SELECT clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_IN_SELECT_CLAUSE")] ProhibitedFieldInSelectClause = 23,
        /// <summary>
        /// A field that is not filterable was included in the WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_IN_WHERE_CLAUSE")] ProhibitedFieldInWhereClause = 24,
        /// <summary>
        /// Resource type specified in the FROM clause is not supported by this
        /// service.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_RESOURCE_TYPE_IN_FROM_CLAUSE")] ProhibitedResourceTypeInFromClause = 43,
        /// <summary>
        /// A field that comes from an incompatible resource was included in the
        /// SELECT clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_RESOURCE_TYPE_IN_SELECT_CLAUSE")] ProhibitedResourceTypeInSelectClause = 48,
        /// <summary>
        /// A field that comes from an incompatible resource was included in the
        /// WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_RESOURCE_TYPE_IN_WHERE_CLAUSE")] ProhibitedResourceTypeInWhereClause = 58,
        /// <summary>
        /// A metric incompatible with the main resource or other selected
        /// segmenting resources was included in the SELECT or WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_METRIC_IN_SELECT_OR_WHERE_CLAUSE")] ProhibitedMetricInSelectOrWhereClause = 49,
        /// <summary>
        /// A segment incompatible with the main resource or other selected
        /// segmenting resources was included in the SELECT or WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_SEGMENT_IN_SELECT_OR_WHERE_CLAUSE")] ProhibitedSegmentInSelectOrWhereClause = 51,
        /// <summary>
        /// A segment in the SELECT clause is incompatible with a metric in the
        /// SELECT or WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_SEGMENT_WITH_METRIC_IN_SELECT_OR_WHERE_CLAUSE")] ProhibitedSegmentWithMetricInSelectOrWhereClause = 53,
        /// <summary>
        /// The value passed to the limit clause is too low.
        /// </summary>
        [pbr::OriginalName("LIMIT_VALUE_TOO_LOW")] LimitValueTooLow = 25,
        /// <summary>
        /// Query has a string containing a newline character.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_NEWLINE_IN_STRING")] ProhibitedNewlineInString = 8,
        /// <summary>
        /// List contains values of different types.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_VALUE_COMBINATION_IN_LIST")] ProhibitedValueCombinationInList = 10,
        /// <summary>
        /// The values passed to the BETWEEN operator are not of the same type.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_VALUE_COMBINATION_WITH_BETWEEN_OPERATOR")] ProhibitedValueCombinationWithBetweenOperator = 21,
        /// <summary>
        /// Query contains unterminated string.
        /// </summary>
        [pbr::OriginalName("STRING_NOT_TERMINATED")] StringNotTerminated = 6,
        /// <summary>
        /// Too many segments are specified in SELECT clause.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SEGMENTS")] TooManySegments = 34,
        /// <summary>
        /// Query is incomplete and cannot be parsed.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_END_OF_QUERY")] UnexpectedEndOfQuery = 9,
        /// <summary>
        /// FROM clause cannot be specified in this query.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_FROM_CLAUSE")] UnexpectedFromClause = 47,
        /// <summary>
        /// Query contains one or more unrecognized fields.
        /// </summary>
        [pbr::OriginalName("UNRECOGNIZED_FIELD")] UnrecognizedField = 32,
        /// <summary>
        /// Query has an unexpected extra part.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_INPUT")] UnexpectedInput = 11,
        /// <summary>
        /// Metrics cannot be requested for a manager account. To retrieve metrics,
        /// issue separate requests against each client account under the manager
        /// account.
        /// </summary>
        [pbr::OriginalName("REQUESTED_METRICS_FOR_MANAGER")] RequestedMetricsForManager = 59,
        /// <summary>
        /// The number of values (right-hand-side operands) in a filter exceeds the
        /// limit.
        /// </summary>
        [pbr::OriginalName("FILTER_HAS_TOO_MANY_VALUES")] FilterHasTooManyValues = 63,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
