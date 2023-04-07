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
    /// AppStoreVersionPhasedReleaseAttributes
    /// </summary>
    [DataContract(Name = "AppStoreVersionPhasedRelease_attributes")]
    public partial class AppStoreVersionPhasedReleaseAttributes : IEquatable<AppStoreVersionPhasedReleaseAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PhasedReleaseState
        /// </summary>
        [DataMember(Name = "phasedReleaseState", EmitDefaultValue = false)]
        public PhasedReleaseState? PhasedReleaseState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseAttributes" /> class.
        /// </summary>
        /// <param name="phasedReleaseState">phasedReleaseState.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="totalPauseDuration">totalPauseDuration.</param>
        /// <param name="currentDayNumber">currentDayNumber.</param>
        public AppStoreVersionPhasedReleaseAttributes(PhasedReleaseState? phasedReleaseState = default(PhasedReleaseState?), DateTimeOffset startDate = default(DateTimeOffset), int totalPauseDuration = default(int), int currentDayNumber = default(int))
        {
            this.PhasedReleaseState = phasedReleaseState;
            this.StartDate = startDate;
            this.TotalPauseDuration = totalPauseDuration;
            this.CurrentDayNumber = currentDayNumber;
        }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalPauseDuration
        /// </summary>
        [DataMember(Name = "totalPauseDuration", EmitDefaultValue = false)]
        public int TotalPauseDuration { get; set; }

        /// <summary>
        /// Gets or Sets CurrentDayNumber
        /// </summary>
        [DataMember(Name = "currentDayNumber", EmitDefaultValue = false)]
        public int CurrentDayNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionPhasedReleaseAttributes {\n");
            sb.Append("  PhasedReleaseState: ").Append(PhasedReleaseState).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TotalPauseDuration: ").Append(TotalPauseDuration).Append("\n");
            sb.Append("  CurrentDayNumber: ").Append(CurrentDayNumber).Append("\n");
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
            return this.Equals(input as AppStoreVersionPhasedReleaseAttributes);
        }

        /// <summary>
        /// Returns true if AppStoreVersionPhasedReleaseAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionPhasedReleaseAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionPhasedReleaseAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PhasedReleaseState == input.PhasedReleaseState ||
                    this.PhasedReleaseState.Equals(input.PhasedReleaseState)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TotalPauseDuration == input.TotalPauseDuration ||
                    this.TotalPauseDuration.Equals(input.TotalPauseDuration)
                ) && 
                (
                    this.CurrentDayNumber == input.CurrentDayNumber ||
                    this.CurrentDayNumber.Equals(input.CurrentDayNumber)
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
                hashCode = (hashCode * 59) + this.PhasedReleaseState.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPauseDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentDayNumber.GetHashCode();
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