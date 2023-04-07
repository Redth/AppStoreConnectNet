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
    /// AppCustomProductPageLocalizationAttributes
    /// </summary>
    [DataContract(Name = "AppCustomProductPageLocalization_attributes")]
    public partial class AppCustomProductPageLocalizationAttributes : IEquatable<AppCustomProductPageLocalizationAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="locale">locale.</param>
        /// <param name="promotionalText">promotionalText.</param>
        public AppCustomProductPageLocalizationAttributes(string locale = default(string), string promotionalText = default(string))
        {
            this.Locale = locale;
            this.PromotionalText = promotionalText;
        }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

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
            sb.Append("class AppCustomProductPageLocalizationAttributes {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as AppCustomProductPageLocalizationAttributes);
        }

        /// <summary>
        /// Returns true if AppCustomProductPageLocalizationAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCustomProductPageLocalizationAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCustomProductPageLocalizationAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
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
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
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