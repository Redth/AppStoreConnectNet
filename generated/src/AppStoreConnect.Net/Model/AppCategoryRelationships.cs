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
    /// AppCategoryRelationships
    /// </summary>
    [DataContract(Name = "AppCategory_relationships")]
    public partial class AppCategoryRelationships : IEquatable<AppCategoryRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCategoryRelationships" /> class.
        /// </summary>
        /// <param name="subcategories">subcategories.</param>
        /// <param name="parent">parent.</param>
        public AppCategoryRelationships(AppCategoryRelationshipsSubcategories subcategories = default(AppCategoryRelationshipsSubcategories), AppCategoryRelationshipsParent parent = default(AppCategoryRelationshipsParent))
        {
            this.Subcategories = subcategories;
            this.Parent = parent;
        }

        /// <summary>
        /// Gets or Sets Subcategories
        /// </summary>
        [DataMember(Name = "subcategories", EmitDefaultValue = false)]
        public AppCategoryRelationshipsSubcategories Subcategories { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public AppCategoryRelationshipsParent Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCategoryRelationships {\n");
            sb.Append("  Subcategories: ").Append(Subcategories).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(input as AppCategoryRelationships);
        }

        /// <summary>
        /// Returns true if AppCategoryRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCategoryRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCategoryRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Subcategories == input.Subcategories ||
                    (this.Subcategories != null &&
                    this.Subcategories.Equals(input.Subcategories))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
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
                if (this.Subcategories != null)
                {
                    hashCode = (hashCode * 59) + this.Subcategories.GetHashCode();
                }
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
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