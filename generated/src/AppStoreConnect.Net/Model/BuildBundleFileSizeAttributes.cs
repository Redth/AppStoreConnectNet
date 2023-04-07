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
    /// BuildBundleFileSizeAttributes
    /// </summary>
    [DataContract(Name = "BuildBundleFileSize_attributes")]
    public partial class BuildBundleFileSizeAttributes : IEquatable<BuildBundleFileSizeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleFileSizeAttributes" /> class.
        /// </summary>
        /// <param name="deviceModel">deviceModel.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="downloadBytes">downloadBytes.</param>
        /// <param name="installBytes">installBytes.</param>
        public BuildBundleFileSizeAttributes(string deviceModel = default(string), string osVersion = default(string), int downloadBytes = default(int), int installBytes = default(int))
        {
            this.DeviceModel = deviceModel;
            this.OsVersion = osVersion;
            this.DownloadBytes = downloadBytes;
            this.InstallBytes = installBytes;
        }

        /// <summary>
        /// Gets or Sets DeviceModel
        /// </summary>
        [DataMember(Name = "deviceModel", EmitDefaultValue = false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets DownloadBytes
        /// </summary>
        [DataMember(Name = "downloadBytes", EmitDefaultValue = false)]
        public int DownloadBytes { get; set; }

        /// <summary>
        /// Gets or Sets InstallBytes
        /// </summary>
        [DataMember(Name = "installBytes", EmitDefaultValue = false)]
        public int InstallBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BuildBundleFileSizeAttributes {\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  DownloadBytes: ").Append(DownloadBytes).Append("\n");
            sb.Append("  InstallBytes: ").Append(InstallBytes).Append("\n");
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
            return this.Equals(input as BuildBundleFileSizeAttributes);
        }

        /// <summary>
        /// Returns true if BuildBundleFileSizeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildBundleFileSizeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildBundleFileSizeAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.DownloadBytes == input.DownloadBytes ||
                    this.DownloadBytes.Equals(input.DownloadBytes)
                ) && 
                (
                    this.InstallBytes == input.InstallBytes ||
                    this.InstallBytes.Equals(input.InstallBytes)
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
                if (this.DeviceModel != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceModel.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DownloadBytes.GetHashCode();
                hashCode = (hashCode * 59) + this.InstallBytes.GetHashCode();
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