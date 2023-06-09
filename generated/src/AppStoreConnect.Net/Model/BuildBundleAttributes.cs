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
    /// BuildBundleAttributes
    /// </summary>
    [DataContract(Name = "BuildBundle_attributes")]
    public partial class BuildBundleAttributes : IEquatable<BuildBundleAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines BundleType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BundleTypeEnum
        {
            /// <summary>
            /// Enum APP for value: APP
            /// </summary>
            [EnumMember(Value = "APP")]
            APP = 1,

            /// <summary>
            /// Enum APPCLIP for value: APP_CLIP
            /// </summary>
            [EnumMember(Value = "APP_CLIP")]
            APPCLIP = 2

        }


        /// <summary>
        /// Gets or Sets BundleType
        /// </summary>
        [DataMember(Name = "bundleType", EmitDefaultValue = false)]
        public BundleTypeEnum? BundleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleAttributes" /> class.
        /// </summary>
        /// <param name="bundleId">bundleId.</param>
        /// <param name="bundleType">bundleType.</param>
        /// <param name="sdkBuild">sdkBuild.</param>
        /// <param name="platformBuild">platformBuild.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="hasSirikit">hasSirikit.</param>
        /// <param name="hasOnDemandResources">hasOnDemandResources.</param>
        /// <param name="hasPrerenderedIcon">hasPrerenderedIcon.</param>
        /// <param name="usesLocationServices">usesLocationServices.</param>
        /// <param name="isIosBuildMacAppStoreCompatible">isIosBuildMacAppStoreCompatible.</param>
        /// <param name="includesSymbols">includesSymbols.</param>
        /// <param name="dSYMUrl">dSYMUrl.</param>
        /// <param name="supportedArchitectures">supportedArchitectures.</param>
        /// <param name="requiredCapabilities">requiredCapabilities.</param>
        /// <param name="deviceProtocols">deviceProtocols.</param>
        /// <param name="locales">locales.</param>
        /// <param name="entitlements">entitlements.</param>
        public BuildBundleAttributes(string bundleId = default(string), BundleTypeEnum? bundleType = default(BundleTypeEnum?), string sdkBuild = default(string), string platformBuild = default(string), string fileName = default(string), bool hasSirikit = default(bool), bool hasOnDemandResources = default(bool), bool hasPrerenderedIcon = default(bool), bool usesLocationServices = default(bool), bool isIosBuildMacAppStoreCompatible = default(bool), bool includesSymbols = default(bool), string dSYMUrl = default(string), List<string> supportedArchitectures = default(List<string>), List<string> requiredCapabilities = default(List<string>), List<string> deviceProtocols = default(List<string>), List<string> locales = default(List<string>), Dictionary<string, Dictionary<string, string>> entitlements = default(Dictionary<string, Dictionary<string, string>>))
        {
            this.BundleId = bundleId;
            this.BundleType = bundleType;
            this.SdkBuild = sdkBuild;
            this.PlatformBuild = platformBuild;
            this.FileName = fileName;
            this.HasSirikit = hasSirikit;
            this.HasOnDemandResources = hasOnDemandResources;
            this.HasPrerenderedIcon = hasPrerenderedIcon;
            this.UsesLocationServices = usesLocationServices;
            this.IsIosBuildMacAppStoreCompatible = isIosBuildMacAppStoreCompatible;
            this.IncludesSymbols = includesSymbols;
            this.DSYMUrl = dSYMUrl;
            this.SupportedArchitectures = supportedArchitectures;
            this.RequiredCapabilities = requiredCapabilities;
            this.DeviceProtocols = deviceProtocols;
            this.Locales = locales;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Gets or Sets BundleId
        /// </summary>
        [DataMember(Name = "bundleId", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// Gets or Sets SdkBuild
        /// </summary>
        [DataMember(Name = "sdkBuild", EmitDefaultValue = false)]
        public string SdkBuild { get; set; }

        /// <summary>
        /// Gets or Sets PlatformBuild
        /// </summary>
        [DataMember(Name = "platformBuild", EmitDefaultValue = false)]
        public string PlatformBuild { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets HasSirikit
        /// </summary>
        [DataMember(Name = "hasSirikit", EmitDefaultValue = true)]
        public bool HasSirikit { get; set; }

        /// <summary>
        /// Gets or Sets HasOnDemandResources
        /// </summary>
        [DataMember(Name = "hasOnDemandResources", EmitDefaultValue = true)]
        public bool HasOnDemandResources { get; set; }

        /// <summary>
        /// Gets or Sets HasPrerenderedIcon
        /// </summary>
        [DataMember(Name = "hasPrerenderedIcon", EmitDefaultValue = true)]
        public bool HasPrerenderedIcon { get; set; }

        /// <summary>
        /// Gets or Sets UsesLocationServices
        /// </summary>
        [DataMember(Name = "usesLocationServices", EmitDefaultValue = true)]
        public bool UsesLocationServices { get; set; }

        /// <summary>
        /// Gets or Sets IsIosBuildMacAppStoreCompatible
        /// </summary>
        [DataMember(Name = "isIosBuildMacAppStoreCompatible", EmitDefaultValue = true)]
        public bool IsIosBuildMacAppStoreCompatible { get; set; }

        /// <summary>
        /// Gets or Sets IncludesSymbols
        /// </summary>
        [DataMember(Name = "includesSymbols", EmitDefaultValue = true)]
        public bool IncludesSymbols { get; set; }

        /// <summary>
        /// Gets or Sets DSYMUrl
        /// </summary>
        [DataMember(Name = "dSYMUrl", EmitDefaultValue = false)]
        public string DSYMUrl { get; set; }

        /// <summary>
        /// Gets or Sets SupportedArchitectures
        /// </summary>
        [DataMember(Name = "supportedArchitectures", EmitDefaultValue = false)]
        public List<string> SupportedArchitectures { get; set; }

        /// <summary>
        /// Gets or Sets RequiredCapabilities
        /// </summary>
        [DataMember(Name = "requiredCapabilities", EmitDefaultValue = false)]
        public List<string> RequiredCapabilities { get; set; }

        /// <summary>
        /// Gets or Sets DeviceProtocols
        /// </summary>
        [DataMember(Name = "deviceProtocols", EmitDefaultValue = false)]
        public List<string> DeviceProtocols { get; set; }

        /// <summary>
        /// Gets or Sets Locales
        /// </summary>
        [DataMember(Name = "locales", EmitDefaultValue = false)]
        public List<string> Locales { get; set; }

        /// <summary>
        /// Gets or Sets Entitlements
        /// </summary>
        [DataMember(Name = "entitlements", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, string>> Entitlements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BuildBundleAttributes {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  BundleType: ").Append(BundleType).Append("\n");
            sb.Append("  SdkBuild: ").Append(SdkBuild).Append("\n");
            sb.Append("  PlatformBuild: ").Append(PlatformBuild).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  HasSirikit: ").Append(HasSirikit).Append("\n");
            sb.Append("  HasOnDemandResources: ").Append(HasOnDemandResources).Append("\n");
            sb.Append("  HasPrerenderedIcon: ").Append(HasPrerenderedIcon).Append("\n");
            sb.Append("  UsesLocationServices: ").Append(UsesLocationServices).Append("\n");
            sb.Append("  IsIosBuildMacAppStoreCompatible: ").Append(IsIosBuildMacAppStoreCompatible).Append("\n");
            sb.Append("  IncludesSymbols: ").Append(IncludesSymbols).Append("\n");
            sb.Append("  DSYMUrl: ").Append(DSYMUrl).Append("\n");
            sb.Append("  SupportedArchitectures: ").Append(SupportedArchitectures).Append("\n");
            sb.Append("  RequiredCapabilities: ").Append(RequiredCapabilities).Append("\n");
            sb.Append("  DeviceProtocols: ").Append(DeviceProtocols).Append("\n");
            sb.Append("  Locales: ").Append(Locales).Append("\n");
            sb.Append("  Entitlements: ").Append(Entitlements).Append("\n");
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
            return this.Equals(input as BuildBundleAttributes);
        }

        /// <summary>
        /// Returns true if BuildBundleAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildBundleAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildBundleAttributes input)
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
                    this.BundleType == input.BundleType ||
                    this.BundleType.Equals(input.BundleType)
                ) && 
                (
                    this.SdkBuild == input.SdkBuild ||
                    (this.SdkBuild != null &&
                    this.SdkBuild.Equals(input.SdkBuild))
                ) && 
                (
                    this.PlatformBuild == input.PlatformBuild ||
                    (this.PlatformBuild != null &&
                    this.PlatformBuild.Equals(input.PlatformBuild))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.HasSirikit == input.HasSirikit ||
                    this.HasSirikit.Equals(input.HasSirikit)
                ) && 
                (
                    this.HasOnDemandResources == input.HasOnDemandResources ||
                    this.HasOnDemandResources.Equals(input.HasOnDemandResources)
                ) && 
                (
                    this.HasPrerenderedIcon == input.HasPrerenderedIcon ||
                    this.HasPrerenderedIcon.Equals(input.HasPrerenderedIcon)
                ) && 
                (
                    this.UsesLocationServices == input.UsesLocationServices ||
                    this.UsesLocationServices.Equals(input.UsesLocationServices)
                ) && 
                (
                    this.IsIosBuildMacAppStoreCompatible == input.IsIosBuildMacAppStoreCompatible ||
                    this.IsIosBuildMacAppStoreCompatible.Equals(input.IsIosBuildMacAppStoreCompatible)
                ) && 
                (
                    this.IncludesSymbols == input.IncludesSymbols ||
                    this.IncludesSymbols.Equals(input.IncludesSymbols)
                ) && 
                (
                    this.DSYMUrl == input.DSYMUrl ||
                    (this.DSYMUrl != null &&
                    this.DSYMUrl.Equals(input.DSYMUrl))
                ) && 
                (
                    this.SupportedArchitectures == input.SupportedArchitectures ||
                    this.SupportedArchitectures != null &&
                    input.SupportedArchitectures != null &&
                    this.SupportedArchitectures.SequenceEqual(input.SupportedArchitectures)
                ) && 
                (
                    this.RequiredCapabilities == input.RequiredCapabilities ||
                    this.RequiredCapabilities != null &&
                    input.RequiredCapabilities != null &&
                    this.RequiredCapabilities.SequenceEqual(input.RequiredCapabilities)
                ) && 
                (
                    this.DeviceProtocols == input.DeviceProtocols ||
                    this.DeviceProtocols != null &&
                    input.DeviceProtocols != null &&
                    this.DeviceProtocols.SequenceEqual(input.DeviceProtocols)
                ) && 
                (
                    this.Locales == input.Locales ||
                    this.Locales != null &&
                    input.Locales != null &&
                    this.Locales.SequenceEqual(input.Locales)
                ) && 
                (
                    this.Entitlements == input.Entitlements ||
                    this.Entitlements != null &&
                    input.Entitlements != null &&
                    this.Entitlements.SequenceEqual(input.Entitlements)
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
                hashCode = (hashCode * 59) + this.BundleType.GetHashCode();
                if (this.SdkBuild != null)
                {
                    hashCode = (hashCode * 59) + this.SdkBuild.GetHashCode();
                }
                if (this.PlatformBuild != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformBuild.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasSirikit.GetHashCode();
                hashCode = (hashCode * 59) + this.HasOnDemandResources.GetHashCode();
                hashCode = (hashCode * 59) + this.HasPrerenderedIcon.GetHashCode();
                hashCode = (hashCode * 59) + this.UsesLocationServices.GetHashCode();
                hashCode = (hashCode * 59) + this.IsIosBuildMacAppStoreCompatible.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludesSymbols.GetHashCode();
                if (this.DSYMUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DSYMUrl.GetHashCode();
                }
                if (this.SupportedArchitectures != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedArchitectures.GetHashCode();
                }
                if (this.RequiredCapabilities != null)
                {
                    hashCode = (hashCode * 59) + this.RequiredCapabilities.GetHashCode();
                }
                if (this.DeviceProtocols != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceProtocols.GetHashCode();
                }
                if (this.Locales != null)
                {
                    hashCode = (hashCode * 59) + this.Locales.GetHashCode();
                }
                if (this.Entitlements != null)
                {
                    hashCode = (hashCode * 59) + this.Entitlements.GetHashCode();
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
