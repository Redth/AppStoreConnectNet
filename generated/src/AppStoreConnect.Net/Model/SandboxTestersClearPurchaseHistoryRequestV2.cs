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
    /// SandboxTestersClearPurchaseHistoryRequestV2
    /// </summary>
    [DataContract(Name = "SandboxTestersClearPurchaseHistoryRequestV2")]
    public partial class SandboxTestersClearPurchaseHistoryRequestV2 : IEquatable<SandboxTestersClearPurchaseHistoryRequestV2>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SandboxTestersClearPurchaseHistoryRequest for value: sandboxTestersClearPurchaseHistoryRequest
            /// </summary>
            [EnumMember(Value = "sandboxTestersClearPurchaseHistoryRequest")]
            SandboxTestersClearPurchaseHistoryRequest = 1

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTestersClearPurchaseHistoryRequestV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SandboxTestersClearPurchaseHistoryRequestV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTestersClearPurchaseHistoryRequestV2" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="links">links (required).</param>
        public SandboxTestersClearPurchaseHistoryRequestV2(TypeEnum type = default(TypeEnum), string id = default(string), ResourceLinks links = default(ResourceLinks))
        {
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for SandboxTestersClearPurchaseHistoryRequestV2 and cannot be null");
            }
            this.Id = id;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for SandboxTestersClearPurchaseHistoryRequestV2 and cannot be null");
            }
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public ResourceLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SandboxTestersClearPurchaseHistoryRequestV2 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as SandboxTestersClearPurchaseHistoryRequestV2);
        }

        /// <summary>
        /// Returns true if SandboxTestersClearPurchaseHistoryRequestV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of SandboxTestersClearPurchaseHistoryRequestV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SandboxTestersClearPurchaseHistoryRequestV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
