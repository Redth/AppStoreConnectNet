/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using AppStoreConnect.Client;
using AppStoreConnect.Api;
// uncomment below to import models
//using AppStoreConnect.Model;

namespace AppStoreConnect.Test.Api
{
    /// <summary>
    ///  Class for testing InAppPurchasePriceSchedulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InAppPurchasePriceSchedulesApiTests : IDisposable
    {
        private InAppPurchasePriceSchedulesApi instance;

        public InAppPurchasePriceSchedulesApiTests()
        {
            instance = new InAppPurchasePriceSchedulesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InAppPurchasePriceSchedulesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InAppPurchasePriceSchedulesApi
            //Assert.IsType<InAppPurchasePriceSchedulesApi>(instance);
        }

        /// <summary>
        /// Test InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated
        /// </summary>
        [Fact]
        public void InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterTerritory = null;
            //List<string>? fieldsInAppPurchasePricePoints = null;
            //List<string>? fieldsInAppPurchasePrices = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsInAppPurchasePrices, fieldsTerritories, limit, include);
            //Assert.IsType<InAppPurchasePricesResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated
        /// </summary>
        [Fact]
        public void InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsTerritories = null;
            //var response = instance.InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated(id, fieldsTerritories);
            //Assert.IsType<TerritoryResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasePriceSchedulesCreateInstance
        /// </summary>
        [Fact]
        public void InAppPurchasePriceSchedulesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InAppPurchasePriceScheduleCreateRequest inAppPurchasePriceScheduleCreateRequest = null;
            //var response = instance.InAppPurchasePriceSchedulesCreateInstance(inAppPurchasePriceScheduleCreateRequest);
            //Assert.IsType<InAppPurchasePriceScheduleResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasePriceSchedulesGetInstance
        /// </summary>
        [Fact]
        public void InAppPurchasePriceSchedulesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchasePriceSchedules = null;
            //List<string>? include = null;
            //List<string>? fieldsInAppPurchasePrices = null;
            //List<string>? fieldsTerritories = null;
            //int? limitAutomaticPrices = null;
            //int? limitManualPrices = null;
            //var response = instance.InAppPurchasePriceSchedulesGetInstance(id, fieldsInAppPurchasePriceSchedules, include, fieldsInAppPurchasePrices, fieldsTerritories, limitAutomaticPrices, limitManualPrices);
            //Assert.IsType<InAppPurchasePriceScheduleResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasePriceSchedulesManualPricesGetToManyRelated
        /// </summary>
        [Fact]
        public void InAppPurchasePriceSchedulesManualPricesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterTerritory = null;
            //List<string>? fieldsInAppPurchasePricePoints = null;
            //List<string>? fieldsInAppPurchasePrices = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasePriceSchedulesManualPricesGetToManyRelated(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsInAppPurchasePrices, fieldsTerritories, limit, include);
            //Assert.IsType<InAppPurchasePricesResponse>(response);
        }
    }
}
