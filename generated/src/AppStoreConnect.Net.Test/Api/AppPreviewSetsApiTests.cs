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
    ///  Class for testing AppPreviewSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppPreviewSetsApiTests : IDisposable
    {
        private AppPreviewSetsApi instance;

        public AppPreviewSetsApiTests()
        {
            instance = new AppPreviewSetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppPreviewSetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppPreviewSetsApi
            //Assert.IsType<AppPreviewSetsApi>(instance);
        }

        /// <summary>
        /// Test AppPreviewSetsAppPreviewsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppPreviewSetsAppPreviewsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppPreviews = null;
            //List<string>? fieldsAppPreviewSets = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppPreviewSetsAppPreviewsGetToManyRelated(id, fieldsAppPreviews, fieldsAppPreviewSets, limit, include);
            //Assert.IsType<AppPreviewsResponse>(response);
        }

        /// <summary>
        /// Test AppPreviewSetsAppPreviewsGetToManyRelationship
        /// </summary>
        [Fact]
        public void AppPreviewSetsAppPreviewsGetToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //var response = instance.AppPreviewSetsAppPreviewsGetToManyRelationship(id, limit);
            //Assert.IsType<AppPreviewSetAppPreviewsLinkagesResponse>(response);
        }

        /// <summary>
        /// Test AppPreviewSetsAppPreviewsReplaceToManyRelationship
        /// </summary>
        [Fact]
        public void AppPreviewSetsAppPreviewsReplaceToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppPreviewSetAppPreviewsLinkagesRequest appPreviewSetAppPreviewsLinkagesRequest = null;
            //instance.AppPreviewSetsAppPreviewsReplaceToManyRelationship(id, appPreviewSetAppPreviewsLinkagesRequest);
        }

        /// <summary>
        /// Test AppPreviewSetsCreateInstance
        /// </summary>
        [Fact]
        public void AppPreviewSetsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppPreviewSetCreateRequest appPreviewSetCreateRequest = null;
            //var response = instance.AppPreviewSetsCreateInstance(appPreviewSetCreateRequest);
            //Assert.IsType<AppPreviewSetResponse>(response);
        }

        /// <summary>
        /// Test AppPreviewSetsDeleteInstance
        /// </summary>
        [Fact]
        public void AppPreviewSetsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppPreviewSetsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppPreviewSetsGetInstance
        /// </summary>
        [Fact]
        public void AppPreviewSetsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppPreviewSets = null;
            //List<string>? include = null;
            //List<string>? fieldsAppPreviews = null;
            //int? limitAppPreviews = null;
            //var response = instance.AppPreviewSetsGetInstance(id, fieldsAppPreviewSets, include, fieldsAppPreviews, limitAppPreviews);
            //Assert.IsType<AppPreviewSetResponse>(response);
        }
    }
}
