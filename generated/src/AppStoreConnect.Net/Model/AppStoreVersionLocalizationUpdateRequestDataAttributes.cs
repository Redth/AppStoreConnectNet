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
    /// AppStoreVersionLocalizationUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppStoreVersionLocalizationUpdateRequest_data_attributes")]
    public partial class AppStoreVersionLocalizationUpdateRequestDataAttributes : IEquatable<AppStoreVersionLocalizationUpdateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="marketingUrl">marketingUrl.</param>
        /// <param name="promotionalText">promotionalText.</param>
        /// <param name="supportUrl">supportUrl.</param>
        /// <param name="whatsNew">whatsNew.</param>
        public AppStoreVersionLocalizationUpdateRequestDataAttributes(string description = default(string), string keywords = default(string), string marketingUrl = default(string), string promotionalText = default(string), string supportUrl = default(string), string whatsNew = default(string))
        {
            this.Description = description;
            this.Keywords = keywords;
            this.MarketingUrl = marketingUrl;
            this.PromotionalText = promotionalText;
            this.SupportUrl = supportUrl;
            this.WhatsNew = whatsNew;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets MarketingUrl
        /// </summary>
        [DataMember(Name = "marketingUrl", EmitDefaultValue = false)]
        public string MarketingUrl { get; set; }

        /// <summary>
        /// Gets or Sets PromotionalText
        /// </summary>
        [DataMember(Name = "promotionalText", EmitDefaultValue = false)]
        public string PromotionalText { get; set; }

        /// <summary>
        /// Gets or Sets SupportUrl
        /// </summary>
        [DataMember(Name = "supportUrl", EmitDefaultValue = false)]
        public string SupportUrl { get; set; }

        /// <summary>
        /// Gets or Sets WhatsNew
        /// </summary>
        [DataMember(Name = "whatsNew", EmitDefaultValue = false)]
        public string WhatsNew { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionLocalizationUpdateRequestDataAttributes {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  MarketingUrl: ").Append(MarketingUrl).Append("\n");
            sb.Append("  PromotionalText: ").Append(PromotionalText).Append("\n");
            sb.Append("  SupportUrl: ").Append(SupportUrl).Append("\n");
            sb.Append("  WhatsNew: ").Append(WhatsNew).Append("\n");
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
            return this.Equals(input as AppStoreVersionLocalizationUpdateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if AppStoreVersionLocalizationUpdateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionLocalizationUpdateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionLocalizationUpdateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.MarketingUrl == input.MarketingUrl ||
                    (this.MarketingUrl != null &&
                    this.MarketingUrl.Equals(input.MarketingUrl))
                ) && 
                (
                    this.PromotionalText == input.PromotionalText ||
                    (this.PromotionalText != null &&
                    this.PromotionalText.Equals(input.PromotionalText))
                ) && 
                (
                    this.SupportUrl == input.SupportUrl ||
                    (this.SupportUrl != null &&
                    this.SupportUrl.Equals(input.SupportUrl))
                ) && 
                (
                    this.WhatsNew == input.WhatsNew ||
                    (this.WhatsNew != null &&
                    this.WhatsNew.Equals(input.WhatsNew))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                if (this.MarketingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MarketingUrl.GetHashCode();
                }
                if (this.PromotionalText != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionalText.GetHashCode();
                }
                if (this.SupportUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SupportUrl.GetHashCode();
                }
                if (this.WhatsNew != null)
                {
                    hashCode = (hashCode * 59) + this.WhatsNew.GetHashCode();
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
