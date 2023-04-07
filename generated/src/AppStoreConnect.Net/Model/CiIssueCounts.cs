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
    /// CiIssueCounts
    /// </summary>
    [DataContract(Name = "CiIssueCounts")]
    public partial class CiIssueCounts : IEquatable<CiIssueCounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiIssueCounts" /> class.
        /// </summary>
        /// <param name="analyzerWarnings">analyzerWarnings.</param>
        /// <param name="errors">errors.</param>
        /// <param name="testFailures">testFailures.</param>
        /// <param name="warnings">warnings.</param>
        public CiIssueCounts(int analyzerWarnings = default(int), int errors = default(int), int testFailures = default(int), int warnings = default(int))
        {
            this.AnalyzerWarnings = analyzerWarnings;
            this.Errors = errors;
            this.TestFailures = testFailures;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets AnalyzerWarnings
        /// </summary>
        [DataMember(Name = "analyzerWarnings", EmitDefaultValue = false)]
        public int AnalyzerWarnings { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public int Errors { get; set; }

        /// <summary>
        /// Gets or Sets TestFailures
        /// </summary>
        [DataMember(Name = "testFailures", EmitDefaultValue = false)]
        public int TestFailures { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public int Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiIssueCounts {\n");
            sb.Append("  AnalyzerWarnings: ").Append(AnalyzerWarnings).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  TestFailures: ").Append(TestFailures).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as CiIssueCounts);
        }

        /// <summary>
        /// Returns true if CiIssueCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of CiIssueCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiIssueCounts input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnalyzerWarnings == input.AnalyzerWarnings ||
                    this.AnalyzerWarnings.Equals(input.AnalyzerWarnings)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors.Equals(input.Errors)
                ) && 
                (
                    this.TestFailures == input.TestFailures ||
                    this.TestFailures.Equals(input.TestFailures)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings.Equals(input.Warnings)
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
                hashCode = (hashCode * 59) + this.AnalyzerWarnings.GetHashCode();
                hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                hashCode = (hashCode * 59) + this.TestFailures.GetHashCode();
                hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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