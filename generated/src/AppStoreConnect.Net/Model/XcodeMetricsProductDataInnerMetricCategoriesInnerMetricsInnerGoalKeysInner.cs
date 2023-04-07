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
    /// XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner
    /// </summary>
    [DataContract(Name = "xcodeMetrics_productData_inner_metricCategories_inner_metrics_inner_goalKeys_inner")]
    public partial class XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner : IEquatable<XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner" /> class.
        /// </summary>
        /// <param name="goalKey">goalKey.</param>
        /// <param name="lowerBound">lowerBound.</param>
        /// <param name="upperBound">upperBound.</param>
        public XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner(string goalKey = default(string), int lowerBound = default(int), int upperBound = default(int))
        {
            this.GoalKey = goalKey;
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
        }

        /// <summary>
        /// Gets or Sets GoalKey
        /// </summary>
        [DataMember(Name = "goalKey", EmitDefaultValue = false)]
        public string GoalKey { get; set; }

        /// <summary>
        /// Gets or Sets LowerBound
        /// </summary>
        [DataMember(Name = "lowerBound", EmitDefaultValue = false)]
        public int LowerBound { get; set; }

        /// <summary>
        /// Gets or Sets UpperBound
        /// </summary>
        [DataMember(Name = "upperBound", EmitDefaultValue = false)]
        public int UpperBound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner {\n");
            sb.Append("  GoalKey: ").Append(GoalKey).Append("\n");
            sb.Append("  LowerBound: ").Append(LowerBound).Append("\n");
            sb.Append("  UpperBound: ").Append(UpperBound).Append("\n");
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
            return this.Equals(input as XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner);
        }

        /// <summary>
        /// Returns true if XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner instances are equal
        /// </summary>
        /// <param name="input">Instance of XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerGoalKeysInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoalKey == input.GoalKey ||
                    (this.GoalKey != null &&
                    this.GoalKey.Equals(input.GoalKey))
                ) && 
                (
                    this.LowerBound == input.LowerBound ||
                    this.LowerBound.Equals(input.LowerBound)
                ) && 
                (
                    this.UpperBound == input.UpperBound ||
                    this.UpperBound.Equals(input.UpperBound)
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
                if (this.GoalKey != null)
                {
                    hashCode = (hashCode * 59) + this.GoalKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LowerBound.GetHashCode();
                hashCode = (hashCode * 59) + this.UpperBound.GetHashCode();
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
