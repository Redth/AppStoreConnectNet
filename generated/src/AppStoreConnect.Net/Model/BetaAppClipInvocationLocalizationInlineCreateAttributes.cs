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
    /// BetaAppClipInvocationLocalizationInlineCreateAttributes
    /// </summary>
    [DataContract(Name = "BetaAppClipInvocationLocalizationInlineCreate_attributes")]
    public partial class BetaAppClipInvocationLocalizationInlineCreateAttributes : IEquatable<BetaAppClipInvocationLocalizationInlineCreateAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationInlineCreateAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaAppClipInvocationLocalizationInlineCreateAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="locale">locale (required).</param>
        public BetaAppClipInvocationLocalizationInlineCreateAttributes(string title = default(string), string locale = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for BetaAppClipInvocationLocalizationInlineCreateAttributes and cannot be null");
            }
            this.Title = title;
            // to ensure "locale" is required (not null)
            if (locale == null)
            {
                throw new ArgumentNullException("locale is a required property for BetaAppClipInvocationLocalizationInlineCreateAttributes and cannot be null");
            }
            this.Locale = locale;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", IsRequired = true, EmitDefaultValue = true)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaAppClipInvocationLocalizationInlineCreateAttributes {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as BetaAppClipInvocationLocalizationInlineCreateAttributes);
        }

        /// <summary>
        /// Returns true if BetaAppClipInvocationLocalizationInlineCreateAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaAppClipInvocationLocalizationInlineCreateAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaAppClipInvocationLocalizationInlineCreateAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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
