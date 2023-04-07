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
    /// AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress
    /// </summary>
    [DataContract(Name = "AppClipAdvancedExperience_attributes_place_mainAddress_structuredAddress")]
    public partial class AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress : IEquatable<AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress" /> class.
        /// </summary>
        /// <param name="streetAddress">streetAddress.</param>
        /// <param name="floor">floor.</param>
        /// <param name="neighborhood">neighborhood.</param>
        /// <param name="locality">locality.</param>
        /// <param name="stateProvince">stateProvince.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="countryCode">countryCode.</param>
        public AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress(List<string> streetAddress = default(List<string>), string floor = default(string), string neighborhood = default(string), string locality = default(string), string stateProvince = default(string), string postalCode = default(string), string countryCode = default(string))
        {
            this.StreetAddress = streetAddress;
            this.Floor = floor;
            this.Neighborhood = neighborhood;
            this.Locality = locality;
            this.StateProvince = stateProvince;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public List<string> StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets Floor
        /// </summary>
        [DataMember(Name = "floor", EmitDefaultValue = false)]
        public string Floor { get; set; }

        /// <summary>
        /// Gets or Sets Neighborhood
        /// </summary>
        [DataMember(Name = "neighborhood", EmitDefaultValue = false)]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name = "locality", EmitDefaultValue = false)]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        [DataMember(Name = "stateProvince", EmitDefaultValue = false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress {\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  Floor: ").Append(Floor).Append("\n");
            sb.Append("  Neighborhood: ").Append(Neighborhood).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress);
        }

        /// <summary>
        /// Returns true if AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppClipAdvancedExperienceAttributesPlaceMainAddressStructuredAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StreetAddress == input.StreetAddress ||
                    this.StreetAddress != null &&
                    input.StreetAddress != null &&
                    this.StreetAddress.SequenceEqual(input.StreetAddress)
                ) && 
                (
                    this.Floor == input.Floor ||
                    (this.Floor != null &&
                    this.Floor.Equals(input.Floor))
                ) && 
                (
                    this.Neighborhood == input.Neighborhood ||
                    (this.Neighborhood != null &&
                    this.Neighborhood.Equals(input.Neighborhood))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.StreetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress.GetHashCode();
                }
                if (this.Floor != null)
                {
                    hashCode = (hashCode * 59) + this.Floor.GetHashCode();
                }
                if (this.Neighborhood != null)
                {
                    hashCode = (hashCode * 59) + this.Neighborhood.GetHashCode();
                }
                if (this.Locality != null)
                {
                    hashCode = (hashCode * 59) + this.Locality.GetHashCode();
                }
                if (this.StateProvince != null)
                {
                    hashCode = (hashCode * 59) + this.StateProvince.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
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