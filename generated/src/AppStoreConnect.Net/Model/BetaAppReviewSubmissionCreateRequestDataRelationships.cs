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
    /// BetaAppReviewSubmissionCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "BetaAppReviewSubmissionCreateRequest_data_relationships")]
    public partial class BetaAppReviewSubmissionCreateRequestDataRelationships : IEquatable<BetaAppReviewSubmissionCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewSubmissionCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaAppReviewSubmissionCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewSubmissionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="build">build (required).</param>
        public BetaAppReviewSubmissionCreateRequestDataRelationships(BetaAppReviewSubmissionCreateRequestDataRelationshipsBuild build = default(BetaAppReviewSubmissionCreateRequestDataRelationshipsBuild))
        {
            // to ensure "build" is required (not null)
            if (build == null)
            {
                throw new ArgumentNullException("build is a required property for BetaAppReviewSubmissionCreateRequestDataRelationships and cannot be null");
            }
            this.Build = build;
        }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name = "build", IsRequired = true, EmitDefaultValue = true)]
        public BetaAppReviewSubmissionCreateRequestDataRelationshipsBuild Build { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaAppReviewSubmissionCreateRequestDataRelationships {\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
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
            return this.Equals(input as BetaAppReviewSubmissionCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if BetaAppReviewSubmissionCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaAppReviewSubmissionCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaAppReviewSubmissionCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
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
                if (this.Build != null)
                {
                    hashCode = (hashCode * 59) + this.Build.GetHashCode();
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
