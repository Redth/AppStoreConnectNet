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
    /// CertificateAttributes
    /// </summary>
    [DataContract(Name = "Certificate_attributes")]
    public partial class CertificateAttributes : IEquatable<CertificateAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CertificateType
        /// </summary>
        [DataMember(Name = "certificateType", EmitDefaultValue = false)]
        public CertificateType? CertificateType { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public BundleIdPlatform? Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="certificateType">certificateType.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="platform">platform.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="certificateContent">certificateContent.</param>
        public CertificateAttributes(string name = default(string), CertificateType? certificateType = default(CertificateType?), string displayName = default(string), string serialNumber = default(string), BundleIdPlatform? platform = default(BundleIdPlatform?), DateTimeOffset expirationDate = default(DateTimeOffset), string certificateContent = default(string))
        {
            this.Name = name;
            this.CertificateType = certificateType;
            this.DisplayName = displayName;
            this.SerialNumber = serialNumber;
            this.Platform = platform;
            this.ExpirationDate = expirationDate;
            this.CertificateContent = certificateContent;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public DateTimeOffset ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets CertificateContent
        /// </summary>
        [DataMember(Name = "certificateContent", EmitDefaultValue = false)]
        public string CertificateContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificateAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CertificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  CertificateContent: ").Append(CertificateContent).Append("\n");
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
            return this.Equals(input as CertificateAttributes);
        }

        /// <summary>
        /// Returns true if CertificateAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateAttributes input)
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
                    this.CertificateType == input.CertificateType ||
                    this.CertificateType.Equals(input.CertificateType)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.CertificateContent == input.CertificateContent ||
                    (this.CertificateContent != null &&
                    this.CertificateContent.Equals(input.CertificateContent))
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
                hashCode = (hashCode * 59) + this.CertificateType.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                }
                if (this.CertificateContent != null)
                {
                    hashCode = (hashCode * 59) + this.CertificateContent.GetHashCode();
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