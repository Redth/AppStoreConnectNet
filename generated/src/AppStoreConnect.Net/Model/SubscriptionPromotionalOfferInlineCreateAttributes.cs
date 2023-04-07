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
    /// SubscriptionPromotionalOfferInlineCreateAttributes
    /// </summary>
    [DataContract(Name = "SubscriptionPromotionalOfferInlineCreate_attributes")]
    public partial class SubscriptionPromotionalOfferInlineCreateAttributes : IEquatable<SubscriptionPromotionalOfferInlineCreateAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionOfferDuration Duration { get; set; }

        /// <summary>
        /// Gets or Sets OfferMode
        /// </summary>
        [DataMember(Name = "offerMode", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionOfferMode OfferMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferInlineCreateAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPromotionalOfferInlineCreateAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="offerCode">offerCode (required).</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="offerMode">offerMode (required).</param>
        /// <param name="numberOfPeriods">numberOfPeriods (required).</param>
        public SubscriptionPromotionalOfferInlineCreateAttributes(string name = default(string), string offerCode = default(string), SubscriptionOfferDuration duration = default(SubscriptionOfferDuration), SubscriptionOfferMode offerMode = default(SubscriptionOfferMode), int numberOfPeriods = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SubscriptionPromotionalOfferInlineCreateAttributes and cannot be null");
            }
            this.Name = name;
            // to ensure "offerCode" is required (not null)
            if (offerCode == null)
            {
                throw new ArgumentNullException("offerCode is a required property for SubscriptionPromotionalOfferInlineCreateAttributes and cannot be null");
            }
            this.OfferCode = offerCode;
            this.Duration = duration;
            this.OfferMode = offerMode;
            this.NumberOfPeriods = numberOfPeriods;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OfferCode
        /// </summary>
        [DataMember(Name = "offerCode", IsRequired = true, EmitDefaultValue = true)]
        public string OfferCode { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPeriods
        /// </summary>
        [DataMember(Name = "numberOfPeriods", IsRequired = true, EmitDefaultValue = true)]
        public int NumberOfPeriods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPromotionalOfferInlineCreateAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OfferCode: ").Append(OfferCode).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  OfferMode: ").Append(OfferMode).Append("\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
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
            return this.Equals(input as SubscriptionPromotionalOfferInlineCreateAttributes);
        }

        /// <summary>
        /// Returns true if SubscriptionPromotionalOfferInlineCreateAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPromotionalOfferInlineCreateAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPromotionalOfferInlineCreateAttributes input)
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
                    this.OfferCode == input.OfferCode ||
                    (this.OfferCode != null &&
                    this.OfferCode.Equals(input.OfferCode))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.OfferMode == input.OfferMode ||
                    this.OfferMode.Equals(input.OfferMode)
                ) && 
                (
                    this.NumberOfPeriods == input.NumberOfPeriods ||
                    this.NumberOfPeriods.Equals(input.NumberOfPeriods)
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
                if (this.OfferCode != null)
                {
                    hashCode = (hashCode * 59) + this.OfferCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                hashCode = (hashCode * 59) + this.OfferMode.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfPeriods.GetHashCode();
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
