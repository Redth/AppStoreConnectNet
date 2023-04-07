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
    /// DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData
    /// </summary>
    [DataContract(Name = "diagnosticLogs_productData_inner_diagnosticLogs_inner_diagnosticMetaData")]
    public partial class DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData : IEquatable<DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData" /> class.
        /// </summary>
        /// <param name="bundleId">bundleId.</param>
        /// <param name="_event">_event.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="writesCaused">writesCaused.</param>
        /// <param name="deviceType">deviceType.</param>
        /// <param name="platformArchitecture">platformArchitecture.</param>
        /// <param name="eventDetail">eventDetail.</param>
        /// <param name="buildVersion">buildVersion.</param>
        public DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData(string bundleId = default(string), string _event = default(string), string osVersion = default(string), string appVersion = default(string), string writesCaused = default(string), string deviceType = default(string), string platformArchitecture = default(string), string eventDetail = default(string), string buildVersion = default(string))
        {
            this.BundleId = bundleId;
            this.Event = _event;
            this.OsVersion = osVersion;
            this.AppVersion = appVersion;
            this.WritesCaused = writesCaused;
            this.DeviceType = deviceType;
            this.PlatformArchitecture = platformArchitecture;
            this.EventDetail = eventDetail;
            this.BuildVersion = buildVersion;
        }

        /// <summary>
        /// Gets or Sets BundleId
        /// </summary>
        [DataMember(Name = "bundleId", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public string Event { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name = "appVersion", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets WritesCaused
        /// </summary>
        [DataMember(Name = "writesCaused", EmitDefaultValue = false)]
        public string WritesCaused { get; set; }

        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name = "deviceType", EmitDefaultValue = false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or Sets PlatformArchitecture
        /// </summary>
        [DataMember(Name = "platformArchitecture", EmitDefaultValue = false)]
        public string PlatformArchitecture { get; set; }

        /// <summary>
        /// Gets or Sets EventDetail
        /// </summary>
        [DataMember(Name = "eventDetail", EmitDefaultValue = false)]
        public string EventDetail { get; set; }

        /// <summary>
        /// Gets or Sets BuildVersion
        /// </summary>
        [DataMember(Name = "buildVersion", EmitDefaultValue = false)]
        public string BuildVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  WritesCaused: ").Append(WritesCaused).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  PlatformArchitecture: ").Append(PlatformArchitecture).Append("\n");
            sb.Append("  EventDetail: ").Append(EventDetail).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
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
            return this.Equals(input as DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData);
        }

        /// <summary>
        /// Returns true if DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticLogsProductDataInnerDiagnosticLogsInnerDiagnosticMetaData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.WritesCaused == input.WritesCaused ||
                    (this.WritesCaused != null &&
                    this.WritesCaused.Equals(input.WritesCaused))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.PlatformArchitecture == input.PlatformArchitecture ||
                    (this.PlatformArchitecture != null &&
                    this.PlatformArchitecture.Equals(input.PlatformArchitecture))
                ) && 
                (
                    this.EventDetail == input.EventDetail ||
                    (this.EventDetail != null &&
                    this.EventDetail.Equals(input.EventDetail))
                ) && 
                (
                    this.BuildVersion == input.BuildVersion ||
                    (this.BuildVersion != null &&
                    this.BuildVersion.Equals(input.BuildVersion))
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
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.Event != null)
                {
                    hashCode = (hashCode * 59) + this.Event.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.WritesCaused != null)
                {
                    hashCode = (hashCode * 59) + this.WritesCaused.GetHashCode();
                }
                if (this.DeviceType != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
                }
                if (this.PlatformArchitecture != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformArchitecture.GetHashCode();
                }
                if (this.EventDetail != null)
                {
                    hashCode = (hashCode * 59) + this.EventDetail.GetHashCode();
                }
                if (this.BuildVersion != null)
                {
                    hashCode = (hashCode * 59) + this.BuildVersion.GetHashCode();
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