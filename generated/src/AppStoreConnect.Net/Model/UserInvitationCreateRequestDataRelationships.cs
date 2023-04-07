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
    /// UserInvitationCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "UserInvitationCreateRequest_data_relationships")]
    public partial class UserInvitationCreateRequestDataRelationships : IEquatable<UserInvitationCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="visibleApps">visibleApps.</param>
        public UserInvitationCreateRequestDataRelationships(UserInvitationCreateRequestDataRelationshipsVisibleApps visibleApps = default(UserInvitationCreateRequestDataRelationshipsVisibleApps))
        {
            this.VisibleApps = visibleApps;
        }

        /// <summary>
        /// Gets or Sets VisibleApps
        /// </summary>
        [DataMember(Name = "visibleApps", EmitDefaultValue = false)]
        public UserInvitationCreateRequestDataRelationshipsVisibleApps VisibleApps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserInvitationCreateRequestDataRelationships {\n");
            sb.Append("  VisibleApps: ").Append(VisibleApps).Append("\n");
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
            return this.Equals(input as UserInvitationCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if UserInvitationCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInvitationCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VisibleApps == input.VisibleApps ||
                    (this.VisibleApps != null &&
                    this.VisibleApps.Equals(input.VisibleApps))
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
                if (this.VisibleApps != null)
                {
                    hashCode = (hashCode * 59) + this.VisibleApps.GetHashCode();
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