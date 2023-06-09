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
    /// AppPreviewSetRelationships
    /// </summary>
    [DataContract(Name = "AppPreviewSet_relationships")]
    public partial class AppPreviewSetRelationships : IEquatable<AppPreviewSetRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionLocalization">appStoreVersionLocalization.</param>
        /// <param name="appCustomProductPageLocalization">appCustomProductPageLocalization.</param>
        /// <param name="appStoreVersionExperimentTreatmentLocalization">appStoreVersionExperimentTreatmentLocalization.</param>
        /// <param name="appPreviews">appPreviews.</param>
        public AppPreviewSetRelationships(AppPreviewSetRelationshipsAppStoreVersionLocalization appStoreVersionLocalization = default(AppPreviewSetRelationshipsAppStoreVersionLocalization), AppPreviewSetRelationshipsAppCustomProductPageLocalization appCustomProductPageLocalization = default(AppPreviewSetRelationshipsAppCustomProductPageLocalization), AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization appStoreVersionExperimentTreatmentLocalization = default(AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization), AppPreviewSetRelationshipsAppPreviews appPreviews = default(AppPreviewSetRelationshipsAppPreviews))
        {
            this.AppStoreVersionLocalization = appStoreVersionLocalization;
            this.AppCustomProductPageLocalization = appCustomProductPageLocalization;
            this.AppStoreVersionExperimentTreatmentLocalization = appStoreVersionExperimentTreatmentLocalization;
            this.AppPreviews = appPreviews;
        }

        /// <summary>
        /// Gets or Sets AppStoreVersionLocalization
        /// </summary>
        [DataMember(Name = "appStoreVersionLocalization", EmitDefaultValue = false)]
        public AppPreviewSetRelationshipsAppStoreVersionLocalization AppStoreVersionLocalization { get; set; }

        /// <summary>
        /// Gets or Sets AppCustomProductPageLocalization
        /// </summary>
        [DataMember(Name = "appCustomProductPageLocalization", EmitDefaultValue = false)]
        public AppPreviewSetRelationshipsAppCustomProductPageLocalization AppCustomProductPageLocalization { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperimentTreatmentLocalization
        /// </summary>
        [DataMember(Name = "appStoreVersionExperimentTreatmentLocalization", EmitDefaultValue = false)]
        public AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization AppStoreVersionExperimentTreatmentLocalization { get; set; }

        /// <summary>
        /// Gets or Sets AppPreviews
        /// </summary>
        [DataMember(Name = "appPreviews", EmitDefaultValue = false)]
        public AppPreviewSetRelationshipsAppPreviews AppPreviews { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPreviewSetRelationships {\n");
            sb.Append("  AppStoreVersionLocalization: ").Append(AppStoreVersionLocalization).Append("\n");
            sb.Append("  AppCustomProductPageLocalization: ").Append(AppCustomProductPageLocalization).Append("\n");
            sb.Append("  AppStoreVersionExperimentTreatmentLocalization: ").Append(AppStoreVersionExperimentTreatmentLocalization).Append("\n");
            sb.Append("  AppPreviews: ").Append(AppPreviews).Append("\n");
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
            return this.Equals(input as AppPreviewSetRelationships);
        }

        /// <summary>
        /// Returns true if AppPreviewSetRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPreviewSetRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPreviewSetRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppStoreVersionLocalization == input.AppStoreVersionLocalization ||
                    (this.AppStoreVersionLocalization != null &&
                    this.AppStoreVersionLocalization.Equals(input.AppStoreVersionLocalization))
                ) && 
                (
                    this.AppCustomProductPageLocalization == input.AppCustomProductPageLocalization ||
                    (this.AppCustomProductPageLocalization != null &&
                    this.AppCustomProductPageLocalization.Equals(input.AppCustomProductPageLocalization))
                ) && 
                (
                    this.AppStoreVersionExperimentTreatmentLocalization == input.AppStoreVersionExperimentTreatmentLocalization ||
                    (this.AppStoreVersionExperimentTreatmentLocalization != null &&
                    this.AppStoreVersionExperimentTreatmentLocalization.Equals(input.AppStoreVersionExperimentTreatmentLocalization))
                ) && 
                (
                    this.AppPreviews == input.AppPreviews ||
                    (this.AppPreviews != null &&
                    this.AppPreviews.Equals(input.AppPreviews))
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
                if (this.AppStoreVersionLocalization != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionLocalization.GetHashCode();
                }
                if (this.AppCustomProductPageLocalization != null)
                {
                    hashCode = (hashCode * 59) + this.AppCustomProductPageLocalization.GetHashCode();
                }
                if (this.AppStoreVersionExperimentTreatmentLocalization != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionExperimentTreatmentLocalization.GetHashCode();
                }
                if (this.AppPreviews != null)
                {
                    hashCode = (hashCode * 59) + this.AppPreviews.GetHashCode();
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
