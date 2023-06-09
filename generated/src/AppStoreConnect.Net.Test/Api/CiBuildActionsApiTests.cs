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
    ///  Class for testing CiBuildActionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CiBuildActionsApiTests : IDisposable
    {
        private CiBuildActionsApi instance;

        public CiBuildActionsApiTests()
        {
            instance = new CiBuildActionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CiBuildActionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CiBuildActionsApi
            //Assert.IsType<CiBuildActionsApi>(instance);
        }

        /// <summary>
        /// Test CiBuildActionsArtifactsGetToManyRelated
        /// </summary>
        [Fact]
        public void CiBuildActionsArtifactsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsCiArtifacts = null;
            //int? limit = null;
            //var response = instance.CiBuildActionsArtifactsGetToManyRelated(id, fieldsCiArtifacts, limit);
            //Assert.IsType<CiArtifactsResponse>(response);
        }

        /// <summary>
        /// Test CiBuildActionsBuildRunGetToOneRelated
        /// </summary>
        [Fact]
        public void CiBuildActionsBuildRunGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsScmGitReferences = null;
            //List<string>? fieldsCiBuildRuns = null;
            //List<string>? fieldsCiWorkflows = null;
            //List<string>? fieldsScmPullRequests = null;
            //List<string>? fieldsCiProducts = null;
            //List<string>? fieldsBuilds = null;
            //int? limitBuilds = null;
            //List<string>? include = null;
            //var response = instance.CiBuildActionsBuildRunGetToOneRelated(id, fieldsScmGitReferences, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsScmPullRequests, fieldsCiProducts, fieldsBuilds, limitBuilds, include);
            //Assert.IsType<CiBuildRunResponse>(response);
        }

        /// <summary>
        /// Test CiBuildActionsGetInstance
        /// </summary>
        [Fact]
        public void CiBuildActionsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsCiBuildActions = null;
            //List<string>? include = null;
            //List<string>? fieldsCiIssues = null;
            //List<string>? fieldsCiBuildRuns = null;
            //List<string>? fieldsCiTestResults = null;
            //List<string>? fieldsCiArtifacts = null;
            //var response = instance.CiBuildActionsGetInstance(id, fieldsCiBuildActions, include, fieldsCiIssues, fieldsCiBuildRuns, fieldsCiTestResults, fieldsCiArtifacts);
            //Assert.IsType<CiBuildActionResponse>(response);
        }

        /// <summary>
        /// Test CiBuildActionsIssuesGetToManyRelated
        /// </summary>
        [Fact]
        public void CiBuildActionsIssuesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsCiIssues = null;
            //int? limit = null;
            //var response = instance.CiBuildActionsIssuesGetToManyRelated(id, fieldsCiIssues, limit);
            //Assert.IsType<CiIssuesResponse>(response);
        }

        /// <summary>
        /// Test CiBuildActionsTestResultsGetToManyRelated
        /// </summary>
        [Fact]
        public void CiBuildActionsTestResultsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsCiTestResults = null;
            //int? limit = null;
            //var response = instance.CiBuildActionsTestResultsGetToManyRelated(id, fieldsCiTestResults, limit);
            //Assert.IsType<CiTestResultsResponse>(response);
        }
    }
}
