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
    /// AppPreviewUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppPreviewUpdateRequest_data_attributes")]
    public partial class AppPreviewUpdateRequestDataAttributes : IEquatable<AppPreviewUpdateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="sourceFileChecksum">sourceFileChecksum.</param>
        /// <param name="previewFrameTimeCode">previewFrameTimeCode.</param>
        /// <param name="uploaded">uploaded.</param>
        public AppPreviewUpdateRequestDataAttributes(string sourceFileChecksum = default(string), string previewFrameTimeCode = default(string), bool uploaded = default(bool))
        {
            this.SourceFileChecksum = sourceFileChecksum;
            this.PreviewFrameTimeCode = previewFrameTimeCode;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Gets or Sets SourceFileChecksum
        /// </summary>
        [DataMember(Name = "sourceFileChecksum", EmitDefaultValue = false)]
        public string SourceFileChecksum { get; set; }

        /// <summary>
        /// Gets or Sets PreviewFrameTimeCode
        /// </summary>
        [DataMember(Name = "previewFrameTimeCode", EmitDefaultValue = false)]
        public string PreviewFrameTimeCode { get; set; }

        /// <summary>
        /// Gets or Sets Uploaded
        /// </summary>
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public bool Uploaded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPreviewUpdateRequestDataAttributes {\n");
            sb.Append("  SourceFileChecksum: ").Append(SourceFileChecksum).Append("\n");
            sb.Append("  PreviewFrameTimeCode: ").Append(PreviewFrameTimeCode).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
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
            return this.Equals(input as AppPreviewUpdateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if AppPreviewUpdateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPreviewUpdateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPreviewUpdateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceFileChecksum == input.SourceFileChecksum ||
                    (this.SourceFileChecksum != null &&
                    this.SourceFileChecksum.Equals(input.SourceFileChecksum))
                ) && 
                (
                    this.PreviewFrameTimeCode == input.PreviewFrameTimeCode ||
                    (this.PreviewFrameTimeCode != null &&
                    this.PreviewFrameTimeCode.Equals(input.PreviewFrameTimeCode))
                ) && 
                (
                    this.Uploaded == input.Uploaded ||
                    this.Uploaded.Equals(input.Uploaded)
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
                if (this.SourceFileChecksum != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileChecksum.GetHashCode();
                }
                if (this.PreviewFrameTimeCode != null)
                {
                    hashCode = (hashCode * 59) + this.PreviewFrameTimeCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Uploaded.GetHashCode();
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
