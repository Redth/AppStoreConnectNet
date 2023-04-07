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
    ///  Class for testing AppStoreVersionExperimentTreatmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppStoreVersionExperimentTreatmentsApiTests : IDisposable
    {
        private AppStoreVersionExperimentTreatmentsApi instance;

        public AppStoreVersionExperimentTreatmentsApiTests()
        {
            instance = new AppStoreVersionExperimentTreatmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppStoreVersionExperimentTreatmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppStoreVersionExperimentTreatmentsApi
            //Assert.IsType<AppStoreVersionExperimentTreatmentsApi>(instance);
        }

        /// <summary>
        /// Test AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterLocale = null;
            //List<string>? fieldsAppScreenshotSets = null;
            //List<string>? fieldsAppStoreVersionExperimentTreatments = null;
            //List<string>? fieldsAppStoreVersionExperimentTreatmentLocalizations = null;
            //List<string>? fieldsAppPreviewSets = null;
            //int? limit = null;
            //int? limitAppScreenshotSets = null;
            //int? limitAppPreviewSets = null;
            //List<string>? include = null;
            //var response = instance.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated(id, filterLocale, fieldsAppScreenshotSets, fieldsAppStoreVersionExperimentTreatments, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppPreviewSets, limit, limitAppScreenshotSets, limitAppPreviewSets, include);
            //Assert.IsType<AppStoreVersionExperimentTreatmentLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionExperimentTreatmentsCreateInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionExperimentTreatmentsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppStoreVersionExperimentTreatmentCreateRequest appStoreVersionExperimentTreatmentCreateRequest = null;
            //var response = instance.AppStoreVersionExperimentTreatmentsCreateInstance(appStoreVersionExperimentTreatmentCreateRequest);
            //Assert.IsType<AppStoreVersionExperimentTreatmentResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionExperimentTreatmentsDeleteInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionExperimentTreatmentsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppStoreVersionExperimentTreatmentsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppStoreVersionExperimentTreatmentsGetInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionExperimentTreatmentsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersionExperimentTreatments = null;
            //List<string>? include = null;
            //List<string>? fieldsAppStoreVersionExperimentTreatmentLocalizations = null;
            //int? limitAppStoreVersionExperimentTreatmentLocalizations = null;
            //var response = instance.AppStoreVersionExperimentTreatmentsGetInstance(id, fieldsAppStoreVersionExperimentTreatments, include, fieldsAppStoreVersionExperimentTreatmentLocalizations, limitAppStoreVersionExperimentTreatmentLocalizations);
            //Assert.IsType<AppStoreVersionExperimentTreatmentResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionExperimentTreatmentsUpdateInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionExperimentTreatmentsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppStoreVersionExperimentTreatmentUpdateRequest appStoreVersionExperimentTreatmentUpdateRequest = null;
            //var response = instance.AppStoreVersionExperimentTreatmentsUpdateInstance(id, appStoreVersionExperimentTreatmentUpdateRequest);
            //Assert.IsType<AppStoreVersionExperimentTreatmentResponse>(response);
        }
    }
}
