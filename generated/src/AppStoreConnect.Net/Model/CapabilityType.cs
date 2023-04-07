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
    /// Defines CapabilityType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CapabilityType
    {
        /// <summary>
        /// Enum ICLOUD for value: ICLOUD
        /// </summary>
        [EnumMember(Value = "ICLOUD")]
        ICLOUD = 1,

        /// <summary>
        /// Enum INAPPPURCHASE for value: IN_APP_PURCHASE
        /// </summary>
        [EnumMember(Value = "IN_APP_PURCHASE")]
        INAPPPURCHASE = 2,

        /// <summary>
        /// Enum GAMECENTER for value: GAME_CENTER
        /// </summary>
        [EnumMember(Value = "GAME_CENTER")]
        GAMECENTER = 3,

        /// <summary>
        /// Enum PUSHNOTIFICATIONS for value: PUSH_NOTIFICATIONS
        /// </summary>
        [EnumMember(Value = "PUSH_NOTIFICATIONS")]
        PUSHNOTIFICATIONS = 4,

        /// <summary>
        /// Enum WALLET for value: WALLET
        /// </summary>
        [EnumMember(Value = "WALLET")]
        WALLET = 5,

        /// <summary>
        /// Enum INTERAPPAUDIO for value: INTER_APP_AUDIO
        /// </summary>
        [EnumMember(Value = "INTER_APP_AUDIO")]
        INTERAPPAUDIO = 6,

        /// <summary>
        /// Enum MAPS for value: MAPS
        /// </summary>
        [EnumMember(Value = "MAPS")]
        MAPS = 7,

        /// <summary>
        /// Enum ASSOCIATEDDOMAINS for value: ASSOCIATED_DOMAINS
        /// </summary>
        [EnumMember(Value = "ASSOCIATED_DOMAINS")]
        ASSOCIATEDDOMAINS = 8,

        /// <summary>
        /// Enum PERSONALVPN for value: PERSONAL_VPN
        /// </summary>
        [EnumMember(Value = "PERSONAL_VPN")]
        PERSONALVPN = 9,

        /// <summary>
        /// Enum APPGROUPS for value: APP_GROUPS
        /// </summary>
        [EnumMember(Value = "APP_GROUPS")]
        APPGROUPS = 10,

        /// <summary>
        /// Enum HEALTHKIT for value: HEALTHKIT
        /// </summary>
        [EnumMember(Value = "HEALTHKIT")]
        HEALTHKIT = 11,

        /// <summary>
        /// Enum HOMEKIT for value: HOMEKIT
        /// </summary>
        [EnumMember(Value = "HOMEKIT")]
        HOMEKIT = 12,

        /// <summary>
        /// Enum WIRELESSACCESSORYCONFIGURATION for value: WIRELESS_ACCESSORY_CONFIGURATION
        /// </summary>
        [EnumMember(Value = "WIRELESS_ACCESSORY_CONFIGURATION")]
        WIRELESSACCESSORYCONFIGURATION = 13,

        /// <summary>
        /// Enum APPLEPAY for value: APPLE_PAY
        /// </summary>
        [EnumMember(Value = "APPLE_PAY")]
        APPLEPAY = 14,

        /// <summary>
        /// Enum DATAPROTECTION for value: DATA_PROTECTION
        /// </summary>
        [EnumMember(Value = "DATA_PROTECTION")]
        DATAPROTECTION = 15,

        /// <summary>
        /// Enum SIRIKIT for value: SIRIKIT
        /// </summary>
        [EnumMember(Value = "SIRIKIT")]
        SIRIKIT = 16,

        /// <summary>
        /// Enum NETWORKEXTENSIONS for value: NETWORK_EXTENSIONS
        /// </summary>
        [EnumMember(Value = "NETWORK_EXTENSIONS")]
        NETWORKEXTENSIONS = 17,

        /// <summary>
        /// Enum MULTIPATH for value: MULTIPATH
        /// </summary>
        [EnumMember(Value = "MULTIPATH")]
        MULTIPATH = 18,

        /// <summary>
        /// Enum HOTSPOT for value: HOT_SPOT
        /// </summary>
        [EnumMember(Value = "HOT_SPOT")]
        HOTSPOT = 19,

        /// <summary>
        /// Enum NFCTAGREADING for value: NFC_TAG_READING
        /// </summary>
        [EnumMember(Value = "NFC_TAG_READING")]
        NFCTAGREADING = 20,

        /// <summary>
        /// Enum CLASSKIT for value: CLASSKIT
        /// </summary>
        [EnumMember(Value = "CLASSKIT")]
        CLASSKIT = 21,

        /// <summary>
        /// Enum AUTOFILLCREDENTIALPROVIDER for value: AUTOFILL_CREDENTIAL_PROVIDER
        /// </summary>
        [EnumMember(Value = "AUTOFILL_CREDENTIAL_PROVIDER")]
        AUTOFILLCREDENTIALPROVIDER = 22,

        /// <summary>
        /// Enum ACCESSWIFIINFORMATION for value: ACCESS_WIFI_INFORMATION
        /// </summary>
        [EnumMember(Value = "ACCESS_WIFI_INFORMATION")]
        ACCESSWIFIINFORMATION = 23,

        /// <summary>
        /// Enum NETWORKCUSTOMPROTOCOL for value: NETWORK_CUSTOM_PROTOCOL
        /// </summary>
        [EnumMember(Value = "NETWORK_CUSTOM_PROTOCOL")]
        NETWORKCUSTOMPROTOCOL = 24,

        /// <summary>
        /// Enum COREMEDIAHLSLOWLATENCY for value: COREMEDIA_HLS_LOW_LATENCY
        /// </summary>
        [EnumMember(Value = "COREMEDIA_HLS_LOW_LATENCY")]
        COREMEDIAHLSLOWLATENCY = 25,

        /// <summary>
        /// Enum SYSTEMEXTENSIONINSTALL for value: SYSTEM_EXTENSION_INSTALL
        /// </summary>
        [EnumMember(Value = "SYSTEM_EXTENSION_INSTALL")]
        SYSTEMEXTENSIONINSTALL = 26,

        /// <summary>
        /// Enum USERMANAGEMENT for value: USER_MANAGEMENT
        /// </summary>
        [EnumMember(Value = "USER_MANAGEMENT")]
        USERMANAGEMENT = 27,

        /// <summary>
        /// Enum APPLEIDAUTH for value: APPLE_ID_AUTH
        /// </summary>
        [EnumMember(Value = "APPLE_ID_AUTH")]
        APPLEIDAUTH = 28

    }

}
