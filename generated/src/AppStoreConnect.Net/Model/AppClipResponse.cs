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
    /// AppClipResponse
    /// </summary>
    [DataContract(Name = "AppClipResponse")]
    public partial class AppClipResponse : IEquatable<AppClipResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppClipResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipResponse" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="included">included.</param>
        /// <param name="links">links (required).</param>
        public AppClipResponse(AppClip data = default(AppClip), List<AppClipsResponseIncludedInner> included = default(List<AppClipsResponseIncludedInner>), DocumentLinks links = default(DocumentLinks))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AppClipResponse and cannot be null");
            }
            this.Data = data;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for AppClipResponse and cannot be null");
            }
            this.Links = links;
            this.Included = included;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public AppClip Data { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", EmitDefaultValue = false)]
        public List<AppClipsResponseIncludedInner> Included { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public DocumentLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as AppClipResponse);
        }

        /// <summary>
        /// Returns true if AppClipResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Included == input.Included ||
                    this.Included != null &&
                    input.Included != null &&
                    this.Included.SequenceEqual(input.Included)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Included != null)
                {
                    hashCode = (hashCode * 59) + this.Included.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
