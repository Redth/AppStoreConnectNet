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
    /// AppClipAdvancedExperienceAttributesPlaceMainAddress
    /// </summary>
    [DataContract(Name = "AppClipAdvancedExperience_attributes_place_mainAddress")]
    public partial class AppClipAdvancedExperienceAttributesPlaceMainAddress : IEquatable<AppClipAdvancedExperienceAttributesPlaceMainAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceMainAddress" /> class.
        /// </summary>
        /// <param name="fullAddress">fullAddress.</param>
        /// <param name="structuredAddress">structuredAddress.</param>
        public AppClipAdvancedExperienceAttributesPlaceMainAddress(string fullAddress = default(string), AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress structuredAddress = default(AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress))
        {
            this.FullAddress = fullAddress;
            this.StructuredAddress = structuredAddress;
        }

        /// <summary>
        /// Gets or Sets FullAddress
        /// </summary>
        [DataMember(Name = "fullAddress", EmitDefaultValue = false)]
        public string FullAddress { get; set; }

        /// <summary>
        /// Gets or Sets StructuredAddress
        /// </summary>
        [DataMember(Name = "structuredAddress", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress StructuredAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAdvancedExperienceAttributesPlaceMainAddress {\n");
            sb.Append("  FullAddress: ").Append(FullAddress).Append("\n");
            sb.Append("  StructuredAddress: ").Append(StructuredAddress).Append("\n");
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
            return this.Equals(input as AppClipAdvancedExperienceAttributesPlaceMainAddress);
        }

        /// <summary>
        /// Returns true if AppClipAdvancedExperienceAttributesPlaceMainAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipAdvancedExperienceAttributesPlaceMainAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipAdvancedExperienceAttributesPlaceMainAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FullAddress == input.FullAddress ||
                    (this.FullAddress != null &&
                    this.FullAddress.Equals(input.FullAddress))
                ) && 
                (
                    this.StructuredAddress == input.StructuredAddress ||
                    (this.StructuredAddress != null &&
                    this.StructuredAddress.Equals(input.StructuredAddress))
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
                if (this.FullAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FullAddress.GetHashCode();
                }
                if (this.StructuredAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StructuredAddress.GetHashCode();
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
