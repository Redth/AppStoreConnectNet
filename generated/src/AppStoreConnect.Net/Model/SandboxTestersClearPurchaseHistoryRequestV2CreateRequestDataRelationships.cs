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
    /// SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "SandboxTestersClearPurchaseHistoryRequestV2CreateRequest_data_relationships")]
    public partial class SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships : IEquatable<SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="sandboxTesters">sandboxTesters (required).</param>
        public SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships(SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationshipsSandboxTesters sandboxTesters = default(SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationshipsSandboxTesters))
        {
            // to ensure "sandboxTesters" is required (not null)
            if (sandboxTesters == null)
            {
                throw new ArgumentNullException("sandboxTesters is a required property for SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships and cannot be null");
            }
            this.SandboxTesters = sandboxTesters;
        }

        /// <summary>
        /// Gets or Sets SandboxTesters
        /// </summary>
        [DataMember(Name = "sandboxTesters", IsRequired = true, EmitDefaultValue = true)]
        public SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationshipsSandboxTesters SandboxTesters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships {\n");
            sb.Append("  SandboxTesters: ").Append(SandboxTesters).Append("\n");
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
            return this.Equals(input as SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SandboxTesters == input.SandboxTesters ||
                    (this.SandboxTesters != null &&
                    this.SandboxTesters.Equals(input.SandboxTesters))
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
                if (this.SandboxTesters != null)
                {
                    hashCode = (hashCode * 59) + this.SandboxTesters.GetHashCode();
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
