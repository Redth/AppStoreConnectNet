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
    /// ScmPullRequestAttributes
    /// </summary>
    [DataContract(Name = "ScmPullRequest_attributes")]
    public partial class ScmPullRequestAttributes : IEquatable<ScmPullRequestAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScmPullRequestAttributes" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="number">number.</param>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="sourceRepositoryOwner">sourceRepositoryOwner.</param>
        /// <param name="sourceRepositoryName">sourceRepositoryName.</param>
        /// <param name="sourceBranchName">sourceBranchName.</param>
        /// <param name="destinationRepositoryOwner">destinationRepositoryOwner.</param>
        /// <param name="destinationRepositoryName">destinationRepositoryName.</param>
        /// <param name="destinationBranchName">destinationBranchName.</param>
        /// <param name="isClosed">isClosed.</param>
        /// <param name="isCrossRepository">isCrossRepository.</param>
        public ScmPullRequestAttributes(string title = default(string), int number = default(int), string webUrl = default(string), string sourceRepositoryOwner = default(string), string sourceRepositoryName = default(string), string sourceBranchName = default(string), string destinationRepositoryOwner = default(string), string destinationRepositoryName = default(string), string destinationBranchName = default(string), bool isClosed = default(bool), bool isCrossRepository = default(bool))
        {
            this.Title = title;
            this.Number = number;
            this.WebUrl = webUrl;
            this.SourceRepositoryOwner = sourceRepositoryOwner;
            this.SourceRepositoryName = sourceRepositoryName;
            this.SourceBranchName = sourceBranchName;
            this.DestinationRepositoryOwner = destinationRepositoryOwner;
            this.DestinationRepositoryName = destinationRepositoryName;
            this.DestinationBranchName = destinationBranchName;
            this.IsClosed = isClosed;
            this.IsCrossRepository = isCrossRepository;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = false)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets SourceRepositoryOwner
        /// </summary>
        [DataMember(Name = "sourceRepositoryOwner", EmitDefaultValue = false)]
        public string SourceRepositoryOwner { get; set; }

        /// <summary>
        /// Gets or Sets SourceRepositoryName
        /// </summary>
        [DataMember(Name = "sourceRepositoryName", EmitDefaultValue = false)]
        public string SourceRepositoryName { get; set; }

        /// <summary>
        /// Gets or Sets SourceBranchName
        /// </summary>
        [DataMember(Name = "sourceBranchName", EmitDefaultValue = false)]
        public string SourceBranchName { get; set; }

        /// <summary>
        /// Gets or Sets DestinationRepositoryOwner
        /// </summary>
        [DataMember(Name = "destinationRepositoryOwner", EmitDefaultValue = false)]
        public string DestinationRepositoryOwner { get; set; }

        /// <summary>
        /// Gets or Sets DestinationRepositoryName
        /// </summary>
        [DataMember(Name = "destinationRepositoryName", EmitDefaultValue = false)]
        public string DestinationRepositoryName { get; set; }

        /// <summary>
        /// Gets or Sets DestinationBranchName
        /// </summary>
        [DataMember(Name = "destinationBranchName", EmitDefaultValue = false)]
        public string DestinationBranchName { get; set; }

        /// <summary>
        /// Gets or Sets IsClosed
        /// </summary>
        [DataMember(Name = "isClosed", EmitDefaultValue = true)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Gets or Sets IsCrossRepository
        /// </summary>
        [DataMember(Name = "isCrossRepository", EmitDefaultValue = true)]
        public bool IsCrossRepository { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScmPullRequestAttributes {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  SourceRepositoryOwner: ").Append(SourceRepositoryOwner).Append("\n");
            sb.Append("  SourceRepositoryName: ").Append(SourceRepositoryName).Append("\n");
            sb.Append("  SourceBranchName: ").Append(SourceBranchName).Append("\n");
            sb.Append("  DestinationRepositoryOwner: ").Append(DestinationRepositoryOwner).Append("\n");
            sb.Append("  DestinationRepositoryName: ").Append(DestinationRepositoryName).Append("\n");
            sb.Append("  DestinationBranchName: ").Append(DestinationBranchName).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  IsCrossRepository: ").Append(IsCrossRepository).Append("\n");
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
            return this.Equals(input as ScmPullRequestAttributes);
        }

        /// <summary>
        /// Returns true if ScmPullRequestAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ScmPullRequestAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScmPullRequestAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.SourceRepositoryOwner == input.SourceRepositoryOwner ||
                    (this.SourceRepositoryOwner != null &&
                    this.SourceRepositoryOwner.Equals(input.SourceRepositoryOwner))
                ) && 
                (
                    this.SourceRepositoryName == input.SourceRepositoryName ||
                    (this.SourceRepositoryName != null &&
                    this.SourceRepositoryName.Equals(input.SourceRepositoryName))
                ) && 
                (
                    this.SourceBranchName == input.SourceBranchName ||
                    (this.SourceBranchName != null &&
                    this.SourceBranchName.Equals(input.SourceBranchName))
                ) && 
                (
                    this.DestinationRepositoryOwner == input.DestinationRepositoryOwner ||
                    (this.DestinationRepositoryOwner != null &&
                    this.DestinationRepositoryOwner.Equals(input.DestinationRepositoryOwner))
                ) && 
                (
                    this.DestinationRepositoryName == input.DestinationRepositoryName ||
                    (this.DestinationRepositoryName != null &&
                    this.DestinationRepositoryName.Equals(input.DestinationRepositoryName))
                ) && 
                (
                    this.DestinationBranchName == input.DestinationBranchName ||
                    (this.DestinationBranchName != null &&
                    this.DestinationBranchName.Equals(input.DestinationBranchName))
                ) && 
                (
                    this.IsClosed == input.IsClosed ||
                    this.IsClosed.Equals(input.IsClosed)
                ) && 
                (
                    this.IsCrossRepository == input.IsCrossRepository ||
                    this.IsCrossRepository.Equals(input.IsCrossRepository)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.WebUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WebUrl.GetHashCode();
                }
                if (this.SourceRepositoryOwner != null)
                {
                    hashCode = (hashCode * 59) + this.SourceRepositoryOwner.GetHashCode();
                }
                if (this.SourceRepositoryName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceRepositoryName.GetHashCode();
                }
                if (this.SourceBranchName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceBranchName.GetHashCode();
                }
                if (this.DestinationRepositoryOwner != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationRepositoryOwner.GetHashCode();
                }
                if (this.DestinationRepositoryName != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationRepositoryName.GetHashCode();
                }
                if (this.DestinationBranchName != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationBranchName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsClosed.GetHashCode();
                hashCode = (hashCode * 59) + this.IsCrossRepository.GetHashCode();
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
