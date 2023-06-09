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
    /// Defines CiGitRefKind
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CiGitRefKind
    {
        /// <summary>
        /// Enum BRANCH for value: BRANCH
        /// </summary>
        [EnumMember(Value = "BRANCH")]
        BRANCH = 1,

        /// <summary>
        /// Enum TAG for value: TAG
        /// </summary>
        [EnumMember(Value = "TAG")]
        TAG = 2

    }

}
