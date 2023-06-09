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
    /// AppClipAdvancedExperienceAttributesPlace
    /// </summary>
    [DataContract(Name = "AppClipAdvancedExperience_attributes_place")]
    public partial class AppClipAdvancedExperienceAttributesPlace : IEquatable<AppClipAdvancedExperienceAttributesPlace>, IValidatableObject
    {
        /// <summary>
        /// Defines MapAction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MapActionEnum
        {
            /// <summary>
            /// Enum BUYTICKETS for value: BUY_TICKETS
            /// </summary>
            [EnumMember(Value = "BUY_TICKETS")]
            BUYTICKETS = 1,

            /// <summary>
            /// Enum VIEWAVAILABILITY for value: VIEW_AVAILABILITY
            /// </summary>
            [EnumMember(Value = "VIEW_AVAILABILITY")]
            VIEWAVAILABILITY = 2,

            /// <summary>
            /// Enum VIEWPRICING for value: VIEW_PRICING
            /// </summary>
            [EnumMember(Value = "VIEW_PRICING")]
            VIEWPRICING = 3,

            /// <summary>
            /// Enum HOTELBOOKROOM for value: HOTEL_BOOK_ROOM
            /// </summary>
            [EnumMember(Value = "HOTEL_BOOK_ROOM")]
            HOTELBOOKROOM = 4,

            /// <summary>
            /// Enum PARKINGRESERVEPARKING for value: PARKING_RESERVE_PARKING
            /// </summary>
            [EnumMember(Value = "PARKING_RESERVE_PARKING")]
            PARKINGRESERVEPARKING = 5,

            /// <summary>
            /// Enum RESTAURANTJOINWAITLIST for value: RESTAURANT_JOIN_WAITLIST
            /// </summary>
            [EnumMember(Value = "RESTAURANT_JOIN_WAITLIST")]
            RESTAURANTJOINWAITLIST = 6,

            /// <summary>
            /// Enum RESTAURANTORDERDELIVERY for value: RESTAURANT_ORDER_DELIVERY
            /// </summary>
            [EnumMember(Value = "RESTAURANT_ORDER_DELIVERY")]
            RESTAURANTORDERDELIVERY = 7,

            /// <summary>
            /// Enum RESTAURANTORDERFOOD for value: RESTAURANT_ORDER_FOOD
            /// </summary>
            [EnumMember(Value = "RESTAURANT_ORDER_FOOD")]
            RESTAURANTORDERFOOD = 8,

            /// <summary>
            /// Enum RESTAURANTORDERTAKEOUT for value: RESTAURANT_ORDER_TAKEOUT
            /// </summary>
            [EnumMember(Value = "RESTAURANT_ORDER_TAKEOUT")]
            RESTAURANTORDERTAKEOUT = 9,

            /// <summary>
            /// Enum RESTAURANTRESERVATION for value: RESTAURANT_RESERVATION
            /// </summary>
            [EnumMember(Value = "RESTAURANT_RESERVATION")]
            RESTAURANTRESERVATION = 10,

            /// <summary>
            /// Enum SCHEDULEAPPOINTMENT for value: SCHEDULE_APPOINTMENT
            /// </summary>
            [EnumMember(Value = "SCHEDULE_APPOINTMENT")]
            SCHEDULEAPPOINTMENT = 11,

            /// <summary>
            /// Enum RESTAURANTVIEWMENU for value: RESTAURANT_VIEW_MENU
            /// </summary>
            [EnumMember(Value = "RESTAURANT_VIEW_MENU")]
            RESTAURANTVIEWMENU = 12,

            /// <summary>
            /// Enum THEATERNOWPLAYING for value: THEATER_NOW_PLAYING
            /// </summary>
            [EnumMember(Value = "THEATER_NOW_PLAYING")]
            THEATERNOWPLAYING = 13

        }


        /// <summary>
        /// Gets or Sets MapAction
        /// </summary>
        [DataMember(Name = "mapAction", EmitDefaultValue = false)]
        public MapActionEnum? MapAction { get; set; }
        /// <summary>
        /// Defines Relationship
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelationshipEnum
        {
            /// <summary>
            /// Enum OWNER for value: OWNER
            /// </summary>
            [EnumMember(Value = "OWNER")]
            OWNER = 1,

            /// <summary>
            /// Enum AUTHORIZED for value: AUTHORIZED
            /// </summary>
            [EnumMember(Value = "AUTHORIZED")]
            AUTHORIZED = 2,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 3

        }


        /// <summary>
        /// Gets or Sets Relationship
        /// </summary>
        [DataMember(Name = "relationship", EmitDefaultValue = false)]
        public RelationshipEnum? Relationship { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlace" /> class.
        /// </summary>
        /// <param name="placeId">placeId.</param>
        /// <param name="names">names.</param>
        /// <param name="mainAddress">mainAddress.</param>
        /// <param name="displayPoint">displayPoint.</param>
        /// <param name="mapAction">mapAction.</param>
        /// <param name="relationship">relationship.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="homePage">homePage.</param>
        /// <param name="categories">categories.</param>
        public AppClipAdvancedExperienceAttributesPlace(string placeId = default(string), List<string> names = default(List<string>), AppClipAdvancedExperienceAttributesPlaceMainAddress mainAddress = default(AppClipAdvancedExperienceAttributesPlaceMainAddress), AppClipAdvancedExperienceAttributesPlaceDisplayPoint displayPoint = default(AppClipAdvancedExperienceAttributesPlaceDisplayPoint), MapActionEnum? mapAction = default(MapActionEnum?), RelationshipEnum? relationship = default(RelationshipEnum?), AppClipAdvancedExperienceAttributesPlacePhoneNumber phoneNumber = default(AppClipAdvancedExperienceAttributesPlacePhoneNumber), string homePage = default(string), List<string> categories = default(List<string>))
        {
            this.PlaceId = placeId;
            this.Names = names;
            this.MainAddress = mainAddress;
            this.DisplayPoint = displayPoint;
            this.MapAction = mapAction;
            this.Relationship = relationship;
            this.PhoneNumber = phoneNumber;
            this.HomePage = homePage;
            this.Categories = categories;
        }

        /// <summary>
        /// Gets or Sets PlaceId
        /// </summary>
        [DataMember(Name = "placeId", EmitDefaultValue = false)]
        public string PlaceId { get; set; }

        /// <summary>
        /// Gets or Sets Names
        /// </summary>
        [DataMember(Name = "names", EmitDefaultValue = false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// Gets or Sets MainAddress
        /// </summary>
        [DataMember(Name = "mainAddress", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceAttributesPlaceMainAddress MainAddress { get; set; }

        /// <summary>
        /// Gets or Sets DisplayPoint
        /// </summary>
        [DataMember(Name = "displayPoint", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceAttributesPlaceDisplayPoint DisplayPoint { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public AppClipAdvancedExperienceAttributesPlacePhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets HomePage
        /// </summary>
        [DataMember(Name = "homePage", EmitDefaultValue = false)]
        public string HomePage { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAdvancedExperienceAttributesPlace {\n");
            sb.Append("  PlaceId: ").Append(PlaceId).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
            sb.Append("  MainAddress: ").Append(MainAddress).Append("\n");
            sb.Append("  DisplayPoint: ").Append(DisplayPoint).Append("\n");
            sb.Append("  MapAction: ").Append(MapAction).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  HomePage: ").Append(HomePage).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(input as AppClipAdvancedExperienceAttributesPlace);
        }

        /// <summary>
        /// Returns true if AppClipAdvancedExperienceAttributesPlace instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipAdvancedExperienceAttributesPlace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipAdvancedExperienceAttributesPlace input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PlaceId == input.PlaceId ||
                    (this.PlaceId != null &&
                    this.PlaceId.Equals(input.PlaceId))
                ) && 
                (
                    this.Names == input.Names ||
                    this.Names != null &&
                    input.Names != null &&
                    this.Names.SequenceEqual(input.Names)
                ) && 
                (
                    this.MainAddress == input.MainAddress ||
                    (this.MainAddress != null &&
                    this.MainAddress.Equals(input.MainAddress))
                ) && 
                (
                    this.DisplayPoint == input.DisplayPoint ||
                    (this.DisplayPoint != null &&
                    this.DisplayPoint.Equals(input.DisplayPoint))
                ) && 
                (
                    this.MapAction == input.MapAction ||
                    this.MapAction.Equals(input.MapAction)
                ) && 
                (
                    this.Relationship == input.Relationship ||
                    this.Relationship.Equals(input.Relationship)
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.HomePage == input.HomePage ||
                    (this.HomePage != null &&
                    this.HomePage.Equals(input.HomePage))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.PlaceId != null)
                {
                    hashCode = (hashCode * 59) + this.PlaceId.GetHashCode();
                }
                if (this.Names != null)
                {
                    hashCode = (hashCode * 59) + this.Names.GetHashCode();
                }
                if (this.MainAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MainAddress.GetHashCode();
                }
                if (this.DisplayPoint != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayPoint.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MapAction.GetHashCode();
                hashCode = (hashCode * 59) + this.Relationship.GetHashCode();
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.HomePage != null)
                {
                    hashCode = (hashCode * 59) + this.HomePage.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
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
