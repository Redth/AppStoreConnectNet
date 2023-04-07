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
    /// SubscriptionOfferCodeOneTimeUseCodeAttributes
    /// </summary>
    [DataContract(Name = "SubscriptionOfferCodeOneTimeUseCode_attributes")]
    public partial class SubscriptionOfferCodeOneTimeUseCodeAttributes : IEquatable<SubscriptionOfferCodeOneTimeUseCodeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeAttributes" /> class.
        /// </summary>
        /// <param name="numberOfCodes">numberOfCodes.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="active">active.</param>
        public SubscriptionOfferCodeOneTimeUseCodeAttributes(int numberOfCodes = default(int), DateTimeOffset createdDate = default(DateTimeOffset), DateTimeOffset expirationDate = default(DateTimeOffset), bool active = default(bool))
        {
            this.NumberOfCodes = numberOfCodes;
            this.CreatedDate = createdDate;
            this.ExpirationDate = expirationDate;
            this.Active = active;
        }

        /// <summary>
        /// Gets or Sets NumberOfCodes
        /// </summary>
        [DataMember(Name = "numberOfCodes", EmitDefaultValue = false)]
        public int NumberOfCodes { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionOfferCodeOneTimeUseCodeAttributes {\n");
            sb.Append("  NumberOfCodes: ").Append(NumberOfCodes).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as SubscriptionOfferCodeOneTimeUseCodeAttributes);
        }

        /// <summary>
        /// Returns true if SubscriptionOfferCodeOneTimeUseCodeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionOfferCodeOneTimeUseCodeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionOfferCodeOneTimeUseCodeAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NumberOfCodes == input.NumberOfCodes ||
                    this.NumberOfCodes.Equals(input.NumberOfCodes)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
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
                hashCode = (hashCode * 59) + this.NumberOfCodes.GetHashCode();
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
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
