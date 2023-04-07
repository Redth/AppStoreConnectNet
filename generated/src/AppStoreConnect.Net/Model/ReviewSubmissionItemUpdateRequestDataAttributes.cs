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
    /// ReviewSubmissionItemUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "ReviewSubmissionItemUpdateRequest_data_attributes")]
    public partial class ReviewSubmissionItemUpdateRequestDataAttributes : IEquatable<ReviewSubmissionItemUpdateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="resolved">resolved.</param>
        /// <param name="removed">removed.</param>
        public ReviewSubmissionItemUpdateRequestDataAttributes(bool resolved = default(bool), bool removed = default(bool))
        {
            this.Resolved = resolved;
            this.Removed = removed;
        }

        /// <summary>
        /// Gets or Sets Resolved
        /// </summary>
        [DataMember(Name = "resolved", EmitDefaultValue = true)]
        public bool Resolved { get; set; }

        /// <summary>
        /// Gets or Sets Removed
        /// </summary>
        [DataMember(Name = "removed", EmitDefaultValue = true)]
        public bool Removed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewSubmissionItemUpdateRequestDataAttributes {\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
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
            return this.Equals(input as ReviewSubmissionItemUpdateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if ReviewSubmissionItemUpdateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewSubmissionItemUpdateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewSubmissionItemUpdateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Resolved == input.Resolved ||
                    this.Resolved.Equals(input.Resolved)
                ) && 
                (
                    this.Removed == input.Removed ||
                    this.Removed.Equals(input.Removed)
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
                hashCode = (hashCode * 59) + this.Resolved.GetHashCode();
                hashCode = (hashCode * 59) + this.Removed.GetHashCode();
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