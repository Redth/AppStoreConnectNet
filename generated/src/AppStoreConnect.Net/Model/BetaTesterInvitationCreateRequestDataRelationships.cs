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
    /// BetaTesterInvitationCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "BetaTesterInvitationCreateRequest_data_relationships")]
    public partial class BetaTesterInvitationCreateRequestDataRelationships : IEquatable<BetaTesterInvitationCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaTesterInvitationCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="betaTester">betaTester (required).</param>
        /// <param name="app">app (required).</param>
        public BetaTesterInvitationCreateRequestDataRelationships(BetaTesterInvitationCreateRequestDataRelationshipsBetaTester betaTester = default(BetaTesterInvitationCreateRequestDataRelationshipsBetaTester), AppAvailabilityCreateRequestDataRelationshipsApp app = default(AppAvailabilityCreateRequestDataRelationshipsApp))
        {
            // to ensure "betaTester" is required (not null)
            if (betaTester == null)
            {
                throw new ArgumentNullException("betaTester is a required property for BetaTesterInvitationCreateRequestDataRelationships and cannot be null");
            }
            this.BetaTester = betaTester;
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for BetaTesterInvitationCreateRequestDataRelationships and cannot be null");
            }
            this.App = app;
        }

        /// <summary>
        /// Gets or Sets BetaTester
        /// </summary>
        [DataMember(Name = "betaTester", IsRequired = true, EmitDefaultValue = true)]
        public BetaTesterInvitationCreateRequestDataRelationshipsBetaTester BetaTester { get; set; }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaTesterInvitationCreateRequestDataRelationships {\n");
            sb.Append("  BetaTester: ").Append(BetaTester).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
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
            return this.Equals(input as BetaTesterInvitationCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if BetaTesterInvitationCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaTesterInvitationCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaTesterInvitationCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BetaTester == input.BetaTester ||
                    (this.BetaTester != null &&
                    this.BetaTester.Equals(input.BetaTester))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
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
                if (this.BetaTester != null)
                {
                    hashCode = (hashCode * 59) + this.BetaTester.GetHashCode();
                }
                if (this.App != null)
                {
                    hashCode = (hashCode * 59) + this.App.GetHashCode();
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
