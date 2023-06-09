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
    /// CustomerReviewResponseV1Relationships
    /// </summary>
    [DataContract(Name = "CustomerReviewResponseV1_relationships")]
    public partial class CustomerReviewResponseV1Relationships : IEquatable<CustomerReviewResponseV1Relationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewResponseV1Relationships" /> class.
        /// </summary>
        /// <param name="review">review.</param>
        public CustomerReviewResponseV1Relationships(CustomerReviewResponseV1RelationshipsReview review = default(CustomerReviewResponseV1RelationshipsReview))
        {
            this.Review = review;
        }

        /// <summary>
        /// Gets or Sets Review
        /// </summary>
        [DataMember(Name = "review", EmitDefaultValue = false)]
        public CustomerReviewResponseV1RelationshipsReview Review { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerReviewResponseV1Relationships {\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
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
            return this.Equals(input as CustomerReviewResponseV1Relationships);
        }

        /// <summary>
        /// Returns true if CustomerReviewResponseV1Relationships instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerReviewResponseV1Relationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerReviewResponseV1Relationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Review == input.Review ||
                    (this.Review != null &&
                    this.Review.Equals(input.Review))
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
                if (this.Review != null)
                {
                    hashCode = (hashCode * 59) + this.Review.GetHashCode();
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
