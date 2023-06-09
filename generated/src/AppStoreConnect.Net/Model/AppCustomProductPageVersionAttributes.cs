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
    /// AppCustomProductPageVersionAttributes
    /// </summary>
    [DataContract(Name = "AppCustomProductPageVersion_attributes")]
    public partial class AppCustomProductPageVersionAttributes : IEquatable<AppCustomProductPageVersionAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum PREPAREFORSUBMISSION for value: PREPARE_FOR_SUBMISSION
            /// </summary>
            [EnumMember(Value = "PREPARE_FOR_SUBMISSION")]
            PREPAREFORSUBMISSION = 1,

            /// <summary>
            /// Enum READYFORREVIEW for value: READY_FOR_REVIEW
            /// </summary>
            [EnumMember(Value = "READY_FOR_REVIEW")]
            READYFORREVIEW = 2,

            /// <summary>
            /// Enum WAITINGFORREVIEW for value: WAITING_FOR_REVIEW
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_REVIEW")]
            WAITINGFORREVIEW = 3,

            /// <summary>
            /// Enum INREVIEW for value: IN_REVIEW
            /// </summary>
            [EnumMember(Value = "IN_REVIEW")]
            INREVIEW = 4,

            /// <summary>
            /// Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            ACCEPTED = 5,

            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 6,

            /// <summary>
            /// Enum REPLACEDWITHNEWVERSION for value: REPLACED_WITH_NEW_VERSION
            /// </summary>
            [EnumMember(Value = "REPLACED_WITH_NEW_VERSION")]
            REPLACEDWITHNEWVERSION = 7,

            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 8

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionAttributes" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="state">state.</param>
        public AppCustomProductPageVersionAttributes(string version = default(string), StateEnum? state = default(StateEnum?))
        {
            this._Version = version;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCustomProductPageVersionAttributes {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as AppCustomProductPageVersionAttributes);
        }

        /// <summary>
        /// Returns true if AppCustomProductPageVersionAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCustomProductPageVersionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCustomProductPageVersionAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
