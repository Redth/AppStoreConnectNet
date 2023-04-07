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
    ///  Class for testing BetaAppReviewDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BetaAppReviewDetailsApiTests : IDisposable
    {
        private BetaAppReviewDetailsApi instance;

        public BetaAppReviewDetailsApiTests()
        {
            instance = new BetaAppReviewDetailsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BetaAppReviewDetailsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BetaAppReviewDetailsApi
            //Assert.IsType<BetaAppReviewDetailsApi>(instance);
        }

        /// <summary>
        /// Test BetaAppReviewDetailsAppGetToOneRelated
        /// </summary>
        [Fact]
        public void BetaAppReviewDetailsAppGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsApps = null;
            //var response = instance.BetaAppReviewDetailsAppGetToOneRelated(id, fieldsApps);
            //Assert.IsType<AppResponse>(response);
        }

        /// <summary>
        /// Test BetaAppReviewDetailsGetCollection
        /// </summary>
        [Fact]
        public void BetaAppReviewDetailsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> filterApp = null;
            //List<string>? fieldsBetaAppReviewDetails = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsApps = null;
            //var response = instance.BetaAppReviewDetailsGetCollection(filterApp, fieldsBetaAppReviewDetails, limit, include, fieldsApps);
            //Assert.IsType<BetaAppReviewDetailsResponse>(response);
        }

        /// <summary>
        /// Test BetaAppReviewDetailsGetInstance
        /// </summary>
        [Fact]
        public void BetaAppReviewDetailsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaAppReviewDetails = null;
            //List<string>? include = null;
            //List<string>? fieldsApps = null;
            //var response = instance.BetaAppReviewDetailsGetInstance(id, fieldsBetaAppReviewDetails, include, fieldsApps);
            //Assert.IsType<BetaAppReviewDetailResponse>(response);
        }

        /// <summary>
        /// Test BetaAppReviewDetailsUpdateInstance
        /// </summary>
        [Fact]
        public void BetaAppReviewDetailsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BetaAppReviewDetailUpdateRequest betaAppReviewDetailUpdateRequest = null;
            //var response = instance.BetaAppReviewDetailsUpdateInstance(id, betaAppReviewDetailUpdateRequest);
            //Assert.IsType<BetaAppReviewDetailResponse>(response);
        }
    }
}