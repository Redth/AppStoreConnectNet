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
    /// AppScreenshotAttributes
    /// </summary>
    [DataContract(Name = "AppScreenshot_attributes")]
    public partial class AppScreenshotAttributes : IEquatable<AppScreenshotAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotAttributes" /> class.
        /// </summary>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="sourceFileChecksum">sourceFileChecksum.</param>
        /// <param name="imageAsset">imageAsset.</param>
        /// <param name="assetToken">assetToken.</param>
        /// <param name="assetType">assetType.</param>
        /// <param name="uploadOperations">uploadOperations.</param>
        /// <param name="assetDeliveryState">assetDeliveryState.</param>
        public AppScreenshotAttributes(int fileSize = default(int), string fileName = default(string), string sourceFileChecksum = default(string), ImageAsset imageAsset = default(ImageAsset), string assetToken = default(string), string assetType = default(string), List<UploadOperation> uploadOperations = default(List<UploadOperation>), AppMediaAssetState assetDeliveryState = default(AppMediaAssetState))
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.SourceFileChecksum = sourceFileChecksum;
            this.ImageAsset = imageAsset;
            this.AssetToken = assetToken;
            this.AssetType = assetType;
            this.UploadOperations = uploadOperations;
            this.AssetDeliveryState = assetDeliveryState;
        }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets SourceFileChecksum
        /// </summary>
        [DataMember(Name = "sourceFileChecksum", EmitDefaultValue = false)]
        public string SourceFileChecksum { get; set; }

        /// <summary>
        /// Gets or Sets ImageAsset
        /// </summary>
        [DataMember(Name = "imageAsset", EmitDefaultValue = false)]
        public ImageAsset ImageAsset { get; set; }

        /// <summary>
        /// Gets or Sets AssetToken
        /// </summary>
        [DataMember(Name = "assetToken", EmitDefaultValue = false)]
        public string AssetToken { get; set; }

        /// <summary>
        /// Gets or Sets AssetType
        /// </summary>
        [DataMember(Name = "assetType", EmitDefaultValue = false)]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or Sets UploadOperations
        /// </summary>
        [DataMember(Name = "uploadOperations", EmitDefaultValue = false)]
        public List<UploadOperation> UploadOperations { get; set; }

        /// <summary>
        /// Gets or Sets AssetDeliveryState
        /// </summary>
        [DataMember(Name = "assetDeliveryState", EmitDefaultValue = false)]
        public AppMediaAssetState AssetDeliveryState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppScreenshotAttributes {\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  SourceFileChecksum: ").Append(SourceFileChecksum).Append("\n");
            sb.Append("  ImageAsset: ").Append(ImageAsset).Append("\n");
            sb.Append("  AssetToken: ").Append(AssetToken).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  UploadOperations: ").Append(UploadOperations).Append("\n");
            sb.Append("  AssetDeliveryState: ").Append(AssetDeliveryState).Append("\n");
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
            return this.Equals(input as AppScreenshotAttributes);
        }

        /// <summary>
        /// Returns true if AppScreenshotAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppScreenshotAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppScreenshotAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.SourceFileChecksum == input.SourceFileChecksum ||
                    (this.SourceFileChecksum != null &&
                    this.SourceFileChecksum.Equals(input.SourceFileChecksum))
                ) && 
                (
                    this.ImageAsset == input.ImageAsset ||
                    (this.ImageAsset != null &&
                    this.ImageAsset.Equals(input.ImageAsset))
                ) && 
                (
                    this.AssetToken == input.AssetToken ||
                    (this.AssetToken != null &&
                    this.AssetToken.Equals(input.AssetToken))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.UploadOperations == input.UploadOperations ||
                    this.UploadOperations != null &&
                    input.UploadOperations != null &&
                    this.UploadOperations.SequenceEqual(input.UploadOperations)
                ) && 
                (
                    this.AssetDeliveryState == input.AssetDeliveryState ||
                    (this.AssetDeliveryState != null &&
                    this.AssetDeliveryState.Equals(input.AssetDeliveryState))
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
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.SourceFileChecksum != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileChecksum.GetHashCode();
                }
                if (this.ImageAsset != null)
                {
                    hashCode = (hashCode * 59) + this.ImageAsset.GetHashCode();
                }
                if (this.AssetToken != null)
                {
                    hashCode = (hashCode * 59) + this.AssetToken.GetHashCode();
                }
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                }
                if (this.UploadOperations != null)
                {
                    hashCode = (hashCode * 59) + this.UploadOperations.GetHashCode();
                }
                if (this.AssetDeliveryState != null)
                {
                    hashCode = (hashCode * 59) + this.AssetDeliveryState.GetHashCode();
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
