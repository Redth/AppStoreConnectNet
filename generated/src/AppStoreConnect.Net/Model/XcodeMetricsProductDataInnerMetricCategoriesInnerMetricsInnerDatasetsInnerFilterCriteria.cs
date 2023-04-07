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
    /// XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria
    /// </summary>
    [DataContract(Name = "xcodeMetrics_productData_inner_metricCategories_inner_metrics_inner_datasets_inner_filterCriteria")]
    public partial class XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria : IEquatable<XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria" /> class.
        /// </summary>
        /// <param name="percentile">percentile.</param>
        /// <param name="device">device.</param>
        /// <param name="deviceMarketingName">deviceMarketingName.</param>
        public XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria(string percentile = default(string), string device = default(string), string deviceMarketingName = default(string))
        {
            this.Percentile = percentile;
            this.Device = device;
            this.DeviceMarketingName = deviceMarketingName;
        }

        /// <summary>
        /// Gets or Sets Percentile
        /// </summary>
        [DataMember(Name = "percentile", EmitDefaultValue = false)]
        public string Percentile { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public string Device { get; set; }

        /// <summary>
        /// Gets or Sets DeviceMarketingName
        /// </summary>
        [DataMember(Name = "deviceMarketingName", EmitDefaultValue = false)]
        public string DeviceMarketingName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria {\n");
            sb.Append("  Percentile: ").Append(Percentile).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  DeviceMarketingName: ").Append(DeviceMarketingName).Append("\n");
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
            return this.Equals(input as XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria);
        }

        /// <summary>
        /// Returns true if XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XcodeMetricsProductDataInnerMetricCategoriesInnerMetricsInnerDatasetsInnerFilterCriteria input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Percentile == input.Percentile ||
                    (this.Percentile != null &&
                    this.Percentile.Equals(input.Percentile))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.DeviceMarketingName == input.DeviceMarketingName ||
                    (this.DeviceMarketingName != null &&
                    this.DeviceMarketingName.Equals(input.DeviceMarketingName))
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
                if (this.Percentile != null)
                {
                    hashCode = (hashCode * 59) + this.Percentile.GetHashCode();
                }
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
                }
                if (this.DeviceMarketingName != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceMarketingName.GetHashCode();
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
