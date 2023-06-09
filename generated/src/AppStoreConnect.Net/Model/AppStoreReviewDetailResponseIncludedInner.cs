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
    /// AppStoreReviewDetailResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(AppStoreReviewDetailResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "AppStoreReviewDetailResponse_included_inner")]
    public partial class AppStoreReviewDetailResponseIncludedInner : AbstractOpenAPISchema, IEquatable<AppStoreReviewDetailResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersion" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersion.</param>
        public AppStoreReviewDetailResponseIncludedInner(AppStoreVersion actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailResponseIncludedInner" /> class
        /// with the <see cref="AppStoreReviewAttachment" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreReviewAttachment.</param>
        public AppStoreReviewDetailResponseIncludedInner(AppStoreReviewAttachment actualInstance)
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
                if (value.GetType() == typeof(AppStoreReviewAttachment))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersion))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppStoreReviewAttachment, AppStoreVersion");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppStoreVersion`. If the actual instance is not `AppStoreVersion`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreVersion</returns>
        public AppStoreVersion GetAppStoreVersion()
        {
            return (AppStoreVersion)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppStoreReviewAttachment`. If the actual instance is not `AppStoreReviewAttachment`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreReviewAttachment</returns>
        public AppStoreReviewAttachment GetAppStoreReviewAttachment()
        {
            return (AppStoreReviewAttachment)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreReviewDetailResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppStoreReviewDetailResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppStoreReviewDetailResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppStoreReviewDetailResponseIncludedInner</returns>
        public static AppStoreReviewDetailResponseIncludedInner FromJson(string jsonString)
        {
            AppStoreReviewDetailResponseIncludedInner newAppStoreReviewDetailResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppStoreReviewDetailResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreReviewAttachment).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreReviewDetailResponseIncludedInner = new AppStoreReviewDetailResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreReviewAttachment>(jsonString, AppStoreReviewDetailResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreReviewDetailResponseIncludedInner = new AppStoreReviewDetailResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreReviewAttachment>(jsonString, AppStoreReviewDetailResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreReviewAttachment");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreReviewAttachment: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersion).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreReviewDetailResponseIncludedInner = new AppStoreReviewDetailResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersion>(jsonString, AppStoreReviewDetailResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreReviewDetailResponseIncludedInner = new AppStoreReviewDetailResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersion>(jsonString, AppStoreReviewDetailResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersion");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersion: {1}", jsonString, exception.ToString()));
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
            return newAppStoreReviewDetailResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppStoreReviewDetailResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if AppStoreReviewDetailResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreReviewDetailResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreReviewDetailResponseIncludedInner input)
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
    /// Custom JSON converter for AppStoreReviewDetailResponseIncludedInner
    /// </summary>
    public class AppStoreReviewDetailResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppStoreReviewDetailResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return AppStoreReviewDetailResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
