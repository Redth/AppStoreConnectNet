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
    /// SubscriptionPriceCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "SubscriptionPriceCreateRequest_data_relationships")]
    public partial class SubscriptionPriceCreateRequestDataRelationships : IEquatable<SubscriptionPriceCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPriceCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscription">subscription (required).</param>
        /// <param name="territory">territory.</param>
        /// <param name="subscriptionPricePoint">subscriptionPricePoint (required).</param>
        public SubscriptionPriceCreateRequestDataRelationships(SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationshipsSubscription subscription = default(SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationshipsSubscription), InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory territory = default(InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory), SubscriptionPriceCreateRequestDataRelationshipsSubscriptionPricePoint subscriptionPricePoint = default(SubscriptionPriceCreateRequestDataRelationshipsSubscriptionPricePoint))
        {
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new ArgumentNullException("subscription is a required property for SubscriptionPriceCreateRequestDataRelationships and cannot be null");
            }
            this.Subscription = subscription;
            // to ensure "subscriptionPricePoint" is required (not null)
            if (subscriptionPricePoint == null)
            {
                throw new ArgumentNullException("subscriptionPricePoint is a required property for SubscriptionPriceCreateRequestDataRelationships and cannot be null");
            }
            this.SubscriptionPricePoint = subscriptionPricePoint;
            this.Territory = territory;
        }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or Sets Territory
        /// </summary>
        [DataMember(Name = "territory", EmitDefaultValue = false)]
        public InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory Territory { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPricePoint
        /// </summary>
        [DataMember(Name = "subscriptionPricePoint", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionPriceCreateRequestDataRelationshipsSubscriptionPricePoint SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPriceCreateRequestDataRelationships {\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Territory: ").Append(Territory).Append("\n");
            sb.Append("  SubscriptionPricePoint: ").Append(SubscriptionPricePoint).Append("\n");
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
            return this.Equals(input as SubscriptionPriceCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if SubscriptionPriceCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPriceCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPriceCreateRequestDataRelationships input)
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
                    this.Territory == input.Territory ||
                    (this.Territory != null &&
                    this.Territory.Equals(input.Territory))
                ) && 
                (
                    this.SubscriptionPricePoint == input.SubscriptionPricePoint ||
                    (this.SubscriptionPricePoint != null &&
                    this.SubscriptionPricePoint.Equals(input.SubscriptionPricePoint))
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
                if (this.Territory != null)
                {
                    hashCode = (hashCode * 59) + this.Territory.GetHashCode();
                }
                if (this.SubscriptionPricePoint != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionPricePoint.GetHashCode();
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
