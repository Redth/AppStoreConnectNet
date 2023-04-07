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
    /// ScmRepositoryAttributes
    /// </summary>
    [DataContract(Name = "ScmRepository_attributes")]
    public partial class ScmRepositoryAttributes : IEquatable<ScmRepositoryAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScmRepositoryAttributes" /> class.
        /// </summary>
        /// <param name="lastAccessedDate">lastAccessedDate.</param>
        /// <param name="httpCloneUrl">httpCloneUrl.</param>
        /// <param name="sshCloneUrl">sshCloneUrl.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="repositoryName">repositoryName.</param>
        public ScmRepositoryAttributes(DateTimeOffset lastAccessedDate = default(DateTimeOffset), string httpCloneUrl = default(string), string sshCloneUrl = default(string), string ownerName = default(string), string repositoryName = default(string))
        {
            this.LastAccessedDate = lastAccessedDate;
            this.HttpCloneUrl = httpCloneUrl;
            this.SshCloneUrl = sshCloneUrl;
            this.OwnerName = ownerName;
            this.RepositoryName = repositoryName;
        }

        /// <summary>
        /// Gets or Sets LastAccessedDate
        /// </summary>
        [DataMember(Name = "lastAccessedDate", EmitDefaultValue = false)]
        public DateTimeOffset LastAccessedDate { get; set; }

        /// <summary>
        /// Gets or Sets HttpCloneUrl
        /// </summary>
        [DataMember(Name = "httpCloneUrl", EmitDefaultValue = false)]
        public string HttpCloneUrl { get; set; }

        /// <summary>
        /// Gets or Sets SshCloneUrl
        /// </summary>
        [DataMember(Name = "sshCloneUrl", EmitDefaultValue = false)]
        public string SshCloneUrl { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets RepositoryName
        /// </summary>
        [DataMember(Name = "repositoryName", EmitDefaultValue = false)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScmRepositoryAttributes {\n");
            sb.Append("  LastAccessedDate: ").Append(LastAccessedDate).Append("\n");
            sb.Append("  HttpCloneUrl: ").Append(HttpCloneUrl).Append("\n");
            sb.Append("  SshCloneUrl: ").Append(SshCloneUrl).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  RepositoryName: ").Append(RepositoryName).Append("\n");
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
            return this.Equals(input as ScmRepositoryAttributes);
        }

        /// <summary>
        /// Returns true if ScmRepositoryAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ScmRepositoryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScmRepositoryAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LastAccessedDate == input.LastAccessedDate ||
                    (this.LastAccessedDate != null &&
                    this.LastAccessedDate.Equals(input.LastAccessedDate))
                ) && 
                (
                    this.HttpCloneUrl == input.HttpCloneUrl ||
                    (this.HttpCloneUrl != null &&
                    this.HttpCloneUrl.Equals(input.HttpCloneUrl))
                ) && 
                (
                    this.SshCloneUrl == input.SshCloneUrl ||
                    (this.SshCloneUrl != null &&
                    this.SshCloneUrl.Equals(input.SshCloneUrl))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.RepositoryName == input.RepositoryName ||
                    (this.RepositoryName != null &&
                    this.RepositoryName.Equals(input.RepositoryName))
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
                if (this.LastAccessedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastAccessedDate.GetHashCode();
                }
                if (this.HttpCloneUrl != null)
                {
                    hashCode = (hashCode * 59) + this.HttpCloneUrl.GetHashCode();
                }
                if (this.SshCloneUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SshCloneUrl.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.RepositoryName != null)
                {
                    hashCode = (hashCode * 59) + this.RepositoryName.GetHashCode();
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
