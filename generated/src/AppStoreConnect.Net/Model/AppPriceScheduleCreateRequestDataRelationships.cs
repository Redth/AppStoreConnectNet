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
    /// AppPriceScheduleCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppPriceScheduleCreateRequest_data_relationships")]
    public partial class AppPriceScheduleCreateRequestDataRelationships : IEquatable<AppPriceScheduleCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppPriceScheduleCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app">app (required).</param>
        /// <param name="baseTerritory">baseTerritory (required).</param>
        /// <param name="manualPrices">manualPrices (required).</param>
        public AppPriceScheduleCreateRequestDataRelationships(AppAvailabilityCreateRequestDataRelationshipsApp app = default(AppAvailabilityCreateRequestDataRelationshipsApp), AppPriceScheduleCreateRequestDataRelationshipsBaseTerritory baseTerritory = default(AppPriceScheduleCreateRequestDataRelationshipsBaseTerritory), AppPriceScheduleCreateRequestDataRelationshipsManualPrices manualPrices = default(AppPriceScheduleCreateRequestDataRelationshipsManualPrices))
        {
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for AppPriceScheduleCreateRequestDataRelationships and cannot be null");
            }
            this.App = app;
            // to ensure "baseTerritory" is required (not null)
            if (baseTerritory == null)
            {
                throw new ArgumentNullException("baseTerritory is a required property for AppPriceScheduleCreateRequestDataRelationships and cannot be null");
            }
            this.BaseTerritory = baseTerritory;
            // to ensure "manualPrices" is required (not null)
            if (manualPrices == null)
            {
                throw new ArgumentNullException("manualPrices is a required property for AppPriceScheduleCreateRequestDataRelationships and cannot be null");
            }
            this.ManualPrices = manualPrices;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets BaseTerritory
        /// </summary>
        [DataMember(Name = "baseTerritory", IsRequired = true, EmitDefaultValue = true)]
        public AppPriceScheduleCreateRequestDataRelationshipsBaseTerritory BaseTerritory { get; set; }

        /// <summary>
        /// Gets or Sets ManualPrices
        /// </summary>
        [DataMember(Name = "manualPrices", IsRequired = true, EmitDefaultValue = true)]
        public AppPriceScheduleCreateRequestDataRelationshipsManualPrices ManualPrices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPriceScheduleCreateRequestDataRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  BaseTerritory: ").Append(BaseTerritory).Append("\n");
            sb.Append("  ManualPrices: ").Append(ManualPrices).Append("\n");
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
            return this.Equals(input as AppPriceScheduleCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppPriceScheduleCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPriceScheduleCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPriceScheduleCreateRequestDataRelationships input)
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
                    this.BaseTerritory == input.BaseTerritory ||
                    (this.BaseTerritory != null &&
                    this.BaseTerritory.Equals(input.BaseTerritory))
                ) && 
                (
                    this.ManualPrices == input.ManualPrices ||
                    (this.ManualPrices != null &&
                    this.ManualPrices.Equals(input.ManualPrices))
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
                if (this.BaseTerritory != null)
                {
                    hashCode = (hashCode * 59) + this.BaseTerritory.GetHashCode();
                }
                if (this.ManualPrices != null)
                {
                    hashCode = (hashCode * 59) + this.ManualPrices.GetHashCode();
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
