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
    /// BundleIdCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "BundleIdCreateRequest_data_attributes")]
    public partial class BundleIdCreateRequestDataAttributes : IEquatable<BundleIdCreateRequestDataAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public BundleIdPlatform Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BundleIdCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="seedId">seedId.</param>
        public BundleIdCreateRequestDataAttributes(string name = default(string), BundleIdPlatform platform = default(BundleIdPlatform), string identifier = default(string), string seedId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for BundleIdCreateRequestDataAttributes and cannot be null");
            }
            this.Name = name;
            this.Platform = platform;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for BundleIdCreateRequestDataAttributes and cannot be null");
            }
            this.Identifier = identifier;
            this.SeedId = seedId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets SeedId
        /// </summary>
        [DataMember(Name = "seedId", EmitDefaultValue = false)]
        public string SeedId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BundleIdCreateRequestDataAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  SeedId: ").Append(SeedId).Append("\n");
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
            return this.Equals(input as BundleIdCreateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if BundleIdCreateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of BundleIdCreateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BundleIdCreateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.SeedId == input.SeedId ||
                    (this.SeedId != null &&
                    this.SeedId.Equals(input.SeedId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.SeedId != null)
                {
                    hashCode = (hashCode * 59) + this.SeedId.GetHashCode();
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
