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
    /// ProfileAttributes
    /// </summary>
    [DataContract(Name = "Profile_attributes")]
    public partial class ProfileAttributes : IEquatable<ProfileAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public BundleIdPlatform? Platform { get; set; }
        /// <summary>
        /// Defines ProfileType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProfileTypeEnum
        {
            /// <summary>
            /// Enum IOSAPPDEVELOPMENT for value: IOS_APP_DEVELOPMENT
            /// </summary>
            [EnumMember(Value = "IOS_APP_DEVELOPMENT")]
            IOSAPPDEVELOPMENT = 1,

            /// <summary>
            /// Enum IOSAPPSTORE for value: IOS_APP_STORE
            /// </summary>
            [EnumMember(Value = "IOS_APP_STORE")]
            IOSAPPSTORE = 2,

            /// <summary>
            /// Enum IOSAPPADHOC for value: IOS_APP_ADHOC
            /// </summary>
            [EnumMember(Value = "IOS_APP_ADHOC")]
            IOSAPPADHOC = 3,

            /// <summary>
            /// Enum IOSAPPINHOUSE for value: IOS_APP_INHOUSE
            /// </summary>
            [EnumMember(Value = "IOS_APP_INHOUSE")]
            IOSAPPINHOUSE = 4,

            /// <summary>
            /// Enum MACAPPDEVELOPMENT for value: MAC_APP_DEVELOPMENT
            /// </summary>
            [EnumMember(Value = "MAC_APP_DEVELOPMENT")]
            MACAPPDEVELOPMENT = 5,

            /// <summary>
            /// Enum MACAPPSTORE for value: MAC_APP_STORE
            /// </summary>
            [EnumMember(Value = "MAC_APP_STORE")]
            MACAPPSTORE = 6,

            /// <summary>
            /// Enum MACAPPDIRECT for value: MAC_APP_DIRECT
            /// </summary>
            [EnumMember(Value = "MAC_APP_DIRECT")]
            MACAPPDIRECT = 7,

            /// <summary>
            /// Enum TVOSAPPDEVELOPMENT for value: TVOS_APP_DEVELOPMENT
            /// </summary>
            [EnumMember(Value = "TVOS_APP_DEVELOPMENT")]
            TVOSAPPDEVELOPMENT = 8,

            /// <summary>
            /// Enum TVOSAPPSTORE for value: TVOS_APP_STORE
            /// </summary>
            [EnumMember(Value = "TVOS_APP_STORE")]
            TVOSAPPSTORE = 9,

            /// <summary>
            /// Enum TVOSAPPADHOC for value: TVOS_APP_ADHOC
            /// </summary>
            [EnumMember(Value = "TVOS_APP_ADHOC")]
            TVOSAPPADHOC = 10,

            /// <summary>
            /// Enum TVOSAPPINHOUSE for value: TVOS_APP_INHOUSE
            /// </summary>
            [EnumMember(Value = "TVOS_APP_INHOUSE")]
            TVOSAPPINHOUSE = 11,

            /// <summary>
            /// Enum MACCATALYSTAPPDEVELOPMENT for value: MAC_CATALYST_APP_DEVELOPMENT
            /// </summary>
            [EnumMember(Value = "MAC_CATALYST_APP_DEVELOPMENT")]
            MACCATALYSTAPPDEVELOPMENT = 12,

            /// <summary>
            /// Enum MACCATALYSTAPPSTORE for value: MAC_CATALYST_APP_STORE
            /// </summary>
            [EnumMember(Value = "MAC_CATALYST_APP_STORE")]
            MACCATALYSTAPPSTORE = 13,

            /// <summary>
            /// Enum MACCATALYSTAPPDIRECT for value: MAC_CATALYST_APP_DIRECT
            /// </summary>
            [EnumMember(Value = "MAC_CATALYST_APP_DIRECT")]
            MACCATALYSTAPPDIRECT = 14

        }


        /// <summary>
        /// Gets or Sets ProfileType
        /// </summary>
        [DataMember(Name = "profileType", EmitDefaultValue = false)]
        public ProfileTypeEnum? ProfileType { get; set; }
        /// <summary>
        /// Defines ProfileState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProfileStateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum INVALID for value: INVALID
            /// </summary>
            [EnumMember(Value = "INVALID")]
            INVALID = 2

        }


        /// <summary>
        /// Gets or Sets ProfileState
        /// </summary>
        [DataMember(Name = "profileState", EmitDefaultValue = false)]
        public ProfileStateEnum? ProfileState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="platform">platform.</param>
        /// <param name="profileType">profileType.</param>
        /// <param name="profileState">profileState.</param>
        /// <param name="profileContent">profileContent.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="expirationDate">expirationDate.</param>
        public ProfileAttributes(string name = default(string), BundleIdPlatform? platform = default(BundleIdPlatform?), ProfileTypeEnum? profileType = default(ProfileTypeEnum?), ProfileStateEnum? profileState = default(ProfileStateEnum?), string profileContent = default(string), string uuid = default(string), DateTimeOffset createdDate = default(DateTimeOffset), DateTimeOffset expirationDate = default(DateTimeOffset))
        {
            this.Name = name;
            this.Platform = platform;
            this.ProfileType = profileType;
            this.ProfileState = profileState;
            this.ProfileContent = profileContent;
            this.Uuid = uuid;
            this.CreatedDate = createdDate;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProfileContent
        /// </summary>
        [DataMember(Name = "profileContent", EmitDefaultValue = false)]
        public string ProfileContent { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public DateTimeOffset ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfileAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ProfileType: ").Append(ProfileType).Append("\n");
            sb.Append("  ProfileState: ").Append(ProfileState).Append("\n");
            sb.Append("  ProfileContent: ").Append(ProfileContent).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as ProfileAttributes);
        }

        /// <summary>
        /// Returns true if ProfileAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileAttributes input)
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
                    this.ProfileType == input.ProfileType ||
                    this.ProfileType.Equals(input.ProfileType)
                ) && 
                (
                    this.ProfileState == input.ProfileState ||
                    this.ProfileState.Equals(input.ProfileState)
                ) && 
                (
                    this.ProfileContent == input.ProfileContent ||
                    (this.ProfileContent != null &&
                    this.ProfileContent.Equals(input.ProfileContent))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                hashCode = (hashCode * 59) + this.ProfileType.GetHashCode();
                hashCode = (hashCode * 59) + this.ProfileState.GetHashCode();
                if (this.ProfileContent != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileContent.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
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