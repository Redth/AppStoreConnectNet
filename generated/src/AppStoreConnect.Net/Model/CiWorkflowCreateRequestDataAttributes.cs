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
    /// CiWorkflowCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "CiWorkflowCreateRequest_data_attributes")]
    public partial class CiWorkflowCreateRequestDataAttributes : IEquatable<CiWorkflowCreateRequestDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CiWorkflowCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="branchStartCondition">branchStartCondition.</param>
        /// <param name="tagStartCondition">tagStartCondition.</param>
        /// <param name="pullRequestStartCondition">pullRequestStartCondition.</param>
        /// <param name="scheduledStartCondition">scheduledStartCondition.</param>
        /// <param name="actions">actions (required).</param>
        /// <param name="isEnabled">isEnabled (required).</param>
        /// <param name="isLockedForEditing">isLockedForEditing.</param>
        /// <param name="clean">clean (required).</param>
        /// <param name="containerFilePath">containerFilePath (required).</param>
        public CiWorkflowCreateRequestDataAttributes(string name = default(string), string description = default(string), CiBranchStartCondition branchStartCondition = default(CiBranchStartCondition), CiTagStartCondition tagStartCondition = default(CiTagStartCondition), CiPullRequestStartCondition pullRequestStartCondition = default(CiPullRequestStartCondition), CiScheduledStartCondition scheduledStartCondition = default(CiScheduledStartCondition), List<CiAction> actions = default(List<CiAction>), bool isEnabled = default(bool), bool isLockedForEditing = default(bool), bool clean = default(bool), string containerFilePath = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CiWorkflowCreateRequestDataAttributes and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for CiWorkflowCreateRequestDataAttributes and cannot be null");
            }
            this.Description = description;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for CiWorkflowCreateRequestDataAttributes and cannot be null");
            }
            this.Actions = actions;
            this.IsEnabled = isEnabled;
            this.Clean = clean;
            // to ensure "containerFilePath" is required (not null)
            if (containerFilePath == null)
            {
                throw new ArgumentNullException("containerFilePath is a required property for CiWorkflowCreateRequestDataAttributes and cannot be null");
            }
            this.ContainerFilePath = containerFilePath;
            this.BranchStartCondition = branchStartCondition;
            this.TagStartCondition = tagStartCondition;
            this.PullRequestStartCondition = pullRequestStartCondition;
            this.ScheduledStartCondition = scheduledStartCondition;
            this.IsLockedForEditing = isLockedForEditing;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets BranchStartCondition
        /// </summary>
        [DataMember(Name = "branchStartCondition", EmitDefaultValue = false)]
        public CiBranchStartCondition BranchStartCondition { get; set; }

        /// <summary>
        /// Gets or Sets TagStartCondition
        /// </summary>
        [DataMember(Name = "tagStartCondition", EmitDefaultValue = false)]
        public CiTagStartCondition TagStartCondition { get; set; }

        /// <summary>
        /// Gets or Sets PullRequestStartCondition
        /// </summary>
        [DataMember(Name = "pullRequestStartCondition", EmitDefaultValue = false)]
        public CiPullRequestStartCondition PullRequestStartCondition { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledStartCondition
        /// </summary>
        [DataMember(Name = "scheduledStartCondition", EmitDefaultValue = false)]
        public CiScheduledStartCondition ScheduledStartCondition { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<CiAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsLockedForEditing
        /// </summary>
        [DataMember(Name = "isLockedForEditing", EmitDefaultValue = true)]
        public bool IsLockedForEditing { get; set; }

        /// <summary>
        /// Gets or Sets Clean
        /// </summary>
        [DataMember(Name = "clean", IsRequired = true, EmitDefaultValue = true)]
        public bool Clean { get; set; }

        /// <summary>
        /// Gets or Sets ContainerFilePath
        /// </summary>
        [DataMember(Name = "containerFilePath", IsRequired = true, EmitDefaultValue = true)]
        public string ContainerFilePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiWorkflowCreateRequestDataAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BranchStartCondition: ").Append(BranchStartCondition).Append("\n");
            sb.Append("  TagStartCondition: ").Append(TagStartCondition).Append("\n");
            sb.Append("  PullRequestStartCondition: ").Append(PullRequestStartCondition).Append("\n");
            sb.Append("  ScheduledStartCondition: ").Append(ScheduledStartCondition).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsLockedForEditing: ").Append(IsLockedForEditing).Append("\n");
            sb.Append("  Clean: ").Append(Clean).Append("\n");
            sb.Append("  ContainerFilePath: ").Append(ContainerFilePath).Append("\n");
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
            return this.Equals(input as CiWorkflowCreateRequestDataAttributes);
        }

        /// <summary>
        /// Returns true if CiWorkflowCreateRequestDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of CiWorkflowCreateRequestDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiWorkflowCreateRequestDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.BranchStartCondition == input.BranchStartCondition ||
                    (this.BranchStartCondition != null &&
                    this.BranchStartCondition.Equals(input.BranchStartCondition))
                ) && 
                (
                    this.TagStartCondition == input.TagStartCondition ||
                    (this.TagStartCondition != null &&
                    this.TagStartCondition.Equals(input.TagStartCondition))
                ) && 
                (
                    this.PullRequestStartCondition == input.PullRequestStartCondition ||
                    (this.PullRequestStartCondition != null &&
                    this.PullRequestStartCondition.Equals(input.PullRequestStartCondition))
                ) && 
                (
                    this.ScheduledStartCondition == input.ScheduledStartCondition ||
                    (this.ScheduledStartCondition != null &&
                    this.ScheduledStartCondition.Equals(input.ScheduledStartCondition))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.IsLockedForEditing == input.IsLockedForEditing ||
                    this.IsLockedForEditing.Equals(input.IsLockedForEditing)
                ) && 
                (
                    this.Clean == input.Clean ||
                    this.Clean.Equals(input.Clean)
                ) && 
                (
                    this.ContainerFilePath == input.ContainerFilePath ||
                    (this.ContainerFilePath != null &&
                    this.ContainerFilePath.Equals(input.ContainerFilePath))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.BranchStartCondition != null)
                {
                    hashCode = (hashCode * 59) + this.BranchStartCondition.GetHashCode();
                }
                if (this.TagStartCondition != null)
                {
                    hashCode = (hashCode * 59) + this.TagStartCondition.GetHashCode();
                }
                if (this.PullRequestStartCondition != null)
                {
                    hashCode = (hashCode * 59) + this.PullRequestStartCondition.GetHashCode();
                }
                if (this.ScheduledStartCondition != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledStartCondition.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.IsLockedForEditing.GetHashCode();
                hashCode = (hashCode * 59) + this.Clean.GetHashCode();
                if (this.ContainerFilePath != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerFilePath.GetHashCode();
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
