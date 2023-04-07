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
    /// Defines InternalBetaState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InternalBetaState
    {
        /// <summary>
        /// Enum PROCESSING for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING = 1,

        /// <summary>
        /// Enum PROCESSINGEXCEPTION for value: PROCESSING_EXCEPTION
        /// </summary>
        [EnumMember(Value = "PROCESSING_EXCEPTION")]
        PROCESSINGEXCEPTION = 2,

        /// <summary>
        /// Enum MISSINGEXPORTCOMPLIANCE for value: MISSING_EXPORT_COMPLIANCE
        /// </summary>
        [EnumMember(Value = "MISSING_EXPORT_COMPLIANCE")]
        MISSINGEXPORTCOMPLIANCE = 3,

        /// <summary>
        /// Enum READYFORBETATESTING for value: READY_FOR_BETA_TESTING
        /// </summary>
        [EnumMember(Value = "READY_FOR_BETA_TESTING")]
        READYFORBETATESTING = 4,

        /// <summary>
        /// Enum INBETATESTING for value: IN_BETA_TESTING
        /// </summary>
        [EnumMember(Value = "IN_BETA_TESTING")]
        INBETATESTING = 5,

        /// <summary>
        /// Enum EXPIRED for value: EXPIRED
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED = 6,

        /// <summary>
        /// Enum INEXPORTCOMPLIANCEREVIEW for value: IN_EXPORT_COMPLIANCE_REVIEW
        /// </summary>
        [EnumMember(Value = "IN_EXPORT_COMPLIANCE_REVIEW")]
        INEXPORTCOMPLIANCEREVIEW = 7

    }

}
