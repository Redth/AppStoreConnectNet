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
    /// InAppPurchasesV2ResponseIncludedInner
    /// </summary>
    [JsonConverter(typeof(InAppPurchasesV2ResponseIncludedInnerJsonConverter))]
    [DataContract(Name = "InAppPurchasesV2Response_included_inner")]
    public partial class InAppPurchasesV2ResponseIncludedInner : AbstractOpenAPISchema, IEquatable<InAppPurchasesV2ResponseIncludedInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasesV2ResponseIncludedInner" /> class
        /// with the <see cref="InAppPurchaseLocalization" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InAppPurchaseLocalization.</param>
        public InAppPurchasesV2ResponseIncludedInner(InAppPurchaseLocalization actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasesV2ResponseIncludedInner" /> class
        /// with the <see cref="InAppPurchasePricePoint" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InAppPurchasePricePoint.</param>
        public InAppPurchasesV2ResponseIncludedInner(InAppPurchasePricePoint actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasesV2ResponseIncludedInner" /> class
        /// with the <see cref="InAppPurchaseContent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InAppPurchaseContent.</param>
        public InAppPurchasesV2ResponseIncludedInner(InAppPurchaseContent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasesV2ResponseIncludedInner" /> class
        /// with the <see cref="InAppPurchaseAppStoreReviewScreenshot" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InAppPurchaseAppStoreReviewScreenshot.</param>
        public InAppPurchasesV2ResponseIncludedInner(InAppPurchaseAppStoreReviewScreenshot actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasesV2ResponseIncludedInner" /> class
        /// with the <see cref="PromotedPurchase" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PromotedPurchase.</param>
        public InAppPurchasesV2ResponseIncludedInner(PromotedPurchase actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasesV2ResponseIncludedInner" /> class
        /// with the <see cref="InAppPurchasePriceSchedule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InAppPurchasePriceSchedule.</param>
        public InAppPurchasesV2ResponseIncludedInner(InAppPurchasePriceSchedule actualInstance)
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
                if (value.GetType() == typeof(InAppPurchaseAppStoreReviewScreenshot))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InAppPurchaseContent))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InAppPurchaseLocalization))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InAppPurchasePricePoint))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InAppPurchasePriceSchedule))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PromotedPurchase))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: InAppPurchaseAppStoreReviewScreenshot, InAppPurchaseContent, InAppPurchaseLocalization, InAppPurchasePricePoint, InAppPurchasePriceSchedule, PromotedPurchase");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `InAppPurchaseLocalization`. If the actual instance is not `InAppPurchaseLocalization`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InAppPurchaseLocalization</returns>
        public InAppPurchaseLocalization GetInAppPurchaseLocalization()
        {
            return (InAppPurchaseLocalization)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InAppPurchasePricePoint`. If the actual instance is not `InAppPurchasePricePoint`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InAppPurchasePricePoint</returns>
        public InAppPurchasePricePoint GetInAppPurchasePricePoint()
        {
            return (InAppPurchasePricePoint)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InAppPurchaseContent`. If the actual instance is not `InAppPurchaseContent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InAppPurchaseContent</returns>
        public InAppPurchaseContent GetInAppPurchaseContent()
        {
            return (InAppPurchaseContent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InAppPurchaseAppStoreReviewScreenshot`. If the actual instance is not `InAppPurchaseAppStoreReviewScreenshot`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InAppPurchaseAppStoreReviewScreenshot</returns>
        public InAppPurchaseAppStoreReviewScreenshot GetInAppPurchaseAppStoreReviewScreenshot()
        {
            return (InAppPurchaseAppStoreReviewScreenshot)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PromotedPurchase`. If the actual instance is not `PromotedPurchase`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PromotedPurchase</returns>
        public PromotedPurchase GetPromotedPurchase()
        {
            return (PromotedPurchase)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InAppPurchasePriceSchedule`. If the actual instance is not `InAppPurchasePriceSchedule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InAppPurchasePriceSchedule</returns>
        public InAppPurchasePriceSchedule GetInAppPurchasePriceSchedule()
        {
            return (InAppPurchasePriceSchedule)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InAppPurchasesV2ResponseIncludedInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, InAppPurchasesV2ResponseIncludedInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of InAppPurchasesV2ResponseIncludedInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of InAppPurchasesV2ResponseIncludedInner</returns>
        public static InAppPurchasesV2ResponseIncludedInner FromJson(string jsonString)
        {
            InAppPurchasesV2ResponseIncludedInner newInAppPurchasesV2ResponseIncludedInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newInAppPurchasesV2ResponseIncludedInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InAppPurchaseAppStoreReviewScreenshot).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchaseAppStoreReviewScreenshot>(jsonString, InAppPurchasesV2ResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchaseAppStoreReviewScreenshot>(jsonString, InAppPurchasesV2ResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InAppPurchaseAppStoreReviewScreenshot");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InAppPurchaseAppStoreReviewScreenshot: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InAppPurchaseContent).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchaseContent>(jsonString, InAppPurchasesV2ResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchaseContent>(jsonString, InAppPurchasesV2ResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InAppPurchaseContent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InAppPurchaseContent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InAppPurchaseLocalization).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchaseLocalization>(jsonString, InAppPurchasesV2ResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchaseLocalization>(jsonString, InAppPurchasesV2ResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InAppPurchaseLocalization");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InAppPurchaseLocalization: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InAppPurchasePricePoint).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchasePricePoint>(jsonString, InAppPurchasesV2ResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchasePricePoint>(jsonString, InAppPurchasesV2ResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InAppPurchasePricePoint");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InAppPurchasePricePoint: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InAppPurchasePriceSchedule).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchasePriceSchedule>(jsonString, InAppPurchasesV2ResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<InAppPurchasePriceSchedule>(jsonString, InAppPurchasesV2ResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InAppPurchasePriceSchedule");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InAppPurchasePriceSchedule: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PromotedPurchase).GetProperty("AdditionalProperties") == null)
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<PromotedPurchase>(jsonString, InAppPurchasesV2ResponseIncludedInner.SerializerSettings));
                }
                else
                {
                    newInAppPurchasesV2ResponseIncludedInner = new InAppPurchasesV2ResponseIncludedInner(JsonConvert.DeserializeObject<PromotedPurchase>(jsonString, InAppPurchasesV2ResponseIncludedInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PromotedPurchase");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PromotedPurchase: {1}", jsonString, exception.ToString()));
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
            return newInAppPurchasesV2ResponseIncludedInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InAppPurchasesV2ResponseIncludedInner);
        }

        /// <summary>
        /// Returns true if InAppPurchasesV2ResponseIncludedInner instances are equal
        /// </summary>
        /// <param name="input">Instance of InAppPurchasesV2ResponseIncludedInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InAppPurchasesV2ResponseIncludedInner input)
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
    /// Custom JSON converter for InAppPurchasesV2ResponseIncludedInner
    /// </summary>
    public class InAppPurchasesV2ResponseIncludedInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(InAppPurchasesV2ResponseIncludedInner).GetMethod("ToJson").Invoke(value, null)));
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
                return InAppPurchasesV2ResponseIncludedInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
