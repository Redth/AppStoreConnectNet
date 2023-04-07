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
    /// CiFilesAndFoldersRule
    /// </summary>
    [DataContract(Name = "CiFilesAndFoldersRule")]
    public partial class CiFilesAndFoldersRule : IEquatable<CiFilesAndFoldersRule>, IValidatableObject
    {
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum STARTIFANYFILEMATCHES for value: START_IF_ANY_FILE_MATCHES
            /// </summary>
            [EnumMember(Value = "START_IF_ANY_FILE_MATCHES")]
            STARTIFANYFILEMATCHES = 1,

            /// <summary>
            /// Enum DONOTSTARTIFALLFILESMATCH for value: DO_NOT_START_IF_ALL_FILES_MATCH
            /// </summary>
            [EnumMember(Value = "DO_NOT_START_IF_ALL_FILES_MATCH")]
            DONOTSTARTIFALLFILESMATCH = 2

        }


        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiFilesAndFoldersRule" /> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="matchers">matchers.</param>
        public CiFilesAndFoldersRule(ModeEnum? mode = default(ModeEnum?), List<CiStartConditionFileMatcher> matchers = default(List<CiStartConditionFileMatcher>))
        {
            this.Mode = mode;
            this.Matchers = matchers;
        }

        /// <summary>
        /// Gets or Sets Matchers
        /// </summary>
        [DataMember(Name = "matchers", EmitDefaultValue = false)]
        public List<CiStartConditionFileMatcher> Matchers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiFilesAndFoldersRule {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Matchers: ").Append(Matchers).Append("\n");
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
            return this.Equals(input as CiFilesAndFoldersRule);
        }

        /// <summary>
        /// Returns true if CiFilesAndFoldersRule instances are equal
        /// </summary>
        /// <param name="input">Instance of CiFilesAndFoldersRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiFilesAndFoldersRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.Matchers == input.Matchers ||
                    this.Matchers != null &&
                    input.Matchers != null &&
                    this.Matchers.SequenceEqual(input.Matchers)
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
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                if (this.Matchers != null)
                {
                    hashCode = (hashCode * 59) + this.Matchers.GetHashCode();
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
