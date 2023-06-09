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
    ///  Class for testing ScmProvidersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScmProvidersApiTests : IDisposable
    {
        private ScmProvidersApi instance;

        public ScmProvidersApiTests()
        {
            instance = new ScmProvidersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScmProvidersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ScmProvidersApi
            //Assert.IsType<ScmProvidersApi>(instance);
        }

        /// <summary>
        /// Test ScmProvidersGetCollection
        /// </summary>
        [Fact]
        public void ScmProvidersGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? fieldsScmProviders = null;
            //int? limit = null;
            //List<string>? fieldsScmRepositories = null;
            //var response = instance.ScmProvidersGetCollection(fieldsScmProviders, limit, fieldsScmRepositories);
            //Assert.IsType<ScmProvidersResponse>(response);
        }

        /// <summary>
        /// Test ScmProvidersGetInstance
        /// </summary>
        [Fact]
        public void ScmProvidersGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsScmProviders = null;
            //List<string>? fieldsScmRepositories = null;
            //var response = instance.ScmProvidersGetInstance(id, fieldsScmProviders, fieldsScmRepositories);
            //Assert.IsType<ScmProviderResponse>(response);
        }

        /// <summary>
        /// Test ScmProvidersRepositoriesGetToManyRelated
        /// </summary>
        [Fact]
        public void ScmProvidersRepositoriesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterId = null;
            //List<string>? fieldsScmGitReferences = null;
            //List<string>? fieldsScmProviders = null;
            //List<string>? fieldsScmRepositories = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.ScmProvidersRepositoriesGetToManyRelated(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
            //Assert.IsType<ScmRepositoriesResponse>(response);
        }
    }
}
