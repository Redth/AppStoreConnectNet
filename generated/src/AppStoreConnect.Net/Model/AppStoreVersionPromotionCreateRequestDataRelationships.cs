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
    /// AppStoreVersionPromotionCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppStoreVersionPromotionCreateRequest_data_relationships")]
    public partial class AppStoreVersionPromotionCreateRequestDataRelationships : IEquatable<AppStoreVersionPromotionCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPromotionCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreVersionPromotionCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPromotionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion">appStoreVersion (required).</param>
        /// <param name="appStoreVersionExperimentTreatment">appStoreVersionExperimentTreatment (required).</param>
        public AppStoreVersionPromotionCreateRequestDataRelationships(AppStoreReviewDetailCreateRequestDataRelationshipsAppStoreVersion appStoreVersion = default(AppStoreReviewDetailCreateRequestDataRelationshipsAppStoreVersion), AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment appStoreVersionExperimentTreatment = default(AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment))
        {
            // to ensure "appStoreVersion" is required (not null)
            if (appStoreVersion == null)
            {
                throw new ArgumentNullException("appStoreVersion is a required property for AppStoreVersionPromotionCreateRequestDataRelationships and cannot be null");
            }
            this.AppStoreVersion = appStoreVersion;
            // to ensure "appStoreVersionExperimentTreatment" is required (not null)
            if (appStoreVersionExperimentTreatment == null)
            {
                throw new ArgumentNullException("appStoreVersionExperimentTreatment is a required property for AppStoreVersionPromotionCreateRequestDataRelationships and cannot be null");
            }
            this.AppStoreVersionExperimentTreatment = appStoreVersionExperimentTreatment;
        }

        /// <summary>
        /// Gets or Sets AppStoreVersion
        /// </summary>
        [DataMember(Name = "appStoreVersion", IsRequired = true, EmitDefaultValue = true)]
        public AppStoreReviewDetailCreateRequestDataRelationshipsAppStoreVersion AppStoreVersion { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperimentTreatment
        /// </summary>
        [DataMember(Name = "appStoreVersionExperimentTreatment", IsRequired = true, EmitDefaultValue = true)]
        public AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment AppStoreVersionExperimentTreatment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionPromotionCreateRequestDataRelationships {\n");
            sb.Append("  AppStoreVersion: ").Append(AppStoreVersion).Append("\n");
            sb.Append("  AppStoreVersionExperimentTreatment: ").Append(AppStoreVersionExperimentTreatment).Append("\n");
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
            return this.Equals(input as AppStoreVersionPromotionCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppStoreVersionPromotionCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionPromotionCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionPromotionCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppStoreVersion == input.AppStoreVersion ||
                    (this.AppStoreVersion != null &&
                    this.AppStoreVersion.Equals(input.AppStoreVersion))
                ) && 
                (
                    this.AppStoreVersionExperimentTreatment == input.AppStoreVersionExperimentTreatment ||
                    (this.AppStoreVersionExperimentTreatment != null &&
                    this.AppStoreVersionExperimentTreatment.Equals(input.AppStoreVersionExperimentTreatment))
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
                if (this.AppStoreVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersion.GetHashCode();
                }
                if (this.AppStoreVersionExperimentTreatment != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionExperimentTreatment.GetHashCode();
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
