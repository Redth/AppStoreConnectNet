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
    /// ReviewSubmissionRelationships
    /// </summary>
    [DataContract(Name = "ReviewSubmission_relationships")]
    public partial class ReviewSubmissionRelationships : IEquatable<ReviewSubmissionRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="app">app.</param>
        /// <param name="items">items.</param>
        /// <param name="appStoreVersionForReview">appStoreVersionForReview.</param>
        public ReviewSubmissionRelationships(AppAvailabilityRelationshipsApp app = default(AppAvailabilityRelationshipsApp), ReviewSubmissionRelationshipsItems items = default(ReviewSubmissionRelationshipsItems), AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion appStoreVersionForReview = default(AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion))
        {
            this.App = app;
            this.Items = items;
            this.AppStoreVersionForReview = appStoreVersionForReview;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", EmitDefaultValue = false)]
        public AppAvailabilityRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public ReviewSubmissionRelationshipsItems Items { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionForReview
        /// </summary>
        [DataMember(Name = "appStoreVersionForReview", EmitDefaultValue = false)]
        public AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion AppStoreVersionForReview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewSubmissionRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  AppStoreVersionForReview: ").Append(AppStoreVersionForReview).Append("\n");
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
            return this.Equals(input as ReviewSubmissionRelationships);
        }

        /// <summary>
        /// Returns true if ReviewSubmissionRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewSubmissionRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewSubmissionRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
                (
                    this.AppStoreVersionForReview == input.AppStoreVersionForReview ||
                    (this.AppStoreVersionForReview != null &&
                    this.AppStoreVersionForReview.Equals(input.AppStoreVersionForReview))
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
                if (this.App != null)
                {
                    hashCode = (hashCode * 59) + this.App.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.AppStoreVersionForReview != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionForReview.GetHashCode();
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
