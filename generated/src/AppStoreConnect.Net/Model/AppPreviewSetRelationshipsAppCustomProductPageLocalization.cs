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
    /// AppPreviewSetRelationshipsAppCustomProductPageLocalization
    /// </summary>
    [DataContract(Name = "AppPreviewSet_relationships_appCustomProductPageLocalization")]
    public partial class AppPreviewSetRelationshipsAppCustomProductPageLocalization : IEquatable<AppPreviewSetRelationshipsAppCustomProductPageLocalization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetRelationshipsAppCustomProductPageLocalization" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="data">data.</param>
        public AppPreviewSetRelationshipsAppCustomProductPageLocalization(AppAvailabilityRelationshipsAppLinks links = default(AppAvailabilityRelationshipsAppLinks), AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataInner data = default(AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataInner))
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public AppAvailabilityRelationshipsAppLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataInner Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPreviewSetRelationshipsAppCustomProductPageLocalization {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as AppPreviewSetRelationshipsAppCustomProductPageLocalization);
        }

        /// <summary>
        /// Returns true if AppPreviewSetRelationshipsAppCustomProductPageLocalization instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPreviewSetRelationshipsAppCustomProductPageLocalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPreviewSetRelationshipsAppCustomProductPageLocalization input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
