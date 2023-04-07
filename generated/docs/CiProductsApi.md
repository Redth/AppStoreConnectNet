# AppStoreConnect.Net.Api.CiProductsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CiProductsAdditionalRepositoriesGetToManyRelated**](CiProductsApi.md#ciproductsadditionalrepositoriesgettomanyrelated) | **GET** /v1/ciProducts/{id}/additionalRepositories |  |
| [**CiProductsAppGetToOneRelated**](CiProductsApi.md#ciproductsappgettoonerelated) | **GET** /v1/ciProducts/{id}/app |  |
| [**CiProductsBuildRunsGetToManyRelated**](CiProductsApi.md#ciproductsbuildrunsgettomanyrelated) | **GET** /v1/ciProducts/{id}/buildRuns |  |
| [**CiProductsDeleteInstance**](CiProductsApi.md#ciproductsdeleteinstance) | **DELETE** /v1/ciProducts/{id} |  |
| [**CiProductsGetCollection**](CiProductsApi.md#ciproductsgetcollection) | **GET** /v1/ciProducts |  |
| [**CiProductsGetInstance**](CiProductsApi.md#ciproductsgetinstance) | **GET** /v1/ciProducts/{id} |  |
| [**CiProductsPrimaryRepositoriesGetToManyRelated**](CiProductsApi.md#ciproductsprimaryrepositoriesgettomanyrelated) | **GET** /v1/ciProducts/{id}/primaryRepositories |  |
| [**CiProductsWorkflowsGetToManyRelated**](CiProductsApi.md#ciproductsworkflowsgettomanyrelated) | **GET** /v1/ciProducts/{id}/workflows |  |

<a name="ciproductsadditionalrepositoriesgettomanyrelated"></a>
# **CiProductsAdditionalRepositoriesGetToManyRelated**
> ScmRepositoriesResponse CiProductsAdditionalRepositoriesGetToManyRelated (string id, List<string>? filterId = null, List<string>? fieldsScmGitReferences = null, List<string>? fieldsScmProviders = null, List<string>? fieldsScmRepositories = null, int? limit = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsAdditionalRepositoriesGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsScmGitReferences = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmGitReferences (optional) 
            var fieldsScmProviders = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmProviders (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                ScmRepositoriesResponse result = apiInstance.CiProductsAdditionalRepositoriesGetToManyRelated(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsAdditionalRepositoriesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsAdditionalRepositoriesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ScmRepositoriesResponse> response = apiInstance.CiProductsAdditionalRepositoriesGetToManyRelatedWithHttpInfo(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsAdditionalRepositoriesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsScmGitReferences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmGitReferences | [optional]  |
| **fieldsScmProviders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmProviders | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**ScmRepositoriesResponse**](ScmRepositoriesResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of ScmRepositories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsappgettoonerelated"></a>
# **CiProductsAppGetToOneRelated**
> AppResponse CiProductsAppGetToOneRelated (string id, List<string>? fieldsBetaLicenseAgreements = null, List<string>? fieldsBetaAppReviewDetails = null, List<string>? fieldsAppClips = null, List<string>? fieldsBetaAppLocalizations = null, List<string>? fieldsAppInfos = null, List<string>? fieldsPreReleaseVersions = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsCiProducts = null, List<string>? fieldsInAppPurchases2 = null, List<string>? fieldsSubscriptionGroups = null, List<string>? fieldsReviewSubmissions = null, List<string>? fieldsBetaGroups = null, List<string>? fieldsAppPreOrders = null, List<string>? fieldsAppPrices = null, List<string>? fieldsGameCenterEnabledVersions = null, List<string>? fieldsSubscriptionGracePeriods = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsEndUserLicenseAgreements = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppCustomProductPages = null, List<string>? fieldsApps = null, List<string>? fieldsAppEvents = null, List<string>? fieldsTerritories = null, List<string>? fieldsBuilds = null, int? limitBetaGroups = null, int? limitAppStoreVersions = null, int? limitPreReleaseVersions = null, int? limitBetaAppLocalizations = null, int? limitBuilds = null, int? limitAppInfos = null, int? limitAppClips = null, int? limitPrices = null, int? limitAvailableTerritories = null, int? limitInAppPurchases = null, int? limitSubscriptionGroups = null, int? limitGameCenterEnabledVersions = null, int? limitAppCustomProductPages = null, int? limitInAppPurchasesV2 = null, int? limitPromotedPurchases = null, int? limitAppEvents = null, int? limitReviewSubmissions = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsAppGetToOneRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaLicenseAgreements (optional) 
            var fieldsBetaAppReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewDetails (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsBetaAppLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppLocalizations (optional) 
            var fieldsAppInfos = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfos (optional) 
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsInAppPurchases2 = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var fieldsReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissions (optional) 
            var fieldsBetaGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaGroups (optional) 
            var fieldsAppPreOrders = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreOrders (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsGameCenterEnabledVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterEnabledVersions (optional) 
            var fieldsSubscriptionGracePeriods = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGracePeriods (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsEndUserLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type endUserLicenseAgreements (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppCustomProductPages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPages (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var limitBetaGroups = 56;  // int? | maximum number of related betaGroups returned (when they are included) (optional) 
            var limitAppStoreVersions = 56;  // int? | maximum number of related appStoreVersions returned (when they are included) (optional) 
            var limitPreReleaseVersions = 56;  // int? | maximum number of related preReleaseVersions returned (when they are included) (optional) 
            var limitBetaAppLocalizations = 56;  // int? | maximum number of related betaAppLocalizations returned (when they are included) (optional) 
            var limitBuilds = 56;  // int? | maximum number of related builds returned (when they are included) (optional) 
            var limitAppInfos = 56;  // int? | maximum number of related appInfos returned (when they are included) (optional) 
            var limitAppClips = 56;  // int? | maximum number of related appClips returned (when they are included) (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var limitAvailableTerritories = 56;  // int? | maximum number of related availableTerritories returned (when they are included) (optional) 
            var limitInAppPurchases = 56;  // int? | maximum number of related inAppPurchases returned (when they are included) (optional) 
            var limitSubscriptionGroups = 56;  // int? | maximum number of related subscriptionGroups returned (when they are included) (optional) 
            var limitGameCenterEnabledVersions = 56;  // int? | maximum number of related gameCenterEnabledVersions returned (when they are included) (optional) 
            var limitAppCustomProductPages = 56;  // int? | maximum number of related appCustomProductPages returned (when they are included) (optional) 
            var limitInAppPurchasesV2 = 56;  // int? | maximum number of related inAppPurchasesV2 returned (when they are included) (optional) 
            var limitPromotedPurchases = 56;  // int? | maximum number of related promotedPurchases returned (when they are included) (optional) 
            var limitAppEvents = 56;  // int? | maximum number of related appEvents returned (when they are included) (optional) 
            var limitReviewSubmissions = 56;  // int? | maximum number of related reviewSubmissions returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppResponse result = apiInstance.CiProductsAppGetToOneRelated(id, fieldsBetaLicenseAgreements, fieldsBetaAppReviewDetails, fieldsAppClips, fieldsBetaAppLocalizations, fieldsAppInfos, fieldsPreReleaseVersions, fieldsInAppPurchases, fieldsCiProducts, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsReviewSubmissions, fieldsBetaGroups, fieldsAppPreOrders, fieldsAppPrices, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsPromotedPurchases, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsApps, fieldsAppEvents, fieldsTerritories, fieldsBuilds, limitBetaGroups, limitAppStoreVersions, limitPreReleaseVersions, limitBetaAppLocalizations, limitBuilds, limitAppInfos, limitAppClips, limitPrices, limitAvailableTerritories, limitInAppPurchases, limitSubscriptionGroups, limitGameCenterEnabledVersions, limitAppCustomProductPages, limitInAppPurchasesV2, limitPromotedPurchases, limitAppEvents, limitReviewSubmissions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsAppGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsAppGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppResponse> response = apiInstance.CiProductsAppGetToOneRelatedWithHttpInfo(id, fieldsBetaLicenseAgreements, fieldsBetaAppReviewDetails, fieldsAppClips, fieldsBetaAppLocalizations, fieldsAppInfos, fieldsPreReleaseVersions, fieldsInAppPurchases, fieldsCiProducts, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsReviewSubmissions, fieldsBetaGroups, fieldsAppPreOrders, fieldsAppPrices, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsPromotedPurchases, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsApps, fieldsAppEvents, fieldsTerritories, fieldsBuilds, limitBetaGroups, limitAppStoreVersions, limitPreReleaseVersions, limitBetaAppLocalizations, limitBuilds, limitAppInfos, limitAppClips, limitPrices, limitAvailableTerritories, limitInAppPurchases, limitSubscriptionGroups, limitGameCenterEnabledVersions, limitAppCustomProductPages, limitInAppPurchasesV2, limitPromotedPurchases, limitAppEvents, limitReviewSubmissions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsAppGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaLicenseAgreements | [optional]  |
| **fieldsBetaAppReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewDetails | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsBetaAppLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppLocalizations | [optional]  |
| **fieldsAppInfos** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfos | [optional]  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsInAppPurchases2** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **fieldsReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissions | [optional]  |
| **fieldsBetaGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaGroups | [optional]  |
| **fieldsAppPreOrders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreOrders | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsGameCenterEnabledVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterEnabledVersions | [optional]  |
| **fieldsSubscriptionGracePeriods** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGracePeriods | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsEndUserLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type endUserLicenseAgreements | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppCustomProductPages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPages | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **limitBetaGroups** | **int?** | maximum number of related betaGroups returned (when they are included) | [optional]  |
| **limitAppStoreVersions** | **int?** | maximum number of related appStoreVersions returned (when they are included) | [optional]  |
| **limitPreReleaseVersions** | **int?** | maximum number of related preReleaseVersions returned (when they are included) | [optional]  |
| **limitBetaAppLocalizations** | **int?** | maximum number of related betaAppLocalizations returned (when they are included) | [optional]  |
| **limitBuilds** | **int?** | maximum number of related builds returned (when they are included) | [optional]  |
| **limitAppInfos** | **int?** | maximum number of related appInfos returned (when they are included) | [optional]  |
| **limitAppClips** | **int?** | maximum number of related appClips returned (when they are included) | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **limitAvailableTerritories** | **int?** | maximum number of related availableTerritories returned (when they are included) | [optional]  |
| **limitInAppPurchases** | **int?** | maximum number of related inAppPurchases returned (when they are included) | [optional]  |
| **limitSubscriptionGroups** | **int?** | maximum number of related subscriptionGroups returned (when they are included) | [optional]  |
| **limitGameCenterEnabledVersions** | **int?** | maximum number of related gameCenterEnabledVersions returned (when they are included) | [optional]  |
| **limitAppCustomProductPages** | **int?** | maximum number of related appCustomProductPages returned (when they are included) | [optional]  |
| **limitInAppPurchasesV2** | **int?** | maximum number of related inAppPurchasesV2 returned (when they are included) | [optional]  |
| **limitPromotedPurchases** | **int?** | maximum number of related promotedPurchases returned (when they are included) | [optional]  |
| **limitAppEvents** | **int?** | maximum number of related appEvents returned (when they are included) | [optional]  |
| **limitReviewSubmissions** | **int?** | maximum number of related reviewSubmissions returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppResponse**](AppResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single App |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsbuildrunsgettomanyrelated"></a>
# **CiProductsBuildRunsGetToManyRelated**
> CiBuildRunsResponse CiProductsBuildRunsGetToManyRelated (string id, List<string>? filterBuilds = null, List<string>? fieldsScmGitReferences = null, List<string>? fieldsCiBuildRuns = null, List<string>? fieldsCiWorkflows = null, List<string>? fieldsScmPullRequests = null, List<string>? fieldsCiProducts = null, List<string>? fieldsBuilds = null, int? limit = null, int? limitBuilds = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsBuildRunsGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterBuilds = new List<string>?(); // List<string>? | filter by id(s) of related 'builds' (optional) 
            var fieldsScmGitReferences = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmGitReferences (optional) 
            var fieldsCiBuildRuns = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciBuildRuns (optional) 
            var fieldsCiWorkflows = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciWorkflows (optional) 
            var fieldsScmPullRequests = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmPullRequests (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitBuilds = 56;  // int? | maximum number of related builds returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CiBuildRunsResponse result = apiInstance.CiProductsBuildRunsGetToManyRelated(id, filterBuilds, fieldsScmGitReferences, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsScmPullRequests, fieldsCiProducts, fieldsBuilds, limit, limitBuilds, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsBuildRunsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsBuildRunsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiBuildRunsResponse> response = apiInstance.CiProductsBuildRunsGetToManyRelatedWithHttpInfo(id, filterBuilds, fieldsScmGitReferences, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsScmPullRequests, fieldsCiProducts, fieldsBuilds, limit, limitBuilds, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsBuildRunsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterBuilds** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;builds&#39; | [optional]  |
| **fieldsScmGitReferences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmGitReferences | [optional]  |
| **fieldsCiBuildRuns** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciBuildRuns | [optional]  |
| **fieldsCiWorkflows** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciWorkflows | [optional]  |
| **fieldsScmPullRequests** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmPullRequests | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitBuilds** | **int?** | maximum number of related builds returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**CiBuildRunsResponse**](CiBuildRunsResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of CiBuildRuns |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsdeleteinstance"></a>
# **CiProductsDeleteInstance**
> void CiProductsDeleteInstance (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsDeleteInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.CiProductsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CiProductsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsDeleteInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsgetcollection"></a>
# **CiProductsGetCollection**
> CiProductsResponse CiProductsGetCollection (List<string>? filterProductType = null, List<string>? filterApp = null, List<string>? fieldsCiProducts = null, int? limit = null, List<string>? include = null, List<string>? fieldsCiBuildRuns = null, List<string>? fieldsCiWorkflows = null, List<string>? fieldsApps = null, List<string>? fieldsScmRepositories = null, int? limitPrimaryRepositories = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsGetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var filterProductType = new List<string>?(); // List<string>? | filter by attribute 'productType' (optional) 
            var filterApp = new List<string>?(); // List<string>? | filter by id(s) of related 'app' (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCiBuildRuns = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciBuildRuns (optional) 
            var fieldsCiWorkflows = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciWorkflows (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var limitPrimaryRepositories = 56;  // int? | maximum number of related primaryRepositories returned (when they are included) (optional) 

            try
            {
                CiProductsResponse result = apiInstance.CiProductsGetCollection(filterProductType, filterApp, fieldsCiProducts, limit, include, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsApps, fieldsScmRepositories, limitPrimaryRepositories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiProductsResponse> response = apiInstance.CiProductsGetCollectionWithHttpInfo(filterProductType, filterApp, fieldsCiProducts, limit, include, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsApps, fieldsScmRepositories, limitPrimaryRepositories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterProductType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;productType&#39; | [optional]  |
| **filterApp** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;app&#39; | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCiBuildRuns** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciBuildRuns | [optional]  |
| **fieldsCiWorkflows** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciWorkflows | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **limitPrimaryRepositories** | **int?** | maximum number of related primaryRepositories returned (when they are included) | [optional]  |

### Return type

[**CiProductsResponse**](CiProductsResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **200** | List of CiProducts |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsgetinstance"></a>
# **CiProductsGetInstance**
> CiProductResponse CiProductsGetInstance (string id, List<string>? fieldsCiProducts = null, List<string>? include = null, List<string>? fieldsCiBuildRuns = null, List<string>? fieldsCiWorkflows = null, List<string>? fieldsApps = null, List<string>? fieldsScmRepositories = null, int? limitPrimaryRepositories = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsGetInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCiBuildRuns = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciBuildRuns (optional) 
            var fieldsCiWorkflows = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciWorkflows (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var limitPrimaryRepositories = 56;  // int? | maximum number of related primaryRepositories returned (when they are included) (optional) 

            try
            {
                CiProductResponse result = apiInstance.CiProductsGetInstance(id, fieldsCiProducts, include, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsApps, fieldsScmRepositories, limitPrimaryRepositories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiProductResponse> response = apiInstance.CiProductsGetInstanceWithHttpInfo(id, fieldsCiProducts, include, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsApps, fieldsScmRepositories, limitPrimaryRepositories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCiBuildRuns** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciBuildRuns | [optional]  |
| **fieldsCiWorkflows** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciWorkflows | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **limitPrimaryRepositories** | **int?** | maximum number of related primaryRepositories returned (when they are included) | [optional]  |

### Return type

[**CiProductResponse**](CiProductResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single CiProduct |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsprimaryrepositoriesgettomanyrelated"></a>
# **CiProductsPrimaryRepositoriesGetToManyRelated**
> ScmRepositoriesResponse CiProductsPrimaryRepositoriesGetToManyRelated (string id, List<string>? filterId = null, List<string>? fieldsScmGitReferences = null, List<string>? fieldsScmProviders = null, List<string>? fieldsScmRepositories = null, int? limit = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsPrimaryRepositoriesGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsScmGitReferences = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmGitReferences (optional) 
            var fieldsScmProviders = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmProviders (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                ScmRepositoriesResponse result = apiInstance.CiProductsPrimaryRepositoriesGetToManyRelated(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsPrimaryRepositoriesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsPrimaryRepositoriesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ScmRepositoriesResponse> response = apiInstance.CiProductsPrimaryRepositoriesGetToManyRelatedWithHttpInfo(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsPrimaryRepositoriesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsScmGitReferences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmGitReferences | [optional]  |
| **fieldsScmProviders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmProviders | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**ScmRepositoriesResponse**](ScmRepositoriesResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of ScmRepositories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ciproductsworkflowsgettomanyrelated"></a>
# **CiProductsWorkflowsGetToManyRelated**
> CiWorkflowsResponse CiProductsWorkflowsGetToManyRelated (string id, List<string>? fieldsCiXcodeVersions = null, List<string>? fieldsCiWorkflows = null, List<string>? fieldsCiMacOsVersions = null, List<string>? fieldsCiProducts = null, List<string>? fieldsScmRepositories = null, int? limit = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class CiProductsWorkflowsGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CiProductsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiXcodeVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciXcodeVersions (optional) 
            var fieldsCiWorkflows = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciWorkflows (optional) 
            var fieldsCiMacOsVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciMacOsVersions (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CiWorkflowsResponse result = apiInstance.CiProductsWorkflowsGetToManyRelated(id, fieldsCiXcodeVersions, fieldsCiWorkflows, fieldsCiMacOsVersions, fieldsCiProducts, fieldsScmRepositories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiProductsApi.CiProductsWorkflowsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiProductsWorkflowsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiWorkflowsResponse> response = apiInstance.CiProductsWorkflowsGetToManyRelatedWithHttpInfo(id, fieldsCiXcodeVersions, fieldsCiWorkflows, fieldsCiMacOsVersions, fieldsCiProducts, fieldsScmRepositories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiProductsApi.CiProductsWorkflowsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiXcodeVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciXcodeVersions | [optional]  |
| **fieldsCiWorkflows** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciWorkflows | [optional]  |
| **fieldsCiMacOsVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciMacOsVersions | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**CiWorkflowsResponse**](CiWorkflowsResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of CiWorkflows |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

