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
    /// AppCustomProductPageLocalizationsResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(AppCustomProductPageLocalizationsResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "AppCustomProductPageLocalizationsResponse_included_inner")]
    public partial class AppCustomProductPageLocalizationsResponseIncludedInner : AbstractOpenAPISchema, IEquatable<AppCustomProductPageLocalizationsResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationsResponseIncludedInner" /> class
        /// with the <see cref="AppCustomProductPageVersion" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppCustomProductPageVersion.</param>
        public AppCustomProductPageLocalizationsResponseIncludedInner(AppCustomProductPageVersion actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationsResponseIncludedInner" /> class
        /// with the <see cref="AppScreenshotSet" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppScreenshotSet.</param>
        public AppCustomProductPageLocalizationsResponseIncludedInner(AppScreenshotSet actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationsResponseIncludedInner" /> class
        /// with the <see cref="AppPreviewSet" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppPreviewSet.</param>
        public AppCustomProductPageLocalizationsResponseIncludedInner(AppPreviewSet actualInstance)
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
                if (value.GetType() == typeof(AppCustomProductPageVersion))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppPreviewSet))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppScreenshotSet))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppCustomProductPageVersion, AppPreviewSet, AppScreenshotSet");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppCustomProductPageVersion`. If the actual instance is not `AppCustomProductPageVersion`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppCustomProductPageVersion</returns>
        public AppCustomProductPageVersion GetAppCustomProductPageVersion()
        {
            return (AppCustomProductPageVersion)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppScreenshotSet`. If the actual instance is not `AppScreenshotSet`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppScreenshotSet</returns>
        public AppScreenshotSet GetAppScreenshotSet()
        {
            return (AppScreenshotSet)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppPreviewSet`. If the actual instance is not `AppPreviewSet`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppPreviewSet</returns>
        public AppPreviewSet GetAppPreviewSet()
        {
            return (AppPreviewSet)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCustomProductPageLocalizationsResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppCustomProductPageLocalizationsResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppCustomProductPageLocalizationsResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppCustomProductPageLocalizationsResponseIncludedInner</returns>
        public static AppCustomProductPageLocalizationsResponseIncludedInner FromJson(string jsonString)
        {
            AppCustomProductPageLocalizationsResponseIncludedInner newAppCustomProductPageLocalizationsResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppCustomProductPageLocalizationsResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppCustomProductPageVersion).GetProperty("AdditionalProperties") == null)
                {
                    newAppCustomProductPageLocalizationsResponseIncludedInner = new AppCustomProductPageLocalizationsResponseIncludedInner(JsonConvert.DeserializeObject<AppCustomProductPageVersion>(jsonString, AppCustomProductPageLocalizationsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppCustomProductPageLocalizationsResponseIncludedInner = new AppCustomProductPageLocalizationsResponseIncludedInner(JsonConvert.DeserializeObject<AppCustomProductPageVersion>(jsonString, AppCustomProductPageLocalizationsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppCustomProductPageVersion");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppCustomProductPageVersion: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppPreviewSet).GetProperty("AdditionalProperties") == null)
                {
                    newAppCustomProductPageLocalizationsResponseIncludedInner = new AppCustomProductPageLocalizationsResponseIncludedInner(JsonConvert.DeserializeObject<AppPreviewSet>(jsonString, AppCustomProductPageLocalizationsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppCustomProductPageLocalizationsResponseIncludedInner = new AppCustomProductPageLocalizationsResponseIncludedInner(JsonConvert.DeserializeObject<AppPreviewSet>(jsonString, AppCustomProductPageLocalizationsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppPreviewSet");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppPreviewSet: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppScreenshotSet).GetProperty("AdditionalProperties") == null)
                {
                    newAppCustomProductPageLocalizationsResponseIncludedInner = new AppCustomProductPageLocalizationsResponseIncludedInner(JsonConvert.DeserializeObject<AppScreenshotSet>(jsonString, AppCustomProductPageLocalizationsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppCustomProductPageLocalizationsResponseIncludedInner = new AppCustomProductPageLocalizationsResponseIncludedInner(JsonConvert.DeserializeObject<AppScreenshotSet>(jsonString, AppCustomProductPageLocalizationsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppScreenshotSet");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppScreenshotSet: {1}", jsonString, exception.ToString()));
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
            return newAppCustomProductPageLocalizationsResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppCustomProductPageLocalizationsResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if AppCustomProductPageLocalizationsResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCustomProductPageLocalizationsResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCustomProductPageLocalizationsResponseIncludedInner input)
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
    /// Custom JSON converter for AppCustomProductPageLocalizationsResponseIncludedInner
    /// </summary>
    public class AppCustomProductPageLocalizationsResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppCustomProductPageLocalizationsResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return AppCustomProductPageLocalizationsResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
