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
    ///  Class for testing BetaAppReviewSubmissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BetaAppReviewSubmissionsApiTests : IDisposable
    {
        private BetaAppReviewSubmissionsApi instance;

        public BetaAppReviewSubmissionsApiTests()
        {
            instance = new BetaAppReviewSubmissionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BetaAppReviewSubmissionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BetaAppReviewSubmissionsApi
            //Assert.IsType<BetaAppReviewSubmissionsApi>(instance);
        }

        /// <summary>
        /// Test BetaAppReviewSubmissionsBuildGetToOneRelated
        /// </summary>
        [Fact]
        public void BetaAppReviewSubmissionsBuildGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.BetaAppReviewSubmissionsBuildGetToOneRelated(id, fieldsBuilds);
            //Assert.IsType<BuildResponse>(response);
        }

        /// <summary>
        /// Test BetaAppReviewSubmissionsCreateInstance
        /// </summary>
        [Fact]
        public void BetaAppReviewSubmissionsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BetaAppReviewSubmissionCreateRequest betaAppReviewSubmissionCreateRequest = null;
            //var response = instance.BetaAppReviewSubmissionsCreateInstance(betaAppReviewSubmissionCreateRequest);
            //Assert.IsType<BetaAppReviewSubmissionResponse>(response);
        }

        /// <summary>
        /// Test BetaAppReviewSubmissionsGetCollection
        /// </summary>
        [Fact]
        public void BetaAppReviewSubmissionsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> filterBuild = null;
            //List<string>? filterBetaReviewState = null;
            //List<string>? fieldsBetaAppReviewSubmissions = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.BetaAppReviewSubmissionsGetCollection(filterBuild, filterBetaReviewState, fieldsBetaAppReviewSubmissions, limit, include, fieldsBuilds);
            //Assert.IsType<BetaAppReviewSubmissionsResponse>(response);
        }

        /// <summary>
        /// Test BetaAppReviewSubmissionsGetInstance
        /// </summary>
        [Fact]
        public void BetaAppReviewSubmissionsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaAppReviewSubmissions = null;
            //List<string>? include = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.BetaAppReviewSubmissionsGetInstance(id, fieldsBetaAppReviewSubmissions, include, fieldsBuilds);
            //Assert.IsType<BetaAppReviewSubmissionResponse>(response);
        }
    }
}
