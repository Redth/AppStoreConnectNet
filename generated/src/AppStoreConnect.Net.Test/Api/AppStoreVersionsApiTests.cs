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
    ///  Class for testing AppStoreVersionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppStoreVersionsApiTests : IDisposable
    {
        private AppStoreVersionsApi instance;

        public AppStoreVersionsApiTests()
        {
            instance = new AppStoreVersionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppStoreVersionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppStoreVersionsApi
            //Assert.IsType<AppStoreVersionsApi>(instance);
        }

        /// <summary>
        /// Test AppStoreVersionsAgeRatingDeclarationGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAgeRatingDeclarationGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAgeRatingDeclarations = null;
            //var response = instance.AppStoreVersionsAgeRatingDeclarationGetToOneRelated(id, fieldsAgeRatingDeclarations);
            //Assert.IsType<AgeRatingDeclarationResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppClipDefaultExperienceGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppClips = null;
            //List<string>? fieldsAppClipAppStoreReviewDetails = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //List<string>? fieldsAppClipDefaultExperienceLocalizations = null;
            //int? limitAppClipDefaultExperienceLocalizations = null;
            //List<string>? include = null;
            //var response = instance.AppStoreVersionsAppClipDefaultExperienceGetToOneRelated(id, fieldsAppClips, fieldsAppClipAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppClipDefaultExperiences, fieldsAppClipDefaultExperienceLocalizations, limitAppClipDefaultExperienceLocalizations, include);
            //Assert.IsType<AppClipDefaultExperienceResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppClipDefaultExperienceGetToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship(id);
            //Assert.IsType<AppStoreVersionAppClipDefaultExperienceLinkageResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppStoreVersionAppClipDefaultExperienceLinkageRequest appStoreVersionAppClipDefaultExperienceLinkageRequest = null;
            //instance.AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship(id, appStoreVersionAppClipDefaultExperienceLinkageRequest);
        }

        /// <summary>
        /// Test AppStoreVersionsAppStoreReviewDetailGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppStoreReviewDetailGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreReviewDetails = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsAppStoreReviewAttachments = null;
            //int? limitAppStoreReviewAttachments = null;
            //List<string>? include = null;
            //var response = instance.AppStoreVersionsAppStoreReviewDetailGetToOneRelated(id, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppStoreReviewAttachments, limitAppStoreReviewAttachments, include);
            //Assert.IsType<AppStoreReviewDetailResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterState = null;
            //List<string>? fieldsAppStoreVersionExperiments = null;
            //List<string>? fieldsAppStoreVersionExperimentTreatments = null;
            //List<string>? fieldsAppStoreVersions = null;
            //int? limit = null;
            //int? limitAppStoreVersionExperimentTreatments = null;
            //List<string>? include = null;
            //var response = instance.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated(id, filterState, fieldsAppStoreVersionExperiments, fieldsAppStoreVersionExperimentTreatments, fieldsAppStoreVersions, limit, limitAppStoreVersionExperimentTreatments, include);
            //Assert.IsType<AppStoreVersionExperimentsResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersionLocalizations = null;
            //int? limit = null;
            //var response = instance.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated(id, fieldsAppStoreVersionLocalizations, limit);
            //Assert.IsType<AppStoreVersionLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersionPhasedReleases = null;
            //var response = instance.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated(id, fieldsAppStoreVersionPhasedReleases);
            //Assert.IsType<AppStoreVersionPhasedReleaseResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersionSubmissions = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? include = null;
            //var response = instance.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated(id, fieldsAppStoreVersionSubmissions, fieldsAppStoreVersions, include);
            //Assert.IsType<AppStoreVersionSubmissionResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsBuildGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsBuildGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBuilds = null;
            //var response = instance.AppStoreVersionsBuildGetToOneRelated(id, fieldsBuilds);
            //Assert.IsType<BuildResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsBuildGetToOneRelationship
        /// </summary>
        [Fact]
        public void AppStoreVersionsBuildGetToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AppStoreVersionsBuildGetToOneRelationship(id);
            //Assert.IsType<AppStoreVersionBuildLinkageResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsBuildUpdateToOneRelationship
        /// </summary>
        [Fact]
        public void AppStoreVersionsBuildUpdateToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppStoreVersionBuildLinkageRequest appStoreVersionBuildLinkageRequest = null;
            //instance.AppStoreVersionsBuildUpdateToOneRelationship(id, appStoreVersionBuildLinkageRequest);
        }

        /// <summary>
        /// Test AppStoreVersionsCreateInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppStoreVersionCreateRequest appStoreVersionCreateRequest = null;
            //var response = instance.AppStoreVersionsCreateInstance(appStoreVersionCreateRequest);
            //Assert.IsType<AppStoreVersionResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsCustomerReviewsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsCustomerReviewsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterRating = null;
            //List<string>? filterTerritory = null;
            //bool? existsPublishedResponse = null;
            //List<string>? sort = null;
            //List<string>? fieldsCustomerReviews = null;
            //List<string>? fieldsCustomerReviewResponses = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppStoreVersionsCustomerReviewsGetToManyRelated(id, filterRating, filterTerritory, existsPublishedResponse, sort, fieldsCustomerReviews, fieldsCustomerReviewResponses, limit, include);
            //Assert.IsType<CustomerReviewsResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsDeleteInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppStoreVersionsDeleteInstance(id);
        }

        /// <summary>
        /// Test AppStoreVersionsGetInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? include = null;
            //List<string>? fieldsAppStoreVersionExperiments = null;
            //List<string>? fieldsAppStoreVersionSubmissions = null;
            //List<string>? fieldsAgeRatingDeclarations = null;
            //List<string>? fieldsCustomerReviews = null;
            //List<string>? fieldsAppStoreReviewDetails = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //List<string>? fieldsRoutingAppCoverages = null;
            //List<string>? fieldsAppStoreVersionPhasedReleases = null;
            //List<string>? fieldsBuilds = null;
            //List<string>? fieldsAppStoreVersionLocalizations = null;
            //int? limitAppStoreVersionExperiments = null;
            //int? limitAppStoreVersionLocalizations = null;
            //var response = instance.AppStoreVersionsGetInstance(id, fieldsAppStoreVersions, include, fieldsAppStoreVersionExperiments, fieldsAppStoreVersionSubmissions, fieldsAgeRatingDeclarations, fieldsCustomerReviews, fieldsAppStoreReviewDetails, fieldsAppClipDefaultExperiences, fieldsRoutingAppCoverages, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limitAppStoreVersionExperiments, limitAppStoreVersionLocalizations);
            //Assert.IsType<AppStoreVersionResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsRoutingAppCoverageGetToOneRelated
        /// </summary>
        [Fact]
        public void AppStoreVersionsRoutingAppCoverageGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsRoutingAppCoverages = null;
            //var response = instance.AppStoreVersionsRoutingAppCoverageGetToOneRelated(id, fieldsRoutingAppCoverages);
            //Assert.IsType<RoutingAppCoverageResponse>(response);
        }

        /// <summary>
        /// Test AppStoreVersionsUpdateInstance
        /// </summary>
        [Fact]
        public void AppStoreVersionsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppStoreVersionUpdateRequest appStoreVersionUpdateRequest = null;
            //var response = instance.AppStoreVersionsUpdateInstance(id, appStoreVersionUpdateRequest);
            //Assert.IsType<AppStoreVersionResponse>(response);
        }
    }
}