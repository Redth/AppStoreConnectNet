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

namespace AppStoreConnect.Model
{
    /// <summary>
    /// Defines AppStoreAgeRating
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppStoreAgeRating
    {
        /// <summary>
        /// Enum FOURPLUS for value: FOUR_PLUS
        /// </summary>
        [EnumMember(Value = "FOUR_PLUS")]
        FOURPLUS = 1,

        /// <summary>
        /// Enum NINEPLUS for value: NINE_PLUS
        /// </summary>
        [EnumMember(Value = "NINE_PLUS")]
        NINEPLUS = 2,

        /// <summary>
        /// Enum TWELVEPLUS for value: TWELVE_PLUS
        /// </summary>
        [EnumMember(Value = "TWELVE_PLUS")]
        TWELVEPLUS = 3,

        /// <summary>
        /// Enum SEVENTEENPLUS for value: SEVENTEEN_PLUS
        /// </summary>
        [EnumMember(Value = "SEVENTEEN_PLUS")]
        SEVENTEENPLUS = 4

    }

}
