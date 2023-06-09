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
    /// SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "SubscriptionOfferCodeOneTimeUseCodeCreateRequest_data_attributes")]
    public partial class SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes : IEquatable<SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="numberOfCodes">numberOfCodes (required).</param>
        /// <param name="expirationDate">expirationDate (required).</param>
        public SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes(int numberOfCodes = default(int), DateTimeOffset expirationDate = default(DateTimeOffset))
        {
            this.NumberOfCodes = numberOfCodes;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Gets or Sets NumberOfCodes
        /// </summary>
        [DataMember(Name = "numberOfCodes", IsRequired = true, EmitDefaultValue = true)]
        public int NumberOfCodes { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes {\n");
            sb.Append("  NumberOfCodes: ").Append(NumberOfCodes).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataAttributes input)
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
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
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
