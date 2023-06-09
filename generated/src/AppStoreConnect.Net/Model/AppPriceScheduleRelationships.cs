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
    /// AppPriceScheduleRelationships
    /// </summary>
    [DataContract(Name = "AppPriceSchedule_relationships")]
    public partial class AppPriceScheduleRelationships : IEquatable<AppPriceScheduleRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPriceScheduleRelationships" /> class.
        /// </summary>
        /// <param name="app">app.</param>
        /// <param name="baseTerritory">baseTerritory.</param>
        /// <param name="manualPrices">manualPrices.</param>
        /// <param name="automaticPrices">automaticPrices.</param>
        public AppPriceScheduleRelationships(AppAvailabilityRelationshipsApp app = default(AppAvailabilityRelationshipsApp), AppPricePointV2RelationshipsTerritory baseTerritory = default(AppPricePointV2RelationshipsTerritory), AppPriceScheduleRelationshipsManualPrices manualPrices = default(AppPriceScheduleRelationshipsManualPrices), AppPriceScheduleRelationshipsManualPrices automaticPrices = default(AppPriceScheduleRelationshipsManualPrices))
        {
            this.App = app;
            this.BaseTerritory = baseTerritory;
            this.ManualPrices = manualPrices;
            this.AutomaticPrices = automaticPrices;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", EmitDefaultValue = false)]
        public AppAvailabilityRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets BaseTerritory
        /// </summary>
        [DataMember(Name = "baseTerritory", EmitDefaultValue = false)]
        public AppPricePointV2RelationshipsTerritory BaseTerritory { get; set; }

        /// <summary>
        /// Gets or Sets ManualPrices
        /// </summary>
        [DataMember(Name = "manualPrices", EmitDefaultValue = false)]
        public AppPriceScheduleRelationshipsManualPrices ManualPrices { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticPrices
        /// </summary>
        [DataMember(Name = "automaticPrices", EmitDefaultValue = false)]
        public AppPriceScheduleRelationshipsManualPrices AutomaticPrices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPriceScheduleRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  BaseTerritory: ").Append(BaseTerritory).Append("\n");
            sb.Append("  ManualPrices: ").Append(ManualPrices).Append("\n");
            sb.Append("  AutomaticPrices: ").Append(AutomaticPrices).Append("\n");
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
            return this.Equals(input as AppPriceScheduleRelationships);
        }

        /// <summary>
        /// Returns true if AppPriceScheduleRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppPriceScheduleRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppPriceScheduleRelationships input)
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
                ) && 
                (
                    this.AutomaticPrices == input.AutomaticPrices ||
                    (this.AutomaticPrices != null &&
                    this.AutomaticPrices.Equals(input.AutomaticPrices))
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
                if (this.AutomaticPrices != null)
                {
                    hashCode = (hashCode * 59) + this.AutomaticPrices.GetHashCode();
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
