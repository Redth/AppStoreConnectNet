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
    /// AppCustomProductPageLocalizationUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppCustomProductPageLocalizationUpdateRequest_data_attributes")]
    public partial class AppCustomProductPageLocalizationUpdateRequestDataAttributes : IEquatable<AppCustomProductPageLocalizationUpdateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="promotionalText">promotionalText.</param>
        public AppCustomProductPageLocalizationUpdateRequestDataAttributes(string promotionalText = default(string))
        {
            this.PromotionalText = promotionalText;
        }

        /// <summary>
        /// Gets or Sets PromotionalText
        /// </summary>
        [DataMember(Name = "promotionalText", EmitDefaultValue = false)]
        public string PromotionalText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCustomProductPageLocalizationUpdateRequestDataAttributes {\n");
            sb.Append("  PromotionalText: ").Append(PromotionalText).Append("\n");
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
            return this.Equals(input as AppCustomProductPageLocalizationUpdateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if AppCustomProductPageLocalizationUpdateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCustomProductPageLocalizationUpdateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCustomProductPageLocalizationUpdateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PromotionalText == input.PromotionalText ||
                    (this.PromotionalText != null &&
                    this.PromotionalText.Equals(input.PromotionalText))
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
                if (this.PromotionalText != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionalText.GetHashCode();
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
