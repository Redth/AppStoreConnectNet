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
    /// InAppPurchasePriceScheduleCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "InAppPurchasePriceScheduleCreateRequest_data_relationships")]
    public partial class InAppPurchasePriceScheduleCreateRequestDataRelationships : IEquatable<InAppPurchasePriceScheduleCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InAppPurchasePriceScheduleCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase">inAppPurchase (required).</param>
        /// <param name="baseTerritory">baseTerritory.</param>
        /// <param name="manualPrices">manualPrices (required).</param>
        public InAppPurchasePriceScheduleCreateRequestDataRelationships(InAppPurchaseAppStoreReviewScreenshotCreateRequestDataRelationshipsInAppPurchaseV2 inAppPurchase = default(InAppPurchaseAppStoreReviewScreenshotCreateRequestDataRelationshipsInAppPurchaseV2), InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory baseTerritory = default(InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory), InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices manualPrices = default(InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices))
        {
            // to ensure "inAppPurchase" is required (not null)
            if (inAppPurchase == null)
            {
                throw new ArgumentNullException("inAppPurchase is a required property for InAppPurchasePriceScheduleCreateRequestDataRelationships and cannot be null");
            }
            this.InAppPurchase = inAppPurchase;
            // to ensure "manualPrices" is required (not null)
            if (manualPrices == null)
            {
                throw new ArgumentNullException("manualPrices is a required property for InAppPurchasePriceScheduleCreateRequestDataRelationships and cannot be null");
            }
            this.ManualPrices = manualPrices;
            this.BaseTerritory = baseTerritory;
        }

        /// <summary>
        /// Gets or Sets InAppPurchase
        /// </summary>
        [DataMember(Name = "inAppPurchase", IsRequired = true, EmitDefaultValue = true)]
        public InAppPurchaseAppStoreReviewScreenshotCreateRequestDataRelationshipsInAppPurchaseV2 InAppPurchase { get; set; }

        /// <summary>
        /// Gets or Sets BaseTerritory
        /// </summary>
        [DataMember(Name = "baseTerritory", EmitDefaultValue = false)]
        public InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory BaseTerritory { get; set; }

        /// <summary>
        /// Gets or Sets ManualPrices
        /// </summary>
        [DataMember(Name = "manualPrices", IsRequired = true, EmitDefaultValue = true)]
        public InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices ManualPrices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InAppPurchasePriceScheduleCreateRequestDataRelationships {\n");
            sb.Append("  InAppPurchase: ").Append(InAppPurchase).Append("\n");
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
            return this.Equals(input as InAppPurchasePriceScheduleCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if InAppPurchasePriceScheduleCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of InAppPurchasePriceScheduleCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InAppPurchasePriceScheduleCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InAppPurchase == input.InAppPurchase ||
                    (this.InAppPurchase != null &&
                    this.InAppPurchase.Equals(input.InAppPurchase))
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
                if (this.InAppPurchase != null)
                {
                    hashCode = (hashCode * 59) + this.InAppPurchase.GetHashCode();
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
