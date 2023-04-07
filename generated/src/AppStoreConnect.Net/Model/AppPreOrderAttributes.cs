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
    /// AppPreOrderAttributes
    /// </summary>
    [DataContract(Name = "AppPreOrder_attributes")]
    public partial class AppPreOrderAttributes : IEquatable<AppPreOrderAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreOrderAttributes" /> class.
        /// </summary>
        /// <param name="preOrderAvailableDate">preOrderAvailableDate.</param>
        /// <param name="appReleaseDate">appReleaseDate.</param>
        public AppPreOrderAttributes(DateTimeOffset preOrderAvailableDate = default(DateTimeOffset), DateTimeOffset appReleaseDate = default(DateTimeOffset))
        {
            this.PreOrderAvailableDate = preOrderAvailableDate;
            this.AppReleaseDate = appReleaseDate;
        }

        /// <summary>
        /// Gets or Sets PreOrderAvailableDate
        /// </summary>
        [DataMember(Name = "preOrderAvailableDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset PreOrderAvailableDate { get; set; }

        /// <summary>
        /// Gets or Sets AppReleaseDate
        /// </summary>
        [DataMember(Name = "appReleaseDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset AppReleaseDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPreOrderAttributes {\n");
            sb.Append("  PreOrderAvailableDate: ").Append(PreOrderAvailableDate).Append("\n");
            sb.Append("  AppReleaseDate: ").Append(AppReleaseDate).Append("\n");
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
            return this.Equals(input as AppPreOrderAttributes);
        }

        /// <summary>
        /// Returns true if AppPreOrderAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPreOrderAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPreOrderAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreOrderAvailableDate == input.PreOrderAvailableDate ||
                    (this.PreOrderAvailableDate != null &&
                    this.PreOrderAvailableDate.Equals(input.PreOrderAvailableDate))
                ) && 
                (
                    this.AppReleaseDate == input.AppReleaseDate ||
                    (this.AppReleaseDate != null &&
                    this.AppReleaseDate.Equals(input.AppReleaseDate))
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
                if (this.PreOrderAvailableDate != null)
                {
                    hashCode = (hashCode * 59) + this.PreOrderAvailableDate.GetHashCode();
                }
                if (this.AppReleaseDate != null)
                {
                    hashCode = (hashCode * 59) + this.AppReleaseDate.GetHashCode();
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