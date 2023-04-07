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
    /// CiXcodeVersionAttributesTestDestinationsInner
    /// </summary>
    [DataContract(Name = "CiXcodeVersion_attributes_testDestinations_inner")]
    public partial class CiXcodeVersionAttributesTestDestinationsInner : IEquatable<CiXcodeVersionAttributesTestDestinationsInner>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public CiTestDestinationKind? Kind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributesTestDestinationsInner" /> class.
        /// </summary>
        /// <param name="deviceTypeName">deviceTypeName.</param>
        /// <param name="deviceTypeIdentifier">deviceTypeIdentifier.</param>
        /// <param name="availableRuntimes">availableRuntimes.</param>
        /// <param name="kind">kind.</param>
        public CiXcodeVersionAttributesTestDestinationsInner(string deviceTypeName = default(string), string deviceTypeIdentifier = default(string), List<CiXcodeVersionAttributesTestDestinationsInnerAvailableRuntimesInner> availableRuntimes = default(List<CiXcodeVersionAttributesTestDestinationsInnerAvailableRuntimesInner>), CiTestDestinationKind? kind = default(CiTestDestinationKind?))
        {
            this.DeviceTypeName = deviceTypeName;
            this.DeviceTypeIdentifier = deviceTypeIdentifier;
            this.AvailableRuntimes = availableRuntimes;
            this.Kind = kind;
        }

        /// <summary>
        /// Gets or Sets DeviceTypeName
        /// </summary>
        [DataMember(Name = "deviceTypeName", EmitDefaultValue = false)]
        public string DeviceTypeName { get; set; }

        /// <summary>
        /// Gets or Sets DeviceTypeIdentifier
        /// </summary>
        [DataMember(Name = "deviceTypeIdentifier", EmitDefaultValue = false)]
        public string DeviceTypeIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AvailableRuntimes
        /// </summary>
        [DataMember(Name = "availableRuntimes", EmitDefaultValue = false)]
        public List<CiXcodeVersionAttributesTestDestinationsInnerAvailableRuntimesInner> AvailableRuntimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiXcodeVersionAttributesTestDestinationsInner {\n");
            sb.Append("  DeviceTypeName: ").Append(DeviceTypeName).Append("\n");
            sb.Append("  DeviceTypeIdentifier: ").Append(DeviceTypeIdentifier).Append("\n");
            sb.Append("  AvailableRuntimes: ").Append(AvailableRuntimes).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return this.Equals(input as CiXcodeVersionAttributesTestDestinationsInner);
        }

        /// <summary>
        /// Returns true if CiXcodeVersionAttributesTestDestinationsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CiXcodeVersionAttributesTestDestinationsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiXcodeVersionAttributesTestDestinationsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceTypeName == input.DeviceTypeName ||
                    (this.DeviceTypeName != null &&
                    this.DeviceTypeName.Equals(input.DeviceTypeName))
                ) && 
                (
                    this.DeviceTypeIdentifier == input.DeviceTypeIdentifier ||
                    (this.DeviceTypeIdentifier != null &&
                    this.DeviceTypeIdentifier.Equals(input.DeviceTypeIdentifier))
                ) && 
                (
                    this.AvailableRuntimes == input.AvailableRuntimes ||
                    this.AvailableRuntimes != null &&
                    input.AvailableRuntimes != null &&
                    this.AvailableRuntimes.SequenceEqual(input.AvailableRuntimes)
                ) && 
                (
                    this.Kind == input.Kind ||
                    this.Kind.Equals(input.Kind)
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
                if (this.DeviceTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceTypeName.GetHashCode();
                }
                if (this.DeviceTypeIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceTypeIdentifier.GetHashCode();
                }
                if (this.AvailableRuntimes != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableRuntimes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Kind.GetHashCode();
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
