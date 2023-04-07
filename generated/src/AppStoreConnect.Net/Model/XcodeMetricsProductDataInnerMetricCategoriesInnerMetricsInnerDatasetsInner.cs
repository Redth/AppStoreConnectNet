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
    /// XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner
    /// </summary>
    [DataContract(Name = "xcodeMetrics_productData_inner_metricCategories_inner_metrics_inner_datasets_inner")]
    public partial class XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner : IEquatable<XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner" /> class.
        /// </summary>
        /// <param name="filterCriteria">filterCriteria.</param>
        /// <param name="points">points.</param>
        public XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner(XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria filterCriteria = default(XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria), List<XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerPointsInner> points = default(List<XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerPointsInner>))
        {
            this.FilterCriteria = filterCriteria;
            this.Points = points;
        }

        /// <summary>
        /// Gets or Sets FilterCriteria
        /// </summary>
        [DataMember(Name = "filterCriteria", EmitDefaultValue = false)]
        public XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        public List<XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerPointsInner> Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner {\n");
            sb.Append("  FilterCriteria: ").Append(FilterCriteria).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner);
        }

        /// <summary>
        /// Returns true if XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FilterCriteria == input.FilterCriteria ||
                    (this.FilterCriteria != null &&
                    this.FilterCriteria.Equals(input.FilterCriteria))
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    input.Points != null &&
                    this.Points.SequenceEqual(input.Points)
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
                if (this.FilterCriteria != null)
                {
                    hashCode = (hashCode * 59) + this.FilterCriteria.GetHashCode();
                }
                if (this.Points != null)
                {
                    hashCode = (hashCode * 59) + this.Points.GetHashCode();
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