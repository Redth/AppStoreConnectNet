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
    ///  Class for testing AppClipHeaderImagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppClipHeaderImagesApiTests : IDisposable
    {
        private AppClipHeaderImagesApi instance;

        public AppClipHeaderImagesApiTests()
        {
            instance = new AppClipHeaderImagesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppClipHeaderImagesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppClipHeaderImagesApi
            //Assert.IsType<AppClipHeaderImagesApi>(instance);
        }

        /// <summary>
        /// Test AppClipHeaderImagesCreateInstance
        /// </summary>
        [Fact]
        public void AppClipHeaderImagesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppClipHeaderImageCreateRequest appClipHeaderImageCreateRequest = null;
            //var response = instance.AppClipHeaderImagesCreateInstance(appClipHeaderImageCreateRequest);
            //Assert.IsType<AppClipHeaderImageResponse>(response);
        }

        /// <summary>
        /// Test AppClipHeaderImagesDeleteInstance
        /// </summary>
        [Fact]
        public void AppClipHeaderImagesDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppClipHeaderImagesDeleteInstance(id);
        }

        /// <summary>
        /// Test AppClipHeaderImagesGetInstance
        /// </summary>
        [Fact]
        public void AppClipHeaderImagesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppClipHeaderImages = null;
            //List<string>? include = null;
            //var response = instance.AppClipHeaderImagesGetInstance(id, fieldsAppClipHeaderImages, include);
            //Assert.IsType<AppClipHeaderImageResponse>(response);
        }

        /// <summary>
        /// Test AppClipHeaderImagesUpdateInstance
        /// </summary>
        [Fact]
        public void AppClipHeaderImagesUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppClipHeaderImageUpdateRequest appClipHeaderImageUpdateRequest = null;
            //var response = instance.AppClipHeaderImagesUpdateInstance(id, appClipHeaderImageUpdateRequest);
            //Assert.IsType<AppClipHeaderImageResponse>(response);
        }
    }
}