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
    /// CiWorkflowUpdateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "CiWorkflowUpdateRequest_data_relationships")]
    public partial class CiWorkflowUpdateRequestDataRelationships : IEquatable<CiWorkflowUpdateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="xcodeVersion">xcodeVersion.</param>
        /// <param name="macOsVersion">macOsVersion.</param>
        public CiWorkflowUpdateRequestDataRelationships(CiWorkflowUpdateRequestDataRelationshipsXcodeVersion xcodeVersion = default(CiWorkflowUpdateRequestDataRelationshipsXcodeVersion), CiWorkflowUpdateRequestDataRelationshipsMacOsVersion macOsVersion = default(CiWorkflowUpdateRequestDataRelationshipsMacOsVersion))
        {
            this.XcodeVersion = xcodeVersion;
            this.MacOsVersion = macOsVersion;
        }

        /// <summary>
        /// Gets or Sets XcodeVersion
        /// </summary>
        [DataMember(Name = "xcodeVersion", EmitDefaultValue = false)]
        public CiWorkflowUpdateRequestDataRelationshipsXcodeVersion XcodeVersion { get; set; }

        /// <summary>
        /// Gets or Sets MacOsVersion
        /// </summary>
        [DataMember(Name = "macOsVersion", EmitDefaultValue = false)]
        public CiWorkflowUpdateRequestDataRelationshipsMacOsVersion MacOsVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiWorkflowUpdateRequestDataRelationships {\n");
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
            return this.Equals(input as CiWorkflowUpdateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if CiWorkflowUpdateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of CiWorkflowUpdateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiWorkflowUpdateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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