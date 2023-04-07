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
    /// ScmProviderType
    /// </summary>
    [DataContract(Name = "ScmProviderType")]
    public partial class ScmProviderType : IEquatable<ScmProviderType>, IValidatableObject
    {
        /// <summary>
        /// Defines Kind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum BITBUCKETCLOUD for value: BITBUCKET_CLOUD
            /// </summary>
            [EnumMember(Value = "BITBUCKET_CLOUD")]
            BITBUCKETCLOUD = 1,

            /// <summary>
            /// Enum BITBUCKETSERVER for value: BITBUCKET_SERVER
            /// </summary>
            [EnumMember(Value = "BITBUCKET_SERVER")]
            BITBUCKETSERVER = 2,

            /// <summary>
            /// Enum GITHUBCLOUD for value: GITHUB_CLOUD
            /// </summary>
            [EnumMember(Value = "GITHUB_CLOUD")]
            GITHUBCLOUD = 3,

            /// <summary>
            /// Enum GITHUBENTERPRISE for value: GITHUB_ENTERPRISE
            /// </summary>
            [EnumMember(Value = "GITHUB_ENTERPRISE")]
            GITHUBENTERPRISE = 4,

            /// <summary>
            /// Enum GITLABCLOUD for value: GITLAB_CLOUD
            /// </summary>
            [EnumMember(Value = "GITLAB_CLOUD")]
            GITLABCLOUD = 5,

            /// <summary>
            /// Enum GITLABSELFMANAGED for value: GITLAB_SELF_MANAGED
            /// </summary>
            [EnumMember(Value = "GITLAB_SELF_MANAGED")]
            GITLABSELFMANAGED = 6

        }


        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public KindEnum? Kind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderType" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="isOnPremise">isOnPremise.</param>
        public ScmProviderType(KindEnum? kind = default(KindEnum?), string displayName = default(string), bool isOnPremise = default(bool))
        {
            this.Kind = kind;
            this.DisplayName = displayName;
            this.IsOnPremise = isOnPremise;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IsOnPremise
        /// </summary>
        [DataMember(Name = "isOnPremise", EmitDefaultValue = true)]
        public bool IsOnPremise { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScmProviderType {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsOnPremise: ").Append(IsOnPremise).Append("\n");
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
            return this.Equals(input as ScmProviderType);
        }

        /// <summary>
        /// Returns true if ScmProviderType instances are equal
        /// </summary>
        /// <param name="input">Instance of ScmProviderType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScmProviderType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Kind == input.Kind ||
                    this.Kind.Equals(input.Kind)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.IsOnPremise == input.IsOnPremise ||
                    this.IsOnPremise.Equals(input.IsOnPremise)
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
                hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsOnPremise.GetHashCode();
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