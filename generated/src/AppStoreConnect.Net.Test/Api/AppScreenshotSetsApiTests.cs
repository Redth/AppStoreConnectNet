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
    ///  Class for testing AppScreenshotSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppScreenshotSetsApiTests : IDisposable
    {
        private AppScreenshotSetsApi instance;

        public AppScreenshotSetsApiTests()
        {
            instance = new AppScreenshotSetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppScreenshotSetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppScreenshotSetsApi
            //Assert.IsType<AppScreenshotSetsApi>(instance);
        }

        /// <summary>
        /// Test AppScreenshotSetsAppScreenshotsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppScreenshotSetsAppScreenshotsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppScreenshotSets = null;
            //List<string>? fieldsAppScreenshots = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppScreenshotSetsAppScreenshotsGetToManyRelated(id, fieldsAppScreenshotSets, fieldsAppScreenshots, limit, include);
            //Assert.IsType<AppScreenshotsResponse>(response);
        }

        /// <summary>
        /// Test AppScreenshotSetsAppScreenshotsGetToManyRelationship
        /// </summary>
        [Fact]
        public void AppScreenshotSetsAppScreenshotsGetToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //var response = instance.AppScreenshotSetsAppScreenshotsGetToManyRelationship(id, limit);
            //Assert.IsType<AppScreenshotSetAppScreenshotsLinkagesResponse>(response);
        }

        /// <summary>
        /// Test AppScreenshotSetsAppScreenshotsReplaceToManyRelationship
        /// </summary>
        [Fact]
        public void AppScreenshotSetsAppScreenshotsReplaceToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppScreenshotSetAppScreenshotsLinkagesRequest appScreenshotSetAppScreenshotsLinkagesRequest = null;
            //instance.AppScreenshotSetsAppScreenshotsReplaceToManyRelationship(id, appScreenshotSetAppScreenshotsLinkagesRequest);
        }

        /// <summary>
        /// Test AppScreenshotSetsCreateInstance
        /// </summary>
        [Fact]
        public void AppScreenshotSetsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppScreenshotSetCreateRequest appScreenshotSetCreateRequest = null;
            //var response = instance.AppScreenshotSetsCreateInstance(appScreenshotSetCreateRequest);
            //Assert.IsType<AppScreenshotSetResponse>(response);
        }

        /// <summary>
        /// Test AppScreenshotSetsDeleteInstance
        /// </summary>
        [Fact]
        public void AppScreenshotSetsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppScreenshotSetsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppScreenshotSetsGetInstance
        /// </summary>
        [Fact]
        public void AppScreenshotSetsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppScreenshotSets = null;
            //List<string>? include = null;
            //List<string>? fieldsAppScreenshots = null;
            //int? limitAppScreenshots = null;
            //var response = instance.AppScreenshotSetsGetInstance(id, fieldsAppScreenshotSets, include, fieldsAppScreenshots, limitAppScreenshots);
            //Assert.IsType<AppScreenshotSetResponse>(response);
        }
    }
}