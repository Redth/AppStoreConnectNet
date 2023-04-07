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
    ///  Class for testing AppClipAdvancedExperiencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppClipAdvancedExperiencesApiTests : IDisposable
    {
        private AppClipAdvancedExperiencesApi instance;

        public AppClipAdvancedExperiencesApiTests()
        {
            instance = new AppClipAdvancedExperiencesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppClipAdvancedExperiencesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppClipAdvancedExperiencesApi
            //Assert.IsType<AppClipAdvancedExperiencesApi>(instance);
        }

        /// <summary>
        /// Test AppClipAdvancedExperiencesCreateInstance
        /// </summary>
        [Fact]
        public void AppClipAdvancedExperiencesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppClipAdvancedExperienceCreateRequest appClipAdvancedExperienceCreateRequest = null;
            //var response = instance.AppClipAdvancedExperiencesCreateInstance(appClipAdvancedExperienceCreateRequest);
            //Assert.IsType<AppClipAdvancedExperienceResponse>(response);
        }

        /// <summary>
        /// Test AppClipAdvancedExperiencesGetInstance
        /// </summary>
        [Fact]
        public void AppClipAdvancedExperiencesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppClipAdvancedExperiences = null;
            //List<string>? include = null;
            //int? limitLocalizations = null;
            //var response = instance.AppClipAdvancedExperiencesGetInstance(id, fieldsAppClipAdvancedExperiences, include, limitLocalizations);
            //Assert.IsType<AppClipAdvancedExperienceResponse>(response);
        }

        /// <summary>
        /// Test AppClipAdvancedExperiencesUpdateInstance
        /// </summary>
        [Fact]
        public void AppClipAdvancedExperiencesUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppClipAdvancedExperienceUpdateRequest appClipAdvancedExperienceUpdateRequest = null;
            //var response = instance.AppClipAdvancedExperiencesUpdateInstance(id, appClipAdvancedExperienceUpdateRequest);
            //Assert.IsType<AppClipAdvancedExperienceResponse>(response);
        }
    }
}
