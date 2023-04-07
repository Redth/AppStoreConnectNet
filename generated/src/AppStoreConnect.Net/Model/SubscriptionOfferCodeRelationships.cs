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
    /// SubscriptionOfferCodeRelationships
    /// </summary>
    [DataContract(Name = "SubscriptionOfferCode_relationships")]
    public partial class SubscriptionOfferCodeRelationships : IEquatable<SubscriptionOfferCodeRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeRelationships" /> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        /// <param name="oneTimeUseCodes">oneTimeUseCodes.</param>
        /// <param name="customCodes">customCodes.</param>
        /// <param name="prices">prices.</param>
        public SubscriptionOfferCodeRelationships(PromotedPurchaseRelationshipsSubscription subscription = default(PromotedPurchaseRelationshipsSubscription), SubscriptionOfferCodeRelationshipsOneTimeUseCodes oneTimeUseCodes = default(SubscriptionOfferCodeRelationshipsOneTimeUseCodes), SubscriptionOfferCodeRelationshipsCustomCodes customCodes = default(SubscriptionOfferCodeRelationshipsCustomCodes), SubscriptionOfferCodeRelationshipsPrices prices = default(SubscriptionOfferCodeRelationshipsPrices))
        {
            this.Subscription = subscription;
            this.OneTimeUseCodes = oneTimeUseCodes;
            this.CustomCodes = customCodes;
            this.Prices = prices;
        }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public PromotedPurchaseRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or Sets OneTimeUseCodes
        /// </summary>
        [DataMember(Name = "oneTimeUseCodes", EmitDefaultValue = false)]
        public SubscriptionOfferCodeRelationshipsOneTimeUseCodes OneTimeUseCodes { get; set; }

        /// <summary>
        /// Gets or Sets CustomCodes
        /// </summary>
        [DataMember(Name = "customCodes", EmitDefaultValue = false)]
        public SubscriptionOfferCodeRelationshipsCustomCodes CustomCodes { get; set; }

        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [DataMember(Name = "prices", EmitDefaultValue = false)]
        public SubscriptionOfferCodeRelationshipsPrices Prices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionOfferCodeRelationships {\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  OneTimeUseCodes: ").Append(OneTimeUseCodes).Append("\n");
            sb.Append("  CustomCodes: ").Append(CustomCodes).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
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
            return this.Equals(input as SubscriptionOfferCodeRelationships);
        }

        /// <summary>
        /// Returns true if SubscriptionOfferCodeRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionOfferCodeRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionOfferCodeRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.OneTimeUseCodes == input.OneTimeUseCodes ||
                    (this.OneTimeUseCodes != null &&
                    this.OneTimeUseCodes.Equals(input.OneTimeUseCodes))
                ) && 
                (
                    this.CustomCodes == input.CustomCodes ||
                    (this.CustomCodes != null &&
                    this.CustomCodes.Equals(input.CustomCodes))
                ) && 
                (
                    this.Prices == input.Prices ||
                    (this.Prices != null &&
                    this.Prices.Equals(input.Prices))
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
                if (this.Subscription != null)
                {
                    hashCode = (hashCode * 59) + this.Subscription.GetHashCode();
                }
                if (this.OneTimeUseCodes != null)
                {
                    hashCode = (hashCode * 59) + this.OneTimeUseCodes.GetHashCode();
                }
                if (this.CustomCodes != null)
                {
                    hashCode = (hashCode * 59) + this.CustomCodes.GetHashCode();
                }
                if (this.Prices != null)
                {
                    hashCode = (hashCode * 59) + this.Prices.GetHashCode();
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