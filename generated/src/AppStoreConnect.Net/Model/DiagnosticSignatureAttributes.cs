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
    /// DiagnosticSignatureAttributes
    /// </summary>
    [DataContract(Name = "DiagnosticSignature_attributes")]
    public partial class DiagnosticSignatureAttributes : IEquatable<DiagnosticSignatureAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines DiagnosticType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiagnosticTypeEnum
        {
            /// <summary>
            /// Enum DISKWRITES for value: DISK_WRITES
            /// </summary>
            [EnumMember(Value = "DISK_WRITES")]
            DISKWRITES = 1,

            /// <summary>
            /// Enum HANGS for value: HANGS
            /// </summary>
            [EnumMember(Value = "HANGS")]
            HANGS = 2

        }


        /// <summary>
        /// Gets or Sets DiagnosticType
        /// </summary>
        [DataMember(Name = "diagnosticType", EmitDefaultValue = false)]
        public DiagnosticTypeEnum? DiagnosticType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticSignatureAttributes" /> class.
        /// </summary>
        /// <param name="diagnosticType">diagnosticType.</param>
        /// <param name="signature">signature.</param>
        /// <param name="weight">weight.</param>
        public DiagnosticSignatureAttributes(DiagnosticTypeEnum? diagnosticType = default(DiagnosticTypeEnum?), string signature = default(string), decimal weight = default(decimal))
        {
            this.DiagnosticType = diagnosticType;
            this.Signature = signature;
            this.Weight = weight;
        }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosticSignatureAttributes {\n");
            sb.Append("  DiagnosticType: ").Append(DiagnosticType).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as DiagnosticSignatureAttributes);
        }

        /// <summary>
        /// Returns true if DiagnosticSignatureAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagnosticSignatureAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticSignatureAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiagnosticType == input.DiagnosticType ||
                    this.DiagnosticType.Equals(input.DiagnosticType)
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
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
                hashCode = (hashCode * 59) + this.DiagnosticType.GetHashCode();
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
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
