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
    /// PreReleaseVersionsResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(PreReleaseVersionsResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "PreReleaseVersionsResponse_included_inner")]
    public partial class PreReleaseVersionsResponseIncludedInner : AbstractOpenAPISchema, IEquatable<PreReleaseVersionsResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreReleaseVersionsResponseIncludedInner" /> class
        /// with the <see cref="Build" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Build.</param>
        public PreReleaseVersionsResponseIncludedInner(Build actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreReleaseVersionsResponseIncludedInner" /> class
        /// with the <see cref="App" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of App.</param>
        public PreReleaseVersionsResponseIncludedInner(App actualInstance)
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
                if (value.GetType() == typeof(App))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Build))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: App, Build");
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
        /// Get the actual instance of `App`. If the actual instance is not `App`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of App</returns>
        public App GetApp()
        {
            return (App)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreReleaseVersionsResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PreReleaseVersionsResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PreReleaseVersionsResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PreReleaseVersionsResponseIncludedInner</returns>
        public static PreReleaseVersionsResponseIncludedInner FromJson(string jsonString)
        {
            PreReleaseVersionsResponseIncludedInner newPreReleaseVersionsResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPreReleaseVersionsResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(App).GetProperty("AdditionalProperties") == null)
                {
                    newPreReleaseVersionsResponseIncludedInner = new PreReleaseVersionsResponseIncludedInner(JsonConvert.DeserializeObject<App>(jsonString, PreReleaseVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newPreReleaseVersionsResponseIncludedInner = new PreReleaseVersionsResponseIncludedInner(JsonConvert.DeserializeObject<App>(jsonString, PreReleaseVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("App");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into App: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Build).GetProperty("AdditionalProperties") == null)
                {
                    newPreReleaseVersionsResponseIncludedInner = new PreReleaseVersionsResponseIncludedInner(JsonConvert.DeserializeObject<Build>(jsonString, PreReleaseVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newPreReleaseVersionsResponseIncludedInner = new PreReleaseVersionsResponseIncludedInner(JsonConvert.DeserializeObject<Build>(jsonString, PreReleaseVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Build");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Build: {1}", jsonString, exception.ToString()));
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
            return newPreReleaseVersionsResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreReleaseVersionsResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if PreReleaseVersionsResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PreReleaseVersionsResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreReleaseVersionsResponseIncludedInner input)
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
    /// Custom JSON converter for PreReleaseVersionsResponseIncludedInner
    /// </summary>
    public class PreReleaseVersionsResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PreReleaseVersionsResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return PreReleaseVersionsResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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