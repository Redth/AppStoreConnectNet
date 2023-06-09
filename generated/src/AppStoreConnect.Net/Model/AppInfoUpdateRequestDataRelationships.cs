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
    /// AppInfoUpdateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppInfoUpdateRequest_data_relationships")]
    public partial class AppInfoUpdateRequestDataRelationships : IEquatable<AppInfoUpdateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="primaryCategory">primaryCategory.</param>
        /// <param name="primarySubcategoryOne">primarySubcategoryOne.</param>
        /// <param name="primarySubcategoryTwo">primarySubcategoryTwo.</param>
        /// <param name="secondaryCategory">secondaryCategory.</param>
        /// <param name="secondarySubcategoryOne">secondarySubcategoryOne.</param>
        /// <param name="secondarySubcategoryTwo">secondarySubcategoryTwo.</param>
        public AppInfoUpdateRequestDataRelationships(AppInfoUpdateRequestDataRelationshipsPrimaryCategory primaryCategory = default(AppInfoUpdateRequestDataRelationshipsPrimaryCategory), AppInfoUpdateRequestDataRelationshipsPrimaryCategory primarySubcategoryOne = default(AppInfoUpdateRequestDataRelationshipsPrimaryCategory), AppInfoUpdateRequestDataRelationshipsPrimaryCategory primarySubcategoryTwo = default(AppInfoUpdateRequestDataRelationshipsPrimaryCategory), AppInfoUpdateRequestDataRelationshipsPrimaryCategory secondaryCategory = default(AppInfoUpdateRequestDataRelationshipsPrimaryCategory), AppInfoUpdateRequestDataRelationshipsPrimaryCategory secondarySubcategoryOne = default(AppInfoUpdateRequestDataRelationshipsPrimaryCategory), AppInfoUpdateRequestDataRelationshipsPrimaryCategory secondarySubcategoryTwo = default(AppInfoUpdateRequestDataRelationshipsPrimaryCategory))
        {
            this.PrimaryCategory = primaryCategory;
            this.PrimarySubcategoryOne = primarySubcategoryOne;
            this.PrimarySubcategoryTwo = primarySubcategoryTwo;
            this.SecondaryCategory = secondaryCategory;
            this.SecondarySubcategoryOne = secondarySubcategoryOne;
            this.SecondarySubcategoryTwo = secondarySubcategoryTwo;
        }

        /// <summary>
        /// Gets or Sets PrimaryCategory
        /// </summary>
        [DataMember(Name = "primaryCategory", EmitDefaultValue = false)]
        public AppInfoUpdateRequestDataRelationshipsPrimaryCategory PrimaryCategory { get; set; }

        /// <summary>
        /// Gets or Sets PrimarySubcategoryOne
        /// </summary>
        [DataMember(Name = "primarySubcategoryOne", EmitDefaultValue = false)]
        public AppInfoUpdateRequestDataRelationshipsPrimaryCategory PrimarySubcategoryOne { get; set; }

        /// <summary>
        /// Gets or Sets PrimarySubcategoryTwo
        /// </summary>
        [DataMember(Name = "primarySubcategoryTwo", EmitDefaultValue = false)]
        public AppInfoUpdateRequestDataRelationshipsPrimaryCategory PrimarySubcategoryTwo { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryCategory
        /// </summary>
        [DataMember(Name = "secondaryCategory", EmitDefaultValue = false)]
        public AppInfoUpdateRequestDataRelationshipsPrimaryCategory SecondaryCategory { get; set; }

        /// <summary>
        /// Gets or Sets SecondarySubcategoryOne
        /// </summary>
        [DataMember(Name = "secondarySubcategoryOne", EmitDefaultValue = false)]
        public AppInfoUpdateRequestDataRelationshipsPrimaryCategory SecondarySubcategoryOne { get; set; }

        /// <summary>
        /// Gets or Sets SecondarySubcategoryTwo
        /// </summary>
        [DataMember(Name = "secondarySubcategoryTwo", EmitDefaultValue = false)]
        public AppInfoUpdateRequestDataRelationshipsPrimaryCategory SecondarySubcategoryTwo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppInfoUpdateRequestDataRelationships {\n");
            sb.Append("  PrimaryCategory: ").Append(PrimaryCategory).Append("\n");
            sb.Append("  PrimarySubcategoryOne: ").Append(PrimarySubcategoryOne).Append("\n");
            sb.Append("  PrimarySubcategoryTwo: ").Append(PrimarySubcategoryTwo).Append("\n");
            sb.Append("  SecondaryCategory: ").Append(SecondaryCategory).Append("\n");
            sb.Append("  SecondarySubcategoryOne: ").Append(SecondarySubcategoryOne).Append("\n");
            sb.Append("  SecondarySubcategoryTwo: ").Append(SecondarySubcategoryTwo).Append("\n");
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
            return this.Equals(input as AppInfoUpdateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if AppInfoUpdateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppInfoUpdateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppInfoUpdateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrimaryCategory == input.PrimaryCategory ||
                    (this.PrimaryCategory != null &&
                    this.PrimaryCategory.Equals(input.PrimaryCategory))
                ) && 
                (
                    this.PrimarySubcategoryOne == input.PrimarySubcategoryOne ||
                    (this.PrimarySubcategoryOne != null &&
                    this.PrimarySubcategoryOne.Equals(input.PrimarySubcategoryOne))
                ) && 
                (
                    this.PrimarySubcategoryTwo == input.PrimarySubcategoryTwo ||
                    (this.PrimarySubcategoryTwo != null &&
                    this.PrimarySubcategoryTwo.Equals(input.PrimarySubcategoryTwo))
                ) && 
                (
                    this.SecondaryCategory == input.SecondaryCategory ||
                    (this.SecondaryCategory != null &&
                    this.SecondaryCategory.Equals(input.SecondaryCategory))
                ) && 
                (
                    this.SecondarySubcategoryOne == input.SecondarySubcategoryOne ||
                    (this.SecondarySubcategoryOne != null &&
                    this.SecondarySubcategoryOne.Equals(input.SecondarySubcategoryOne))
                ) && 
                (
                    this.SecondarySubcategoryTwo == input.SecondarySubcategoryTwo ||
                    (this.SecondarySubcategoryTwo != null &&
                    this.SecondarySubcategoryTwo.Equals(input.SecondarySubcategoryTwo))
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
                if (this.PrimaryCategory != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryCategory.GetHashCode();
                }
                if (this.PrimarySubcategoryOne != null)
                {
                    hashCode = (hashCode * 59) + this.PrimarySubcategoryOne.GetHashCode();
                }
                if (this.PrimarySubcategoryTwo != null)
                {
                    hashCode = (hashCode * 59) + this.PrimarySubcategoryTwo.GetHashCode();
                }
                if (this.SecondaryCategory != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryCategory.GetHashCode();
                }
                if (this.SecondarySubcategoryOne != null)
                {
                    hashCode = (hashCode * 59) + this.SecondarySubcategoryOne.GetHashCode();
                }
                if (this.SecondarySubcategoryTwo != null)
                {
                    hashCode = (hashCode * 59) + this.SecondarySubcategoryTwo.GetHashCode();
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
