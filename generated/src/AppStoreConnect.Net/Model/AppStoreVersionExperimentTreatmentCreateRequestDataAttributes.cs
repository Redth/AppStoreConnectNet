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
    /// AppStoreVersionExperimentTreatmentCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppStoreVersionExperimentTreatmentCreateRequest_data_attributes")]
    public partial class AppStoreVersionExperimentTreatmentCreateRequestDataAttributes : IEquatable<AppStoreVersionExperimentTreatmentCreateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreVersionExperimentTreatmentCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="appIconName">appIconName.</param>
        public AppStoreVersionExperimentTreatmentCreateRequestDataAttributes(string name = default(string), string appIconName = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AppStoreVersionExperimentTreatmentCreateRequestDataAttributes and cannot be null");
            }
            this.Name = name;
            this.AppIconName = appIconName;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AppIconName
        /// </summary>
        [DataMember(Name = "appIconName", EmitDefaultValue = false)]
        public string AppIconName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionExperimentTreatmentCreateRequestDataAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AppIconName: ").Append(AppIconName).Append("\n");
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
            return this.Equals(input as AppStoreVersionExperimentTreatmentCreateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if AppStoreVersionExperimentTreatmentCreateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionExperimentTreatmentCreateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionExperimentTreatmentCreateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AppIconName == input.AppIconName ||
                    (this.AppIconName != null &&
                    this.AppIconName.Equals(input.AppIconName))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AppIconName != null)
                {
                    hashCode = (hashCode * 59) + this.AppIconName.GetHashCode();
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
