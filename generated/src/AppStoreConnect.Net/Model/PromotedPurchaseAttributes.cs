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
    /// PromotedPurchaseAttributes
    /// </summary>
    [DataContract(Name = "PromotedPurchase_attributes")]
    public partial class PromotedPurchaseAttributes : IEquatable<PromotedPurchaseAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 1,

            /// <summary>
            /// Enum INREVIEW for value: IN_REVIEW
            /// </summary>
            [EnumMember(Value = "IN_REVIEW")]
            INREVIEW = 2,

            /// <summary>
            /// Enum PREPAREFORSUBMISSION for value: PREPARE_FOR_SUBMISSION
            /// </summary>
            [EnumMember(Value = "PREPARE_FOR_SUBMISSION")]
            PREPAREFORSUBMISSION = 3,

            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 4

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseAttributes" /> class.
        /// </summary>
        /// <param name="visibleForAllUsers">visibleForAllUsers.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="state">state.</param>
        public PromotedPurchaseAttributes(bool visibleForAllUsers = default(bool), bool enabled = default(bool), StateEnum? state = default(StateEnum?))
        {
            this.VisibleForAllUsers = visibleForAllUsers;
            this.Enabled = enabled;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets VisibleForAllUsers
        /// </summary>
        [DataMember(Name = "visibleForAllUsers", EmitDefaultValue = true)]
        public bool VisibleForAllUsers { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromotedPurchaseAttributes {\n");
            sb.Append("  VisibleForAllUsers: ").Append(VisibleForAllUsers).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as PromotedPurchaseAttributes);
        }

        /// <summary>
        /// Returns true if PromotedPurchaseAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of PromotedPurchaseAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotedPurchaseAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VisibleForAllUsers == input.VisibleForAllUsers ||
                    this.VisibleForAllUsers.Equals(input.VisibleForAllUsers)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                hashCode = (hashCode * 59) + this.VisibleForAllUsers.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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