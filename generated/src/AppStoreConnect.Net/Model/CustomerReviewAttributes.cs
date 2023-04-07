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
    /// CustomerReviewAttributes
    /// </summary>
    [DataContract(Name = "CustomerReview_attributes")]
    public partial class CustomerReviewAttributes : IEquatable<CustomerReviewAttributes>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Territory
        /// </summary>
        [DataMember(Name = "territory", EmitDefaultValue = false)]
        public TerritoryCode? Territory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewAttributes" /> class.
        /// </summary>
        /// <param name="rating">rating.</param>
        /// <param name="title">title.</param>
        /// <param name="body">body.</param>
        /// <param name="reviewerNickname">reviewerNickname.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="territory">territory.</param>
        public CustomerReviewAttributes(int rating = default(int), string title = default(string), string body = default(string), string reviewerNickname = default(string), DateTimeOffset createdDate = default(DateTimeOffset), TerritoryCode? territory = default(TerritoryCode?))
        {
            this.Rating = rating;
            this.Title = title;
            this.Body = body;
            this.ReviewerNickname = reviewerNickname;
            this.CreatedDate = createdDate;
            this.Territory = territory;
        }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets ReviewerNickname
        /// </summary>
        [DataMember(Name = "reviewerNickname", EmitDefaultValue = false)]
        public string ReviewerNickname { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerReviewAttributes {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ReviewerNickname: ").Append(ReviewerNickname).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Territory: ").Append(Territory).Append("\n");
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
            return this.Equals(input as CustomerReviewAttributes);
        }

        /// <summary>
        /// Returns true if CustomerReviewAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerReviewAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerReviewAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.ReviewerNickname == input.ReviewerNickname ||
                    (this.ReviewerNickname != null &&
                    this.ReviewerNickname.Equals(input.ReviewerNickname))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Territory == input.Territory ||
                    this.Territory.Equals(input.Territory)
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
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.ReviewerNickname != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewerNickname.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Territory.GetHashCode();
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
            // Rating (int) maximum
            if (this.Rating > (int)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rating, must be a value less than or equal to 5.", new [] { "Rating" });
            }

            // Rating (int) minimum
            if (this.Rating < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rating, must be a value greater than or equal to 1.", new [] { "Rating" });
            }

            yield break;
        }
    }

}
