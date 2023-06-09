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
    /// SubscriptionGroupLocalizationAttributes
    /// </summary>
    [DataContract(Name = "SubscriptionGroupLocalization_attributes")]
    public partial class SubscriptionGroupLocalizationAttributes : IEquatable<SubscriptionGroupLocalizationAttributes>, IValidatableObject
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
            /// Enum WAITINGFORREVIEW for value: WAITING_FOR_REVIEW
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_REVIEW")]
            WAITINGFORREVIEW = 2,

            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 3,

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
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="customAppName">customAppName.</param>
        /// <param name="locale">locale.</param>
        /// <param name="state">state.</param>
        public SubscriptionGroupLocalizationAttributes(string name = default(string), string customAppName = default(string), string locale = default(string), StateEnum? state = default(StateEnum?))
        {
            this.Name = name;
            this.CustomAppName = customAppName;
            this.Locale = locale;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CustomAppName
        /// </summary>
        [DataMember(Name = "customAppName", EmitDefaultValue = false)]
        public string CustomAppName { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionGroupLocalizationAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomAppName: ").Append(CustomAppName).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as SubscriptionGroupLocalizationAttributes);
        }

        /// <summary>
        /// Returns true if SubscriptionGroupLocalizationAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionGroupLocalizationAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionGroupLocalizationAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CustomAppName == input.CustomAppName ||
                    (this.CustomAppName != null &&
                    this.CustomAppName.Equals(input.CustomAppName))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CustomAppName != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAppName.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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
