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
    /// ReviewSubmissionItemCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "ReviewSubmissionItemCreateRequest_data_relationships")]
    public partial class ReviewSubmissionItemCreateRequestDataRelationships : IEquatable<ReviewSubmissionItemCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReviewSubmissionItemCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="reviewSubmission">reviewSubmission (required).</param>
        /// <param name="appStoreVersion">appStoreVersion.</param>
        /// <param name="appCustomProductPageVersion">appCustomProductPageVersion.</param>
        /// <param name="appStoreVersionExperiment">appStoreVersionExperiment.</param>
        /// <param name="appEvent">appEvent.</param>
        public ReviewSubmissionItemCreateRequestDataRelationships(ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission reviewSubmission = default(ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission), AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion appStoreVersion = default(AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion), AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion appCustomProductPageVersion = default(AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion), ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment appStoreVersionExperiment = default(ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment), ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent appEvent = default(ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent))
        {
            // to ensure "reviewSubmission" is required (not null)
            if (reviewSubmission == null)
            {
                throw new ArgumentNullException("reviewSubmission is a required property for ReviewSubmissionItemCreateRequestDataRelationships and cannot be null");
            }
            this.ReviewSubmission = reviewSubmission;
            this.AppStoreVersion = appStoreVersion;
            this.AppCustomProductPageVersion = appCustomProductPageVersion;
            this.AppStoreVersionExperiment = appStoreVersionExperiment;
            this.AppEvent = appEvent;
        }

        /// <summary>
        /// Gets or Sets ReviewSubmission
        /// </summary>
        [DataMember(Name = "reviewSubmission", IsRequired = true, EmitDefaultValue = true)]
        public ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission ReviewSubmission { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersion
        /// </summary>
        [DataMember(Name = "appStoreVersion", EmitDefaultValue = false)]
        public AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion AppStoreVersion { get; set; }

        /// <summary>
        /// Gets or Sets AppCustomProductPageVersion
        /// </summary>
        [DataMember(Name = "appCustomProductPageVersion", EmitDefaultValue = false)]
        public AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion AppCustomProductPageVersion { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperiment
        /// </summary>
        [DataMember(Name = "appStoreVersionExperiment", EmitDefaultValue = false)]
        public ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment AppStoreVersionExperiment { get; set; }

        /// <summary>
        /// Gets or Sets AppEvent
        /// </summary>
        [DataMember(Name = "appEvent", EmitDefaultValue = false)]
        public ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent AppEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewSubmissionItemCreateRequestDataRelationships {\n");
            sb.Append("  ReviewSubmission: ").Append(ReviewSubmission).Append("\n");
            sb.Append("  AppStoreVersion: ").Append(AppStoreVersion).Append("\n");
            sb.Append("  AppCustomProductPageVersion: ").Append(AppCustomProductPageVersion).Append("\n");
            sb.Append("  AppStoreVersionExperiment: ").Append(AppStoreVersionExperiment).Append("\n");
            sb.Append("  AppEvent: ").Append(AppEvent).Append("\n");
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
            return this.Equals(input as ReviewSubmissionItemCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if ReviewSubmissionItemCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewSubmissionItemCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewSubmissionItemCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReviewSubmission == input.ReviewSubmission ||
                    (this.ReviewSubmission != null &&
                    this.ReviewSubmission.Equals(input.ReviewSubmission))
                ) && 
                (
                    this.AppStoreVersion == input.AppStoreVersion ||
                    (this.AppStoreVersion != null &&
                    this.AppStoreVersion.Equals(input.AppStoreVersion))
                ) && 
                (
                    this.AppCustomProductPageVersion == input.AppCustomProductPageVersion ||
                    (this.AppCustomProductPageVersion != null &&
                    this.AppCustomProductPageVersion.Equals(input.AppCustomProductPageVersion))
                ) && 
                (
                    this.AppStoreVersionExperiment == input.AppStoreVersionExperiment ||
                    (this.AppStoreVersionExperiment != null &&
                    this.AppStoreVersionExperiment.Equals(input.AppStoreVersionExperiment))
                ) && 
                (
                    this.AppEvent == input.AppEvent ||
                    (this.AppEvent != null &&
                    this.AppEvent.Equals(input.AppEvent))
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
                if (this.ReviewSubmission != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewSubmission.GetHashCode();
                }
                if (this.AppStoreVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersion.GetHashCode();
                }
                if (this.AppCustomProductPageVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppCustomProductPageVersion.GetHashCode();
                }
                if (this.AppStoreVersionExperiment != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionExperiment.GetHashCode();
                }
                if (this.AppEvent != null)
                {
                    hashCode = (hashCode * 59) + this.AppEvent.GetHashCode();
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
