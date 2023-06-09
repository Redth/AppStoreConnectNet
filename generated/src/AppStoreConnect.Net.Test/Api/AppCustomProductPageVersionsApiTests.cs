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
    ///  Class for testing AppCustomProductPageVersionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppCustomProductPageVersionsApiTests : IDisposable
    {
        private AppCustomProductPageVersionsApi instance;

        public AppCustomProductPageVersionsApiTests()
        {
            instance = new AppCustomProductPageVersionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppCustomProductPageVersionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppCustomProductPageVersionsApi
            //Assert.IsType<AppCustomProductPageVersionsApi>(instance);
        }

        /// <summary>
        /// Test AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterLocale = null;
            //List<string>? fieldsAppScreenshotSets = null;
            //List<string>? fieldsAppCustomProductPageLocalizations = null;
            //List<string>? fieldsAppCustomProductPageVersions = null;
            //List<string>? fieldsAppPreviewSets = null;
            //int? limit = null;
            //int? limitAppScreenshotSets = null;
            //int? limitAppPreviewSets = null;
            //List<string>? include = null;
            //var response = instance.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelated(id, filterLocale, fieldsAppScreenshotSets, fieldsAppCustomProductPageLocalizations, fieldsAppCustomProductPageVersions, fieldsAppPreviewSets, limit, limitAppScreenshotSets, limitAppPreviewSets, include);
            //Assert.IsType<AppCustomProductPageLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test AppCustomProductPageVersionsCreateInstance
        /// </summary>
        [Fact]
        public void AppCustomProductPageVersionsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppCustomProductPageVersionCreateRequest appCustomProductPageVersionCreateRequest = null;
            //var response = instance.AppCustomProductPageVersionsCreateInstance(appCustomProductPageVersionCreateRequest);
            //Assert.IsType<AppCustomProductPageVersionResponse>(response);
        }

        /// <summary>
        /// Test AppCustomProductPageVersionsGetInstance
        /// </summary>
        [Fact]
        public void AppCustomProductPageVersionsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppCustomProductPageVersions = null;
            //List<string>? include = null;
            //List<string>? fieldsAppCustomProductPageLocalizations = null;
            //int? limitAppCustomProductPageLocalizations = null;
            //var response = instance.AppCustomProductPageVersionsGetInstance(id, fieldsAppCustomProductPageVersions, include, fieldsAppCustomProductPageLocalizations, limitAppCustomProductPageLocalizations);
            //Assert.IsType<AppCustomProductPageVersionResponse>(response);
        }
    }
}
