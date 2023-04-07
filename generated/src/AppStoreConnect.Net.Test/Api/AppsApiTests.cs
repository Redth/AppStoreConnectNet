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
    ///  Class for testing AppsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppsApiTests : IDisposable
    {
        private AppsApi instance;

        public AppsApiTests()
        {
            instance = new AppsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppsApi
            //Assert.IsType<AppsApi>(instance);
        }

        /// <summary>
        /// Test AppsAppAvailabilityGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsAppAvailabilityGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppAvailabilities = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsTerritories = null;
            //int? limitAvailableTerritories = null;
            //List<string>? include = null;
            //var response = instance.AppsAppAvailabilityGetToOneRelated(id, fieldsAppAvailabilities, fieldsApps, fieldsTerritories, limitAvailableTerritories, include);
            //Assert.IsType<AppAvailabilityResponse>(response);
        }

        /// <summary>
        /// Test AppsAppClipsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAppClipsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterBundleId = null;
            //List<string>? fieldsAppClips = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsAppClipDefaultExperiences = null;
            //int? limit = null;
            //int? limitAppClipDefaultExperiences = null;
            //List<string>? include = null;
            //var response = instance.AppsAppClipsGetToManyRelated(id, filterBundleId, fieldsAppClips, fieldsApps, fieldsAppClipDefaultExperiences, limit, limitAppClipDefaultExperiences, include);
            //Assert.IsType<AppClipsResponse>(response);
        }

        /// <summary>
        /// Test AppsAppCustomProductPagesGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAppCustomProductPagesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterVisible = null;
            //List<string>? fieldsAppCustomProductPages = null;
            //List<string>? fieldsAppCustomProductPageVersions = null;
            //List<string>? fieldsApps = null;
            //int? limit = null;
            //int? limitAppCustomProductPageVersions = null;
            //List<string>? include = null;
            //var response = instance.AppsAppCustomProductPagesGetToManyRelated(id, filterVisible, fieldsAppCustomProductPages, fieldsAppCustomProductPageVersions, fieldsApps, limit, limitAppCustomProductPageVersions, include);
            //Assert.IsType<AppCustomProductPagesResponse>(response);
        }

        /// <summary>
        /// Test AppsAppEventsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAppEventsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterEventState = null;
            //List<string>? filterId = null;
            //List<string>? fieldsAppEventLocalizations = null;
            //List<string>? fieldsAppEvents = null;
            //int? limit = null;
            //int? limitLocalizations = null;
            //List<string>? include = null;
            //var response = instance.AppsAppEventsGetToManyRelated(id, filterEventState, filterId, fieldsAppEventLocalizations, fieldsAppEvents, limit, limitLocalizations, include);
            //Assert.IsType<AppEventsResponse>(response);
        }

        /// <summary>
        /// Test AppsAppInfosGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAppInfosGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAgeRatingDeclarations = null;
            //List<string>? fieldsAppInfos = null;
            //List<string>? fieldsAppInfoLocalizations = null;
            //List<string>? fieldsAppCategories = null;
            //List<string>? fieldsApps = null;
            //int? limit = null;
            //int? limitAppInfoLocalizations = null;
            //List<string>? include = null;
            //var response = instance.AppsAppInfosGetToManyRelated(id, fieldsAgeRatingDeclarations, fieldsAppInfos, fieldsAppInfoLocalizations, fieldsAppCategories, fieldsApps, limit, limitAppInfoLocalizations, include);
            //Assert.IsType<AppInfosResponse>(response);
        }

        /// <summary>
        /// Test AppsAppPricePointsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAppPricePointsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterTerritory = null;
            //List<string>? fieldsAppPricePoints = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppsAppPricePointsGetToManyRelated(id, filterTerritory, fieldsAppPricePoints, fieldsApps, fieldsTerritories, limit, include);
            //Assert.IsType<AppPricePointsV3Response>(response);
        }

        /// <summary>
        /// Test AppsAppPriceScheduleGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsAppPriceScheduleGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppPrices = null;
            //List<string>? fieldsAppPriceSchedules = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsTerritories = null;
            //int? limitManualPrices = null;
            //int? limitAutomaticPrices = null;
            //List<string>? include = null;
            //var response = instance.AppsAppPriceScheduleGetToOneRelated(id, fieldsAppPrices, fieldsAppPriceSchedules, fieldsApps, fieldsTerritories, limitManualPrices, limitAutomaticPrices, include);
            //Assert.IsType<AppPriceScheduleResponse>(response);
        }

        /// <summary>
        /// Test AppsAppStoreVersionsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAppStoreVersionsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterAppStoreState = null;
            //List<string>? filterPlatform = null;
            //List<string>? filterVersionString = null;
            //List<string>? filterId = null;
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
            //int? limit = null;
            //int? limitAppStoreVersionLocalizations = null;
            //int? limitAppStoreVersionExperiments = null;
            //List<string>? include = null;
            //var response = instance.AppsAppStoreVersionsGetToManyRelated(id, filterAppStoreState, filterPlatform, filterVersionString, filterId, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limit, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
            //Assert.IsType<AppStoreVersionsResponse>(response);
        }

        /// <summary>
        /// Test AppsAvailableTerritoriesGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsAvailableTerritoriesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //var response = instance.AppsAvailableTerritoriesGetToManyRelated(id, fieldsTerritories, limit);
            //Assert.IsType<TerritoriesResponse>(response);
        }

        /// <summary>
        /// Test AppsBetaAppLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsBetaAppLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaAppLocalizations = null;
            //int? limit = null;
            //var response = instance.AppsBetaAppLocalizationsGetToManyRelated(id, fieldsBetaAppLocalizations, limit);
            //Assert.IsType<BetaAppLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test AppsBetaAppReviewDetailGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsBetaAppReviewDetailGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaAppReviewDetails = null;
            //var response = instance.AppsBetaAppReviewDetailGetToOneRelated(id, fieldsBetaAppReviewDetails);
            //Assert.IsType<BetaAppReviewDetailResponse>(response);
        }

        /// <summary>
        /// Test AppsBetaGroupsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsBetaGroupsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaGroups = null;
            //int? limit = null;
            //var response = instance.AppsBetaGroupsGetToManyRelated(id, fieldsBetaGroups, limit);
            //Assert.IsType<BetaGroupsResponse>(response);
        }

        /// <summary>
        /// Test AppsBetaLicenseAgreementGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsBetaLicenseAgreementGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaLicenseAgreements = null;
            //var response = instance.AppsBetaLicenseAgreementGetToOneRelated(id, fieldsBetaLicenseAgreements);
            //Assert.IsType<BetaLicenseAgreementResponse>(response);
        }

        /// <summary>
        /// Test AppsBetaTestersDeleteToManyRelationship
        /// </summary>
        [Fact]
        public void AppsBetaTestersDeleteToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppBetaTestersLinkagesRequest appBetaTestersLinkagesRequest = null;
            //instance.AppsBetaTestersDeleteToManyRelationship(id, appBetaTestersLinkagesRequest);
        }

        /// <summary>
        /// Test AppsBuildsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsBuildsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBuilds = null;
            //int? limit = null;
            //var response = instance.AppsBuildsGetToManyRelated(id, fieldsBuilds, limit);
            //Assert.IsType<BuildsResponse>(response);
        }

        /// <summary>
        /// Test AppsCiProductGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsCiProductGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsCiProducts = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsScmRepositories = null;
            //List<string>? fieldsBundleIds = null;
            //int? limitPrimaryRepositories = null;
            //List<string>? include = null;
            //var response = instance.AppsCiProductGetToOneRelated(id, fieldsCiProducts, fieldsApps, fieldsScmRepositories, fieldsBundleIds, limitPrimaryRepositories, include);
            //Assert.IsType<CiProductResponse>(response);
        }

        /// <summary>
        /// Test AppsCustomerReviewsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsCustomerReviewsGetToManyRelatedTest()
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
            //var response = instance.AppsCustomerReviewsGetToManyRelated(id, filterRating, filterTerritory, existsPublishedResponse, sort, fieldsCustomerReviews, fieldsCustomerReviewResponses, limit, include);
            //Assert.IsType<CustomerReviewsResponse>(response);
        }

        /// <summary>
        /// Test AppsEndUserLicenseAgreementGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsEndUserLicenseAgreementGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsEndUserLicenseAgreements = null;
            //var response = instance.AppsEndUserLicenseAgreementGetToOneRelated(id, fieldsEndUserLicenseAgreements);
            //Assert.IsType<EndUserLicenseAgreementResponse>(response);
        }

        /// <summary>
        /// Test AppsGameCenterEnabledVersionsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsGameCenterEnabledVersionsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterPlatform = null;
            //List<string>? filterVersionString = null;
            //List<string>? filterId = null;
            //List<string>? sort = null;
            //List<string>? fieldsGameCenterEnabledVersions = null;
            //List<string>? fieldsApps = null;
            //int? limit = null;
            //int? limitCompatibleVersions = null;
            //List<string>? include = null;
            //var response = instance.AppsGameCenterEnabledVersionsGetToManyRelated(id, filterPlatform, filterVersionString, filterId, sort, fieldsGameCenterEnabledVersions, fieldsApps, limit, limitCompatibleVersions, include);
            //Assert.IsType<GameCenterEnabledVersionsResponse>(response);
        }

        /// <summary>
        /// Test AppsGetCollection
        /// </summary>
        [Fact]
        public void AppsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? filterAppStoreVersionsAppStoreState = null;
            //List<string>? filterAppStoreVersionsPlatform = null;
            //List<string>? filterBundleId = null;
            //List<string>? filterName = null;
            //List<string>? filterSku = null;
            //List<string>? filterAppStoreVersions = null;
            //List<string>? filterId = null;
            //bool? existsGameCenterEnabledVersions = null;
            //List<string>? sort = null;
            //List<string>? fieldsApps = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsBetaAppReviewDetails = null;
            //List<string>? fieldsAppPriceSchedules = null;
            //List<string>? fieldsCiProducts = null;
            //List<string>? fieldsReviewSubmissions = null;
            //List<string>? fieldsBetaGroups = null;
            //List<string>? fieldsPromotedPurchases = null;
            //List<string>? fieldsAppAvailabilities = null;
            //List<string>? fieldsCustomerReviews = null;
            //List<string>? fieldsAppEvents = null;
            //List<string>? fieldsBuilds = null;
            //List<string>? fieldsBetaLicenseAgreements = null;
            //List<string>? fieldsAppClips = null;
            //List<string>? fieldsAppInfos = null;
            //List<string>? fieldsBetaAppLocalizations = null;
            //List<string>? fieldsAppPricePoints = null;
            //List<string>? fieldsAppPricePoints2 = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsPreReleaseVersions = null;
            //List<string>? fieldsInAppPurchases2 = null;
            //List<string>? fieldsSubscriptionGroups = null;
            //List<string>? fieldsAppPrices = null;
            //List<string>? fieldsAppPreOrders = null;
            //List<string>? fieldsGameCenterEnabledVersions = null;
            //List<string>? fieldsSubscriptionGracePeriods = null;
            //List<string>? fieldsEndUserLicenseAgreements = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsAppCustomProductPages = null;
            //List<string>? fieldsTerritories = null;
            //List<string>? fieldsPerfPowerMetrics = null;
            //int? limitAppClips = null;
            //int? limitAppCustomProductPages = null;
            //int? limitAppEvents = null;
            //int? limitAppInfos = null;
            //int? limitAppStoreVersions = null;
            //int? limitAvailableTerritories = null;
            //int? limitBetaAppLocalizations = null;
            //int? limitBetaGroups = null;
            //int? limitBuilds = null;
            //int? limitGameCenterEnabledVersions = null;
            //int? limitInAppPurchases = null;
            //int? limitInAppPurchasesV2 = null;
            //int? limitPreReleaseVersions = null;
            //int? limitPrices = null;
            //int? limitPromotedPurchases = null;
            //int? limitReviewSubmissions = null;
            //int? limitSubscriptionGroups = null;
            //var response = instance.AppsGetCollection(filterAppStoreVersionsAppStoreState, filterAppStoreVersionsPlatform, filterBundleId, filterName, filterSku, filterAppStoreVersions, filterId, existsGameCenterEnabledVersions, sort, fieldsApps, limit, include, fieldsBetaAppReviewDetails, fieldsAppPriceSchedules, fieldsCiProducts, fieldsReviewSubmissions, fieldsBetaGroups, fieldsPromotedPurchases, fieldsAppAvailabilities, fieldsCustomerReviews, fieldsAppEvents, fieldsBuilds, fieldsBetaLicenseAgreements, fieldsAppClips, fieldsAppInfos, fieldsBetaAppLocalizations, fieldsAppPricePoints, fieldsAppPricePoints2, fieldsInAppPurchases, fieldsPreReleaseVersions, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsAppPrices, fieldsAppPreOrders, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsTerritories, fieldsPerfPowerMetrics, limitAppClips, limitAppCustomProductPages, limitAppEvents, limitAppInfos, limitAppStoreVersions, limitAvailableTerritories, limitBetaAppLocalizations, limitBetaGroups, limitBuilds, limitGameCenterEnabledVersions, limitInAppPurchases, limitInAppPurchasesV2, limitPreReleaseVersions, limitPrices, limitPromotedPurchases, limitReviewSubmissions, limitSubscriptionGroups);
            //Assert.IsType<AppsResponse>(response);
        }

        /// <summary>
        /// Test AppsGetInstance
        /// </summary>
        [Fact]
        public void AppsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsApps = null;
            //List<string>? include = null;
            //List<string>? fieldsBetaAppReviewDetails = null;
            //List<string>? fieldsAppPriceSchedules = null;
            //List<string>? fieldsCiProducts = null;
            //List<string>? fieldsReviewSubmissions = null;
            //List<string>? fieldsBetaGroups = null;
            //List<string>? fieldsPromotedPurchases = null;
            //List<string>? fieldsAppAvailabilities = null;
            //List<string>? fieldsCustomerReviews = null;
            //List<string>? fieldsAppEvents = null;
            //List<string>? fieldsBuilds = null;
            //List<string>? fieldsBetaLicenseAgreements = null;
            //List<string>? fieldsAppClips = null;
            //List<string>? fieldsAppInfos = null;
            //List<string>? fieldsBetaAppLocalizations = null;
            //List<string>? fieldsAppPricePoints = null;
            //List<string>? fieldsAppPricePoints2 = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsPreReleaseVersions = null;
            //List<string>? fieldsInAppPurchases2 = null;
            //List<string>? fieldsSubscriptionGroups = null;
            //List<string>? fieldsAppPrices = null;
            //List<string>? fieldsAppPreOrders = null;
            //List<string>? fieldsGameCenterEnabledVersions = null;
            //List<string>? fieldsSubscriptionGracePeriods = null;
            //List<string>? fieldsEndUserLicenseAgreements = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsAppCustomProductPages = null;
            //List<string>? fieldsTerritories = null;
            //List<string>? fieldsPerfPowerMetrics = null;
            //int? limitAppClips = null;
            //int? limitAppCustomProductPages = null;
            //int? limitAppEvents = null;
            //int? limitAppInfos = null;
            //int? limitAppStoreVersions = null;
            //int? limitAvailableTerritories = null;
            //int? limitBetaAppLocalizations = null;
            //int? limitBetaGroups = null;
            //int? limitBuilds = null;
            //int? limitGameCenterEnabledVersions = null;
            //int? limitInAppPurchases = null;
            //int? limitInAppPurchasesV2 = null;
            //int? limitPreReleaseVersions = null;
            //int? limitPrices = null;
            //int? limitPromotedPurchases = null;
            //int? limitReviewSubmissions = null;
            //int? limitSubscriptionGroups = null;
            //var response = instance.AppsGetInstance(id, fieldsApps, include, fieldsBetaAppReviewDetails, fieldsAppPriceSchedules, fieldsCiProducts, fieldsReviewSubmissions, fieldsBetaGroups, fieldsPromotedPurchases, fieldsAppAvailabilities, fieldsCustomerReviews, fieldsAppEvents, fieldsBuilds, fieldsBetaLicenseAgreements, fieldsAppClips, fieldsAppInfos, fieldsBetaAppLocalizations, fieldsAppPricePoints, fieldsAppPricePoints2, fieldsInAppPurchases, fieldsPreReleaseVersions, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsAppPrices, fieldsAppPreOrders, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsTerritories, fieldsPerfPowerMetrics, limitAppClips, limitAppCustomProductPages, limitAppEvents, limitAppInfos, limitAppStoreVersions, limitAvailableTerritories, limitBetaAppLocalizations, limitBetaGroups, limitBuilds, limitGameCenterEnabledVersions, limitInAppPurchases, limitInAppPurchasesV2, limitPreReleaseVersions, limitPrices, limitPromotedPurchases, limitReviewSubmissions, limitSubscriptionGroups);
            //Assert.IsType<AppResponse>(response);
        }

        /// <summary>
        /// Test AppsInAppPurchasesGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsInAppPurchasesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterInAppPurchaseType = null;
            //List<string>? filterCanBeSubmitted = null;
            //List<string>? sort = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsApps = null;
            //int? limit = null;
            //int? limitApps = null;
            //List<string>? include = null;
            //var response = instance.AppsInAppPurchasesGetToManyRelated(id, filterInAppPurchaseType, filterCanBeSubmitted, sort, fieldsInAppPurchases, fieldsApps, limit, limitApps, include);
            //Assert.IsType<InAppPurchasesResponse>(response);
        }

        /// <summary>
        /// Test AppsInAppPurchasesV2GetToManyRelated
        /// </summary>
        [Fact]
        public void AppsInAppPurchasesV2GetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterInAppPurchaseType = null;
            //List<string>? filterName = null;
            //List<string>? filterProductId = null;
            //List<string>? filterState = null;
            //List<string>? sort = null;
            //List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null;
            //List<string>? fieldsInAppPurchasePricePoints = null;
            //List<string>? fieldsPromotedPurchases = null;
            //List<string>? fieldsInAppPurchaseLocalizations = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsInAppPurchasePriceSchedules = null;
            //List<string>? fieldsInAppPurchaseContents = null;
            //int? limit = null;
            //int? limitInAppPurchaseLocalizations = null;
            //int? limitPricePoints = null;
            //List<string>? include = null;
            //var response = instance.AppsInAppPurchasesV2GetToManyRelated(id, filterInAppPurchaseType, filterName, filterProductId, filterState, sort, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsInAppPurchasePricePoints, fieldsPromotedPurchases, fieldsInAppPurchaseLocalizations, fieldsInAppPurchases, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchaseContents, limit, limitInAppPurchaseLocalizations, limitPricePoints, include);
            //Assert.IsType<InAppPurchasesV2Response>(response);
        }

        /// <summary>
        /// Test AppsPerfPowerMetricsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsPerfPowerMetricsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterDeviceType = null;
            //List<string>? filterMetricType = null;
            //List<string>? filterPlatform = null;
            //var response = instance.AppsPerfPowerMetricsGetToManyRelated(id, filterDeviceType, filterMetricType, filterPlatform);
            //Assert.IsType<XcodeMetrics>(response);
        }

        /// <summary>
        /// Test AppsPreOrderGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsPreOrderGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppPreOrders = null;
            //var response = instance.AppsPreOrderGetToOneRelated(id, fieldsAppPreOrders);
            //Assert.IsType<AppPreOrderResponse>(response);
        }

        /// <summary>
        /// Test AppsPreReleaseVersionsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsPreReleaseVersionsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsPreReleaseVersions = null;
            //int? limit = null;
            //var response = instance.AppsPreReleaseVersionsGetToManyRelated(id, fieldsPreReleaseVersions, limit);
            //Assert.IsType<PreReleaseVersionsResponse>(response);
        }

        /// <summary>
        /// Test AppsPricePointsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsPricePointsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterPriceTier = null;
            //List<string>? filterTerritory = null;
            //List<string>? fieldsAppPriceTiers = null;
            //List<string>? fieldsAppPricePoints = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppsPricePointsGetToManyRelated(id, filterPriceTier, filterTerritory, fieldsAppPriceTiers, fieldsAppPricePoints, fieldsApps, fieldsTerritories, limit, include);
            //Assert.IsType<AppPricePointsV2Response>(response);
        }

        /// <summary>
        /// Test AppsPricesGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsPricesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppPriceTiers = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsAppPrices = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.AppsPricesGetToManyRelated(id, fieldsAppPriceTiers, fieldsApps, fieldsAppPrices, limit, include);
            //Assert.IsType<AppPricesResponse>(response);
        }

        /// <summary>
        /// Test AppsPromotedPurchasesGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsPromotedPurchasesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsPromotedPurchases = null;
            //List<string>? fieldsSubscriptions = null;
            //List<string>? fieldsInAppPurchases = null;
            //List<string>? fieldsPromotedPurchaseImages = null;
            //int? limit = null;
            //int? limitPromotionImages = null;
            //List<string>? include = null;
            //var response = instance.AppsPromotedPurchasesGetToManyRelated(id, fieldsPromotedPurchases, fieldsSubscriptions, fieldsInAppPurchases, fieldsPromotedPurchaseImages, limit, limitPromotionImages, include);
            //Assert.IsType<PromotedPurchasesResponse>(response);
        }

        /// <summary>
        /// Test AppsPromotedPurchasesGetToManyRelationship
        /// </summary>
        [Fact]
        public void AppsPromotedPurchasesGetToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //var response = instance.AppsPromotedPurchasesGetToManyRelationship(id, limit);
            //Assert.IsType<AppPromotedPurchasesLinkagesResponse>(response);
        }

        /// <summary>
        /// Test AppsPromotedPurchasesReplaceToManyRelationship
        /// </summary>
        [Fact]
        public void AppsPromotedPurchasesReplaceToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppPromotedPurchasesLinkagesRequest appPromotedPurchasesLinkagesRequest = null;
            //instance.AppsPromotedPurchasesReplaceToManyRelationship(id, appPromotedPurchasesLinkagesRequest);
        }

        /// <summary>
        /// Test AppsReviewSubmissionsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsReviewSubmissionsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterPlatform = null;
            //List<string>? filterState = null;
            //List<string>? fieldsReviewSubmissionItems = null;
            //List<string>? fieldsAppStoreVersions = null;
            //List<string>? fieldsApps = null;
            //List<string>? fieldsReviewSubmissions = null;
            //int? limit = null;
            //int? limitItems = null;
            //List<string>? include = null;
            //var response = instance.AppsReviewSubmissionsGetToManyRelated(id, filterPlatform, filterState, fieldsReviewSubmissionItems, fieldsAppStoreVersions, fieldsApps, fieldsReviewSubmissions, limit, limitItems, include);
            //Assert.IsType<ReviewSubmissionsResponse>(response);
        }

        /// <summary>
        /// Test AppsSubscriptionGracePeriodGetToOneRelated
        /// </summary>
        [Fact]
        public void AppsSubscriptionGracePeriodGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsSubscriptionGracePeriods = null;
            //var response = instance.AppsSubscriptionGracePeriodGetToOneRelated(id, fieldsSubscriptionGracePeriods);
            //Assert.IsType<SubscriptionGracePeriodResponse>(response);
        }

        /// <summary>
        /// Test AppsSubscriptionGroupsGetToManyRelated
        /// </summary>
        [Fact]
        public void AppsSubscriptionGroupsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterReferenceName = null;
            //List<string>? filterSubscriptionsState = null;
            //List<string>? sort = null;
            //List<string>? fieldsSubscriptions = null;
            //List<string>? fieldsSubscriptionGroups = null;
            //List<string>? fieldsSubscriptionGroupLocalizations = null;
            //int? limit = null;
            //int? limitSubscriptions = null;
            //int? limitSubscriptionGroupLocalizations = null;
            //List<string>? include = null;
            //var response = instance.AppsSubscriptionGroupsGetToManyRelated(id, filterReferenceName, filterSubscriptionsState, sort, fieldsSubscriptions, fieldsSubscriptionGroups, fieldsSubscriptionGroupLocalizations, limit, limitSubscriptions, limitSubscriptionGroupLocalizations, include);
            //Assert.IsType<SubscriptionGroupsResponse>(response);
        }

        /// <summary>
        /// Test AppsUpdateInstance
        /// </summary>
        [Fact]
        public void AppsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AppUpdateRequest appUpdateRequest = null;
            //var response = instance.AppsUpdateInstance(id, appUpdateRequest);
            //Assert.IsType<AppResponse>(response);
        }
    }
}