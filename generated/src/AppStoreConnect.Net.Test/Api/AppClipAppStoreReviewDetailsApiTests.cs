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
    ///  Class for testing AppClipAppStoreReviewDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppClipAppStoreReviewDetailsApiTests : IDisposable
    {
        private AppClipAppStoreReviewDetailsApi instance;

        public AppClipAppStoreReviewDetailsApiTests()
        {
            instance = new AppClipAppStoreReviewDetailsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppClipAppStoreReviewDetailsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppClipAppStoreReviewDetailsApi
            //Assert.IsType<AppClipAppStoreReviewDetailsApi>(instance);
        }

        /// <summary>
        /// Test AppClipAppStoreReviewDetailsCreateInstance
        /// </summary>
        [Fact]
        public void AppClipAppStoreReviewDetailsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppClipAppStoreReviewDetailCreateRequest appClipAppStoreReviewDetailCreateRequest = null;
            //var response = instance.AppClipAppStoreReviewDetailsCreateInstance(appClipAppStoreReviewDetailCreateRequest);
            //Assert.IsType<AppClipAppStoreReviewDetailResponse>(response);
        }

        /// <summary>
        /// Test AppClipAppStoreReviewDetailsGetInstance
        /// </summary>
        [Fact]
        public void AppClipAppStoreReviewDetailsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppClipAppStoreReviewDetails = null;
            //List<string>? include = null;
            //var response = instance.AppClipAppStoreReviewDetailsGetInstance(id, fieldsAppClipAppStoreReviewDetails, include);
            //Assert.IsType<AppClipAppStoreReviewDetailResponse>(response);
        }

        /// <summary>
        /// Test AppClipAppStoreReviewDetailsUpdateInstance
        /// </summary>
        [Fact]
        public void AppClipAppStoreReviewDetailsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppClipAppStoreReviewDetailUpdateRequest appClipAppStoreReviewDetailUpdateRequest = null;
            //var response = instance.AppClipAppStoreReviewDetailsUpdateInstance(id, appClipAppStoreReviewDetailUpdateRequest);
            //Assert.IsType<AppClipAppStoreReviewDetailResponse>(response);
        }
    }
}
