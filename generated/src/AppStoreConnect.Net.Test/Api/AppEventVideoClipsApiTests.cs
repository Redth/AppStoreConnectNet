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
    ///  Class for testing AppEventVideoClipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppEventVideoClipsApiTests : IDisposable
    {
        private AppEventVideoClipsApi instance;

        public AppEventVideoClipsApiTests()
        {
            instance = new AppEventVideoClipsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppEventVideoClipsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppEventVideoClipsApi
            //Assert.IsType<AppEventVideoClipsApi>(instance);
        }

        /// <summary>
        /// Test AppEventVideoClipsCreateInstance
        /// </summary>
        [Fact]
        public void AppEventVideoClipsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppEventVideoClipCreateRequest appEventVideoClipCreateRequest = null;
            //var response = instance.AppEventVideoClipsCreateInstance(appEventVideoClipCreateRequest);
            //Assert.IsType<AppEventVideoClipResponse>(response);
        }

        /// <summary>
        /// Test AppEventVideoClipsDeleteInstance
        /// </summary>
        [Fact]
        public void AppEventVideoClipsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppEventVideoClipsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppEventVideoClipsGetInstance
        /// </summary>
        [Fact]
        public void AppEventVideoClipsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppEventVideoClips = null;
            //List<string>? include = null;
            //var response = instance.AppEventVideoClipsGetInstance(id, fieldsAppEventVideoClips, include);
            //Assert.IsType<AppEventVideoClipResponse>(response);
        }

        /// <summary>
        /// Test AppEventVideoClipsUpdateInstance
        /// </summary>
        [Fact]
        public void AppEventVideoClipsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppEventVideoClipUpdateRequest appEventVideoClipUpdateRequest = null;
            //var response = instance.AppEventVideoClipsUpdateInstance(id, appEventVideoClipUpdateRequest);
            //Assert.IsType<AppEventVideoClipResponse>(response);
        }
    }
}
