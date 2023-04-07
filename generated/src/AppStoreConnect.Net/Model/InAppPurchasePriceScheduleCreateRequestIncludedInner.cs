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
    /// InAppPurchasePriceScheduleCreateRequestIncludedInner
    /// </summary>
    [JsonConverter(typeof(InAppPurchasePriceScheduleCreateRequestIncludedInnerJsonConverter))]
    [DataContract(Name = "InAppPurchasePriceScheduleCreateRequest_included_inner")]
    public partial class InAppPurchasePriceScheduleCreateRequestIncludedInner : AbstractOpenAPISchema, IEquatable<InAppPurchasePriceScheduleCreateRequestIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleCreateRequestIncludedInner" /> class
        /// with the <see cref="InAppPurchasePriceInlineCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InAppPurchasePriceInlineCreate.</param>
        public InAppPurchasePriceScheduleCreateRequestIncludedInner(InAppPurchasePriceInlineCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleCreateRequestIncludedInner" /> class
        /// with the <see cref="TerritoryInlineCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TerritoryInlineCreate.</param>
        public InAppPurchasePriceScheduleCreateRequestIncludedInner(TerritoryInlineCreate actualInstance)
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
                if (value.GetType() == typeof(InAppPurchasePriceInlineCreate))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TerritoryInlineCreate))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: InAppPurchasePriceInlineCreate, TerritoryInlineCreate");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `InAppPurchasePriceInlineCreate`. If the actual instance is not `InAppPurchasePriceInlineCreate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InAppPurchasePriceInlineCreate</returns>
        public InAppPurchasePriceInlineCreate GetInAppPurchasePriceInlineCreate()
        {
            return (InAppPurchasePriceInlineCreate)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TerritoryInlineCreate`. If the actual instance is not `TerritoryInlineCreate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TerritoryInlineCreate</returns>
        public TerritoryInlineCreate GetTerritoryInlineCreate()
        {
            return (TerritoryInlineCreate)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InAppPurchasePriceScheduleCreateRequestIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, InAppPurchasePriceScheduleCreateRequestIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of InAppPurchasePriceScheduleCreateRequestIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of InAppPurchasePriceScheduleCreateRequestIncludedInner</returns>
        public static InAppPurchasePriceScheduleCreateRequestIncludedInner FromJson(string jsonString)
        {
            InAppPurchasePriceScheduleCreateRequestIncludedInner newInAppPurchasePriceScheduleCreateRequestIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newInAppPurchasePriceScheduleCreateRequestIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InAppPurchasePriceInlineCreate).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasePriceScheduleCreateRequestIncludedInner = new InAppPurchasePriceScheduleCreateRequestIncludedInner(JsonConvert.DeserializeObject<InAppPurchasePriceInlineCreate>(jsonString, InAppPurchasePriceScheduleCreateRequestIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasePriceScheduleCreateRequestIncludedInner = new InAppPurchasePriceScheduleCreateRequestIncludedInner(JsonConvert.DeserializeObject<InAppPurchasePriceInlineCreate>(jsonString, InAppPurchasePriceScheduleCreateRequestIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InAppPurchasePriceInlineCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InAppPurchasePriceInlineCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TerritoryInlineCreate).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasePriceScheduleCreateRequestIncludedInner = new InAppPurchasePriceScheduleCreateRequestIncludedInner(JsonConvert.DeserializeObject<TerritoryInlineCreate>(jsonString, InAppPurchasePriceScheduleCreateRequestIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasePriceScheduleCreateRequestIncludedInner = new InAppPurchasePriceScheduleCreateRequestIncludedInner(JsonConvert.DeserializeObject<TerritoryInlineCreate>(jsonString, InAppPurchasePriceScheduleCreateRequestIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TerritoryInlineCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TerritoryInlineCreate: {1}", jsonString, exception.ToString()));
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
            return newInAppPurchasePriceScheduleCreateRequestIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InAppPurchasePriceScheduleCreateRequestIncludedInner);
        }

        /// <summary>
        /// Returns true if InAppPurchasePriceScheduleCreateRequestIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of InAppPurchasePriceScheduleCreateRequestIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InAppPurchasePriceScheduleCreateRequestIncludedInner input)
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
    /// Custom JSON converter for InAppPurchasePriceScheduleCreateRequestIncludedInner
    /// </summary>
    public class InAppPurchasePriceScheduleCreateRequestIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(InAppPurchasePriceScheduleCreateRequestIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return InAppPurchasePriceScheduleCreateRequestIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
