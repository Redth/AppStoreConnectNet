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
using System.Reflection;

namespace AppStoreConnect.Model
{
    /// <summary>
    /// CiBuildRunsResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(CiBuildRunsResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "CiBuildRunsResponse_included_inner")]
    public partial class CiBuildRunsResponseIncludedInner : AbstractOpenAPISchema, IEquatable<CiBuildRunsResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunsResponseIncludedInner" /> class
        /// with the <see cref="Build" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Build.</param>
        public CiBuildRunsResponseIncludedInner(Build actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunsResponseIncludedInner" /> class
        /// with the <see cref="CiWorkflow" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CiWorkflow.</param>
        public CiBuildRunsResponseIncludedInner(CiWorkflow actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunsResponseIncludedInner" /> class
        /// with the <see cref="CiProduct" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CiProduct.</param>
        public CiBuildRunsResponseIncludedInner(CiProduct actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunsResponseIncludedInner" /> class
        /// with the <see cref="ScmGitReference" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ScmGitReference.</param>
        public CiBuildRunsResponseIncludedInner(ScmGitReference actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="CiBuildRunsResponseIncludedInner" /> class
        ///// with the <see cref="ScmGitReference" /> class
        ///// </summary>
        ///// <param name="actualInstance">An instance of ScmGitReference.</param>
        //public CiBuildRunsResponseIncludedInner(ScmGitReference actualInstance)
        //{
        //    this.IsNullable = false;
        //    this.SchemaType= "oneOf";
        //    this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        //}

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunsResponseIncludedInner" /> class
        /// with the <see cref="ScmPullRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ScmPullRequest.</param>
        public CiBuildRunsResponseIncludedInner(ScmPullRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Build))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CiProduct))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CiWorkflow))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ScmGitReference))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ScmPullRequest))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Build, CiProduct, CiWorkflow, ScmGitReference, ScmPullRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Build`. If the actual instance is not `Build`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Build</returns>
        public Build GetBuild()
        {
            return (Build)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CiWorkflow`. If the actual instance is not `CiWorkflow`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CiWorkflow</returns>
        public CiWorkflow GetCiWorkflow()
        {
            return (CiWorkflow)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CiProduct`. If the actual instance is not `CiProduct`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CiProduct</returns>
        public CiProduct GetCiProduct()
        {
            return (CiProduct)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ScmGitReference`. If the actual instance is not `ScmGitReference`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ScmGitReference</returns>
        public ScmGitReference GetScmGitReference()
        {
            return (ScmGitReference)this.ActualInstance;
        }

        ///// <summary>
        ///// Get the actual instance of `ScmGitReference`. If the actual instance is not `ScmGitReference`,
        ///// the InvalidClassException will be thrown
        ///// </summary>
        ///// <returns>An instance of ScmGitReference</returns>
        //public ScmGitReference GetScmGitReference()
        //{
        //    return (ScmGitReference)this.ActualInstance;
        //}

        /// <summary>
        /// Get the actual instance of `ScmPullRequest`. If the actual instance is not `ScmPullRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ScmPullRequest</returns>
        public ScmPullRequest GetScmPullRequest()
        {
            return (ScmPullRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CiBuildRunsResponseIncludedInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, CiBuildRunsResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CiBuildRunsResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CiBuildRunsResponseIncludedInner</returns>
        public static CiBuildRunsResponseIncludedInner FromJson(string jsonString)
        {
            CiBuildRunsResponseIncludedInner newCiBuildRunsResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCiBuildRunsResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Build).GetProperty("AdditionalProperties") == null)
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<Build>(jsonString, CiBuildRunsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<Build>(jsonString, CiBuildRunsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Build");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Build: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CiProduct).GetProperty("AdditionalProperties") == null)
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<CiProduct>(jsonString, CiBuildRunsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<CiProduct>(jsonString, CiBuildRunsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CiProduct");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CiProduct: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CiWorkflow).GetProperty("AdditionalProperties") == null)
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<CiWorkflow>(jsonString, CiBuildRunsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<CiWorkflow>(jsonString, CiBuildRunsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CiWorkflow");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CiWorkflow: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ScmGitReference).GetProperty("AdditionalProperties") == null)
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<ScmGitReference>(jsonString, CiBuildRunsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<ScmGitReference>(jsonString, CiBuildRunsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ScmGitReference");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ScmGitReference: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ScmPullRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<ScmPullRequest>(jsonString, CiBuildRunsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newCiBuildRunsResponseIncludedInner = new CiBuildRunsResponseIncludedInner(JsonConvert.DeserializeObject<ScmPullRequest>(jsonString, CiBuildRunsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ScmPullRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ScmPullRequest: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newCiBuildRunsResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CiBuildRunsResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if CiBuildRunsResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CiBuildRunsResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CiBuildRunsResponseIncludedInner input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for CiBuildRunsResponseIncludedInner
    /// </summary>
    public class CiBuildRunsResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CiBuildRunsResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return CiBuildRunsResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
