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
    /// AppClipAppStoreReviewDetailAttributes
    /// </summary>
    [DataContract(Name = "AppClipAppStoreReviewDetail_attributes")]
    public partial class AppClipAppStoreReviewDetailAttributes : IEquatable<AppClipAppStoreReviewDetailAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailAttributes" /> class.
        /// </summary>
        /// <param name="invocationUrls">invocationUrls.</param>
        public AppClipAppStoreReviewDetailAttributes(List<string> invocationUrls = default(List<string>))
        {
            this.InvocationUrls = invocationUrls;
        }

        /// <summary>
        /// Gets or Sets InvocationUrls
        /// </summary>
        [DataMember(Name = "invocationUrls", EmitDefaultValue = false)]
        public List<string> InvocationUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAppStoreReviewDetailAttributes {\n");
            sb.Append("  InvocationUrls: ").Append(InvocationUrls).Append("\n");
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
            return this.Equals(input as AppClipAppStoreReviewDetailAttributes);
        }

        /// <summary>
        /// Returns true if AppClipAppStoreReviewDetailAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipAppStoreReviewDetailAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipAppStoreReviewDetailAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvocationUrls == input.InvocationUrls ||
                    this.InvocationUrls != null &&
                    input.InvocationUrls != null &&
                    this.InvocationUrls.SequenceEqual(input.InvocationUrls)
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
                if (this.InvocationUrls != null)
                {
                    hashCode = (hashCode * 59) + this.InvocationUrls.GetHashCode();
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
