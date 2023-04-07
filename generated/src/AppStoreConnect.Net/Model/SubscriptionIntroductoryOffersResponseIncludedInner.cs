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
    /// SubscriptionIntroductoryOffersResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(SubscriptionIntroductoryOffersResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "SubscriptionIntroductoryOffersResponse_included_inner")]
    public partial class SubscriptionIntroductoryOffersResponseIncludedInner : AbstractOpenAPISchema, IEquatable<SubscriptionIntroductoryOffersResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOffersResponseIncludedInner" /> class
        /// with the <see cref="Subscription" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Subscription.</param>
        public SubscriptionIntroductoryOffersResponseIncludedInner(Subscription actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOffersResponseIncludedInner" /> class
        /// with the <see cref="Territory" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Territory.</param>
        public SubscriptionIntroductoryOffersResponseIncludedInner(Territory actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOffersResponseIncludedInner" /> class
        /// with the <see cref="SubscriptionPricePoint" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubscriptionPricePoint.</param>
        public SubscriptionIntroductoryOffersResponseIncludedInner(SubscriptionPricePoint actualInstance)
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
                if (value.GetType() == typeof(Subscription))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SubscriptionPricePoint))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Territory))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Subscription, SubscriptionPricePoint, Territory");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Subscription`. If the actual instance is not `Subscription`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Subscription</returns>
        public Subscription GetSubscription()
        {
            return (Subscription)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Territory`. If the actual instance is not `Territory`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Territory</returns>
        public Territory GetTerritory()
        {
            return (Territory)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SubscriptionPricePoint`. If the actual instance is not `SubscriptionPricePoint`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubscriptionPricePoint</returns>
        public SubscriptionPricePoint GetSubscriptionPricePoint()
        {
            return (SubscriptionPricePoint)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionIntroductoryOffersResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SubscriptionIntroductoryOffersResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SubscriptionIntroductoryOffersResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SubscriptionIntroductoryOffersResponseIncludedInner</returns>
        public static SubscriptionIntroductoryOffersResponseIncludedInner FromJson(string jsonString)
        {
            SubscriptionIntroductoryOffersResponseIncludedInner newSubscriptionIntroductoryOffersResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSubscriptionIntroductoryOffersResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Subscription).GetProperty("AdditionalProperties") == null)
                {
                    newSubscriptionIntroductoryOffersResponseIncludedInner = new SubscriptionIntroductoryOffersResponseIncludedInner(JsonConvert.DeserializeObject<Subscription>(jsonString, SubscriptionIntroductoryOffersResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newSubscriptionIntroductoryOffersResponseIncludedInner = new SubscriptionIntroductoryOffersResponseIncludedInner(JsonConvert.DeserializeObject<Subscription>(jsonString, SubscriptionIntroductoryOffersResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Subscription");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Subscription: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubscriptionPricePoint).GetProperty("AdditionalProperties") == null)
                {
                    newSubscriptionIntroductoryOffersResponseIncludedInner = new SubscriptionIntroductoryOffersResponseIncludedInner(JsonConvert.DeserializeObject<SubscriptionPricePoint>(jsonString, SubscriptionIntroductoryOffersResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newSubscriptionIntroductoryOffersResponseIncludedInner = new SubscriptionIntroductoryOffersResponseIncludedInner(JsonConvert.DeserializeObject<SubscriptionPricePoint>(jsonString, SubscriptionIntroductoryOffersResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubscriptionPricePoint");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubscriptionPricePoint: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Territory).GetProperty("AdditionalProperties") == null)
                {
                    newSubscriptionIntroductoryOffersResponseIncludedInner = new SubscriptionIntroductoryOffersResponseIncludedInner(JsonConvert.DeserializeObject<Territory>(jsonString, SubscriptionIntroductoryOffersResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newSubscriptionIntroductoryOffersResponseIncludedInner = new SubscriptionIntroductoryOffersResponseIncludedInner(JsonConvert.DeserializeObject<Territory>(jsonString, SubscriptionIntroductoryOffersResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Territory");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Territory: {1}", jsonString, exception.ToString()));
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
            return newSubscriptionIntroductoryOffersResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionIntroductoryOffersResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if SubscriptionIntroductoryOffersResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionIntroductoryOffersResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionIntroductoryOffersResponseIncludedInner input)
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
    /// Custom JSON converter for SubscriptionIntroductoryOffersResponseIncludedInner
    /// </summary>
    public class SubscriptionIntroductoryOffersResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SubscriptionIntroductoryOffersResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return SubscriptionIntroductoryOffersResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
