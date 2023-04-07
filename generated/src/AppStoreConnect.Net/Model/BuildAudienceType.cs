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
    /// Defines BuildAudienceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuildAudienceType
    {
        /// <summary>
        /// Enum INTERNALONLY for value: INTERNAL_ONLY
        /// </summary>
        [EnumMember(Value = "INTERNAL_ONLY")]
        INTERNALONLY = 1,

        /// <summary>
        /// Enum APPSTOREELIGIBLE for value: APP_STORE_ELIGIBLE
        /// </summary>
        [EnumMember(Value = "APP_STORE_ELIGIBLE")]
        APPSTOREELIGIBLE = 2

    }

}