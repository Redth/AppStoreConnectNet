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
    /// AppScreenshotSetsResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(AppScreenshotSetsResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "AppScreenshotSetsResponse_included_inner")]
    public partial class AppScreenshotSetsResponseIncludedInner : AbstractOpenAPISchema, IEquatable<AppScreenshotSetsResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersionLocalization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersionLocalization.</param>
        public AppScreenshotSetsResponseIncludedInner(AppStoreVersionLocalization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetsResponseIncludedInner" /> class
        /// with the <see cref="AppCustomProductPageLocalization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppCustomProductPageLocalization.</param>
        public AppScreenshotSetsResponseIncludedInner(AppCustomProductPageLocalization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersionExperimentTreatmentLocalization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersionExperimentTreatmentLocalization.</param>
        public AppScreenshotSetsResponseIncludedInner(AppStoreVersionExperimentTreatmentLocalization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetsResponseIncludedInner" /> class
        /// with the <see cref="AppScreenshot" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppScreenshot.</param>
        public AppScreenshotSetsResponseIncludedInner(AppScreenshot actualInstance)
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
                if (value.GetType() == typeof(AppCustomProductPageLocalization))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppScreenshot))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersionExperimentTreatmentLocalization))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersionLocalization))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppCustomProductPageLocalization, AppScreenshot, AppStoreVersionExperimentTreatmentLocalization, AppStoreVersionLocalization");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppStoreVersionLocalization`. If the actual instance is not `AppStoreVersionLocalization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreVersionLocalization</returns>
        public AppStoreVersionLocalization GetAppStoreVersionLocalization()
        {
            return (AppStoreVersionLocalization)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppCustomProductPageLocalization`. If the actual instance is not `AppCustomProductPageLocalization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppCustomProductPageLocalization</returns>
        public AppCustomProductPageLocalization GetAppCustomProductPageLocalization()
        {
            return (AppCustomProductPageLocalization)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppStoreVersionExperimentTreatmentLocalization`. If the actual instance is not `AppStoreVersionExperimentTreatmentLocalization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreVersionExperimentTreatmentLocalization</returns>
        public AppStoreVersionExperimentTreatmentLocalization GetAppStoreVersionExperimentTreatmentLocalization()
        {
            return (AppStoreVersionExperimentTreatmentLocalization)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppScreenshot`. If the actual instance is not `AppScreenshot`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppScreenshot</returns>
        public AppScreenshot GetAppScreenshot()
        {
            return (AppScreenshot)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppScreenshotSetsResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppScreenshotSetsResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppScreenshotSetsResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppScreenshotSetsResponseIncludedInner</returns>
        public static AppScreenshotSetsResponseIncludedInner FromJson(string jsonString)
        {
            AppScreenshotSetsResponseIncludedInner newAppScreenshotSetsResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppScreenshotSetsResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppCustomProductPageLocalization).GetProperty("AdditionalProperties") == null)
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppCustomProductPageLocalization>(jsonString, AppScreenshotSetsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppCustomProductPageLocalization>(jsonString, AppScreenshotSetsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppCustomProductPageLocalization");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppCustomProductPageLocalization: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppScreenshot).GetProperty("AdditionalProperties") == null)
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppScreenshot>(jsonString, AppScreenshotSetsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppScreenshot>(jsonString, AppScreenshotSetsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppScreenshot");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppScreenshot: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersionExperimentTreatmentLocalization).GetProperty("AdditionalProperties") == null)
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionExperimentTreatmentLocalization>(jsonString, AppScreenshotSetsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionExperimentTreatmentLocalization>(jsonString, AppScreenshotSetsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersionExperimentTreatmentLocalization");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersionExperimentTreatmentLocalization: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersionLocalization).GetProperty("AdditionalProperties") == null)
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionLocalization>(jsonString, AppScreenshotSetsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppScreenshotSetsResponseIncludedInner = new AppScreenshotSetsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionLocalization>(jsonString, AppScreenshotSetsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersionLocalization");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersionLocalization: {1}", jsonString, exception.ToString()));
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
            return newAppScreenshotSetsResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppScreenshotSetsResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if AppScreenshotSetsResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AppScreenshotSetsResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppScreenshotSetsResponseIncludedInner input)
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
    /// Custom JSON converter for AppScreenshotSetsResponseIncludedInner
    /// </summary>
    public class AppScreenshotSetsResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppScreenshotSetsResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return AppScreenshotSetsResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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