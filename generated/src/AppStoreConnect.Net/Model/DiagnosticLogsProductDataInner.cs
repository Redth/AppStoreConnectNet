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
    /// DiagnosticLogsProductDataInner
    /// </summary>
    [DataContract(Name = "diagnosticLogs_productData_inner")]
    public partial class DiagnosticLogsProductDataInner : IEquatable<DiagnosticLogsProductDataInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataInner" /> class.
        /// </summary>
        /// <param name="signatureId">signatureId.</param>
        /// <param name="diagnosticInsights">diagnosticInsights.</param>
        /// <param name="diagnosticLogs">diagnosticLogs.</param>
        public DiagnosticLogsProductDataInner(string signatureId = default(string), List<DiagnosticLogsProductDataInnerDiagnosticInsightsInner> diagnosticInsights = default(List<DiagnosticLogsProductDataInnerDiagnosticInsightsInner>), List<DiagnosticLogsProductDataInnerDiagnosticLogsInner> diagnosticLogs = default(List<DiagnosticLogsProductDataInnerDiagnosticLogsInner>))
        {
            this.SignatureId = signatureId;
            this.DiagnosticInsights = diagnosticInsights;
            this.DiagnosticLogs = diagnosticLogs;
        }

        /// <summary>
        /// Gets or Sets SignatureId
        /// </summary>
        [DataMember(Name = "signatureId", EmitDefaultValue = false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticInsights
        /// </summary>
        [DataMember(Name = "diagnosticInsights", EmitDefaultValue = false)]
        public List<DiagnosticLogsProductDataInnerDiagnosticInsightsInner> DiagnosticInsights { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticLogs
        /// </summary>
        [DataMember(Name = "diagnosticLogs", EmitDefaultValue = false)]
        public List<DiagnosticLogsProductDataInnerDiagnosticLogsInner> DiagnosticLogs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosticLogsProductDataInner {\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  DiagnosticInsights: ").Append(DiagnosticInsights).Append("\n");
            sb.Append("  DiagnosticLogs: ").Append(DiagnosticLogs).Append("\n");
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
            return this.Equals(input as DiagnosticLogsProductDataInner);
        }

        /// <summary>
        /// Returns true if DiagnosticLogsProductDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagnosticLogsProductDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticLogsProductDataInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
                ) && 
                (
                    this.DiagnosticInsights == input.DiagnosticInsights ||
                    this.DiagnosticInsights != null &&
                    input.DiagnosticInsights != null &&
                    this.DiagnosticInsights.SequenceEqual(input.DiagnosticInsights)
                ) && 
                (
                    this.DiagnosticLogs == input.DiagnosticLogs ||
                    this.DiagnosticLogs != null &&
                    input.DiagnosticLogs != null &&
                    this.DiagnosticLogs.SequenceEqual(input.DiagnosticLogs)
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
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                if (this.DiagnosticInsights != null)
                {
                    hashCode = (hashCode * 59) + this.DiagnosticInsights.GetHashCode();
                }
                if (this.DiagnosticLogs != null)
                {
                    hashCode = (hashCode * 59) + this.DiagnosticLogs.GetHashCode();
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
