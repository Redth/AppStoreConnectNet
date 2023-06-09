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
    /// AppEncryptionDeclarationAttributes
    /// </summary>
    [DataContract(Name = "AppEncryptionDeclaration_attributes")]
    public partial class AppEncryptionDeclarationAttributes : IEquatable<AppEncryptionDeclarationAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public Platform? Platform { get; set; }

        /// <summary>
        /// Gets or Sets AppEncryptionDeclarationState
        /// </summary>
        [DataMember(Name = "appEncryptionDeclarationState", EmitDefaultValue = false)]
        public AppEncryptionDeclarationState? AppEncryptionDeclarationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationAttributes" /> class.
        /// </summary>
        /// <param name="appDescription">appDescription.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="usesEncryption">usesEncryption.</param>
        /// <param name="exempt">exempt.</param>
        /// <param name="containsProprietaryCryptography">containsProprietaryCryptography.</param>
        /// <param name="containsThirdPartyCryptography">containsThirdPartyCryptography.</param>
        /// <param name="availableOnFrenchStore">availableOnFrenchStore.</param>
        /// <param name="platform">platform.</param>
        /// <param name="uploadedDate">uploadedDate.</param>
        /// <param name="documentUrl">documentUrl.</param>
        /// <param name="documentName">documentName.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="appEncryptionDeclarationState">appEncryptionDeclarationState.</param>
        /// <param name="codeValue">codeValue.</param>
        public AppEncryptionDeclarationAttributes(string appDescription = default(string), DateTimeOffset createdDate = default(DateTimeOffset), bool usesEncryption = default(bool), bool exempt = default(bool), bool containsProprietaryCryptography = default(bool), bool containsThirdPartyCryptography = default(bool), bool availableOnFrenchStore = default(bool), Platform? platform = default(Platform?), DateTimeOffset uploadedDate = default(DateTimeOffset), string documentUrl = default(string), string documentName = default(string), string documentType = default(string), AppEncryptionDeclarationState? appEncryptionDeclarationState = default(AppEncryptionDeclarationState?), string codeValue = default(string))
        {
            this.AppDescription = appDescription;
            this.CreatedDate = createdDate;
            this.UsesEncryption = usesEncryption;
            this.Exempt = exempt;
            this.ContainsProprietaryCryptography = containsProprietaryCryptography;
            this.ContainsThirdPartyCryptography = containsThirdPartyCryptography;
            this.AvailableOnFrenchStore = availableOnFrenchStore;
            this.Platform = platform;
            this.UploadedDate = uploadedDate;
            this.DocumentUrl = documentUrl;
            this.DocumentName = documentName;
            this.DocumentType = documentType;
            this.AppEncryptionDeclarationState = appEncryptionDeclarationState;
            this.CodeValue = codeValue;
        }

        /// <summary>
        /// Gets or Sets AppDescription
        /// </summary>
        [DataMember(Name = "appDescription", EmitDefaultValue = false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets UsesEncryption
        /// </summary>
        [DataMember(Name = "usesEncryption", EmitDefaultValue = true)]
        [Obsolete]
        public bool UsesEncryption { get; set; }

        /// <summary>
        /// Gets or Sets Exempt
        /// </summary>
        [DataMember(Name = "exempt", EmitDefaultValue = true)]
        public bool Exempt { get; set; }

        /// <summary>
        /// Gets or Sets ContainsProprietaryCryptography
        /// </summary>
        [DataMember(Name = "containsProprietaryCryptography", EmitDefaultValue = true)]
        public bool ContainsProprietaryCryptography { get; set; }

        /// <summary>
        /// Gets or Sets ContainsThirdPartyCryptography
        /// </summary>
        [DataMember(Name = "containsThirdPartyCryptography", EmitDefaultValue = true)]
        public bool ContainsThirdPartyCryptography { get; set; }

        /// <summary>
        /// Gets or Sets AvailableOnFrenchStore
        /// </summary>
        [DataMember(Name = "availableOnFrenchStore", EmitDefaultValue = true)]
        public bool AvailableOnFrenchStore { get; set; }

        /// <summary>
        /// Gets or Sets UploadedDate
        /// </summary>
        [DataMember(Name = "uploadedDate", EmitDefaultValue = false)]
        [Obsolete]
        public DateTimeOffset UploadedDate { get; set; }

        /// <summary>
        /// Gets or Sets DocumentUrl
        /// </summary>
        [DataMember(Name = "documentUrl", EmitDefaultValue = false)]
        [Obsolete]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// Gets or Sets DocumentName
        /// </summary>
        [DataMember(Name = "documentName", EmitDefaultValue = false)]
        [Obsolete]
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        [Obsolete]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets CodeValue
        /// </summary>
        [DataMember(Name = "codeValue", EmitDefaultValue = false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEncryptionDeclarationAttributes {\n");
            sb.Append("  AppDescription: ").Append(AppDescription).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UsesEncryption: ").Append(UsesEncryption).Append("\n");
            sb.Append("  Exempt: ").Append(Exempt).Append("\n");
            sb.Append("  ContainsProprietaryCryptography: ").Append(ContainsProprietaryCryptography).Append("\n");
            sb.Append("  ContainsThirdPartyCryptography: ").Append(ContainsThirdPartyCryptography).Append("\n");
            sb.Append("  AvailableOnFrenchStore: ").Append(AvailableOnFrenchStore).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  UploadedDate: ").Append(UploadedDate).Append("\n");
            sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  AppEncryptionDeclarationState: ").Append(AppEncryptionDeclarationState).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
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
            return this.Equals(input as AppEncryptionDeclarationAttributes);
        }

        /// <summary>
        /// Returns true if AppEncryptionDeclarationAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppEncryptionDeclarationAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEncryptionDeclarationAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppDescription == input.AppDescription ||
                    (this.AppDescription != null &&
                    this.AppDescription.Equals(input.AppDescription))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.UsesEncryption == input.UsesEncryption ||
                    this.UsesEncryption.Equals(input.UsesEncryption)
                ) && 
                (
                    this.Exempt == input.Exempt ||
                    this.Exempt.Equals(input.Exempt)
                ) && 
                (
                    this.ContainsProprietaryCryptography == input.ContainsProprietaryCryptography ||
                    this.ContainsProprietaryCryptography.Equals(input.ContainsProprietaryCryptography)
                ) && 
                (
                    this.ContainsThirdPartyCryptography == input.ContainsThirdPartyCryptography ||
                    this.ContainsThirdPartyCryptography.Equals(input.ContainsThirdPartyCryptography)
                ) && 
                (
                    this.AvailableOnFrenchStore == input.AvailableOnFrenchStore ||
                    this.AvailableOnFrenchStore.Equals(input.AvailableOnFrenchStore)
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.UploadedDate == input.UploadedDate ||
                    (this.UploadedDate != null &&
                    this.UploadedDate.Equals(input.UploadedDate))
                ) && 
                (
                    this.DocumentUrl == input.DocumentUrl ||
                    (this.DocumentUrl != null &&
                    this.DocumentUrl.Equals(input.DocumentUrl))
                ) && 
                (
                    this.DocumentName == input.DocumentName ||
                    (this.DocumentName != null &&
                    this.DocumentName.Equals(input.DocumentName))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.AppEncryptionDeclarationState == input.AppEncryptionDeclarationState ||
                    this.AppEncryptionDeclarationState.Equals(input.AppEncryptionDeclarationState)
                ) && 
                (
                    this.CodeValue == input.CodeValue ||
                    (this.CodeValue != null &&
                    this.CodeValue.Equals(input.CodeValue))
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
                if (this.AppDescription != null)
                {
                    hashCode = (hashCode * 59) + this.AppDescription.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UsesEncryption.GetHashCode();
                hashCode = (hashCode * 59) + this.Exempt.GetHashCode();
                hashCode = (hashCode * 59) + this.ContainsProprietaryCryptography.GetHashCode();
                hashCode = (hashCode * 59) + this.ContainsThirdPartyCryptography.GetHashCode();
                hashCode = (hashCode * 59) + this.AvailableOnFrenchStore.GetHashCode();
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.UploadedDate != null)
                {
                    hashCode = (hashCode * 59) + this.UploadedDate.GetHashCode();
                }
                if (this.DocumentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentUrl.GetHashCode();
                }
                if (this.DocumentName != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentName.GetHashCode();
                }
                if (this.DocumentType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AppEncryptionDeclarationState.GetHashCode();
                if (this.CodeValue != null)
                {
                    hashCode = (hashCode * 59) + this.CodeValue.GetHashCode();
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
