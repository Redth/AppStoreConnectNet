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
    /// AppCustomProductPageVersionInlineCreateRelationships
    /// </summary>
    [DataContract(Name = "AppCustomProductPageVersionInlineCreate_relationships")]
    public partial class AppCustomProductPageVersionInlineCreateRelationships : IEquatable<AppCustomProductPageVersionInlineCreateRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPage">appCustomProductPage.</param>
        /// <param name="appCustomProductPageLocalizations">appCustomProductPageLocalizations.</param>
        public AppCustomProductPageVersionInlineCreateRelationships(AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage appCustomProductPage = default(AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage), AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations appCustomProductPageLocalizations = default(AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations))
        {
            this.AppCustomProductPage = appCustomProductPage;
            this.AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
        }

        /// <summary>
        /// Gets or Sets AppCustomProductPage
        /// </summary>
        [DataMember(Name = "appCustomProductPage", EmitDefaultValue = false)]
        public AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage AppCustomProductPage { get; set; }

        /// <summary>
        /// Gets or Sets AppCustomProductPageLocalizations
        /// </summary>
        [DataMember(Name = "appCustomProductPageLocalizations", EmitDefaultValue = false)]
        public AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations AppCustomProductPageLocalizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCustomProductPageVersionInlineCreateRelationships {\n");
            sb.Append("  AppCustomProductPage: ").Append(AppCustomProductPage).Append("\n");
            sb.Append("  AppCustomProductPageLocalizations: ").Append(AppCustomProductPageLocalizations).Append("\n");
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
            return this.Equals(input as AppCustomProductPageVersionInlineCreateRelationships);
        }

        /// <summary>
        /// Returns true if AppCustomProductPageVersionInlineCreateRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCustomProductPageVersionInlineCreateRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCustomProductPageVersionInlineCreateRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppCustomProductPage == input.AppCustomProductPage ||
                    (this.AppCustomProductPage != null &&
                    this.AppCustomProductPage.Equals(input.AppCustomProductPage))
                ) && 
                (
                    this.AppCustomProductPageLocalizations == input.AppCustomProductPageLocalizations ||
                    (this.AppCustomProductPageLocalizations != null &&
                    this.AppCustomProductPageLocalizations.Equals(input.AppCustomProductPageLocalizations))
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
                if (this.AppCustomProductPage != null)
                {
                    hashCode = (hashCode * 59) + this.AppCustomProductPage.GetHashCode();
                }
                if (this.AppCustomProductPageLocalizations != null)
                {
                    hashCode = (hashCode * 59) + this.AppCustomProductPageLocalizations.GetHashCode();
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
