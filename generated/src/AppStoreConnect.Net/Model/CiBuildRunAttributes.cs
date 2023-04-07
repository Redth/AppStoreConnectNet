/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = AppStoreConnect.Client.FileParameter;
using OpenAPIDateConverter = AppStoreConnect.Client.OpenAPIDateConverter;

namespace AppStoreConnect.Model
{
    /// <summary>
    /// CiBuildRunAttributes
    /// </summary>
    [DataContract(Name = "CiBuildRun_attributes")]
    public partial class CiBuildRunAttributes : IEquatable<CiBuildRunAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ExecutionProgress
        /// </summary>
        [DataMember(Name = "executionProgress", EmitDefaultValue = false)]
        public CiExecutionProgress? ExecutionProgress { get; set; }

        /// <summary>
        /// Gets or Sets CompletionStatus
        /// </summary>
        [DataMember(Name = "completionStatus", EmitDefaultValue = false)]
        public CiCompletionStatus? CompletionStatus { get; set; }
        /// <summary>
        /// Defines StartReason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StartReasonEnum
        {
            /// <summary>
            /// Enum GITREFCHANGE for value: GIT_REF_CHANGE
            /// </summary>
            [EnumMember(Value = "GIT_REF_CHANGE")]
            GITREFCHANGE = 1,

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 2,

            /// <summary>
            /// Enum MANUALREBUILD for value: MANUAL_REBUILD
            /// </summary>
            [EnumMember(Value = "MANUAL_REBUILD")]
            MANUALREBUILD = 3,

            /// <summary>
            /// Enum PULLREQUESTOPEN for value: PULL_REQUEST_OPEN
            /// </summary>
            [EnumMember(Value = "PULL_REQUEST_OPEN")]
            PULLREQUESTOPEN = 4,

            /// <summary>
            /// Enum PULLREQUESTUPDATE for value: PULL_REQUEST_UPDATE
            /// </summary>
            [EnumMember(Value = "PULL_REQUEST_UPDATE")]
            PULLREQUESTUPDATE = 5,

            /// <summary>
            /// Enum SCHEDULE for value: SCHEDULE
            /// </summary>
            [EnumMember(Value = "SCHEDULE")]
            SCHEDULE = 6

        }


        /// <summary>
        /// Gets or Sets StartReason
        /// </summary>
        [DataMember(Name = "startReason", EmitDefaultValue = false)]
        public StartReasonEnum? StartReason { get; set; }
        /// <summary>
        /// Defines CancelReason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CancelReasonEnum
        {
            /// <summary>
            /// Enum AUTOMATICALLYBYNEWERBUILD for value: AUTOMATICALLY_BY_NEWER_BUILD
            /// </summary>
            [EnumMember(Value = "AUTOMATICALLY_BY_NEWER_BUILD")]
            AUTOMATICALLYBYNEWERBUILD = 1,

            /// <summary>
            /// Enum MANUALLYBYUSER for value: MANUALLY_BY_USER
            /// </summary>
            [EnumMember(Value = "MANUALLY_BY_USER")]
            MANUALLYBYUSER = 2

        }


        /// <summary>
        /// Gets or Sets CancelReason
        /// </summary>
        [DataMember(Name = "cancelReason", EmitDefaultValue = false)]
        public CancelReasonEnum? CancelReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunAttributes" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="startedDate">startedDate.</param>
        /// <param name="finishedDate">finishedDate.</param>
        /// <param name="sourceCommit">sourceCommit.</param>
        /// <param name="destinationCommit">destinationCommit.</param>
        /// <param name="isPullRequestBuild">isPullRequestBuild.</param>
        /// <param name="issueCounts">issueCounts.</param>
        /// <param name="executionProgress">executionProgress.</param>
        /// <param name="completionStatus">completionStatus.</param>
        /// <param name="startReason">startReason.</param>
        /// <param name="cancelReason">cancelReason.</param>
        public CiBuildRunAttributes(int number = default(int), DateTimeOffset createdDate = default(DateTimeOffset), DateTimeOffset startedDate = default(DateTimeOffset), DateTimeOffset finishedDate = default(DateTimeOffset), CiBuildRunAttributesSourceCommit sourceCommit = default(CiBuildRunAttributesSourceCommit), CiBuildRunAttributesSourceCommit destinationCommit = default(CiBuildRunAttributesSourceCommit), bool isPullRequestBuild = default(bool), CiIssueCounts issueCounts = default(CiIssueCounts), CiExecutionProgress? executionProgress = default(CiExecutionProgress?), CiCompletionStatus? completionStatus = default(CiCompletionStatus?), StartReasonEnum? startReason = default(StartReasonEnum?), CancelReasonEnum? cancelReason = default(CancelReasonEnum?))
        {
            this.Number = number;
            this.CreatedDate = createdDate;
            this.StartedDate = startedDate;
            this.FinishedDate = finishedDate;
            this.SourceCommit = sourceCommit;
            this.DestinationCommit = destinationCommit;
            this.IsPullRequestBuild = isPullRequestBuild;
            this.IssueCounts = issueCounts;
            this.ExecutionProgress = executionProgress;
            this.CompletionStatus = completionStatus;
            this.StartReason = startReason;
            this.CancelReason = cancelReason;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets StartedDate
        /// </summary>
        [DataMember(Name = "startedDate", EmitDefaultValue = false)]
        public DateTimeOffset StartedDate { get; set; }

        /// <summary>
        /// Gets or Sets FinishedDate
        /// </summary>
        [DataMember(Name = "finishedDate", EmitDefaultValue = false)]
        public DateTimeOffset FinishedDate { get; set; }

        /// <summary>
        /// Gets or Sets SourceCommit
        /// </summary>
        [DataMember(Name = "sourceCommit", EmitDefaultValue = false)]
        public CiBuildRunAttributesSourceCommit SourceCommit { get; set; }

        /// <summary>
        /// Gets or Sets DestinationCommit
        /// </summary>
        [DataMember(Name = "destinationCommit", EmitDefaultValue = false)]
        public CiBuildRunAttributesSourceCommit DestinationCommit { get; set; }

        /// <summary>
        /// Gets or Sets IsPullRequestBuild
        /// </summary>
        [DataMember(Name = "isPullRequestBuild", EmitDefaultValue = true)]
        public bool IsPullRequestBuild { get; set; }

        /// <summary>
        /// Gets or Sets IssueCounts
        /// </summary>
        [DataMember(Name = "issueCounts", EmitDefaultValue = false)]
        public CiIssueCounts IssueCounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiBuildRunAttributes {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  FinishedDate: ").Append(FinishedDate).Append("\n");
            sb.Append("  SourceCommit: ").Append(SourceCommit).Append("\n");
            sb.Append("  DestinationCommit: ").Append(DestinationCommit).Append("\n");
            sb.Append("  IsPullRequestBuild: ").Append(IsPullRequestBuild).Append("\n");
            sb.Append("  IssueCounts: ").Append(IssueCounts).Append("\n");
            sb.Append("  ExecutionProgress: ").Append(ExecutionProgress).Append("\n");
            sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
            sb.Append("  StartReason: ").Append(StartReason).Append("\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CiBuildRunAttributes);
        }

        /// <summary>
        /// Returns true if CiBuildRunAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CiBuildRunAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiBuildRunAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.StartedDate == input.StartedDate ||
                    (this.StartedDate != null &&
                    this.StartedDate.Equals(input.StartedDate))
                ) && 
                (
                    this.FinishedDate == input.FinishedDate ||
                    (this.FinishedDate != null &&
                    this.FinishedDate.Equals(input.FinishedDate))
                ) && 
                (
                    this.SourceCommit == input.SourceCommit ||
                    (this.SourceCommit != null &&
                    this.SourceCommit.Equals(input.SourceCommit))
                ) && 
                (
                    this.DestinationCommit == input.DestinationCommit ||
                    (this.DestinationCommit != null &&
                    this.DestinationCommit.Equals(input.DestinationCommit))
                ) && 
                (
                    this.IsPullRequestBuild == input.IsPullRequestBuild ||
                    this.IsPullRequestBuild.Equals(input.IsPullRequestBuild)
                ) && 
                (
                    this.IssueCounts == input.IssueCounts ||
                    (this.IssueCounts != null &&
                    this.IssueCounts.Equals(input.IssueCounts))
                ) && 
                (
                    this.ExecutionProgress == input.ExecutionProgress ||
                    this.ExecutionProgress.Equals(input.ExecutionProgress)
                ) && 
                (
                    this.CompletionStatus == input.CompletionStatus ||
                    this.CompletionStatus.Equals(input.CompletionStatus)
                ) && 
                (
                    this.StartReason == input.StartReason ||
                    this.StartReason.Equals(input.StartReason)
                ) && 
                (
                    this.CancelReason == input.CancelReason ||
                    this.CancelReason.Equals(input.CancelReason)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.StartedDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartedDate.GetHashCode();
                }
                if (this.FinishedDate != null)
                {
                    hashCode = (hashCode * 59) + this.FinishedDate.GetHashCode();
                }
                if (this.SourceCommit != null)
                {
                    hashCode = (hashCode * 59) + this.SourceCommit.GetHashCode();
                }
                if (this.DestinationCommit != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationCommit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPullRequestBuild.GetHashCode();
                if (this.IssueCounts != null)
                {
                    hashCode = (hashCode * 59) + this.IssueCounts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExecutionProgress.GetHashCode();
                hashCode = (hashCode * 59) + this.CompletionStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.StartReason.GetHashCode();
                hashCode = (hashCode * 59) + this.CancelReason.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
