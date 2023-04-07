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
    /// Defines ScreenshotDisplayType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScreenshotDisplayType
    {
        /// <summary>
        /// Enum APPIPHONE67 for value: APP_IPHONE_67
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_67")]
        APPIPHONE67 = 1,

        /// <summary>
        /// Enum APPIPHONE61 for value: APP_IPHONE_61
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_61")]
        APPIPHONE61 = 2,

        /// <summary>
        /// Enum APPIPHONE65 for value: APP_IPHONE_65
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_65")]
        APPIPHONE65 = 3,

        /// <summary>
        /// Enum APPIPHONE58 for value: APP_IPHONE_58
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_58")]
        APPIPHONE58 = 4,

        /// <summary>
        /// Enum APPIPHONE55 for value: APP_IPHONE_55
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_55")]
        APPIPHONE55 = 5,

        /// <summary>
        /// Enum APPIPHONE47 for value: APP_IPHONE_47
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_47")]
        APPIPHONE47 = 6,

        /// <summary>
        /// Enum APPIPHONE40 for value: APP_IPHONE_40
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_40")]
        APPIPHONE40 = 7,

        /// <summary>
        /// Enum APPIPHONE35 for value: APP_IPHONE_35
        /// </summary>
        [EnumMember(Value = "APP_IPHONE_35")]
        APPIPHONE35 = 8,

        /// <summary>
        /// Enum APPIPADPRO3GEN129 for value: APP_IPAD_PRO_3GEN_129
        /// </summary>
        [EnumMember(Value = "APP_IPAD_PRO_3GEN_129")]
        APPIPADPRO3GEN129 = 9,

        /// <summary>
        /// Enum APPIPADPRO3GEN11 for value: APP_IPAD_PRO_3GEN_11
        /// </summary>
        [EnumMember(Value = "APP_IPAD_PRO_3GEN_11")]
        APPIPADPRO3GEN11 = 10,

        /// <summary>
        /// Enum APPIPADPRO129 for value: APP_IPAD_PRO_129
        /// </summary>
        [EnumMember(Value = "APP_IPAD_PRO_129")]
        APPIPADPRO129 = 11,

        /// <summary>
        /// Enum APPIPAD105 for value: APP_IPAD_105
        /// </summary>
        [EnumMember(Value = "APP_IPAD_105")]
        APPIPAD105 = 12,

        /// <summary>
        /// Enum APPIPAD97 for value: APP_IPAD_97
        /// </summary>
        [EnumMember(Value = "APP_IPAD_97")]
        APPIPAD97 = 13,

        /// <summary>
        /// Enum APPDESKTOP for value: APP_DESKTOP
        /// </summary>
        [EnumMember(Value = "APP_DESKTOP")]
        APPDESKTOP = 14,

        /// <summary>
        /// Enum APPWATCHULTRA for value: APP_WATCH_ULTRA
        /// </summary>
        [EnumMember(Value = "APP_WATCH_ULTRA")]
        APPWATCHULTRA = 15,

        /// <summary>
        /// Enum APPWATCHSERIES7 for value: APP_WATCH_SERIES_7
        /// </summary>
        [EnumMember(Value = "APP_WATCH_SERIES_7")]
        APPWATCHSERIES7 = 16,

        /// <summary>
        /// Enum APPWATCHSERIES4 for value: APP_WATCH_SERIES_4
        /// </summary>
        [EnumMember(Value = "APP_WATCH_SERIES_4")]
        APPWATCHSERIES4 = 17,

        /// <summary>
        /// Enum APPWATCHSERIES3 for value: APP_WATCH_SERIES_3
        /// </summary>
        [EnumMember(Value = "APP_WATCH_SERIES_3")]
        APPWATCHSERIES3 = 18,

        /// <summary>
        /// Enum APPAPPLETV for value: APP_APPLE_TV
        /// </summary>
        [EnumMember(Value = "APP_APPLE_TV")]
        APPAPPLETV = 19,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE67 for value: IMESSAGE_APP_IPHONE_67
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_67")]
        IMESSAGEAPPIPHONE67 = 20,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE61 for value: IMESSAGE_APP_IPHONE_61
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_61")]
        IMESSAGEAPPIPHONE61 = 21,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE65 for value: IMESSAGE_APP_IPHONE_65
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_65")]
        IMESSAGEAPPIPHONE65 = 22,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE58 for value: IMESSAGE_APP_IPHONE_58
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_58")]
        IMESSAGEAPPIPHONE58 = 23,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE55 for value: IMESSAGE_APP_IPHONE_55
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_55")]
        IMESSAGEAPPIPHONE55 = 24,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE47 for value: IMESSAGE_APP_IPHONE_47
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_47")]
        IMESSAGEAPPIPHONE47 = 25,

        /// <summary>
        /// Enum IMESSAGEAPPIPHONE40 for value: IMESSAGE_APP_IPHONE_40
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPHONE_40")]
        IMESSAGEAPPIPHONE40 = 26,

        /// <summary>
        /// Enum IMESSAGEAPPIPADPRO3GEN129 for value: IMESSAGE_APP_IPAD_PRO_3GEN_129
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPAD_PRO_3GEN_129")]
        IMESSAGEAPPIPADPRO3GEN129 = 27,

        /// <summary>
        /// Enum IMESSAGEAPPIPADPRO3GEN11 for value: IMESSAGE_APP_IPAD_PRO_3GEN_11
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPAD_PRO_3GEN_11")]
        IMESSAGEAPPIPADPRO3GEN11 = 28,

        /// <summary>
        /// Enum IMESSAGEAPPIPADPRO129 for value: IMESSAGE_APP_IPAD_PRO_129
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPAD_PRO_129")]
        IMESSAGEAPPIPADPRO129 = 29,

        /// <summary>
        /// Enum IMESSAGEAPPIPAD105 for value: IMESSAGE_APP_IPAD_105
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPAD_105")]
        IMESSAGEAPPIPAD105 = 30,

        /// <summary>
        /// Enum IMESSAGEAPPIPAD97 for value: IMESSAGE_APP_IPAD_97
        /// </summary>
        [EnumMember(Value = "IMESSAGE_APP_IPAD_97")]
        IMESSAGEAPPIPAD97 = 31

    }

}