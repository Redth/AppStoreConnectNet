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
    /// BetaGroupCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "BetaGroupCreateRequest_data_relationships")]
    public partial class BetaGroupCreateRequestDataRelationships : IEquatable<BetaGroupCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaGroupCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app">app (required).</param>
        /// <param name="builds">builds.</param>
        /// <param name="betaTesters">betaTesters.</param>
        public BetaGroupCreateRequestDataRelationships(AppAvailabilityCreateRequestDataRelationshipsApp app = default(AppAvailabilityCreateRequestDataRelationshipsApp), BetaGroupCreateRequestDataRelationshipsBuilds builds = default(BetaGroupCreateRequestDataRelationshipsBuilds), BetaGroupCreateRequestDataRelationshipsBetaTesters betaTesters = default(BetaGroupCreateRequestDataRelationshipsBetaTesters))
        {
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for BetaGroupCreateRequestDataRelationships and cannot be null");
            }
            this.App = app;
            this.Builds = builds;
            this.BetaTesters = betaTesters;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets Builds
        /// </summary>
        [DataMember(Name = "builds", EmitDefaultValue = false)]
        public BetaGroupCreateRequestDataRelationshipsBuilds Builds { get; set; }

        /// <summary>
        /// Gets or Sets BetaTesters
        /// </summary>
        [DataMember(Name = "betaTesters", EmitDefaultValue = false)]
        public BetaGroupCreateRequestDataRelationshipsBetaTesters BetaTesters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaGroupCreateRequestDataRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Builds: ").Append(Builds).Append("\n");
            sb.Append("  BetaTesters: ").Append(BetaTesters).Append("\n");
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
            return this.Equals(input as BetaGroupCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if BetaGroupCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of BetaGroupCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BetaGroupCreateRequestDataRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Builds == input.Builds ||
                    (this.Builds != null &&
                    this.Builds.Equals(input.Builds))
                ) && 
                (
                    this.BetaTesters == input.BetaTesters ||
                    (this.BetaTesters != null &&
                    this.BetaTesters.Equals(input.BetaTesters))
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
                if (this.App != null)
                {
                    hashCode = (hashCode * 59) + this.App.GetHashCode();
                }
                if (this.Builds != null)
                {
                    hashCode = (hashCode * 59) + this.Builds.GetHashCode();
                }
                if (this.BetaTesters != null)
                {
                    hashCode = (hashCode * 59) + this.BetaTesters.GetHashCode();
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