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
    ///  Class for testing AppEventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppEventsApiTests : IDisposable
    {
        private AppEventsApi instance;

        public AppEventsApiTests()
        {
            instance = new AppEventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppEventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppEventsApi
            //Assert.IsType<AppEventsApi>(instance);
        }

        /// <summary>
        /// Test AppEventsCreateInstance
        /// </summary>
        [Fact]
        public void AppEventsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppEventCreateRequest appEventCreateRequest = null;
            //var response = instance.AppEventsCreateInstance(appEventCreateRequest);
            //Assert.IsType<AppEventResponse>(response);
        }

        /// <summary>
        /// Test AppEventsDeleteInstance
        /// </summary>
        [Fact]
        public void AppEventsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppEventsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppEventsGetInstance
        /// </summary>
        [Fact]
        public void AppEventsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppEvents = null;
            //List<string>? include = null;
            //List<string>? fieldsAppEventLocalizations = null;
            //int? limitLocalizations = null;
            //var response = instance.AppEventsGetInstance(id, fieldsAppEvents, include, fieldsAppEventLocalizations, limitLocalizations);
            //Assert.IsType<AppEventResponse>(response);
        }

        /// <summary>
        /// Test AppEventsLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppEventsLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppEventScreenshots = null;
            //List<string>? fieldsAppEventVideoClips = null;
            //List<string>? fieldsAppEventLocalizations = null;
            //List<string>? fieldsAppEvents = null;
            //int? limit = null;
            //int? limitAppEventScreenshots = null;
            //int? limitAppEventVideoClips = null;
            //List<string>? include = null;
            //var response = instance.AppEventsLocalizationsGetToManyRelated(id, fieldsAppEventScreenshots, fieldsAppEventVideoClips, fieldsAppEventLocalizations, fieldsAppEvents, limit, limitAppEventScreenshots, limitAppEventVideoClips, include);
            //Assert.IsType<AppEventLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test AppEventsUpdateInstance
        /// </summary>
        [Fact]
        public void AppEventsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppEventUpdateRequest appEventUpdateRequest = null;
            //var response = instance.AppEventsUpdateInstance(id, appEventUpdateRequest);
            //Assert.IsType<AppEventResponse>(response);
        }
    }
}
