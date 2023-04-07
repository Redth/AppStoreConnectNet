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
    /// AppStoreReviewAttachmentCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppStoreReviewAttachmentCreateRequest_data_relationships")]
    public partial class AppStoreReviewAttachmentCreateRequestDataRelationships : IEquatable<AppStoreReviewAttachmentCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewAttachmentCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreReviewAttachmentCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewAttachmentCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreReviewDetail">appStoreReviewDetail (required).</param>
        public AppStoreReviewAttachmentCreateRequestDataRelationships(AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetail appStoreReviewDetail = default(AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetail))
        {
            // to ensure "appStoreReviewDetail" is required (not null)
            if (appStoreReviewDetail == null)
            {
                throw new ArgumentNullException("appStoreReviewDetail is a required property for AppStoreReviewAttachmentCreateRequestDataRelationships and cannot be null");
            }
            this.AppStoreReviewDetail = appStoreReviewDetail;
        }

        /// <summary>
        /// Gets or Sets AppStoreReviewDetail
        /// </summary>
        [DataMember(Name = "appStoreReviewDetail", IsRequired = true, EmitDefaultValue = true)]
        public AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetail AppStoreReviewDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreReviewAttachmentCreateRequestDataRelationships {\n");
            sb.Append("  AppStoreReviewDetail: ").Append(AppStoreReviewDetail).Append("\n");
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
            return this.Equals(input as AppStoreReviewAttachmentCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppStoreReviewAttachmentCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreReviewAttachmentCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreReviewAttachmentCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppStoreReviewDetail == input.AppStoreReviewDetail ||
                    (this.AppStoreReviewDetail != null &&
                    this.AppStoreReviewDetail.Equals(input.AppStoreReviewDetail))
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
                if (this.AppStoreReviewDetail != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreReviewDetail.GetHashCode();
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