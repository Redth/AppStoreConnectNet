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
    /// InAppPurchaseV2RelationshipsContentData
    /// </summary>
    [DataContract(Name = "InAppPurchaseV2_relationships_content_data")]
    public partial class InAppPurchaseV2RelationshipsContentData : IEquatable<InAppPurchaseV2RelationshipsContentData>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum InAppPurchaseContents for value: inAppPurchaseContents
            /// </summary>
            [EnumMember(Value = "inAppPurchaseContents")]
            InAppPurchaseContents = 1

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2RelationshipsContentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InAppPurchaseV2RelationshipsContentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2RelationshipsContentData" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        public InAppPurchaseV2RelationshipsContentData(TypeEnum type = default(TypeEnum), string id = default(string))
        {
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for InAppPurchaseV2RelationshipsContentData and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InAppPurchaseV2RelationshipsContentData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as InAppPurchaseV2RelationshipsContentData);
        }

        /// <summary>
        /// Returns true if InAppPurchaseV2RelationshipsContentData instances are equal
        /// </summary>
        /// <param name="input">Instance of InAppPurchaseV2RelationshipsContentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InAppPurchaseV2RelationshipsContentData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
