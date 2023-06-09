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
    ///  Class for testing AppEventLocalizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppEventLocalizationsApiTests : IDisposable
    {
        private AppEventLocalizationsApi instance;

        public AppEventLocalizationsApiTests()
        {
            instance = new AppEventLocalizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppEventLocalizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppEventLocalizationsApi
            //Assert.IsType<AppEventLocalizationsApi>(instance);
        }

        /// <summary>
        /// Test AppEventLocalizationsAppEventScreenshotsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppEventLocalizationsAppEventScreenshotsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppEventScreenshots = null;
            //List<string>? fieldsAppEventLocalizations = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppEventLocalizationsAppEventScreenshotsGetToManyRelated(id, fieldsAppEventScreenshots, fieldsAppEventLocalizations, limit, include);
            //Assert.IsType<AppEventScreenshotsResponse>(response);
        }

        /// <summary>
        /// Test AppEventLocalizationsAppEventVideoClipsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppEventLocalizationsAppEventVideoClipsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppEventVideoClips = null;
            //List<string>? fieldsAppEventLocalizations = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppEventLocalizationsAppEventVideoClipsGetToManyRelated(id, fieldsAppEventVideoClips, fieldsAppEventLocalizations, limit, include);
            //Assert.IsType<AppEventVideoClipsResponse>(response);
        }

        /// <summary>
        /// Test AppEventLocalizationsCreateInstance
        /// </summary>
        [Fact]
        public void AppEventLocalizationsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppEventLocalizationCreateRequest appEventLocalizationCreateRequest = null;
            //var response = instance.AppEventLocalizationsCreateInstance(appEventLocalizationCreateRequest);
            //Assert.IsType<AppEventLocalizationResponse>(response);
        }

        /// <summary>
        /// Test AppEventLocalizationsDeleteInstance
        /// </summary>
        [Fact]
        public void AppEventLocalizationsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppEventLocalizationsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppEventLocalizationsGetInstance
        /// </summary>
        [Fact]
        public void AppEventLocalizationsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppEventLocalizations = null;
            //List<string>? include = null;
            //List<string>? fieldsAppEventScreenshots = null;
            //List<string>? fieldsAppEventVideoClips = null;
            //int? limitAppEventScreenshots = null;
            //int? limitAppEventVideoClips = null;
            //var response = instance.AppEventLocalizationsGetInstance(id, fieldsAppEventLocalizations, include, fieldsAppEventScreenshots, fieldsAppEventVideoClips, limitAppEventScreenshots, limitAppEventVideoClips);
            //Assert.IsType<AppEventLocalizationResponse>(response);
        }

        /// <summary>
        /// Test AppEventLocalizationsUpdateInstance
        /// </summary>
        [Fact]
        public void AppEventLocalizationsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppEventLocalizationUpdateRequest appEventLocalizationUpdateRequest = null;
            //var response = instance.AppEventLocalizationsUpdateInstance(id, appEventLocalizationUpdateRequest);
            //Assert.IsType<AppEventLocalizationResponse>(response);
        }
    }
}
