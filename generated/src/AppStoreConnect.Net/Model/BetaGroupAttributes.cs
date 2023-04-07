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
    /// BetaGroupAttributes
    /// </summary>
    [DataContract(Name = "BetaGroup_attributes")]
    public partial class BetaGroupAttributes : IEquatable<BetaGroupAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="isInternalGroup">isInternalGroup.</param>
        /// <param name="hasAccessToAllBuilds">hasAccessToAllBuilds.</param>
        /// <param name="publicLinkEnabled">publicLinkEnabled.</param>
        /// <param name="publicLinkId">publicLinkId.</param>
        /// <param name="publicLinkLimitEnabled">publicLinkLimitEnabled.</param>
        /// <param name="publicLinkLimit">publicLinkLimit.</param>
        /// <param name="publicLink">publicLink.</param>
        /// <param name="feedbackEnabled">feedbackEnabled.</param>
        /// <param name="iosBuildsAvailableForAppleSiliconMac">iosBuildsAvailableForAppleSiliconMac.</param>
        public BetaGroupAttributes(string name = default(string), DateTimeOffset createdDate = default(DateTimeOffset), bool isInternalGroup = default(bool), bool hasAccessToAllBuilds = default(bool), bool publicLinkEnabled = default(bool), string publicLinkId = default(string), bool publicLinkLimitEnabled = default(bool), int publicLinkLimit = default(int), string publicLink = default(string), bool feedbackEnabled = default(bool), bool iosBuildsAvailableForAppleSiliconMac = default(bool))
        {
            this.Name = name;
            this.CreatedDate = createdDate;
            this.IsInternalGroup = isInternalGroup;
            this.HasAccessToAllBuilds = hasAccessToAllBuilds;
            this.PublicLinkEnabled = publicLinkEnabled;
            this.PublicLinkId = publicLinkId;
            this.PublicLinkLimitEnabled = publicLinkLimitEnabled;
            this.PublicLinkLimit = publicLinkLimit;
            this.PublicLink = publicLink;
            this.FeedbackEnabled = feedbackEnabled;
            this.IosBuildsAvailableForAppleSiliconMac = iosBuildsAvailableForAppleSiliconMac;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets IsInternalGroup
        /// </summary>
        [DataMember(Name = "isInternalGroup", EmitDefaultValue = true)]
        public bool IsInternalGroup { get; set; }

        /// <summary>
        /// Gets or Sets HasAccessToAllBuilds
        /// </summary>
        [DataMember(Name = "hasAccessToAllBuilds", EmitDefaultValue = true)]
        public bool HasAccessToAllBuilds { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkEnabled
        /// </summary>
        [DataMember(Name = "publicLinkEnabled", EmitDefaultValue = true)]
        public bool PublicLinkEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkId
        /// </summary>
        [DataMember(Name = "publicLinkId", EmitDefaultValue = false)]
        public string PublicLinkId { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkLimitEnabled
        /// </summary>
        [DataMember(Name = "publicLinkLimitEnabled", EmitDefaultValue = true)]
        public bool PublicLinkLimitEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkLimit
        /// </summary>
        [DataMember(Name = "publicLinkLimit", EmitDefaultValue = false)]
        public int PublicLinkLimit { get; set; }

        /// <summary>
        /// Gets or Sets PublicLink
        /// </summary>
        [DataMember(Name = "publicLink", EmitDefaultValue = false)]
        public string PublicLink { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackEnabled
        /// </summary>
        [DataMember(Name = "feedbackEnabled", EmitDefaultValue = true)]
        public bool FeedbackEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IosBuildsAvailableForAppleSiliconMac
        /// </summary>
        [DataMember(Name = "iosBuildsAvailableForAppleSiliconMac", EmitDefaultValue = true)]
        public bool IosBuildsAvailableForAppleSiliconMac { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaGroupAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  IsInternalGroup: ").Append(IsInternalGroup).Append("\n");
            sb.Append("  HasAccessToAllBuilds: ").Append(HasAccessToAllBuilds).Append("\n");
            sb.Append("  PublicLinkEnabled: ").Append(PublicLinkEnabled).Append("\n");
            sb.Append("  PublicLinkId: ").Append(PublicLinkId).Append("\n");
            sb.Append("  PublicLinkLimitEnabled: ").Append(PublicLinkLimitEnabled).Append("\n");
            sb.Append("  PublicLinkLimit: ").Append(PublicLinkLimit).Append("\n");
            sb.Append("  PublicLink: ").Append(PublicLink).Append("\n");
            sb.Append("  FeedbackEnabled: ").Append(FeedbackEnabled).Append("\n");
            sb.Append("  IosBuildsAvailableForAppleSiliconMac: ").Append(IosBuildsAvailableForAppleSiliconMac).Append("\n");
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
            return this.Equals(input as BetaGroupAttributes);
        }

        /// <summary>
        /// Returns true if BetaGroupAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaGroupAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaGroupAttributes input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.IsInternalGroup == input.IsInternalGroup ||
                    this.IsInternalGroup.Equals(input.IsInternalGroup)
                ) && 
                (
                    this.HasAccessToAllBuilds == input.HasAccessToAllBuilds ||
                    this.HasAccessToAllBuilds.Equals(input.HasAccessToAllBuilds)
                ) && 
                (
                    this.PublicLinkEnabled == input.PublicLinkEnabled ||
                    this.PublicLinkEnabled.Equals(input.PublicLinkEnabled)
                ) && 
                (
                    this.PublicLinkId == input.PublicLinkId ||
                    (this.PublicLinkId != null &&
                    this.PublicLinkId.Equals(input.PublicLinkId))
                ) && 
                (
                    this.PublicLinkLimitEnabled == input.PublicLinkLimitEnabled ||
                    this.PublicLinkLimitEnabled.Equals(input.PublicLinkLimitEnabled)
                ) && 
                (
                    this.PublicLinkLimit == input.PublicLinkLimit ||
                    this.PublicLinkLimit.Equals(input.PublicLinkLimit)
                ) && 
                (
                    this.PublicLink == input.PublicLink ||
                    (this.PublicLink != null &&
                    this.PublicLink.Equals(input.PublicLink))
                ) && 
                (
                    this.FeedbackEnabled == input.FeedbackEnabled ||
                    this.FeedbackEnabled.Equals(input.FeedbackEnabled)
                ) && 
                (
                    this.IosBuildsAvailableForAppleSiliconMac == input.IosBuildsAvailableForAppleSiliconMac ||
                    this.IosBuildsAvailableForAppleSiliconMac.Equals(input.IosBuildsAvailableForAppleSiliconMac)
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
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsInternalGroup.GetHashCode();
                hashCode = (hashCode * 59) + this.HasAccessToAllBuilds.GetHashCode();
                hashCode = (hashCode * 59) + this.PublicLinkEnabled.GetHashCode();
                if (this.PublicLinkId != null)
                {
                    hashCode = (hashCode * 59) + this.PublicLinkId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PublicLinkLimitEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.PublicLinkLimit.GetHashCode();
                if (this.PublicLink != null)
                {
                    hashCode = (hashCode * 59) + this.PublicLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FeedbackEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.IosBuildsAvailableForAppleSiliconMac.GetHashCode();
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