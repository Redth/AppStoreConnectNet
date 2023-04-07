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
    ///  Class for testing AppClipDefaultExperiencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppClipDefaultExperiencesApiTests : IDisposable
    {
        private AppClipDefaultExperiencesApi instance;

        public AppClipDefaultExperiencesApiTests()
        {
            instance = new AppClipDefaultExperiencesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppClipDefaultExperiencesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppClipDefaultExperiencesApi
            //Assert.IsType<AppClipDefaultExperiencesApi>(instance);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppClipAppStoreReviewDetails = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //List<string>? include = null;
            //var response = instance.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated(id, fieldsAppClipAppStoreReviewDetails, fieldsAppClipDefaultExperiences, include);
            //Assert.IsType<AppClipAppStoreReviewDetailResponse>(response);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterLocale = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //List<string>? fieldsAppClipDefaultExperienceLocalizations = null;
            //List<string>? fieldsAppClipHeaderImages = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated(id, filterLocale, fieldsAppClipDefaultExperiences, fieldsAppClipDefaultExperienceLocalizations, fieldsAppClipHeaderImages, limit, include);
            //Assert.IsType<AppClipDefaultExperienceLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesCreateInstance
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppClipDefaultExperienceCreateRequest appClipDefaultExperienceCreateRequest = null;
            //var response = instance.AppClipDefaultExperiencesCreateInstance(appClipDefaultExperienceCreateRequest);
            //Assert.IsType<AppClipDefaultExperienceResponse>(response);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesDeleteInstance
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AppClipDefaultExperiencesDeleteInstance(id);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesGetInstance
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //List<string>? include = null;
            //List<string>? fieldsAppClipAppStoreReviewDetails = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsAppClipDefaultExperienceLocalizations = null;
            //int? limitAppClipDefaultExperienceLocalizations = null;
            //var response = instance.AppClipDefaultExperiencesGetInstance(id, fieldsAppClipDefaultExperiences, include, fieldsAppClipAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppClipDefaultExperienceLocalizations, limitAppClipDefaultExperienceLocalizations);
            //Assert.IsType<AppClipDefaultExperienceResponse>(response);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppStoreVersionExperiments = null;
            //List<string>? fieldsAgeRatingDeclarations = null;
            //List<string>? fieldsAppStoreVersionSubmissions = null;
            //List<string>? fieldsAppStoreReviewDetails = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsRoutingAppCoverages = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //List<string>? fieldsAppStoreVersionPhasedReleases = null;
            //List<string>? fieldsBuilds = null;
            //List<string>? fieldsAppStoreVersionLocalizations = null;
            //int? limitAppStoreVersionLocalizations = null;
            //int? limitAppStoreVersionExperiments = null;
            //List<string>? include = null;
            //var response = instance.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated(id, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
            //Assert.IsType<AppStoreVersionResponse>(response);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship(id);
            //Assert.IsType<AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponse>(response);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest = null;
            //instance.AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship(id, appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest);
        }

        /// <summary>
        /// Test AppClipDefaultExperiencesUpdateInstance
        /// </summary>
        [Fact]
        public void AppClipDefaultExperiencesUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppClipDefaultExperienceUpdateRequest appClipDefaultExperienceUpdateRequest = null;
            //var response = instance.AppClipDefaultExperiencesUpdateInstance(id, appClipDefaultExperienceUpdateRequest);
            //Assert.IsType<AppClipDefaultExperienceResponse>(response);
        }
    }
}
