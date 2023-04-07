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
    /// SubscriptionUpdateRequestIncludedInner
    /// </summary>
    [JsonConverter(typeof(SubscriptionUpdateRequestIncludedInnerJsonConverter))]
    [DataContract(Name = "SubscriptionUpdateRequest_included_inner")]
    public partial class SubscriptionUpdateRequestIncludedInner : AbstractOpenAPISchema, IEquatable<SubscriptionUpdateRequestIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequestIncludedInner" /> class
        /// with the <see cref="SubscriptionPromotionalOfferInlineCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubscriptionPromotionalOfferInlineCreate.</param>
        public SubscriptionUpdateRequestIncludedInner(SubscriptionPromotionalOfferInlineCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequestIncludedInner" /> class
        /// with the <see cref="SubscriptionPriceInlineCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubscriptionPriceInlineCreate.</param>
        public SubscriptionUpdateRequestIncludedInner(SubscriptionPriceInlineCreate actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequestIncludedInner" /> class
        /// with the <see cref="SubscriptionIntroductoryOfferInlineCreate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubscriptionIntroductoryOfferInlineCreate.</param>
        public SubscriptionUpdateRequestIncludedInner(SubscriptionIntroductoryOfferInlineCreate actualInstance)
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
                if (value.GetType() == typeof(SubscriptionIntroductoryOfferInlineCreate))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SubscriptionPriceInlineCreate))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SubscriptionPromotionalOfferInlineCreate))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: SubscriptionIntroductoryOfferInlineCreate, SubscriptionPriceInlineCreate, SubscriptionPromotionalOfferInlineCreate");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `SubscriptionPromotionalOfferInlineCreate`. If the actual instance is not `SubscriptionPromotionalOfferInlineCreate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubscriptionPromotionalOfferInlineCreate</returns>
        public SubscriptionPromotionalOfferInlineCreate GetSubscriptionPromotionalOfferInlineCreate()
        {
            return (SubscriptionPromotionalOfferInlineCreate)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SubscriptionPriceInlineCreate`. If the actual instance is not `SubscriptionPriceInlineCreate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubscriptionPriceInlineCreate</returns>
        public SubscriptionPriceInlineCreate GetSubscriptionPriceInlineCreate()
        {
            return (SubscriptionPriceInlineCreate)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SubscriptionIntroductoryOfferInlineCreate`. If the actual instance is not `SubscriptionIntroductoryOfferInlineCreate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubscriptionIntroductoryOfferInlineCreate</returns>
        public SubscriptionIntroductoryOfferInlineCreate GetSubscriptionIntroductoryOfferInlineCreate()
        {
            return (SubscriptionIntroductoryOfferInlineCreate)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionUpdateRequestIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SubscriptionUpdateRequestIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SubscriptionUpdateRequestIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SubscriptionUpdateRequestIncludedInner</returns>
        public static SubscriptionUpdateRequestIncludedInner FromJson(string jsonString)
        {
            SubscriptionUpdateRequestIncludedInner newSubscriptionUpdateRequestIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSubscriptionUpdateRequestIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubscriptionIntroductoryOfferInlineCreate).GetProperty("AdditionalProperties") == null)
                {
                    newSubscriptionUpdateRequestIncludedInner = new SubscriptionUpdateRequestIncludedInner(JsonConvert.DeserializeObject<SubscriptionIntroductoryOfferInlineCreate>(jsonString, SubscriptionUpdateRequestIncludedInner.SerializerSettings));
                }
                else
                {
                    newSubscriptionUpdateRequestIncludedInner = new SubscriptionUpdateRequestIncludedInner(JsonConvert.DeserializeObject<SubscriptionIntroductoryOfferInlineCreate>(jsonString, SubscriptionUpdateRequestIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubscriptionIntroductoryOfferInlineCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubscriptionIntroductoryOfferInlineCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubscriptionPriceInlineCreate).GetProperty("AdditionalProperties") == null)
                {
                    newSubscriptionUpdateRequestIncludedInner = new SubscriptionUpdateRequestIncludedInner(JsonConvert.DeserializeObject<SubscriptionPriceInlineCreate>(jsonString, SubscriptionUpdateRequestIncludedInner.SerializerSettings));
                }
                else
                {
                    newSubscriptionUpdateRequestIncludedInner = new SubscriptionUpdateRequestIncludedInner(JsonConvert.DeserializeObject<SubscriptionPriceInlineCreate>(jsonString, SubscriptionUpdateRequestIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubscriptionPriceInlineCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubscriptionPriceInlineCreate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubscriptionPromotionalOfferInlineCreate).GetProperty("AdditionalProperties") == null)
                {
                    newSubscriptionUpdateRequestIncludedInner = new SubscriptionUpdateRequestIncludedInner(JsonConvert.DeserializeObject<SubscriptionPromotionalOfferInlineCreate>(jsonString, SubscriptionUpdateRequestIncludedInner.SerializerSettings));
                }
                else
                {
                    newSubscriptionUpdateRequestIncludedInner = new SubscriptionUpdateRequestIncludedInner(JsonConvert.DeserializeObject<SubscriptionPromotionalOfferInlineCreate>(jsonString, SubscriptionUpdateRequestIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubscriptionPromotionalOfferInlineCreate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubscriptionPromotionalOfferInlineCreate: {1}", jsonString, exception.ToString()));
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
            return newSubscriptionUpdateRequestIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionUpdateRequestIncludedInner);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdateRequestIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdateRequestIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdateRequestIncludedInner input)
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
    /// Custom JSON converter for SubscriptionUpdateRequestIncludedInner
    /// </summary>
    public class SubscriptionUpdateRequestIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SubscriptionUpdateRequestIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return SubscriptionUpdateRequestIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
