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
    /// CiWorkflowCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "CiWorkflowCreateRequest_data_relationships")]
    public partial class CiWorkflowCreateRequestDataRelationships : IEquatable<CiWorkflowCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CiWorkflowCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="product">product (required).</param>
        /// <param name="repository">repository (required).</param>
        /// <param name="xcodeVersion">xcodeVersion (required).</param>
        /// <param name="macOsVersion">macOsVersion (required).</param>
        public CiWorkflowCreateRequestDataRelationships(CiWorkflowCreateRequestDataRelationshipsProduct product = default(CiWorkflowCreateRequestDataRelationshipsProduct), CiWorkflowCreateRequestDataRelationshipsRepository repository = default(CiWorkflowCreateRequestDataRelationshipsRepository), CiWorkflowCreateRequestDataRelationshipsXcodeVersion xcodeVersion = default(CiWorkflowCreateRequestDataRelationshipsXcodeVersion), CiWorkflowCreateRequestDataRelationshipsMacOsVersion macOsVersion = default(CiWorkflowCreateRequestDataRelationshipsMacOsVersion))
        {
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new ArgumentNullException("product is a required property for CiWorkflowCreateRequestDataRelationships and cannot be null");
            }
            this.Product = product;
            // to ensure "repository" is required (not null)
            if (repository == null)
            {
                throw new ArgumentNullException("repository is a required property for CiWorkflowCreateRequestDataRelationships and cannot be null");
            }
            this.Repository = repository;
            // to ensure "xcodeVersion" is required (not null)
            if (xcodeVersion == null)
            {
                throw new ArgumentNullException("xcodeVersion is a required property for CiWorkflowCreateRequestDataRelationships and cannot be null");
            }
            this.XcodeVersion = xcodeVersion;
            // to ensure "macOsVersion" is required (not null)
            if (macOsVersion == null)
            {
                throw new ArgumentNullException("macOsVersion is a required property for CiWorkflowCreateRequestDataRelationships and cannot be null");
            }
            this.MacOsVersion = macOsVersion;
        }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", IsRequired = true, EmitDefaultValue = true)]
        public CiWorkflowCreateRequestDataRelationshipsProduct Product { get; set; }

        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [DataMember(Name = "repository", IsRequired = true, EmitDefaultValue = true)]
        public CiWorkflowCreateRequestDataRelationshipsRepository Repository { get; set; }

        /// <summary>
        /// Gets or Sets XcodeVersion
        /// </summary>
        [DataMember(Name = "xcodeVersion", IsRequired = true, EmitDefaultValue = true)]
        public CiWorkflowCreateRequestDataRelationshipsXcodeVersion XcodeVersion { get; set; }

        /// <summary>
        /// Gets or Sets MacOsVersion
        /// </summary>
        [DataMember(Name = "macOsVersion", IsRequired = true, EmitDefaultValue = true)]
        public CiWorkflowCreateRequestDataRelationshipsMacOsVersion MacOsVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiWorkflowCreateRequestDataRelationships {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  XcodeVersion: ").Append(XcodeVersion).Append("\n");
            sb.Append("  MacOsVersion: ").Append(MacOsVersion).Append("\n");
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
            return this.Equals(input as CiWorkflowCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if CiWorkflowCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of CiWorkflowCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiWorkflowCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Repository == input.Repository ||
                    (this.Repository != null &&
                    this.Repository.Equals(input.Repository))
                ) && 
                (
                    this.XcodeVersion == input.XcodeVersion ||
                    (this.XcodeVersion != null &&
                    this.XcodeVersion.Equals(input.XcodeVersion))
                ) && 
                (
                    this.MacOsVersion == input.MacOsVersion ||
                    (this.MacOsVersion != null &&
                    this.MacOsVersion.Equals(input.MacOsVersion))
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
                if (this.Product != null)
                {
                    hashCode = (hashCode * 59) + this.Product.GetHashCode();
                }
                if (this.Repository != null)
                {
                    hashCode = (hashCode * 59) + this.Repository.GetHashCode();
                }
                if (this.XcodeVersion != null)
                {
                    hashCode = (hashCode * 59) + this.XcodeVersion.GetHashCode();
                }
                if (this.MacOsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.MacOsVersion.GetHashCode();
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
