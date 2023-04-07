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
    /// GameCenterEnabledVersionAttributes
    /// </summary>
    [DataContract(Name = "GameCenterEnabledVersion_attributes")]
    public partial class GameCenterEnabledVersionAttributes : IEquatable<GameCenterEnabledVersionAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public Platform? Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterEnabledVersionAttributes" /> class.
        /// </summary>
        /// <param name="platform">platform.</param>
        /// <param name="versionString">versionString.</param>
        /// <param name="iconAsset">iconAsset.</param>
        public GameCenterEnabledVersionAttributes(Platform? platform = default(Platform?), string versionString = default(string), ImageAsset iconAsset = default(ImageAsset))
        {
            this.Platform = platform;
            this.VersionString = versionString;
            this.IconAsset = iconAsset;
        }

        /// <summary>
        /// Gets or Sets VersionString
        /// </summary>
        [DataMember(Name = "versionString", EmitDefaultValue = false)]
        public string VersionString { get; set; }

        /// <summary>
        /// Gets or Sets IconAsset
        /// </summary>
        [DataMember(Name = "iconAsset", EmitDefaultValue = false)]
        public ImageAsset IconAsset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterEnabledVersionAttributes {\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  VersionString: ").Append(VersionString).Append("\n");
            sb.Append("  IconAsset: ").Append(IconAsset).Append("\n");
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
            return this.Equals(input as GameCenterEnabledVersionAttributes);
        }

        /// <summary>
        /// Returns true if GameCenterEnabledVersionAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of GameCenterEnabledVersionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameCenterEnabledVersionAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.VersionString == input.VersionString ||
                    (this.VersionString != null &&
                    this.VersionString.Equals(input.VersionString))
                ) && 
                (
                    this.IconAsset == input.IconAsset ||
                    (this.IconAsset != null &&
                    this.IconAsset.Equals(input.IconAsset))
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
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.VersionString != null)
                {
                    hashCode = (hashCode * 59) + this.VersionString.GetHashCode();
                }
                if (this.IconAsset != null)
                {
                    hashCode = (hashCode * 59) + this.IconAsset.GetHashCode();
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
