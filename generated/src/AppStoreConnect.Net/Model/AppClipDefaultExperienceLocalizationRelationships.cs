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
    /// AppClipDefaultExperienceLocalizationRelationships
    /// </summary>
    [DataContract(Name = "AppClipDefaultExperienceLocalization_relationships")]
    public partial class AppClipDefaultExperienceLocalizationRelationships : IEquatable<AppClipDefaultExperienceLocalizationRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperience">appClipDefaultExperience.</param>
        /// <param name="appClipHeaderImage">appClipHeaderImage.</param>
        public AppClipDefaultExperienceLocalizationRelationships(AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience appClipDefaultExperience = default(AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience), AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage appClipHeaderImage = default(AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage))
        {
            this.AppClipDefaultExperience = appClipDefaultExperience;
            this.AppClipHeaderImage = appClipHeaderImage;
        }

        /// <summary>
        /// Gets or Sets AppClipDefaultExperience
        /// </summary>
        [DataMember(Name = "appClipDefaultExperience", EmitDefaultValue = false)]
        public AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience AppClipDefaultExperience { get; set; }

        /// <summary>
        /// Gets or Sets AppClipHeaderImage
        /// </summary>
        [DataMember(Name = "appClipHeaderImage", EmitDefaultValue = false)]
        public AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage AppClipHeaderImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipDefaultExperienceLocalizationRelationships {\n");
            sb.Append("  AppClipDefaultExperience: ").Append(AppClipDefaultExperience).Append("\n");
            sb.Append("  AppClipHeaderImage: ").Append(AppClipHeaderImage).Append("\n");
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
            return this.Equals(input as AppClipDefaultExperienceLocalizationRelationships);
        }

        /// <summary>
        /// Returns true if AppClipDefaultExperienceLocalizationRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipDefaultExperienceLocalizationRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipDefaultExperienceLocalizationRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppClipDefaultExperience == input.AppClipDefaultExperience ||
                    (this.AppClipDefaultExperience != null &&
                    this.AppClipDefaultExperience.Equals(input.AppClipDefaultExperience))
                ) && 
                (
                    this.AppClipHeaderImage == input.AppClipHeaderImage ||
                    (this.AppClipHeaderImage != null &&
                    this.AppClipHeaderImage.Equals(input.AppClipHeaderImage))
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
                if (this.AppClipDefaultExperience != null)
                {
                    hashCode = (hashCode * 59) + this.AppClipDefaultExperience.GetHashCode();
                }
                if (this.AppClipHeaderImage != null)
                {
                    hashCode = (hashCode * 59) + this.AppClipHeaderImage.GetHashCode();
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
