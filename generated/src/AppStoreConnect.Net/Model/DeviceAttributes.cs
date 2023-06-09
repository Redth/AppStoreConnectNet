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
    /// DeviceAttributes
    /// </summary>
    [DataContract(Name = "Device_attributes")]
    public partial class DeviceAttributes : IEquatable<DeviceAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public BundleIdPlatform? Platform { get; set; }
        /// <summary>
        /// Defines DeviceClass
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceClassEnum
        {
            /// <summary>
            /// Enum APPLEWATCH for value: APPLE_WATCH
            /// </summary>
            [EnumMember(Value = "APPLE_WATCH")]
            APPLEWATCH = 1,

            /// <summary>
            /// Enum IPAD for value: IPAD
            /// </summary>
            [EnumMember(Value = "IPAD")]
            IPAD = 2,

            /// <summary>
            /// Enum IPHONE for value: IPHONE
            /// </summary>
            [EnumMember(Value = "IPHONE")]
            IPHONE = 3,

            /// <summary>
            /// Enum IPOD for value: IPOD
            /// </summary>
            [EnumMember(Value = "IPOD")]
            IPOD = 4,

            /// <summary>
            /// Enum APPLETV for value: APPLE_TV
            /// </summary>
            [EnumMember(Value = "APPLE_TV")]
            APPLETV = 5,

            /// <summary>
            /// Enum MAC for value: MAC
            /// </summary>
            [EnumMember(Value = "MAC")]
            MAC = 6

        }


        /// <summary>
        /// Gets or Sets DeviceClass
        /// </summary>
        [DataMember(Name = "deviceClass", EmitDefaultValue = false)]
        public DeviceClassEnum? DeviceClass { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED = 1,

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 2

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="platform">platform.</param>
        /// <param name="udid">udid.</param>
        /// <param name="deviceClass">deviceClass.</param>
        /// <param name="status">status.</param>
        /// <param name="model">model.</param>
        /// <param name="addedDate">addedDate.</param>
        public DeviceAttributes(string name = default(string), BundleIdPlatform? platform = default(BundleIdPlatform?), string udid = default(string), DeviceClassEnum? deviceClass = default(DeviceClassEnum?), StatusEnum? status = default(StatusEnum?), string model = default(string), DateTimeOffset addedDate = default(DateTimeOffset))
        {
            this.Name = name;
            this.Platform = platform;
            this.Udid = udid;
            this.DeviceClass = deviceClass;
            this.Status = status;
            this.Model = model;
            this.AddedDate = addedDate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Udid
        /// </summary>
        [DataMember(Name = "udid", EmitDefaultValue = false)]
        public string Udid { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets AddedDate
        /// </summary>
        [DataMember(Name = "addedDate", EmitDefaultValue = false)]
        public DateTimeOffset AddedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Udid: ").Append(Udid).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  AddedDate: ").Append(AddedDate).Append("\n");
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
            return this.Equals(input as DeviceAttributes);
        }

        /// <summary>
        /// Returns true if DeviceAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.Udid == input.Udid ||
                    (this.Udid != null &&
                    this.Udid.Equals(input.Udid))
                ) && 
                (
                    this.DeviceClass == input.DeviceClass ||
                    this.DeviceClass.Equals(input.DeviceClass)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.AddedDate == input.AddedDate ||
                    (this.AddedDate != null &&
                    this.AddedDate.Equals(input.AddedDate))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.Udid != null)
                {
                    hashCode = (hashCode * 59) + this.Udid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeviceClass.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.AddedDate != null)
                {
                    hashCode = (hashCode * 59) + this.AddedDate.GetHashCode();
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
