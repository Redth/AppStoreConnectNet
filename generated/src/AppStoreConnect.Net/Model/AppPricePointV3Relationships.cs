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
    /// AppPricePointV3Relationships
    /// </summary>
    [DataContract(Name = "AppPricePointV3_relationships")]
    public partial class AppPricePointV3Relationships : IEquatable<AppPricePointV3Relationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPricePointV3Relationships" /> class.
        /// </summary>
        /// <param name="app">app.</param>
        /// <param name="territory">territory.</param>
        public AppPricePointV3Relationships(AppAvailabilityRelationshipsApp app = default(AppAvailabilityRelationshipsApp), AppPricePointV2RelationshipsTerritory territory = default(AppPricePointV2RelationshipsTerritory))
        {
            this.App = app;
            this.Territory = territory;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", EmitDefaultValue = false)]
        public AppAvailabilityRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets Territory
        /// </summary>
        [DataMember(Name = "territory", EmitDefaultValue = false)]
        public AppPricePointV2RelationshipsTerritory Territory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPricePointV3Relationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Territory: ").Append(Territory).Append("\n");
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
            return this.Equals(input as AppPricePointV3Relationships);
        }

        /// <summary>
        /// Returns true if AppPricePointV3Relationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPricePointV3Relationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPricePointV3Relationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Territory == input.Territory ||
                    (this.Territory != null &&
                    this.Territory.Equals(input.Territory))
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
                if (this.App != null)
                {
                    hashCode = (hashCode * 59) + this.App.GetHashCode();
                }
                if (this.Territory != null)
                {
                    hashCode = (hashCode * 59) + this.Territory.GetHashCode();
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