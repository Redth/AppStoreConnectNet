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
    /// AppStoreVersionSubmissionCreateRequestData
    /// </summary>
    [DataContract(Name = "AppStoreVersionSubmissionCreateRequest_data")]
    public partial class AppStoreVersionSubmissionCreateRequestData : IEquatable<AppStoreVersionSubmissionCreateRequestData>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AppStoreVersionSubmissions for value: appStoreVersionSubmissions
            /// </summary>
            [EnumMember(Value = "appStoreVersionSubmissions")]
            AppStoreVersionSubmissions = 1

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionSubmissionCreateRequestData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreVersionSubmissionCreateRequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionSubmissionCreateRequestData" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="relationships">relationships (required).</param>
        public AppStoreVersionSubmissionCreateRequestData(TypeEnum type = default(TypeEnum), AppStoreReviewDetailCreateRequestDataRelationships relationships = default(AppStoreReviewDetailCreateRequestDataRelationships))
        {
            this.Type = type;
            // to ensure "relationships" is required (not null)
            if (relationships == null)
            {
                throw new ArgumentNullException("relationships is a required property for AppStoreVersionSubmissionCreateRequestData and cannot be null");
            }
            this.Relationships = relationships;
        }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", IsRequired = true, EmitDefaultValue = true)]
        public AppStoreReviewDetailCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionSubmissionCreateRequestData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            return this.Equals(input as AppStoreVersionSubmissionCreateRequestData);
        }

        /// <summary>
        /// Returns true if AppStoreVersionSubmissionCreateRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionSubmissionCreateRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionSubmissionCreateRequestData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    (this.Relationships != null &&
                    this.Relationships.Equals(input.Relationships))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Relationships != null)
                {
                    hashCode = (hashCode * 59) + this.Relationships.GetHashCode();
                }
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
