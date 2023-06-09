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
    /// ReviewSubmissionUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "ReviewSubmissionUpdateRequest_data_attributes")]
    public partial class ReviewSubmissionUpdateRequestDataAttributes : IEquatable<ReviewSubmissionUpdateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="submitted">submitted.</param>
        /// <param name="canceled">canceled.</param>
        public ReviewSubmissionUpdateRequestDataAttributes(bool submitted = default(bool), bool canceled = default(bool))
        {
            this.Submitted = submitted;
            this.Canceled = canceled;
        }

        /// <summary>
        /// Gets or Sets Submitted
        /// </summary>
        [DataMember(Name = "submitted", EmitDefaultValue = true)]
        public bool Submitted { get; set; }

        /// <summary>
        /// Gets or Sets Canceled
        /// </summary>
        [DataMember(Name = "canceled", EmitDefaultValue = true)]
        public bool Canceled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewSubmissionUpdateRequestDataAttributes {\n");
            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  Canceled: ").Append(Canceled).Append("\n");
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
            return this.Equals(input as ReviewSubmissionUpdateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if ReviewSubmissionUpdateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewSubmissionUpdateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewSubmissionUpdateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Submitted == input.Submitted ||
                    this.Submitted.Equals(input.Submitted)
                ) && 
                (
                    this.Canceled == input.Canceled ||
                    this.Canceled.Equals(input.Canceled)
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
                hashCode = (hashCode * 59) + this.Submitted.GetHashCode();
                hashCode = (hashCode * 59) + this.Canceled.GetHashCode();
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
