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
    /// AppEventLocalizationUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppEventLocalizationUpdateRequest_data_attributes")]
    public partial class AppEventLocalizationUpdateRequestDataAttributes : IEquatable<AppEventLocalizationUpdateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="longDescription">longDescription.</param>
        public AppEventLocalizationUpdateRequestDataAttributes(string name = default(string), string shortDescription = default(string), string longDescription = default(string))
        {
            this.Name = name;
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "shortDescription", EmitDefaultValue = false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets LongDescription
        /// </summary>
        [DataMember(Name = "longDescription", EmitDefaultValue = false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEventLocalizationUpdateRequestDataAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
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
            return this.Equals(input as AppEventLocalizationUpdateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if AppEventLocalizationUpdateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppEventLocalizationUpdateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventLocalizationUpdateRequestDataAttributes input)
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
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
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
                if (this.ShortDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ShortDescription.GetHashCode();
                }
                if (this.LongDescription != null)
                {
                    hashCode = (hashCode * 59) + this.LongDescription.GetHashCode();
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
