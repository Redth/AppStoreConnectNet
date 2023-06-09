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
    /// AppMediaAssetState
    /// </summary>
    [DataContract(Name = "AppMediaAssetState")]
    public partial class AppMediaAssetState : IEquatable<AppMediaAssetState>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum AWAITINGUPLOAD for value: AWAITING_UPLOAD
            /// </summary>
            [EnumMember(Value = "AWAITING_UPLOAD")]
            AWAITINGUPLOAD = 1,

            /// <summary>
            /// Enum UPLOADCOMPLETE for value: UPLOAD_COMPLETE
            /// </summary>
            [EnumMember(Value = "UPLOAD_COMPLETE")]
            UPLOADCOMPLETE = 2,

            /// <summary>
            /// Enum COMPLETE for value: COMPLETE
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            COMPLETE = 3,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 4

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppMediaAssetState" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="warnings">warnings.</param>
        /// <param name="state">state.</param>
        public AppMediaAssetState(List<AppMediaStateError> errors = default(List<AppMediaStateError>), List<AppMediaStateError> warnings = default(List<AppMediaStateError>), StateEnum? state = default(StateEnum?))
        {
            this.Errors = errors;
            this.Warnings = warnings;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<AppMediaStateError> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<AppMediaStateError> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppMediaAssetState {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as AppMediaAssetState);
        }

        /// <summary>
        /// Returns true if AppMediaAssetState instances are equal
        /// </summary>
        /// <param name="input">Instance of AppMediaAssetState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppMediaAssetState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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
