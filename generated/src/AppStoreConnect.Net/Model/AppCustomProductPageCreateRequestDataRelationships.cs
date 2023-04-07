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
    /// AppCustomProductPageCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppCustomProductPageCreateRequest_data_relationships")]
    public partial class AppCustomProductPageCreateRequestDataRelationships : IEquatable<AppCustomProductPageCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppCustomProductPageCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app">app (required).</param>
        /// <param name="appCustomProductPageVersions">appCustomProductPageVersions.</param>
        /// <param name="appStoreVersionTemplate">appStoreVersionTemplate.</param>
        /// <param name="customProductPageTemplate">customProductPageTemplate.</param>
        public AppCustomProductPageCreateRequestDataRelationships(AppAvailabilityCreateRequestDataRelationshipsApp app = default(AppAvailabilityCreateRequestDataRelationshipsApp), AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions appCustomProductPageVersions = default(AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions), AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion appStoreVersionTemplate = default(AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion), AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage customProductPageTemplate = default(AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage))
        {
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for AppCustomProductPageCreateRequestDataRelationships and cannot be null");
            }
            this.App = app;
            this.AppCustomProductPageVersions = appCustomProductPageVersions;
            this.AppStoreVersionTemplate = appStoreVersionTemplate;
            this.CustomProductPageTemplate = customProductPageTemplate;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets AppCustomProductPageVersions
        /// </summary>
        [DataMember(Name = "appCustomProductPageVersions", EmitDefaultValue = false)]
        public AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions AppCustomProductPageVersions { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionTemplate
        /// </summary>
        [DataMember(Name = "appStoreVersionTemplate", EmitDefaultValue = false)]
        public AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion AppStoreVersionTemplate { get; set; }

        /// <summary>
        /// Gets or Sets CustomProductPageTemplate
        /// </summary>
        [DataMember(Name = "customProductPageTemplate", EmitDefaultValue = false)]
        public AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage CustomProductPageTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCustomProductPageCreateRequestDataRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  AppCustomProductPageVersions: ").Append(AppCustomProductPageVersions).Append("\n");
            sb.Append("  AppStoreVersionTemplate: ").Append(AppStoreVersionTemplate).Append("\n");
            sb.Append("  CustomProductPageTemplate: ").Append(CustomProductPageTemplate).Append("\n");
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
            return this.Equals(input as AppCustomProductPageCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppCustomProductPageCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCustomProductPageCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCustomProductPageCreateRequestDataRelationships input)
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
                    this.AppCustomProductPageVersions == input.AppCustomProductPageVersions ||
                    (this.AppCustomProductPageVersions != null &&
                    this.AppCustomProductPageVersions.Equals(input.AppCustomProductPageVersions))
                ) && 
                (
                    this.AppStoreVersionTemplate == input.AppStoreVersionTemplate ||
                    (this.AppStoreVersionTemplate != null &&
                    this.AppStoreVersionTemplate.Equals(input.AppStoreVersionTemplate))
                ) && 
                (
                    this.CustomProductPageTemplate == input.CustomProductPageTemplate ||
                    (this.CustomProductPageTemplate != null &&
                    this.CustomProductPageTemplate.Equals(input.CustomProductPageTemplate))
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
                if (this.AppCustomProductPageVersions != null)
                {
                    hashCode = (hashCode * 59) + this.AppCustomProductPageVersions.GetHashCode();
                }
                if (this.AppStoreVersionTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionTemplate.GetHashCode();
                }
                if (this.CustomProductPageTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.CustomProductPageTemplate.GetHashCode();
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