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
    ///  Class for testing BuildBetaDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BuildBetaDetailsApiTests : IDisposable
    {
        private BuildBetaDetailsApi instance;

        public BuildBetaDetailsApiTests()
        {
            instance = new BuildBetaDetailsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BuildBetaDetailsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BuildBetaDetailsApi
            //Assert.IsType<BuildBetaDetailsApi>(instance);
        }

        /// <summary>
        /// Test BuildBetaDetailsBuildGetToOneRelated
        /// </summary>
        [Fact]
        public void BuildBetaDetailsBuildGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.BuildBetaDetailsBuildGetToOneRelated(id, fieldsBuilds);
            //Assert.IsType<BuildResponse>(response);
        }

        /// <summary>
        /// Test BuildBetaDetailsGetCollection
        /// </summary>
        [Fact]
        public void BuildBetaDetailsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? filterBuild = null;
            //List<string>? filterId = null;
            //List<string>? fieldsBuildBetaDetails = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.BuildBetaDetailsGetCollection(filterBuild, filterId, fieldsBuildBetaDetails, limit, include, fieldsBuilds);
            //Assert.IsType<BuildBetaDetailsResponse>(response);
        }

        /// <summary>
        /// Test BuildBetaDetailsGetInstance
        /// </summary>
        [Fact]
        public void BuildBetaDetailsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBuildBetaDetails = null;
            //List<string>? include = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.BuildBetaDetailsGetInstance(id, fieldsBuildBetaDetails, include, fieldsBuilds);
            //Assert.IsType<BuildBetaDetailResponse>(response);
        }

        /// <summary>
        /// Test BuildBetaDetailsUpdateInstance
        /// </summary>
        [Fact]
        public void BuildBetaDetailsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BuildBetaDetailUpdateRequest buildBetaDetailUpdateRequest = null;
            //var response = instance.BuildBetaDetailsUpdateInstance(id, buildBetaDetailUpdateRequest);
            //Assert.IsType<BuildBetaDetailResponse>(response);
        }
    }
}
