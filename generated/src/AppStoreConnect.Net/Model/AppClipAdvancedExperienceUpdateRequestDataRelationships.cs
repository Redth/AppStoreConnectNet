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
    /// AppClipAdvancedExperienceUpdateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppClipAdvancedExperienceUpdateRequest_data_relationships")]
    public partial class AppClipAdvancedExperienceUpdateRequestDataRelationships : IEquatable<AppClipAdvancedExperienceUpdateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClip">appClip.</param>
        /// <param name="headerImage">headerImage.</param>
        /// <param name="localizations">localizations.</param>
        public AppClipAdvancedExperienceUpdateRequestDataRelationships(AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip appClip = default(AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip), AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage headerImage = default(AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage), AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations localizations = default(AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations))
        {
            this.AppClip = appClip;
            this.HeaderImage = headerImage;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Gets or Sets AppClip
        /// </summary>
        [DataMember(Name = "appClip", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClip AppClip { get; set; }

        /// <summary>
        /// Gets or Sets HeaderImage
        /// </summary>
        [DataMember(Name = "headerImage", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImage HeaderImage { get; set; }

        /// <summary>
        /// Gets or Sets Localizations
        /// </summary>
        [DataMember(Name = "localizations", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizations Localizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAdvancedExperienceUpdateRequestDataRelationships {\n");
            sb.Append("  AppClip: ").Append(AppClip).Append("\n");
            sb.Append("  HeaderImage: ").Append(HeaderImage).Append("\n");
            sb.Append("  Localizations: ").Append(Localizations).Append("\n");
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
            return this.Equals(input as AppClipAdvancedExperienceUpdateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppClipAdvancedExperienceUpdateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipAdvancedExperienceUpdateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipAdvancedExperienceUpdateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppClip == input.AppClip ||
                    (this.AppClip != null &&
                    this.AppClip.Equals(input.AppClip))
                ) && 
                (
                    this.HeaderImage == input.HeaderImage ||
                    (this.HeaderImage != null &&
                    this.HeaderImage.Equals(input.HeaderImage))
                ) && 
                (
                    this.Localizations == input.Localizations ||
                    (this.Localizations != null &&
                    this.Localizations.Equals(input.Localizations))
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
                if (this.AppClip != null)
                {
                    hashCode = (hashCode * 59) + this.AppClip.GetHashCode();
                }
                if (this.HeaderImage != null)
                {
                    hashCode = (hashCode * 59) + this.HeaderImage.GetHashCode();
                }
                if (this.Localizations != null)
                {
                    hashCode = (hashCode * 59) + this.Localizations.GetHashCode();
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
