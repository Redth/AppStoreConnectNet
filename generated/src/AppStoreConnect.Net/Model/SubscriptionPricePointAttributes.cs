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
    /// SubscriptionPricePointAttributes
    /// </summary>
    [DataContract(Name = "SubscriptionPricePoint_attributes")]
    public partial class SubscriptionPricePointAttributes : IEquatable<SubscriptionPricePointAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPricePointAttributes" /> class.
        /// </summary>
        /// <param name="customerPrice">customerPrice.</param>
        /// <param name="proceeds">proceeds.</param>
        /// <param name="proceedsYear2">proceedsYear2.</param>
        public SubscriptionPricePointAttributes(string customerPrice = default(string), string proceeds = default(string), string proceedsYear2 = default(string))
        {
            this.CustomerPrice = customerPrice;
            this.Proceeds = proceeds;
            this.ProceedsYear2 = proceedsYear2;
        }

        /// <summary>
        /// Gets or Sets CustomerPrice
        /// </summary>
        [DataMember(Name = "customerPrice", EmitDefaultValue = false)]
        public string CustomerPrice { get; set; }

        /// <summary>
        /// Gets or Sets Proceeds
        /// </summary>
        [DataMember(Name = "proceeds", EmitDefaultValue = false)]
        public string Proceeds { get; set; }

        /// <summary>
        /// Gets or Sets ProceedsYear2
        /// </summary>
        [DataMember(Name = "proceedsYear2", EmitDefaultValue = false)]
        public string ProceedsYear2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPricePointAttributes {\n");
            sb.Append("  CustomerPrice: ").Append(CustomerPrice).Append("\n");
            sb.Append("  Proceeds: ").Append(Proceeds).Append("\n");
            sb.Append("  ProceedsYear2: ").Append(ProceedsYear2).Append("\n");
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
            return this.Equals(input as SubscriptionPricePointAttributes);
        }

        /// <summary>
        /// Returns true if SubscriptionPricePointAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPricePointAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPricePointAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerPrice == input.CustomerPrice ||
                    (this.CustomerPrice != null &&
                    this.CustomerPrice.Equals(input.CustomerPrice))
                ) && 
                (
                    this.Proceeds == input.Proceeds ||
                    (this.Proceeds != null &&
                    this.Proceeds.Equals(input.Proceeds))
                ) && 
                (
                    this.ProceedsYear2 == input.ProceedsYear2 ||
                    (this.ProceedsYear2 != null &&
                    this.ProceedsYear2.Equals(input.ProceedsYear2))
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
                if (this.CustomerPrice != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerPrice.GetHashCode();
                }
                if (this.Proceeds != null)
                {
                    hashCode = (hashCode * 59) + this.Proceeds.GetHashCode();
                }
                if (this.ProceedsYear2 != null)
                {
                    hashCode = (hashCode * 59) + this.ProceedsYear2.GetHashCode();
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