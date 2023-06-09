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
    /// AppClipAdvancedExperienceAttributes
    /// </summary>
    [DataContract(Name = "AppClipAdvancedExperience_attributes")]
    public partial class AppClipAdvancedExperienceAttributes : IEquatable<AppClipAdvancedExperienceAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 1,

            /// <summary>
            /// Enum DEACTIVATED for value: DEACTIVATED
            /// </summary>
            [EnumMember(Value = "DEACTIVATED")]
            DEACTIVATED = 2,

            /// <summary>
            /// Enum APPTRANSFERINPROGRESS for value: APP_TRANSFER_IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "APP_TRANSFER_IN_PROGRESS")]
            APPTRANSFERINPROGRESS = 3

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public AppClipAction? Action { get; set; }
        /// <summary>
        /// Defines PlaceStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlaceStatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,

            /// <summary>
            /// Enum MATCHED for value: MATCHED
            /// </summary>
            [EnumMember(Value = "MATCHED")]
            MATCHED = 2,

            /// <summary>
            /// Enum NOMATCH for value: NO_MATCH
            /// </summary>
            [EnumMember(Value = "NO_MATCH")]
            NOMATCH = 3

        }


        /// <summary>
        /// Gets or Sets PlaceStatus
        /// </summary>
        [DataMember(Name = "placeStatus", EmitDefaultValue = false)]
        public PlaceStatusEnum? PlaceStatus { get; set; }
        /// <summary>
        /// Defines BusinessCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BusinessCategoryEnum
        {
            /// <summary>
            /// Enum AUTOMOTIVE for value: AUTOMOTIVE
            /// </summary>
            [EnumMember(Value = "AUTOMOTIVE")]
            AUTOMOTIVE = 1,

            /// <summary>
            /// Enum BEAUTY for value: BEAUTY
            /// </summary>
            [EnumMember(Value = "BEAUTY")]
            BEAUTY = 2,

            /// <summary>
            /// Enum BIKES for value: BIKES
            /// </summary>
            [EnumMember(Value = "BIKES")]
            BIKES = 3,

            /// <summary>
            /// Enum BOOKS for value: BOOKS
            /// </summary>
            [EnumMember(Value = "BOOKS")]
            BOOKS = 4,

            /// <summary>
            /// Enum CASINO for value: CASINO
            /// </summary>
            [EnumMember(Value = "CASINO")]
            CASINO = 5,

            /// <summary>
            /// Enum EDUCATION for value: EDUCATION
            /// </summary>
            [EnumMember(Value = "EDUCATION")]
            EDUCATION = 6,

            /// <summary>
            /// Enum EDUCATIONJAPAN for value: EDUCATION_JAPAN
            /// </summary>
            [EnumMember(Value = "EDUCATION_JAPAN")]
            EDUCATIONJAPAN = 7,

            /// <summary>
            /// Enum ENTERTAINMENT for value: ENTERTAINMENT
            /// </summary>
            [EnumMember(Value = "ENTERTAINMENT")]
            ENTERTAINMENT = 8,

            /// <summary>
            /// Enum EVCHARGER for value: EV_CHARGER
            /// </summary>
            [EnumMember(Value = "EV_CHARGER")]
            EVCHARGER = 9,

            /// <summary>
            /// Enum FINANCIALUSD for value: FINANCIAL_USD
            /// </summary>
            [EnumMember(Value = "FINANCIAL_USD")]
            FINANCIALUSD = 10,

            /// <summary>
            /// Enum FINANCIALCNY for value: FINANCIAL_CNY
            /// </summary>
            [EnumMember(Value = "FINANCIAL_CNY")]
            FINANCIALCNY = 11,

            /// <summary>
            /// Enum FINANCIALGBP for value: FINANCIAL_GBP
            /// </summary>
            [EnumMember(Value = "FINANCIAL_GBP")]
            FINANCIALGBP = 12,

            /// <summary>
            /// Enum FINANCIALJPY for value: FINANCIAL_JPY
            /// </summary>
            [EnumMember(Value = "FINANCIAL_JPY")]
            FINANCIALJPY = 13,

            /// <summary>
            /// Enum FINANCIALEUR for value: FINANCIAL_EUR
            /// </summary>
            [EnumMember(Value = "FINANCIAL_EUR")]
            FINANCIALEUR = 14,

            /// <summary>
            /// Enum FITNESS for value: FITNESS
            /// </summary>
            [EnumMember(Value = "FITNESS")]
            FITNESS = 15,

            /// <summary>
            /// Enum FOODANDDRINK for value: FOOD_AND_DRINK
            /// </summary>
            [EnumMember(Value = "FOOD_AND_DRINK")]
            FOODANDDRINK = 16,

            /// <summary>
            /// Enum GAS for value: GAS
            /// </summary>
            [EnumMember(Value = "GAS")]
            GAS = 17,

            /// <summary>
            /// Enum GROCERY for value: GROCERY
            /// </summary>
            [EnumMember(Value = "GROCERY")]
            GROCERY = 18,

            /// <summary>
            /// Enum HEALTHANDMEDICAL for value: HEALTH_AND_MEDICAL
            /// </summary>
            [EnumMember(Value = "HEALTH_AND_MEDICAL")]
            HEALTHANDMEDICAL = 19,

            /// <summary>
            /// Enum HOTELANDTRAVEL for value: HOTEL_AND_TRAVEL
            /// </summary>
            [EnumMember(Value = "HOTEL_AND_TRAVEL")]
            HOTELANDTRAVEL = 20,

            /// <summary>
            /// Enum MUSIC for value: MUSIC
            /// </summary>
            [EnumMember(Value = "MUSIC")]
            MUSIC = 21,

            /// <summary>
            /// Enum PARKING for value: PARKING
            /// </summary>
            [EnumMember(Value = "PARKING")]
            PARKING = 22,

            /// <summary>
            /// Enum PETSERVICES for value: PET_SERVICES
            /// </summary>
            [EnumMember(Value = "PET_SERVICES")]
            PETSERVICES = 23,

            /// <summary>
            /// Enum PROFESSIONALSERVICES for value: PROFESSIONAL_SERVICES
            /// </summary>
            [EnumMember(Value = "PROFESSIONAL_SERVICES")]
            PROFESSIONALSERVICES = 24,

            /// <summary>
            /// Enum SHOPPING for value: SHOPPING
            /// </summary>
            [EnumMember(Value = "SHOPPING")]
            SHOPPING = 25,

            /// <summary>
            /// Enum TICKETING for value: TICKETING
            /// </summary>
            [EnumMember(Value = "TICKETING")]
            TICKETING = 26,

            /// <summary>
            /// Enum TRANSIT for value: TRANSIT
            /// </summary>
            [EnumMember(Value = "TRANSIT")]
            TRANSIT = 27

        }


        /// <summary>
        /// Gets or Sets BusinessCategory
        /// </summary>
        [DataMember(Name = "businessCategory", EmitDefaultValue = false)]
        public BusinessCategoryEnum? BusinessCategory { get; set; }

        /// <summary>
        /// Gets or Sets DefaultLanguage
        /// </summary>
        [DataMember(Name = "defaultLanguage", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceLanguage? DefaultLanguage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributes" /> class.
        /// </summary>
        /// <param name="link">link.</param>
        /// <param name="version">version.</param>
        /// <param name="status">status.</param>
        /// <param name="action">action.</param>
        /// <param name="isPoweredBy">isPoweredBy.</param>
        /// <param name="place">place.</param>
        /// <param name="placeStatus">placeStatus.</param>
        /// <param name="businessCategory">businessCategory.</param>
        /// <param name="defaultLanguage">defaultLanguage.</param>
        public AppClipAdvancedExperienceAttributes(string link = default(string), int version = default(int), StatusEnum? status = default(StatusEnum?), AppClipAction? action = default(AppClipAction?), bool isPoweredBy = default(bool), AppClipAdvancedExperienceAttributesPlace place = default(AppClipAdvancedExperienceAttributesPlace), PlaceStatusEnum? placeStatus = default(PlaceStatusEnum?), BusinessCategoryEnum? businessCategory = default(BusinessCategoryEnum?), AppClipAdvancedExperienceLanguage? defaultLanguage = default(AppClipAdvancedExperienceLanguage?))
        {
            this.Link = link;
            this._Version = version;
            this.Status = status;
            this.Action = action;
            this.IsPoweredBy = isPoweredBy;
            this.Place = place;
            this.PlaceStatus = placeStatus;
            this.BusinessCategory = businessCategory;
            this.DefaultLanguage = defaultLanguage;
        }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets IsPoweredBy
        /// </summary>
        [DataMember(Name = "isPoweredBy", EmitDefaultValue = true)]
        public bool IsPoweredBy { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name = "place", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceAttributesPlace Place { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAdvancedExperienceAttributes {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  IsPoweredBy: ").Append(IsPoweredBy).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
            sb.Append("  PlaceStatus: ").Append(PlaceStatus).Append("\n");
            sb.Append("  BusinessCategory: ").Append(BusinessCategory).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
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
            return this.Equals(input as AppClipAdvancedExperienceAttributes);
        }

        /// <summary>
        /// Returns true if AppClipAdvancedExperienceAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipAdvancedExperienceAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipAdvancedExperienceAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.IsPoweredBy == input.IsPoweredBy ||
                    this.IsPoweredBy.Equals(input.IsPoweredBy)
                ) && 
                (
                    this.Place == input.Place ||
                    (this.Place != null &&
                    this.Place.Equals(input.Place))
                ) && 
                (
                    this.PlaceStatus == input.PlaceStatus ||
                    this.PlaceStatus.Equals(input.PlaceStatus)
                ) && 
                (
                    this.BusinessCategory == input.BusinessCategory ||
                    this.BusinessCategory.Equals(input.BusinessCategory)
                ) && 
                (
                    this.DefaultLanguage == input.DefaultLanguage ||
                    this.DefaultLanguage.Equals(input.DefaultLanguage)
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
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPoweredBy.GetHashCode();
                if (this.Place != null)
                {
                    hashCode = (hashCode * 59) + this.Place.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlaceStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.BusinessCategory.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultLanguage.GetHashCode();
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
