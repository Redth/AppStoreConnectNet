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
    /// AppEventLocalizationRelationships
    /// </summary>
    [DataContract(Name = "AppEventLocalization_relationships")]
    public partial class AppEventLocalizationRelationships : IEquatable<AppEventLocalizationRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appEvent">appEvent.</param>
        /// <param name="appEventScreenshots">appEventScreenshots.</param>
        /// <param name="appEventVideoClips">appEventVideoClips.</param>
        public AppEventLocalizationRelationships(AppEventLocalizationRelationshipsAppEvent appEvent = default(AppEventLocalizationRelationshipsAppEvent), AppEventLocalizationRelationshipsAppEventScreenshots appEventScreenshots = default(AppEventLocalizationRelationshipsAppEventScreenshots), AppEventLocalizationRelationshipsAppEventVideoClips appEventVideoClips = default(AppEventLocalizationRelationshipsAppEventVideoClips))
        {
            this.AppEvent = appEvent;
            this.AppEventScreenshots = appEventScreenshots;
            this.AppEventVideoClips = appEventVideoClips;
        }

        /// <summary>
        /// Gets or Sets AppEvent
        /// </summary>
        [DataMember(Name = "appEvent", EmitDefaultValue = false)]
        public AppEventLocalizationRelationshipsAppEvent AppEvent { get; set; }

        /// <summary>
        /// Gets or Sets AppEventScreenshots
        /// </summary>
        [DataMember(Name = "appEventScreenshots", EmitDefaultValue = false)]
        public AppEventLocalizationRelationshipsAppEventScreenshots AppEventScreenshots { get; set; }

        /// <summary>
        /// Gets or Sets AppEventVideoClips
        /// </summary>
        [DataMember(Name = "appEventVideoClips", EmitDefaultValue = false)]
        public AppEventLocalizationRelationshipsAppEventVideoClips AppEventVideoClips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEventLocalizationRelationships {\n");
            sb.Append("  AppEvent: ").Append(AppEvent).Append("\n");
            sb.Append("  AppEventScreenshots: ").Append(AppEventScreenshots).Append("\n");
            sb.Append("  AppEventVideoClips: ").Append(AppEventVideoClips).Append("\n");
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
            return this.Equals(input as AppEventLocalizationRelationships);
        }

        /// <summary>
        /// Returns true if AppEventLocalizationRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppEventLocalizationRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventLocalizationRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppEvent == input.AppEvent ||
                    (this.AppEvent != null &&
                    this.AppEvent.Equals(input.AppEvent))
                ) && 
                (
                    this.AppEventScreenshots == input.AppEventScreenshots ||
                    (this.AppEventScreenshots != null &&
                    this.AppEventScreenshots.Equals(input.AppEventScreenshots))
                ) && 
                (
                    this.AppEventVideoClips == input.AppEventVideoClips ||
                    (this.AppEventVideoClips != null &&
                    this.AppEventVideoClips.Equals(input.AppEventVideoClips))
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
                if (this.AppEvent != null)
                {
                    hashCode = (hashCode * 59) + this.AppEvent.GetHashCode();
                }
                if (this.AppEventScreenshots != null)
                {
                    hashCode = (hashCode * 59) + this.AppEventScreenshots.GetHashCode();
                }
                if (this.AppEventVideoClips != null)
                {
                    hashCode = (hashCode * 59) + this.AppEventVideoClips.GetHashCode();
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
