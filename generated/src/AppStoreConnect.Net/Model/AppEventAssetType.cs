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
    /// Defines AppEventAssetType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppEventAssetType
    {
        /// <summary>
        /// Enum CARD for value: EVENT_CARD
        /// </summary>
        [EnumMember(Value = "EVENT_CARD")]
        CARD = 1,

        /// <summary>
        /// Enum DETAILSPAGE for value: EVENT_DETAILS_PAGE
        /// </summary>
        [EnumMember(Value = "EVENT_DETAILS_PAGE")]
        DETAILSPAGE = 2

    }

}
