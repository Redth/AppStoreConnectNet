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
    /// AppStoreVersionsResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(AppStoreVersionsResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "AppStoreVersionsResponse_included_inner")]
    public partial class AppStoreVersionsResponseIncludedInner : AbstractOpenAPISchema, IEquatable<AppStoreVersionsResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="App" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of App.</param>
        public AppStoreVersionsResponseIncludedInner(App actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AgeRatingDeclaration" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AgeRatingDeclaration.</param>
        public AppStoreVersionsResponseIncludedInner(AgeRatingDeclaration actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersionLocalization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersionLocalization.</param>
        public AppStoreVersionsResponseIncludedInner(AppStoreVersionLocalization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="Build" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Build.</param>
        public AppStoreVersionsResponseIncludedInner(Build actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersionPhasedRelease" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersionPhasedRelease.</param>
        public AppStoreVersionsResponseIncludedInner(AppStoreVersionPhasedRelease actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="RoutingAppCoverage" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RoutingAppCoverage.</param>
        public AppStoreVersionsResponseIncludedInner(RoutingAppCoverage actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreReviewDetail" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreReviewDetail.</param>
        public AppStoreVersionsResponseIncludedInner(AppStoreReviewDetail actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersionSubmission" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersionSubmission.</param>
        public AppStoreVersionsResponseIncludedInner(AppStoreVersionSubmission actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AppClipDefaultExperience" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppClipDefaultExperience.</param>
        public AppStoreVersionsResponseIncludedInner(AppClipDefaultExperience actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionsResponseIncludedInner" /> class
        /// with the <see cref="AppStoreVersionExperiment" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppStoreVersionExperiment.</param>
        public AppStoreVersionsResponseIncludedInner(AppStoreVersionExperiment actualInstance)
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
                if (value.GetType() == typeof(AgeRatingDeclaration))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(App))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppClipDefaultExperience))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreReviewDetail))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersionExperiment))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersionLocalization))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersionPhasedRelease))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppStoreVersionSubmission))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Build))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RoutingAppCoverage))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AgeRatingDeclaration, App, AppClipDefaultExperience, AppStoreReviewDetail, AppStoreVersionExperiment, AppStoreVersionLocalization, AppStoreVersionPhasedRelease, AppStoreVersionSubmission, Build, RoutingAppCoverage");
                }
            }
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
        /// Get the actual instance of `AgeRatingDeclaration`. If the actual instance is not `AgeRatingDeclaration`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AgeRatingDeclaration</returns>
        public AgeRatingDeclaration GetAgeRatingDeclaration()
        {
            return (AgeRatingDeclaration)this.ActualInstance;
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
        /// Get the actual instance of `Build`. If the actual instance is not `Build`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Build</returns>
        public Build GetBuild()
        {
            return (Build)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppStoreVersionPhasedRelease`. If the actual instance is not `AppStoreVersionPhasedRelease`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreVersionPhasedRelease</returns>
        public AppStoreVersionPhasedRelease GetAppStoreVersionPhasedRelease()
        {
            return (AppStoreVersionPhasedRelease)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RoutingAppCoverage`. If the actual instance is not `RoutingAppCoverage`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RoutingAppCoverage</returns>
        public RoutingAppCoverage GetRoutingAppCoverage()
        {
            return (RoutingAppCoverage)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppStoreReviewDetail`. If the actual instance is not `AppStoreReviewDetail`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreReviewDetail</returns>
        public AppStoreReviewDetail GetAppStoreReviewDetail()
        {
            return (AppStoreReviewDetail)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppStoreVersionSubmission`. If the actual instance is not `AppStoreVersionSubmission`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreVersionSubmission</returns>
        public AppStoreVersionSubmission GetAppStoreVersionSubmission()
        {
            return (AppStoreVersionSubmission)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppClipDefaultExperience`. If the actual instance is not `AppClipDefaultExperience`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppClipDefaultExperience</returns>
        public AppClipDefaultExperience GetAppClipDefaultExperience()
        {
            return (AppClipDefaultExperience)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppStoreVersionExperiment`. If the actual instance is not `AppStoreVersionExperiment`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppStoreVersionExperiment</returns>
        public AppStoreVersionExperiment GetAppStoreVersionExperiment()
        {
            return (AppStoreVersionExperiment)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreVersionsResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppStoreVersionsResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppStoreVersionsResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppStoreVersionsResponseIncludedInner</returns>
        public static AppStoreVersionsResponseIncludedInner FromJson(string jsonString)
        {
            AppStoreVersionsResponseIncludedInner newAppStoreVersionsResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppStoreVersionsResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AgeRatingDeclaration).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AgeRatingDeclaration>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AgeRatingDeclaration>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AgeRatingDeclaration");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AgeRatingDeclaration: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(App).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<App>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<App>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
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
                if (typeof(AppClipDefaultExperience).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppClipDefaultExperience>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppClipDefaultExperience>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppClipDefaultExperience");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppClipDefaultExperience: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreReviewDetail).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreReviewDetail>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreReviewDetail>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreReviewDetail");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreReviewDetail: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersionExperiment).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionExperiment>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionExperiment>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersionExperiment");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersionExperiment: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersionLocalization).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionLocalization>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionLocalization>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersionLocalization");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersionLocalization: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersionPhasedRelease).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionPhasedRelease>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionPhasedRelease>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersionPhasedRelease");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersionPhasedRelease: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppStoreVersionSubmission).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionSubmission>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<AppStoreVersionSubmission>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppStoreVersionSubmission");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppStoreVersionSubmission: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Build).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<Build>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<Build>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
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
                if (typeof(RoutingAppCoverage).GetProperty("AdditionalProperties") == null)
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<RoutingAppCoverage>(jsonString, AppStoreVersionsResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newAppStoreVersionsResponseIncludedInner = new AppStoreVersionsResponseIncludedInner(JsonConvert.DeserializeObject<RoutingAppCoverage>(jsonString, AppStoreVersionsResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RoutingAppCoverage");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RoutingAppCoverage: {1}", jsonString, exception.ToString()));
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
            return newAppStoreVersionsResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppStoreVersionsResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if AppStoreVersionsResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreVersionsResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreVersionsResponseIncludedInner input)
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
    /// Custom JSON converter for AppStoreVersionsResponseIncludedInner
    /// </summary>
    public class AppStoreVersionsResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppStoreVersionsResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return AppStoreVersionsResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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