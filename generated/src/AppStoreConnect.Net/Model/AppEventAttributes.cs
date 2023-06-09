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
    /// AppEventAttributes
    /// </summary>
    [DataContract(Name = "AppEvent_attributes")]
    public partial class AppEventAttributes : IEquatable<AppEventAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines Badge
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BadgeEnum
        {
            /// <summary>
            /// Enum LIVEEVENT for value: LIVE_EVENT
            /// </summary>
            [EnumMember(Value = "LIVE_EVENT")]
            LIVEEVENT = 1,

            /// <summary>
            /// Enum PREMIERE for value: PREMIERE
            /// </summary>
            [EnumMember(Value = "PREMIERE")]
            PREMIERE = 2,

            /// <summary>
            /// Enum CHALLENGE for value: CHALLENGE
            /// </summary>
            [EnumMember(Value = "CHALLENGE")]
            CHALLENGE = 3,

            /// <summary>
            /// Enum COMPETITION for value: COMPETITION
            /// </summary>
            [EnumMember(Value = "COMPETITION")]
            COMPETITION = 4,

            /// <summary>
            /// Enum NEWSEASON for value: NEW_SEASON
            /// </summary>
            [EnumMember(Value = "NEW_SEASON")]
            NEWSEASON = 5,

            /// <summary>
            /// Enum MAJORUPDATE for value: MAJOR_UPDATE
            /// </summary>
            [EnumMember(Value = "MAJOR_UPDATE")]
            MAJORUPDATE = 6,

            /// <summary>
            /// Enum SPECIALEVENT for value: SPECIAL_EVENT
            /// </summary>
            [EnumMember(Value = "SPECIAL_EVENT")]
            SPECIALEVENT = 7

        }


        /// <summary>
        /// Gets or Sets Badge
        /// </summary>
        [DataMember(Name = "badge", EmitDefaultValue = false)]
        public BadgeEnum? Badge { get; set; }
        /// <summary>
        /// Defines EventState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventStateEnum
        {
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,

            /// <summary>
            /// Enum READYFORREVIEW for value: READY_FOR_REVIEW
            /// </summary>
            [EnumMember(Value = "READY_FOR_REVIEW")]
            READYFORREVIEW = 2,

            /// <summary>
            /// Enum WAITINGFORREVIEW for value: WAITING_FOR_REVIEW
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_REVIEW")]
            WAITINGFORREVIEW = 3,

            /// <summary>
            /// Enum INREVIEW for value: IN_REVIEW
            /// </summary>
            [EnumMember(Value = "IN_REVIEW")]
            INREVIEW = 4,

            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 5,

            /// <summary>
            /// Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            ACCEPTED = 6,

            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 7,

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            [EnumMember(Value = "PUBLISHED")]
            PUBLISHED = 8,

            /// <summary>
            /// Enum PAST for value: PAST
            /// </summary>
            [EnumMember(Value = "PAST")]
            PAST = 9,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 10

        }


        /// <summary>
        /// Gets or Sets EventState
        /// </summary>
        [DataMember(Name = "eventState", EmitDefaultValue = false)]
        public EventStateEnum? EventState { get; set; }
        /// <summary>
        /// Defines PurchaseRequirement
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PurchaseRequirementEnum
        {
            /// <summary>
            /// Enum NOCOSTASSOCIATED for value: NO_COST_ASSOCIATED
            /// </summary>
            [EnumMember(Value = "NO_COST_ASSOCIATED")]
            NOCOSTASSOCIATED = 1,

            /// <summary>
            /// Enum INAPPPURCHASE for value: IN_APP_PURCHASE
            /// </summary>
            [EnumMember(Value = "IN_APP_PURCHASE")]
            INAPPPURCHASE = 2,

            /// <summary>
            /// Enum SUBSCRIPTION for value: SUBSCRIPTION
            /// </summary>
            [EnumMember(Value = "SUBSCRIPTION")]
            SUBSCRIPTION = 3,

            /// <summary>
            /// Enum INAPPPURCHASEANDSUBSCRIPTION for value: IN_APP_PURCHASE_AND_SUBSCRIPTION
            /// </summary>
            [EnumMember(Value = "IN_APP_PURCHASE_AND_SUBSCRIPTION")]
            INAPPPURCHASEANDSUBSCRIPTION = 4,

            /// <summary>
            /// Enum INAPPPURCHASEORSUBSCRIPTION for value: IN_APP_PURCHASE_OR_SUBSCRIPTION
            /// </summary>
            [EnumMember(Value = "IN_APP_PURCHASE_OR_SUBSCRIPTION")]
            INAPPPURCHASEORSUBSCRIPTION = 5

        }


        /// <summary>
        /// Gets or Sets PurchaseRequirement
        /// </summary>
        [DataMember(Name = "purchaseRequirement", EmitDefaultValue = false)]
        public PurchaseRequirementEnum? PurchaseRequirement { get; set; }
        /// <summary>
        /// Defines Priority
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum HIGH for value: HIGH
            /// </summary>
            [EnumMember(Value = "HIGH")]
            HIGH = 1,

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMAL = 2

        }


        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Defines Purpose
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Enum APPROPRIATEFORALLUSERS for value: APPROPRIATE_FOR_ALL_USERS
            /// </summary>
            [EnumMember(Value = "APPROPRIATE_FOR_ALL_USERS")]
            APPROPRIATEFORALLUSERS = 1,

            /// <summary>
            /// Enum ATTRACTNEWUSERS for value: ATTRACT_NEW_USERS
            /// </summary>
            [EnumMember(Value = "ATTRACT_NEW_USERS")]
            ATTRACTNEWUSERS = 2,

            /// <summary>
            /// Enum KEEPACTIVEUSERSINFORMED for value: KEEP_ACTIVE_USERS_INFORMED
            /// </summary>
            [EnumMember(Value = "KEEP_ACTIVE_USERS_INFORMED")]
            KEEPACTIVEUSERSINFORMED = 3,

            /// <summary>
            /// Enum BRINGBACKLAPSEDUSERS for value: BRING_BACK_LAPSED_USERS
            /// </summary>
            [EnumMember(Value = "BRING_BACK_LAPSED_USERS")]
            BRINGBACKLAPSEDUSERS = 4

        }


        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name = "purpose", EmitDefaultValue = false)]
        public PurposeEnum? Purpose { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventAttributes" /> class.
        /// </summary>
        /// <param name="referenceName">referenceName.</param>
        /// <param name="badge">badge.</param>
        /// <param name="eventState">eventState.</param>
        /// <param name="deepLink">deepLink.</param>
        /// <param name="purchaseRequirement">purchaseRequirement.</param>
        /// <param name="primaryLocale">primaryLocale.</param>
        /// <param name="priority">priority.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="territorySchedules">territorySchedules.</param>
        /// <param name="archivedTerritorySchedules">archivedTerritorySchedules.</param>
        public AppEventAttributes(string referenceName = default(string), BadgeEnum? badge = default(BadgeEnum?), EventStateEnum? eventState = default(EventStateEnum?), string deepLink = default(string), PurchaseRequirementEnum? purchaseRequirement = default(PurchaseRequirementEnum?), string primaryLocale = default(string), PriorityEnum? priority = default(PriorityEnum?), PurposeEnum? purpose = default(PurposeEnum?), List<AppEventAttributesTerritorySchedulesInner> territorySchedules = default(List<AppEventAttributesTerritorySchedulesInner>), List<AppEventAttributesTerritorySchedulesInner> archivedTerritorySchedules = default(List<AppEventAttributesTerritorySchedulesInner>))
        {
            this.ReferenceName = referenceName;
            this.Badge = badge;
            this.EventState = eventState;
            this.DeepLink = deepLink;
            this.PurchaseRequirement = purchaseRequirement;
            this.PrimaryLocale = primaryLocale;
            this.Priority = priority;
            this.Purpose = purpose;
            this.TerritorySchedules = territorySchedules;
            this.ArchivedTerritorySchedules = archivedTerritorySchedules;
        }

        /// <summary>
        /// Gets or Sets ReferenceName
        /// </summary>
        [DataMember(Name = "referenceName", EmitDefaultValue = false)]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or Sets DeepLink
        /// </summary>
        [DataMember(Name = "deepLink", EmitDefaultValue = false)]
        public string DeepLink { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryLocale
        /// </summary>
        [DataMember(Name = "primaryLocale", EmitDefaultValue = false)]
        public string PrimaryLocale { get; set; }

        /// <summary>
        /// Gets or Sets TerritorySchedules
        /// </summary>
        [DataMember(Name = "territorySchedules", EmitDefaultValue = false)]
        public List<AppEventAttributesTerritorySchedulesInner> TerritorySchedules { get; set; }

        /// <summary>
        /// Gets or Sets ArchivedTerritorySchedules
        /// </summary>
        [DataMember(Name = "archivedTerritorySchedules", EmitDefaultValue = false)]
        public List<AppEventAttributesTerritorySchedulesInner> ArchivedTerritorySchedules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEventAttributes {\n");
            sb.Append("  ReferenceName: ").Append(ReferenceName).Append("\n");
            sb.Append("  Badge: ").Append(Badge).Append("\n");
            sb.Append("  EventState: ").Append(EventState).Append("\n");
            sb.Append("  DeepLink: ").Append(DeepLink).Append("\n");
            sb.Append("  PurchaseRequirement: ").Append(PurchaseRequirement).Append("\n");
            sb.Append("  PrimaryLocale: ").Append(PrimaryLocale).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  TerritorySchedules: ").Append(TerritorySchedules).Append("\n");
            sb.Append("  ArchivedTerritorySchedules: ").Append(ArchivedTerritorySchedules).Append("\n");
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
            return this.Equals(input as AppEventAttributes);
        }

        /// <summary>
        /// Returns true if AppEventAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppEventAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReferenceName == input.ReferenceName ||
                    (this.ReferenceName != null &&
                    this.ReferenceName.Equals(input.ReferenceName))
                ) && 
                (
                    this.Badge == input.Badge ||
                    this.Badge.Equals(input.Badge)
                ) && 
                (
                    this.EventState == input.EventState ||
                    this.EventState.Equals(input.EventState)
                ) && 
                (
                    this.DeepLink == input.DeepLink ||
                    (this.DeepLink != null &&
                    this.DeepLink.Equals(input.DeepLink))
                ) && 
                (
                    this.PurchaseRequirement == input.PurchaseRequirement ||
                    this.PurchaseRequirement.Equals(input.PurchaseRequirement)
                ) && 
                (
                    this.PrimaryLocale == input.PrimaryLocale ||
                    (this.PrimaryLocale != null &&
                    this.PrimaryLocale.Equals(input.PrimaryLocale))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    this.Purpose.Equals(input.Purpose)
                ) && 
                (
                    this.TerritorySchedules == input.TerritorySchedules ||
                    this.TerritorySchedules != null &&
                    input.TerritorySchedules != null &&
                    this.TerritorySchedules.SequenceEqual(input.TerritorySchedules)
                ) && 
                (
                    this.ArchivedTerritorySchedules == input.ArchivedTerritorySchedules ||
                    this.ArchivedTerritorySchedules != null &&
                    input.ArchivedTerritorySchedules != null &&
                    this.ArchivedTerritorySchedules.SequenceEqual(input.ArchivedTerritorySchedules)
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
                if (this.ReferenceName != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Badge.GetHashCode();
                hashCode = (hashCode * 59) + this.EventState.GetHashCode();
                if (this.DeepLink != null)
                {
                    hashCode = (hashCode * 59) + this.DeepLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PurchaseRequirement.GetHashCode();
                if (this.PrimaryLocale != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryLocale.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                hashCode = (hashCode * 59) + this.Purpose.GetHashCode();
                if (this.TerritorySchedules != null)
                {
                    hashCode = (hashCode * 59) + this.TerritorySchedules.GetHashCode();
                }
                if (this.ArchivedTerritorySchedules != null)
                {
                    hashCode = (hashCode * 59) + this.ArchivedTerritorySchedules.GetHashCode();
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
