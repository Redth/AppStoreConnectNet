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
    /// AppCategoryAttributes
    /// </summary>
    [DataContract(Name = "AppCategory_attributes")]
    public partial class AppCategoryAttributes : IEquatable<AppCategoryAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCategoryAttributes" /> class.
        /// </summary>
        /// <param name="platforms">platforms.</param>
        public AppCategoryAttributes(List<Platform> platforms = default(List<Platform>))
        {
            this.Platforms = platforms;
        }

        /// <summary>
        /// Gets or Sets Platforms
        /// </summary>
        [DataMember(Name = "platforms", EmitDefaultValue = false)]
        public List<Platform> Platforms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCategoryAttributes {\n");
            sb.Append("  Platforms: ").Append(Platforms).Append("\n");
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
            return this.Equals(input as AppCategoryAttributes);
        }

        /// <summary>
        /// Returns true if AppCategoryAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCategoryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCategoryAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Platforms == input.Platforms ||
                    this.Platforms != null &&
                    input.Platforms != null &&
                    this.Platforms.SequenceEqual(input.Platforms)
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
                if (this.Platforms != null)
                {
                    hashCode = (hashCode * 59) + this.Platforms.GetHashCode();
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
