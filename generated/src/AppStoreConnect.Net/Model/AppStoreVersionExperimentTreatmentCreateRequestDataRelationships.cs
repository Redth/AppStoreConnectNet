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
    /// AppStoreVersionExperimentTreatmentCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppStoreVersionExperimentTreatmentCreateRequest_data_relationships")]
    public partial class AppStoreVersionExperimentTreatmentCreateRequestDataRelationships : IEquatable<AppStoreVersionExperimentTreatmentCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreVersionExperimentTreatmentCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperiment">appStoreVersionExperiment (required).</param>
        public AppStoreVersionExperimentTreatmentCreateRequestDataRelationships(AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment appStoreVersionExperiment = default(AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment))
        {
            // to ensure "appStoreVersionExperiment" is required (not null)
            if (appStoreVersionExperiment == null)
            {
                throw new ArgumentNullException("appStoreVersionExperiment is a required property for AppStoreVersionExperimentTreatmentCreateRequestDataRelationships and cannot be null");
            }
            this.AppStoreVersionExperiment = appStoreVersionExperiment;
        }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperiment
        /// </summary>
        [DataMember(Name = "appStoreVersionExperiment", IsRequired = true, EmitDefaultValue = true)]
        public AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment AppStoreVersionExperiment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionExperimentTreatmentCreateRequestDataRelationships {\n");
            sb.Append("  AppStoreVersionExperiment: ").Append(AppStoreVersionExperiment).Append("\n");
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
            return this.Equals(input as AppStoreVersionExperimentTreatmentCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppStoreVersionExperimentTreatmentCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionExperimentTreatmentCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionExperimentTreatmentCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppStoreVersionExperiment == input.AppStoreVersionExperiment ||
                    (this.AppStoreVersionExperiment != null &&
                    this.AppStoreVersionExperiment.Equals(input.AppStoreVersionExperiment))
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
                if (this.AppStoreVersionExperiment != null)
                {
                    hashCode = (hashCode * 59) + this.AppStoreVersionExperiment.GetHashCode();
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