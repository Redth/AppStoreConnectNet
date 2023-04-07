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
    /// SubscriptionOfferCodeCustomCodeRelationships
    /// </summary>
    [DataContract(Name = "SubscriptionOfferCodeCustomCode_relationships")]
    public partial class SubscriptionOfferCodeCustomCodeRelationships : IEquatable<SubscriptionOfferCodeCustomCodeRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCustomCodeRelationships" /> class.
        /// </summary>
        /// <param name="offerCode">offerCode.</param>
        public SubscriptionOfferCodeCustomCodeRelationships(SubscriptionOfferCodeCustomCodeRelationshipsOfferCode offerCode = default(SubscriptionOfferCodeCustomCodeRelationshipsOfferCode))
        {
            this.OfferCode = offerCode;
        }

        /// <summary>
        /// Gets or Sets OfferCode
        /// </summary>
        [DataMember(Name = "offerCode", EmitDefaultValue = false)]
        public SubscriptionOfferCodeCustomCodeRelationshipsOfferCode OfferCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionOfferCodeCustomCodeRelationships {\n");
            sb.Append("  OfferCode: ").Append(OfferCode).Append("\n");
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
            return this.Equals(input as SubscriptionOfferCodeCustomCodeRelationships);
        }

        /// <summary>
        /// Returns true if SubscriptionOfferCodeCustomCodeRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionOfferCodeCustomCodeRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionOfferCodeCustomCodeRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OfferCode == input.OfferCode ||
                    (this.OfferCode != null &&
                    this.OfferCode.Equals(input.OfferCode))
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
                if (this.OfferCode != null)
                {
                    hashCode = (hashCode * 59) + this.OfferCode.GetHashCode();
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
