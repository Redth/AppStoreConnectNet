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
    ///  Class for testing ReviewSubmissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReviewSubmissionsApiTests : IDisposable
    {
        private ReviewSubmissionsApi instance;

        public ReviewSubmissionsApiTests()
        {
            instance = new ReviewSubmissionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReviewSubmissionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReviewSubmissionsApi
            //Assert.IsType<ReviewSubmissionsApi>(instance);
        }

        /// <summary>
        /// Test ReviewSubmissionsCreateInstance
        /// </summary>
        [Fact]
        public void ReviewSubmissionsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReviewSubmissionCreateRequest reviewSubmissionCreateRequest = null;
            //var response = instance.ReviewSubmissionsCreateInstance(reviewSubmissionCreateRequest);
            //Assert.IsType<ReviewSubmissionResponse>(response);
        }

        /// <summary>
        /// Test ReviewSubmissionsGetCollection
        /// </summary>
        [Fact]
        public void ReviewSubmissionsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> filterApp = null;
            //List<string>? filterPlatform = null;
            //List<string>? filterState = null;
            //List<string>? fieldsReviewSubmissions = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsReviewSubmissionItems = null;
            //int? limitItems = null;
            //var response = instance.ReviewSubmissionsGetCollection(filterApp, filterPlatform, filterState, fieldsReviewSubmissions, limit, include, fieldsReviewSubmissionItems, limitItems);
            //Assert.IsType<ReviewSubmissionsResponse>(response);
        }

        /// <summary>
        /// Test ReviewSubmissionsGetInstance
        /// </summary>
        [Fact]
        public void ReviewSubmissionsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsReviewSubmissions = null;
            //List<string>? include = null;
            //List<string>? fieldsReviewSubmissionItems = null;
            //int? limitItems = null;
            //var response = instance.ReviewSubmissionsGetInstance(id, fieldsReviewSubmissions, include, fieldsReviewSubmissionItems, limitItems);
            //Assert.IsType<ReviewSubmissionResponse>(response);
        }

        /// <summary>
        /// Test ReviewSubmissionsItemsGetToManyRelated
        /// </summary>
        [Fact]
        public void ReviewSubmissionsItemsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersionExperiments = null;
            //List<string>? fieldsReviewSubmissionItems = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsAppCustomProductPageVersions = null;
            //List<string>? fieldsAppEvents = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.ReviewSubmissionsItemsGetToManyRelated(id, fieldsAppStoreVersionExperiments, fieldsReviewSubmissionItems, fieldsAppStoreVersions, fieldsAppCustomProductPageVersions, fieldsAppEvents, limit, include);
            //Assert.IsType<ReviewSubmissionItemsResponse>(response);
        }

        /// <summary>
        /// Test ReviewSubmissionsUpdateInstance
        /// </summary>
        [Fact]
        public void ReviewSubmissionsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ReviewSubmissionUpdateRequest reviewSubmissionUpdateRequest = null;
            //var response = instance.ReviewSubmissionsUpdateInstance(id, reviewSubmissionUpdateRequest);
            //Assert.IsType<ReviewSubmissionResponse>(response);
        }
    }
}
