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
    /// AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppStoreVersionExperimentTreatmentLocalizationCreateRequest_data_relationships")]
    public partial class AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships : IEquatable<AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperimentTreatment">appStoreVersionExperimentTreatment (required).</param>
        public AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships(AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment appStoreVersionExperimentTreatment = default(AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment))
        {
            // to ensure "appStoreVersionExperimentTreatment" is required (not null)
            if (appStoreVersionExperimentTreatment == null)
            {
                throw new ArgumentNullException("appStoreVersionExperimentTreatment is a required property for AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships and cannot be null");
            }
            this.AppStoreVersionExperimentTreatment = appStoreVersionExperimentTreatment;
        }

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
            sb.Append("class AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships {\n");
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
            return this.Equals(input as AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionExperimentTreatmentLocalizationCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
