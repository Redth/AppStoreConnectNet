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
    /// InAppPurchaseAttributes
    /// </summary>
    [DataContract(Name = "InAppPurchase_attributes")]
    public partial class InAppPurchaseAttributes : IEquatable<InAppPurchaseAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines InAppPurchaseType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InAppPurchaseTypeEnum
        {
            /// <summary>
            /// Enum AUTOMATICALLYRENEWABLESUBSCRIPTION for value: AUTOMATICALLY_RENEWABLE_SUBSCRIPTION
            /// </summary>
            [EnumMember(Value = "AUTOMATICALLY_RENEWABLE_SUBSCRIPTION")]
            AUTOMATICALLYRENEWABLESUBSCRIPTION = 1,

            /// <summary>
            /// Enum NONCONSUMABLE for value: NON_CONSUMABLE
            /// </summary>
            [EnumMember(Value = "NON_CONSUMABLE")]
            NONCONSUMABLE = 2,

            /// <summary>
            /// Enum CONSUMABLE for value: CONSUMABLE
            /// </summary>
            [EnumMember(Value = "CONSUMABLE")]
            CONSUMABLE = 3,

            /// <summary>
            /// Enum NONRENEWINGSUBSCRIPTION for value: NON_RENEWING_SUBSCRIPTION
            /// </summary>
            [EnumMember(Value = "NON_RENEWING_SUBSCRIPTION")]
            NONRENEWINGSUBSCRIPTION = 4,

            /// <summary>
            /// Enum FREESUBSCRIPTION for value: FREE_SUBSCRIPTION
            /// </summary>
            [EnumMember(Value = "FREE_SUBSCRIPTION")]
            FREESUBSCRIPTION = 5

        }


        /// <summary>
        /// Gets or Sets InAppPurchaseType
        /// </summary>
        [DataMember(Name = "inAppPurchaseType", EmitDefaultValue = false)]
        public InAppPurchaseTypeEnum? InAppPurchaseType { get; set; }
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED = 1,

            /// <summary>
            /// Enum DEVELOPERSIGNEDOFF for value: DEVELOPER_SIGNED_OFF
            /// </summary>
            [EnumMember(Value = "DEVELOPER_SIGNED_OFF")]
            DEVELOPERSIGNEDOFF = 2,

            /// <summary>
            /// Enum DEVELOPERACTIONNEEDED for value: DEVELOPER_ACTION_NEEDED
            /// </summary>
            [EnumMember(Value = "DEVELOPER_ACTION_NEEDED")]
            DEVELOPERACTIONNEEDED = 3,

            /// <summary>
            /// Enum DELETIONINPROGRESS for value: DELETION_IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "DELETION_IN_PROGRESS")]
            DELETIONINPROGRESS = 4,

            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 5,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 6,

            /// <summary>
            /// Enum REMOVEDFROMSALE for value: REMOVED_FROM_SALE
            /// </summary>
            [EnumMember(Value = "REMOVED_FROM_SALE")]
            REMOVEDFROMSALE = 7,

            /// <summary>
            /// Enum DEVELOPERREMOVEDFROMSALE for value: DEVELOPER_REMOVED_FROM_SALE
            /// </summary>
            [EnumMember(Value = "DEVELOPER_REMOVED_FROM_SALE")]
            DEVELOPERREMOVEDFROMSALE = 8,

            /// <summary>
            /// Enum WAITINGFORUPLOAD for value: WAITING_FOR_UPLOAD
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_UPLOAD")]
            WAITINGFORUPLOAD = 9,

            /// <summary>
            /// Enum PROCESSINGCONTENT for value: PROCESSING_CONTENT
            /// </summary>
            [EnumMember(Value = "PROCESSING_CONTENT")]
            PROCESSINGCONTENT = 10,

            /// <summary>
            /// Enum REPLACED for value: REPLACED
            /// </summary>
            [EnumMember(Value = "REPLACED")]
            REPLACED = 11,

            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 12,

            /// <summary>
            /// Enum WAITINGFORSCREENSHOT for value: WAITING_FOR_SCREENSHOT
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_SCREENSHOT")]
            WAITINGFORSCREENSHOT = 13,

            /// <summary>
            /// Enum PREPAREFORSUBMISSION for value: PREPARE_FOR_SUBMISSION
            /// </summary>
            [EnumMember(Value = "PREPARE_FOR_SUBMISSION")]
            PREPAREFORSUBMISSION = 14,

            /// <summary>
            /// Enum MISSINGMETADATA for value: MISSING_METADATA
            /// </summary>
            [EnumMember(Value = "MISSING_METADATA")]
            MISSINGMETADATA = 15,

            /// <summary>
            /// Enum READYTOSUBMIT for value: READY_TO_SUBMIT
            /// </summary>
            [EnumMember(Value = "READY_TO_SUBMIT")]
            READYTOSUBMIT = 16,

            /// <summary>
            /// Enum WAITINGFORREVIEW for value: WAITING_FOR_REVIEW
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_REVIEW")]
            WAITINGFORREVIEW = 17,

            /// <summary>
            /// Enum INREVIEW for value: IN_REVIEW
            /// </summary>
            [EnumMember(Value = "IN_REVIEW")]
            INREVIEW = 18,

            /// <summary>
            /// Enum PENDINGDEVELOPERRELEASE for value: PENDING_DEVELOPER_RELEASE
            /// </summary>
            [EnumMember(Value = "PENDING_DEVELOPER_RELEASE")]
            PENDINGDEVELOPERRELEASE = 19

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAttributes" /> class.
        /// </summary>
        /// <param name="referenceName">referenceName.</param>
        /// <param name="productId">productId.</param>
        /// <param name="inAppPurchaseType">inAppPurchaseType.</param>
        /// <param name="state">state.</param>
        public InAppPurchaseAttributes(string referenceName = default(string), string productId = default(string), InAppPurchaseTypeEnum? inAppPurchaseType = default(InAppPurchaseTypeEnum?), StateEnum? state = default(StateEnum?))
        {
            this.ReferenceName = referenceName;
            this.ProductId = productId;
            this.InAppPurchaseType = inAppPurchaseType;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets ReferenceName
        /// </summary>
        [DataMember(Name = "referenceName", EmitDefaultValue = false)]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InAppPurchaseAttributes {\n");
            sb.Append("  ReferenceName: ").Append(ReferenceName).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  InAppPurchaseType: ").Append(InAppPurchaseType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as InAppPurchaseAttributes);
        }

        /// <summary>
        /// Returns true if InAppPurchaseAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of InAppPurchaseAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InAppPurchaseAttributes input)
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
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.InAppPurchaseType == input.InAppPurchaseType ||
                    this.InAppPurchaseType.Equals(input.InAppPurchaseType)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InAppPurchaseType.GetHashCode();
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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
