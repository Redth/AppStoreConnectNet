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
    /// SubscriptionUpdateRequest
    /// </summary>
    [DataContract(Name = "SubscriptionUpdateRequest")]
    public partial class SubscriptionUpdateRequest : IEquatable<SubscriptionUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="included">included.</param>
        public SubscriptionUpdateRequest(SubscriptionUpdateRequestData data = default(SubscriptionUpdateRequestData), List<SubscriptionUpdateRequestIncludedInner> included = default(List<SubscriptionUpdateRequestIncludedInner>))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for SubscriptionUpdateRequest and cannot be null");
            }
            this.Data = data;
            this.Included = included;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionUpdateRequestData Data { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", EmitDefaultValue = false)]
        public List<SubscriptionUpdateRequestIncludedInner> Included { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionUpdateRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
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
            return this.Equals(input as SubscriptionUpdateRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Included == input.Included ||
                    this.Included != null &&
                    input.Included != null &&
                    this.Included.SequenceEqual(input.Included)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Included != null)
                {
                    hashCode = (hashCode * 59) + this.Included.GetHashCode();
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
