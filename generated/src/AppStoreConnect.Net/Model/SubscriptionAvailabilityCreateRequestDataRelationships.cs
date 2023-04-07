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
    /// SubscriptionAvailabilityCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "SubscriptionAvailabilityCreateRequest_data_relationships")]
    public partial class SubscriptionAvailabilityCreateRequestDataRelationships : IEquatable<SubscriptionAvailabilityCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionAvailabilityCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscription">subscription (required).</param>
        /// <param name="availableTerritories">availableTerritories (required).</param>
        public SubscriptionAvailabilityCreateRequestDataRelationships(SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationshipsSubscription subscription = default(SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationshipsSubscription), AppAvailabilityCreateRequestDataRelationshipsAvailableTerritories availableTerritories = default(AppAvailabilityCreateRequestDataRelationshipsAvailableTerritories))
        {
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new ArgumentNullException("subscription is a required property for SubscriptionAvailabilityCreateRequestDataRelationships and cannot be null");
            }
            this.Subscription = subscription;
            // to ensure "availableTerritories" is required (not null)
            if (availableTerritories == null)
            {
                throw new ArgumentNullException("availableTerritories is a required property for SubscriptionAvailabilityCreateRequestDataRelationships and cannot be null");
            }
            this.AvailableTerritories = availableTerritories;
        }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or Sets AvailableTerritories
        /// </summary>
        [DataMember(Name = "availableTerritories", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsAvailableTerritories AvailableTerritories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionAvailabilityCreateRequestDataRelationships {\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  AvailableTerritories: ").Append(AvailableTerritories).Append("\n");
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
            return this.Equals(input as SubscriptionAvailabilityCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if SubscriptionAvailabilityCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionAvailabilityCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionAvailabilityCreateRequestDataRelationships input)
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
                    this.AvailableTerritories == input.AvailableTerritories ||
                    (this.AvailableTerritories != null &&
                    this.AvailableTerritories.Equals(input.AvailableTerritories))
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
                if (this.AvailableTerritories != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableTerritories.GetHashCode();
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
