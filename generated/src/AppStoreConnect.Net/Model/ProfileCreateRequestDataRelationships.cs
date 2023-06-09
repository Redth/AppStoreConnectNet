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
    /// ProfileCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "ProfileCreateRequest_data_relationships")]
    public partial class ProfileCreateRequestDataRelationships : IEquatable<ProfileCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfileCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="bundleId">bundleId (required).</param>
        /// <param name="devices">devices.</param>
        /// <param name="certificates">certificates (required).</param>
        public ProfileCreateRequestDataRelationships(BundleIdCapabilityCreateRequestDataRelationshipsBundleId bundleId = default(BundleIdCapabilityCreateRequestDataRelationshipsBundleId), ProfileCreateRequestDataRelationshipsDevices devices = default(ProfileCreateRequestDataRelationshipsDevices), ProfileCreateRequestDataRelationshipsCertificates certificates = default(ProfileCreateRequestDataRelationshipsCertificates))
        {
            // to ensure "bundleId" is required (not null)
            if (bundleId == null)
            {
                throw new ArgumentNullException("bundleId is a required property for ProfileCreateRequestDataRelationships and cannot be null");
            }
            this.BundleId = bundleId;
            // to ensure "certificates" is required (not null)
            if (certificates == null)
            {
                throw new ArgumentNullException("certificates is a required property for ProfileCreateRequestDataRelationships and cannot be null");
            }
            this.Certificates = certificates;
            this.Devices = devices;
        }

        /// <summary>
        /// Gets or Sets BundleId
        /// </summary>
        [DataMember(Name = "bundleId", IsRequired = true, EmitDefaultValue = true)]
        public BundleIdCapabilityCreateRequestDataRelationshipsBundleId BundleId { get; set; }

        /// <summary>
        /// Gets or Sets Devices
        /// </summary>
        [DataMember(Name = "devices", EmitDefaultValue = false)]
        public ProfileCreateRequestDataRelationshipsDevices Devices { get; set; }

        /// <summary>
        /// Gets or Sets Certificates
        /// </summary>
        [DataMember(Name = "certificates", IsRequired = true, EmitDefaultValue = true)]
        public ProfileCreateRequestDataRelationshipsCertificates Certificates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfileCreateRequestDataRelationships {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
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
            return this.Equals(input as ProfileCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if ProfileCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.Devices == input.Devices ||
                    (this.Devices != null &&
                    this.Devices.Equals(input.Devices))
                ) && 
                (
                    this.Certificates == input.Certificates ||
                    (this.Certificates != null &&
                    this.Certificates.Equals(input.Certificates))
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
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.Devices != null)
                {
                    hashCode = (hashCode * 59) + this.Devices.GetHashCode();
                }
                if (this.Certificates != null)
                {
                    hashCode = (hashCode * 59) + this.Certificates.GetHashCode();
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
