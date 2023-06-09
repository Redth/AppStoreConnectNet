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
    /// DiagnosticLogs
    /// </summary>
    [DataContract(Name = "diagnosticLogs")]
    public partial class DiagnosticLogs : IEquatable<DiagnosticLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogs" /> class.
        /// </summary>
        /// <param name="productData">productData.</param>
        /// <param name="version">version.</param>
        public DiagnosticLogs(List<DiagnosticLogsProductDataInner> productData = default(List<DiagnosticLogsProductDataInner>), string version = default(string))
        {
            this.ProductData = productData;
            this._Version = version;
        }

        /// <summary>
        /// Gets or Sets ProductData
        /// </summary>
        [DataMember(Name = "productData", EmitDefaultValue = false)]
        public List<DiagnosticLogsProductDataInner> ProductData { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosticLogs {\n");
            sb.Append("  ProductData: ").Append(ProductData).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as DiagnosticLogs);
        }

        /// <summary>
        /// Returns true if DiagnosticLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagnosticLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticLogs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProductData == input.ProductData ||
                    this.ProductData != null &&
                    input.ProductData != null &&
                    this.ProductData.SequenceEqual(input.ProductData)
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.ProductData != null)
                {
                    hashCode = (hashCode * 59) + this.ProductData.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
