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
    ///  Class for testing InAppPurchasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InAppPurchasesApiTests : IDisposable
    {
        private InAppPurchasesApi instance;

        public InAppPurchasesApiTests()
        {
            instance = new InAppPurchasesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InAppPurchasesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InAppPurchasesApi
            //Assert.IsType<InAppPurchasesApi>(instance);
        }

        /// <summary>
        /// Test InAppPurchasesAppStoreReviewScreenshotGetToOneRelated
        /// </summary>
        [Fact]
        public void InAppPurchasesAppStoreReviewScreenshotGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasesAppStoreReviewScreenshotGetToOneRelated(id, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsInAppPurchases, include);
            //Assert.IsType<InAppPurchaseAppStoreReviewScreenshotResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesContentGetToOneRelated
        /// </summary>
        [Fact]
        public void InAppPurchasesContentGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsInAppPurchaseContents = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasesContentGetToOneRelated(id, fieldsInAppPurchases, fieldsInAppPurchaseContents, include);
            //Assert.IsType<InAppPurchaseContentResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesCreateInstance
        /// </summary>
        [Fact]
        public void InAppPurchasesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InAppPurchaseV2CreateRequest inAppPurchaseV2CreateRequest = null;
            //var response = instance.InAppPurchasesCreateInstance(inAppPurchaseV2CreateRequest);
            //Assert.IsType<InAppPurchaseV2Response>(response);
        }

        /// <summary>
        /// Test InAppPurchasesDeleteInstance
        /// </summary>
        [Fact]
        public void InAppPurchasesDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.InAppPurchasesDeleteInstance(id);
        }

        /// <summary>
        /// Test InAppPurchasesGetInstance
        /// </summary>
        [Fact]
        public void InAppPurchasesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? include = null;
            //int? limitApps = null;
            //var response = instance.InAppPurchasesGetInstance(id, fieldsInAppPurchases, include, limitApps);
            //Assert.IsType<InAppPurchaseResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesGetInstance_0
        /// </summary>
        [Fact]
        public void InAppPurchasesGetInstance_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? include = null;
            //List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null;
            //List<string>? fieldsPromotedPurchases = null;
            //List<string>? fieldsInAppPurchasePricePoints = null;
            //List<string>? fieldsInAppPurchaseLocalizations = null;
            //List<string>? fieldsInAppPurchasePriceSchedules = null;
            //List<string>? fieldsInAppPurchaseContents = null;
            //int? limitInAppPurchaseLocalizations = null;
            //int? limitPricePoints = null;
            //var response = instance.InAppPurchasesGetInstance_0(id, fieldsInAppPurchases, include, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsPromotedPurchases, fieldsInAppPurchasePricePoints, fieldsInAppPurchaseLocalizations, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchaseContents, limitInAppPurchaseLocalizations, limitPricePoints);
            //Assert.IsType<InAppPurchaseV2Response>(response);
        }

        /// <summary>
        /// Test InAppPurchasesIapPriceScheduleGetToOneRelated
        /// </summary>
        [Fact]
        public void InAppPurchasesIapPriceScheduleGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchasePrices = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsInAppPurchasePriceSchedules = null;
            //List<string>? fieldsTerritories = null;
            //int? limitManualPrices = null;
            //int? limitAutomaticPrices = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasesIapPriceScheduleGetToOneRelated(id, fieldsInAppPurchasePrices, fieldsInAppPurchases, fieldsInAppPurchasePriceSchedules, fieldsTerritories, limitManualPrices, limitAutomaticPrices, include);
            //Assert.IsType<InAppPurchasePriceScheduleResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesInAppPurchaseLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void InAppPurchasesInAppPurchaseLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchaseLocalizations = null;
            //List<string>? fieldsInAppPurchases = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasesInAppPurchaseLocalizationsGetToManyRelated(id, fieldsInAppPurchaseLocalizations, fieldsInAppPurchases, limit, include);
            //Assert.IsType<InAppPurchaseLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesPricePointsGetToManyRelated
        /// </summary>
        [Fact]
        public void InAppPurchasesPricePointsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterPriceTier = null;
            //List<string>? filterTerritory = null;
            //List<string>? fieldsInAppPurchasePricePoints = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasesPricePointsGetToManyRelated(id, filterPriceTier, filterTerritory, fieldsInAppPurchasePricePoints, fieldsTerritories, limit, include);
            //Assert.IsType<InAppPurchasePricePointsResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesPromotedPurchaseGetToOneRelated
        /// </summary>
        [Fact]
        public void InAppPurchasesPromotedPurchaseGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsPromotedPurchases = null;
            //List<string>? fieldsSubscriptions = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsPromotedPurchaseImages = null;
            //int? limitPromotionImages = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchasesPromotedPurchaseGetToOneRelated(id, fieldsPromotedPurchases, fieldsSubscriptions, fieldsInAppPurchases, fieldsPromotedPurchaseImages, limitPromotionImages, include);
            //Assert.IsType<PromotedPurchaseResponse>(response);
        }

        /// <summary>
        /// Test InAppPurchasesUpdateInstance
        /// </summary>
        [Fact]
        public void InAppPurchasesUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //InAppPurchaseV2UpdateRequest inAppPurchaseV2UpdateRequest = null;
            //var response = instance.InAppPurchasesUpdateInstance(id, inAppPurchaseV2UpdateRequest);
            //Assert.IsType<InAppPurchaseV2Response>(response);
        }
    }
}