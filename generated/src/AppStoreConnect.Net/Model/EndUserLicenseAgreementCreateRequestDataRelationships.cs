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
    /// EndUserLicenseAgreementCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "EndUserLicenseAgreementCreateRequest_data_relationships")]
    public partial class EndUserLicenseAgreementCreateRequestDataRelationships : IEquatable<EndUserLicenseAgreementCreateRequestDataRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EndUserLicenseAgreementCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app">app (required).</param>
        /// <param name="territories">territories (required).</param>
        public EndUserLicenseAgreementCreateRequestDataRelationships(AppAvailabilityCreateRequestDataRelationshipsApp app = default(AppAvailabilityCreateRequestDataRelationshipsApp), AppAvailabilityCreateRequestDataRelationshipsAvailableTerritories territories = default(AppAvailabilityCreateRequestDataRelationshipsAvailableTerritories))
        {
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for EndUserLicenseAgreementCreateRequestDataRelationships and cannot be null");
            }
            this.App = app;
            // to ensure "territories" is required (not null)
            if (territories == null)
            {
                throw new ArgumentNullException("territories is a required property for EndUserLicenseAgreementCreateRequestDataRelationships and cannot be null");
            }
            this.Territories = territories;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets Territories
        /// </summary>
        [DataMember(Name = "territories", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityCreateRequestDataRelationshipsAvailableTerritories Territories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EndUserLicenseAgreementCreateRequestDataRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Territories: ").Append(Territories).Append("\n");
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
            return this.Equals(input as EndUserLicenseAgreementCreateRequestDataRelationships);
        }

        /// <summary>
        /// Returns true if EndUserLicenseAgreementCreateRequestDataRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of EndUserLicenseAgreementCreateRequestDataRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndUserLicenseAgreementCreateRequestDataRelationships input)
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
                    this.Territories == input.Territories ||
                    (this.Territories != null &&
                    this.Territories.Equals(input.Territories))
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
                if (this.Territories != null)
                {
                    hashCode = (hashCode * 59) + this.Territories.GetHashCode();
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
