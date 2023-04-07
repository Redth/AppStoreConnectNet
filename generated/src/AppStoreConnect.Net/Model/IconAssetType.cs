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
    /// Defines IconAssetType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IconAssetType
    {
        /// <summary>
        /// Enum APPSTORE for value: APP_STORE
        /// </summary>
        [EnumMember(Value = "APP_STORE")]
        APPSTORE = 1,

        /// <summary>
        /// Enum MESSAGESAPPSTORE for value: MESSAGES_APP_STORE
        /// </summary>
        [EnumMember(Value = "MESSAGES_APP_STORE")]
        MESSAGESAPPSTORE = 2,

        /// <summary>
        /// Enum WATCHAPPSTORE for value: WATCH_APP_STORE
        /// </summary>
        [EnumMember(Value = "WATCH_APP_STORE")]
        WATCHAPPSTORE = 3,

        /// <summary>
        /// Enum TVOSHOMESCREEN for value: TV_OS_HOME_SCREEN
        /// </summary>
        [EnumMember(Value = "TV_OS_HOME_SCREEN")]
        TVOSHOMESCREEN = 4,

        /// <summary>
        /// Enum TVOSTOPSHELF for value: TV_OS_TOP_SHELF
        /// </summary>
        [EnumMember(Value = "TV_OS_TOP_SHELF")]
        TVOSTOPSHELF = 5,

        /// <summary>
        /// Enum ALTERNATEEXPERIMENT for value: ALTERNATE_EXPERIMENT
        /// </summary>
        [EnumMember(Value = "ALTERNATE_EXPERIMENT")]
        ALTERNATEEXPERIMENT = 6

    }

}
