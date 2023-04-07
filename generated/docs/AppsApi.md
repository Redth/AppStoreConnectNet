# AppStoreConnect.Net.Api.AppsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppsAppAvailabilityGetToOneRelated**](AppsApi.md#appsappavailabilitygettoonerelated) | **GET** /v1/apps/{id}/appAvailability |  |
| [**AppsAppClipsGetToManyRelated**](AppsApi.md#appsappclipsgettomanyrelated) | **GET** /v1/apps/{id}/appClips |  |
| [**AppsAppCustomProductPagesGetToManyRelated**](AppsApi.md#appsappcustomproductpagesgettomanyrelated) | **GET** /v1/apps/{id}/appCustomProductPages |  |
| [**AppsAppEventsGetToManyRelated**](AppsApi.md#appsappeventsgettomanyrelated) | **GET** /v1/apps/{id}/appEvents |  |
| [**AppsAppInfosGetToManyRelated**](AppsApi.md#appsappinfosgettomanyrelated) | **GET** /v1/apps/{id}/appInfos |  |
| [**AppsAppPricePointsGetToManyRelated**](AppsApi.md#appsapppricepointsgettomanyrelated) | **GET** /v1/apps/{id}/appPricePoints |  |
| [**AppsAppPriceScheduleGetToOneRelated**](AppsApi.md#appsapppriceschedulegettoonerelated) | **GET** /v1/apps/{id}/appPriceSchedule |  |
| [**AppsAppStoreVersionsGetToManyRelated**](AppsApi.md#appsappstoreversionsgettomanyrelated) | **GET** /v1/apps/{id}/appStoreVersions |  |
| [**AppsAvailableTerritoriesGetToManyRelated**](AppsApi.md#appsavailableterritoriesgettomanyrelated) | **GET** /v1/apps/{id}/availableTerritories |  |
| [**AppsBetaAppLocalizationsGetToManyRelated**](AppsApi.md#appsbetaapplocalizationsgettomanyrelated) | **GET** /v1/apps/{id}/betaAppLocalizations |  |
| [**AppsBetaAppReviewDetailGetToOneRelated**](AppsApi.md#appsbetaappreviewdetailgettoonerelated) | **GET** /v1/apps/{id}/betaAppReviewDetail |  |
| [**AppsBetaGroupsGetToManyRelated**](AppsApi.md#appsbetagroupsgettomanyrelated) | **GET** /v1/apps/{id}/betaGroups |  |
| [**AppsBetaLicenseAgreementGetToOneRelated**](AppsApi.md#appsbetalicenseagreementgettoonerelated) | **GET** /v1/apps/{id}/betaLicenseAgreement |  |
| [**AppsBetaTestersDeleteToManyRelationship**](AppsApi.md#appsbetatestersdeletetomanyrelationship) | **DELETE** /v1/apps/{id}/relationships/betaTesters |  |
| [**AppsBuildsGetToManyRelated**](AppsApi.md#appsbuildsgettomanyrelated) | **GET** /v1/apps/{id}/builds |  |
| [**AppsCiProductGetToOneRelated**](AppsApi.md#appsciproductgettoonerelated) | **GET** /v1/apps/{id}/ciProduct |  |
| [**AppsCustomerReviewsGetToManyRelated**](AppsApi.md#appscustomerreviewsgettomanyrelated) | **GET** /v1/apps/{id}/customerReviews |  |
| [**AppsEndUserLicenseAgreementGetToOneRelated**](AppsApi.md#appsenduserlicenseagreementgettoonerelated) | **GET** /v1/apps/{id}/endUserLicenseAgreement |  |
| [**AppsGameCenterEnabledVersionsGetToManyRelated**](AppsApi.md#appsgamecenterenabledversionsgettomanyrelated) | **GET** /v1/apps/{id}/gameCenterEnabledVersions |  |
| [**AppsGetCollection**](AppsApi.md#appsgetcollection) | **GET** /v1/apps |  |
| [**AppsGetInstance**](AppsApi.md#appsgetinstance) | **GET** /v1/apps/{id} |  |
| [**AppsInAppPurchasesGetToManyRelated**](AppsApi.md#appsinapppurchasesgettomanyrelated) | **GET** /v1/apps/{id}/inAppPurchases |  |
| [**AppsInAppPurchasesV2GetToManyRelated**](AppsApi.md#appsinapppurchasesv2gettomanyrelated) | **GET** /v1/apps/{id}/inAppPurchasesV2 |  |
| [**AppsPerfPowerMetricsGetToManyRelated**](AppsApi.md#appsperfpowermetricsgettomanyrelated) | **GET** /v1/apps/{id}/perfPowerMetrics |  |
| [**AppsPreOrderGetToOneRelated**](AppsApi.md#appspreordergettoonerelated) | **GET** /v1/apps/{id}/preOrder |  |
| [**AppsPreReleaseVersionsGetToManyRelated**](AppsApi.md#appsprereleaseversionsgettomanyrelated) | **GET** /v1/apps/{id}/preReleaseVersions |  |
| [**AppsPricePointsGetToManyRelated**](AppsApi.md#appspricepointsgettomanyrelated) | **GET** /v1/apps/{id}/pricePoints |  |
| [**AppsPricesGetToManyRelated**](AppsApi.md#appspricesgettomanyrelated) | **GET** /v1/apps/{id}/prices |  |
| [**AppsPromotedPurchasesGetToManyRelated**](AppsApi.md#appspromotedpurchasesgettomanyrelated) | **GET** /v1/apps/{id}/promotedPurchases |  |
| [**AppsPromotedPurchasesGetToManyRelationship**](AppsApi.md#appspromotedpurchasesgettomanyrelationship) | **GET** /v1/apps/{id}/relationships/promotedPurchases |  |
| [**AppsPromotedPurchasesReplaceToManyRelationship**](AppsApi.md#appspromotedpurchasesreplacetomanyrelationship) | **PATCH** /v1/apps/{id}/relationships/promotedPurchases |  |
| [**AppsReviewSubmissionsGetToManyRelated**](AppsApi.md#appsreviewsubmissionsgettomanyrelated) | **GET** /v1/apps/{id}/reviewSubmissions |  |
| [**AppsSubscriptionGracePeriodGetToOneRelated**](AppsApi.md#appssubscriptiongraceperiodgettoonerelated) | **GET** /v1/apps/{id}/subscriptionGracePeriod |  |
| [**AppsSubscriptionGroupsGetToManyRelated**](AppsApi.md#appssubscriptiongroupsgettomanyrelated) | **GET** /v1/apps/{id}/subscriptionGroups |  |
| [**AppsUpdateInstance**](AppsApi.md#appsupdateinstance) | **PATCH** /v1/apps/{id} |  |

<a name="appsappavailabilitygettoonerelated"></a>
# **AppsAppAvailabilityGetToOneRelated**
> AppAvailabilityResponse AppsAppAvailabilityGetToOneRelated (string id, List<string>? fieldsAppAvailabilities = null, List<string>? fieldsApps = null, List<string>? fieldsTerritories = null, int? limitAvailableTerritories = null, List<string>? include = null)



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
    public class AppsAppAvailabilityGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type appAvailabilities (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limitAvailableTerritories = 56;  // int? | maximum number of related availableTerritories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppAvailabilityResponse result = apiInstance.AppsAppAvailabilityGetToOneRelated(id, fieldsAppAvailabilities, fieldsApps, fieldsTerritories, limitAvailableTerritories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppAvailabilityGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppAvailabilityGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppAvailabilityResponse> response = apiInstance.AppsAppAvailabilityGetToOneRelatedWithHttpInfo(id, fieldsAppAvailabilities, fieldsApps, fieldsTerritories, limitAvailableTerritories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppAvailabilityGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appAvailabilities | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limitAvailableTerritories** | **int?** | maximum number of related availableTerritories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppAvailabilityResponse**](AppAvailabilityResponse.md)

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
| **200** | Single AppAvailability |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsappclipsgettomanyrelated"></a>
# **AppsAppClipsGetToManyRelated**
> AppClipsResponse AppsAppClipsGetToManyRelated (string id, List<string>? filterBundleId = null, List<string>? fieldsAppClips = null, List<string>? fieldsApps = null, List<string>? fieldsAppClipDefaultExperiences = null, int? limit = null, int? limitAppClipDefaultExperiences = null, List<string>? include = null)



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
    public class AppsAppClipsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterBundleId = new List<string>?(); // List<string>? | filter by attribute 'bundleId' (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppClipDefaultExperiences = 56;  // int? | maximum number of related appClipDefaultExperiences returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipsResponse result = apiInstance.AppsAppClipsGetToManyRelated(id, filterBundleId, fieldsAppClips, fieldsApps, fieldsAppClipDefaultExperiences, limit, limitAppClipDefaultExperiences, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppClipsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppClipsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipsResponse> response = apiInstance.AppsAppClipsGetToManyRelatedWithHttpInfo(id, filterBundleId, fieldsAppClips, fieldsApps, fieldsAppClipDefaultExperiences, limit, limitAppClipDefaultExperiences, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppClipsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterBundleId** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;bundleId&#39; | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppClipDefaultExperiences** | **int?** | maximum number of related appClipDefaultExperiences returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipsResponse**](AppClipsResponse.md)

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
| **200** | List of AppClips |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsappcustomproductpagesgettomanyrelated"></a>
# **AppsAppCustomProductPagesGetToManyRelated**
> AppCustomProductPagesResponse AppsAppCustomProductPagesGetToManyRelated (string id, List<string>? filterVisible = null, List<string>? fieldsAppCustomProductPages = null, List<string>? fieldsAppCustomProductPageVersions = null, List<string>? fieldsApps = null, int? limit = null, int? limitAppCustomProductPageVersions = null, List<string>? include = null)



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
    public class AppsAppCustomProductPagesGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterVisible = new List<string>?(); // List<string>? | filter by attribute 'visible' (optional) 
            var fieldsAppCustomProductPages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPages (optional) 
            var fieldsAppCustomProductPageVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPageVersions (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppCustomProductPageVersions = 56;  // int? | maximum number of related appCustomProductPageVersions returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCustomProductPagesResponse result = apiInstance.AppsAppCustomProductPagesGetToManyRelated(id, filterVisible, fieldsAppCustomProductPages, fieldsAppCustomProductPageVersions, fieldsApps, limit, limitAppCustomProductPageVersions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppCustomProductPagesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppCustomProductPagesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCustomProductPagesResponse> response = apiInstance.AppsAppCustomProductPagesGetToManyRelatedWithHttpInfo(id, filterVisible, fieldsAppCustomProductPages, fieldsAppCustomProductPageVersions, fieldsApps, limit, limitAppCustomProductPageVersions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppCustomProductPagesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterVisible** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;visible&#39; | [optional]  |
| **fieldsAppCustomProductPages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPages | [optional]  |
| **fieldsAppCustomProductPageVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPageVersions | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppCustomProductPageVersions** | **int?** | maximum number of related appCustomProductPageVersions returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCustomProductPagesResponse**](AppCustomProductPagesResponse.md)

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
| **200** | List of AppCustomProductPages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsappeventsgettomanyrelated"></a>
# **AppsAppEventsGetToManyRelated**
> AppEventsResponse AppsAppEventsGetToManyRelated (string id, List<string>? filterEventState = null, List<string>? filterId = null, List<string>? fieldsAppEventLocalizations = null, List<string>? fieldsAppEvents = null, int? limit = null, int? limitLocalizations = null, List<string>? include = null)



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
    public class AppsAppEventsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterEventState = new List<string>?(); // List<string>? | filter by attribute 'eventState' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsAppEventLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventLocalizations (optional) 
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppEventsResponse result = apiInstance.AppsAppEventsGetToManyRelated(id, filterEventState, filterId, fieldsAppEventLocalizations, fieldsAppEvents, limit, limitLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppEventsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppEventsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventsResponse> response = apiInstance.AppsAppEventsGetToManyRelatedWithHttpInfo(id, filterEventState, filterId, fieldsAppEventLocalizations, fieldsAppEvents, limit, limitLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppEventsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterEventState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;eventState&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsAppEventLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventLocalizations | [optional]  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppEventsResponse**](AppEventsResponse.md)

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
| **200** | List of AppEvents |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsappinfosgettomanyrelated"></a>
# **AppsAppInfosGetToManyRelated**
> AppInfosResponse AppsAppInfosGetToManyRelated (string id, List<string>? fieldsAgeRatingDeclarations = null, List<string>? fieldsAppInfos = null, List<string>? fieldsAppInfoLocalizations = null, List<string>? fieldsAppCategories = null, List<string>? fieldsApps = null, int? limit = null, int? limitAppInfoLocalizations = null, List<string>? include = null)



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
    public class AppsAppInfosGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 
            var fieldsAppInfos = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfos (optional) 
            var fieldsAppInfoLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfoLocalizations (optional) 
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppInfoLocalizations = 56;  // int? | maximum number of related appInfoLocalizations returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppInfosResponse result = apiInstance.AppsAppInfosGetToManyRelated(id, fieldsAgeRatingDeclarations, fieldsAppInfos, fieldsAppInfoLocalizations, fieldsAppCategories, fieldsApps, limit, limitAppInfoLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppInfosGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppInfosGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppInfosResponse> response = apiInstance.AppsAppInfosGetToManyRelatedWithHttpInfo(id, fieldsAgeRatingDeclarations, fieldsAppInfos, fieldsAppInfoLocalizations, fieldsAppCategories, fieldsApps, limit, limitAppInfoLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppInfosGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |
| **fieldsAppInfos** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfos | [optional]  |
| **fieldsAppInfoLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfoLocalizations | [optional]  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppInfoLocalizations** | **int?** | maximum number of related appInfoLocalizations returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppInfosResponse**](AppInfosResponse.md)

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
| **200** | List of AppInfos |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsapppricepointsgettomanyrelated"></a>
# **AppsAppPricePointsGetToManyRelated**
> AppPricePointsV3Response AppsAppPricePointsGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsApps = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class AppsAppPricePointsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPricePointsV3Response result = apiInstance.AppsAppPricePointsGetToManyRelated(id, filterTerritory, fieldsAppPricePoints, fieldsApps, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppPricePointsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppPricePointsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPricePointsV3Response> response = apiInstance.AppsAppPricePointsGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsAppPricePoints, fieldsApps, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppPricePointsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPricePointsV3Response**](AppPricePointsV3Response.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of AppPricePoints |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsapppriceschedulegettoonerelated"></a>
# **AppsAppPriceScheduleGetToOneRelated**
> AppPriceScheduleResponse AppsAppPriceScheduleGetToOneRelated (string id, List<string>? fieldsAppPrices = null, List<string>? fieldsAppPriceSchedules = null, List<string>? fieldsApps = null, List<string>? fieldsTerritories = null, int? limitManualPrices = null, int? limitAutomaticPrices = null, List<string>? include = null)



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
    public class AppsAppPriceScheduleGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsAppPriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceSchedules (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limitManualPrices = 56;  // int? | maximum number of related manualPrices returned (when they are included) (optional) 
            var limitAutomaticPrices = 56;  // int? | maximum number of related automaticPrices returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPriceScheduleResponse result = apiInstance.AppsAppPriceScheduleGetToOneRelated(id, fieldsAppPrices, fieldsAppPriceSchedules, fieldsApps, fieldsTerritories, limitManualPrices, limitAutomaticPrices, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppPriceScheduleGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppPriceScheduleGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPriceScheduleResponse> response = apiInstance.AppsAppPriceScheduleGetToOneRelatedWithHttpInfo(id, fieldsAppPrices, fieldsAppPriceSchedules, fieldsApps, fieldsTerritories, limitManualPrices, limitAutomaticPrices, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppPriceScheduleGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsAppPriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceSchedules | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limitManualPrices** | **int?** | maximum number of related manualPrices returned (when they are included) | [optional]  |
| **limitAutomaticPrices** | **int?** | maximum number of related automaticPrices returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPriceScheduleResponse**](AppPriceScheduleResponse.md)

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
| **200** | Single AppPriceSchedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsappstoreversionsgettomanyrelated"></a>
# **AppsAppStoreVersionsGetToManyRelated**
> AppStoreVersionsResponse AppsAppStoreVersionsGetToManyRelated (string id, List<string>? filterAppStoreState = null, List<string>? filterPlatform = null, List<string>? filterVersionString = null, List<string>? filterId = null, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsAgeRatingDeclarations = null, List<string>? fieldsAppStoreVersionSubmissions = null, List<string>? fieldsAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsApps = null, List<string>? fieldsRoutingAppCoverages = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppStoreVersionPhasedReleases = null, List<string>? fieldsBuilds = null, List<string>? fieldsAppStoreVersionLocalizations = null, int? limit = null, int? limitAppStoreVersionLocalizations = null, int? limitAppStoreVersionExperiments = null, List<string>? include = null)



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
    public class AppsAppStoreVersionsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterAppStoreState = new List<string>?(); // List<string>? | filter by attribute 'appStoreState' (optional) 
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 
            var filterVersionString = new List<string>?(); // List<string>? | filter by attribute 'versionString' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsAppStoreVersionExperiments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperiments (optional) 
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 
            var fieldsAppStoreVersionSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionSubmissions (optional) 
            var fieldsAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewDetails (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsRoutingAppCoverages = new List<string>?(); // List<string>? | the fields to include for returned resources of type routingAppCoverages (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var fieldsAppStoreVersionPhasedReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionPhasedReleases (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var fieldsAppStoreVersionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppStoreVersionLocalizations = 56;  // int? | maximum number of related appStoreVersionLocalizations returned (when they are included) (optional) 
            var limitAppStoreVersionExperiments = 56;  // int? | maximum number of related appStoreVersionExperiments returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreVersionsResponse result = apiInstance.AppsAppStoreVersionsGetToManyRelated(id, filterAppStoreState, filterPlatform, filterVersionString, filterId, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limit, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAppStoreVersionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAppStoreVersionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionsResponse> response = apiInstance.AppsAppStoreVersionsGetToManyRelatedWithHttpInfo(id, filterAppStoreState, filterPlatform, filterVersionString, filterId, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limit, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAppStoreVersionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterAppStoreState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;appStoreState&#39; | [optional]  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |
| **filterVersionString** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;versionString&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsAppStoreVersionExperiments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperiments | [optional]  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |
| **fieldsAppStoreVersionSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionSubmissions | [optional]  |
| **fieldsAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewDetails | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsRoutingAppCoverages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type routingAppCoverages | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **fieldsAppStoreVersionPhasedReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionPhasedReleases | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **fieldsAppStoreVersionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppStoreVersionLocalizations** | **int?** | maximum number of related appStoreVersionLocalizations returned (when they are included) | [optional]  |
| **limitAppStoreVersionExperiments** | **int?** | maximum number of related appStoreVersionExperiments returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreVersionsResponse**](AppStoreVersionsResponse.md)

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
| **200** | List of AppStoreVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsavailableterritoriesgettomanyrelated"></a>
# **AppsAvailableTerritoriesGetToManyRelated**
> TerritoriesResponse AppsAvailableTerritoriesGetToManyRelated (string id, List<string>? fieldsTerritories = null, int? limit = null)



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
    public class AppsAvailableTerritoriesGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                TerritoriesResponse result = apiInstance.AppsAvailableTerritoriesGetToManyRelated(id, fieldsTerritories, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAvailableTerritoriesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsAvailableTerritoriesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TerritoriesResponse> response = apiInstance.AppsAvailableTerritoriesGetToManyRelatedWithHttpInfo(id, fieldsTerritories, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsAvailableTerritoriesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**TerritoriesResponse**](TerritoriesResponse.md)

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
| **200** | List of Territories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsbetaapplocalizationsgettomanyrelated"></a>
# **AppsBetaAppLocalizationsGetToManyRelated**
> BetaAppLocalizationsResponse AppsBetaAppLocalizationsGetToManyRelated (string id, List<string>? fieldsBetaAppLocalizations = null, int? limit = null)



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
    public class AppsBetaAppLocalizationsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaAppLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BetaAppLocalizationsResponse result = apiInstance.AppsBetaAppLocalizationsGetToManyRelated(id, fieldsBetaAppLocalizations, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsBetaAppLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBetaAppLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppLocalizationsResponse> response = apiInstance.AppsBetaAppLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsBetaAppLocalizations, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsBetaAppLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaAppLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BetaAppLocalizationsResponse**](BetaAppLocalizationsResponse.md)

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
| **200** | List of BetaAppLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsbetaappreviewdetailgettoonerelated"></a>
# **AppsBetaAppReviewDetailGetToOneRelated**
> BetaAppReviewDetailResponse AppsBetaAppReviewDetailGetToOneRelated (string id, List<string>? fieldsBetaAppReviewDetails = null)



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
    public class AppsBetaAppReviewDetailGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaAppReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewDetails (optional) 

            try
            {
                BetaAppReviewDetailResponse result = apiInstance.AppsBetaAppReviewDetailGetToOneRelated(id, fieldsBetaAppReviewDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsBetaAppReviewDetailGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBetaAppReviewDetailGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppReviewDetailResponse> response = apiInstance.AppsBetaAppReviewDetailGetToOneRelatedWithHttpInfo(id, fieldsBetaAppReviewDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsBetaAppReviewDetailGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaAppReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewDetails | [optional]  |

### Return type

[**BetaAppReviewDetailResponse**](BetaAppReviewDetailResponse.md)

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
| **200** | Single BetaAppReviewDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsbetagroupsgettomanyrelated"></a>
# **AppsBetaGroupsGetToManyRelated**
> BetaGroupsResponse AppsBetaGroupsGetToManyRelated (string id, List<string>? fieldsBetaGroups = null, int? limit = null)



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
    public class AppsBetaGroupsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaGroups (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BetaGroupsResponse result = apiInstance.AppsBetaGroupsGetToManyRelated(id, fieldsBetaGroups, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsBetaGroupsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBetaGroupsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaGroupsResponse> response = apiInstance.AppsBetaGroupsGetToManyRelatedWithHttpInfo(id, fieldsBetaGroups, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsBetaGroupsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaGroups | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BetaGroupsResponse**](BetaGroupsResponse.md)

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
| **200** | List of BetaGroups |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsbetalicenseagreementgettoonerelated"></a>
# **AppsBetaLicenseAgreementGetToOneRelated**
> BetaLicenseAgreementResponse AppsBetaLicenseAgreementGetToOneRelated (string id, List<string>? fieldsBetaLicenseAgreements = null)



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
    public class AppsBetaLicenseAgreementGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaLicenseAgreements (optional) 

            try
            {
                BetaLicenseAgreementResponse result = apiInstance.AppsBetaLicenseAgreementGetToOneRelated(id, fieldsBetaLicenseAgreements);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsBetaLicenseAgreementGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBetaLicenseAgreementGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaLicenseAgreementResponse> response = apiInstance.AppsBetaLicenseAgreementGetToOneRelatedWithHttpInfo(id, fieldsBetaLicenseAgreements);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsBetaLicenseAgreementGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaLicenseAgreements | [optional]  |

### Return type

[**BetaLicenseAgreementResponse**](BetaLicenseAgreementResponse.md)

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
| **200** | Single BetaLicenseAgreement |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsbetatestersdeletetomanyrelationship"></a>
# **AppsBetaTestersDeleteToManyRelationship**
> void AppsBetaTestersDeleteToManyRelationship (string id, AppBetaTestersLinkagesRequest appBetaTestersLinkagesRequest)



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
    public class AppsBetaTestersDeleteToManyRelationshipExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appBetaTestersLinkagesRequest = new AppBetaTestersLinkagesRequest(); // AppBetaTestersLinkagesRequest | List of related linkages

            try
            {
                apiInstance.AppsBetaTestersDeleteToManyRelationship(id, appBetaTestersLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsBetaTestersDeleteToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBetaTestersDeleteToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppsBetaTestersDeleteToManyRelationshipWithHttpInfo(id, appBetaTestersLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsBetaTestersDeleteToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appBetaTestersLinkagesRequest** | [**AppBetaTestersLinkagesRequest**](AppBetaTestersLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **202** | Accepted for future completion |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsbuildsgettomanyrelated"></a>
# **AppsBuildsGetToManyRelated**
> BuildsResponse AppsBuildsGetToManyRelated (string id, List<string>? fieldsBuilds = null, int? limit = null)



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
    public class AppsBuildsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BuildsResponse result = apiInstance.AppsBuildsGetToManyRelated(id, fieldsBuilds, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsBuildsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBuildsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildsResponse> response = apiInstance.AppsBuildsGetToManyRelatedWithHttpInfo(id, fieldsBuilds, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsBuildsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BuildsResponse**](BuildsResponse.md)

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
| **200** | List of Builds |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsciproductgettoonerelated"></a>
# **AppsCiProductGetToOneRelated**
> CiProductResponse AppsCiProductGetToOneRelated (string id, List<string>? fieldsCiProducts = null, List<string>? fieldsApps = null, List<string>? fieldsScmRepositories = null, List<string>? fieldsBundleIds = null, int? limitPrimaryRepositories = null, List<string>? include = null)



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
    public class AppsCiProductGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var fieldsBundleIds = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIds (optional) 
            var limitPrimaryRepositories = 56;  // int? | maximum number of related primaryRepositories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CiProductResponse result = apiInstance.AppsCiProductGetToOneRelated(id, fieldsCiProducts, fieldsApps, fieldsScmRepositories, fieldsBundleIds, limitPrimaryRepositories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsCiProductGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsCiProductGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiProductResponse> response = apiInstance.AppsCiProductGetToOneRelatedWithHttpInfo(id, fieldsCiProducts, fieldsApps, fieldsScmRepositories, fieldsBundleIds, limitPrimaryRepositories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsCiProductGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **fieldsBundleIds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIds | [optional]  |
| **limitPrimaryRepositories** | **int?** | maximum number of related primaryRepositories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

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

<a name="appscustomerreviewsgettomanyrelated"></a>
# **AppsCustomerReviewsGetToManyRelated**
> CustomerReviewsResponse AppsCustomerReviewsGetToManyRelated (string id, List<string>? filterRating = null, List<string>? filterTerritory = null, bool? existsPublishedResponse = null, List<string>? sort = null, List<string>? fieldsCustomerReviews = null, List<string>? fieldsCustomerReviewResponses = null, int? limit = null, List<string>? include = null)



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
    public class AppsCustomerReviewsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterRating = new List<string>?(); // List<string>? | filter by attribute 'rating' (optional) 
            var filterTerritory = new List<string>?(); // List<string>? | filter by attribute 'territory' (optional) 
            var existsPublishedResponse = true;  // bool? | filter by publishedResponse (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsCustomerReviews = new List<string>?(); // List<string>? | the fields to include for returned resources of type customerReviews (optional) 
            var fieldsCustomerReviewResponses = new List<string>?(); // List<string>? | the fields to include for returned resources of type customerReviewResponses (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CustomerReviewsResponse result = apiInstance.AppsCustomerReviewsGetToManyRelated(id, filterRating, filterTerritory, existsPublishedResponse, sort, fieldsCustomerReviews, fieldsCustomerReviewResponses, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsCustomerReviewsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsCustomerReviewsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CustomerReviewsResponse> response = apiInstance.AppsCustomerReviewsGetToManyRelatedWithHttpInfo(id, filterRating, filterTerritory, existsPublishedResponse, sort, fieldsCustomerReviews, fieldsCustomerReviewResponses, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsCustomerReviewsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterRating** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;rating&#39; | [optional]  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;territory&#39; | [optional]  |
| **existsPublishedResponse** | **bool?** | filter by publishedResponse | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsCustomerReviews** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type customerReviews | [optional]  |
| **fieldsCustomerReviewResponses** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type customerReviewResponses | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**CustomerReviewsResponse**](CustomerReviewsResponse.md)

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
| **200** | List of CustomerReviews |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsenduserlicenseagreementgettoonerelated"></a>
# **AppsEndUserLicenseAgreementGetToOneRelated**
> EndUserLicenseAgreementResponse AppsEndUserLicenseAgreementGetToOneRelated (string id, List<string>? fieldsEndUserLicenseAgreements = null)



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
    public class AppsEndUserLicenseAgreementGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsEndUserLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type endUserLicenseAgreements (optional) 

            try
            {
                EndUserLicenseAgreementResponse result = apiInstance.AppsEndUserLicenseAgreementGetToOneRelated(id, fieldsEndUserLicenseAgreements);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsEndUserLicenseAgreementGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsEndUserLicenseAgreementGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EndUserLicenseAgreementResponse> response = apiInstance.AppsEndUserLicenseAgreementGetToOneRelatedWithHttpInfo(id, fieldsEndUserLicenseAgreements);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsEndUserLicenseAgreementGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsEndUserLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type endUserLicenseAgreements | [optional]  |

### Return type

[**EndUserLicenseAgreementResponse**](EndUserLicenseAgreementResponse.md)

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
| **200** | Single EndUserLicenseAgreement |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgamecenterenabledversionsgettomanyrelated"></a>
# **AppsGameCenterEnabledVersionsGetToManyRelated**
> GameCenterEnabledVersionsResponse AppsGameCenterEnabledVersionsGetToManyRelated (string id, List<string>? filterPlatform = null, List<string>? filterVersionString = null, List<string>? filterId = null, List<string>? sort = null, List<string>? fieldsGameCenterEnabledVersions = null, List<string>? fieldsApps = null, int? limit = null, int? limitCompatibleVersions = null, List<string>? include = null)



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
    public class AppsGameCenterEnabledVersionsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 
            var filterVersionString = new List<string>?(); // List<string>? | filter by attribute 'versionString' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsGameCenterEnabledVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterEnabledVersions (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitCompatibleVersions = 56;  // int? | maximum number of related compatibleVersions returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterEnabledVersionsResponse result = apiInstance.AppsGameCenterEnabledVersionsGetToManyRelated(id, filterPlatform, filterVersionString, filterId, sort, fieldsGameCenterEnabledVersions, fieldsApps, limit, limitCompatibleVersions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGameCenterEnabledVersionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsGameCenterEnabledVersionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterEnabledVersionsResponse> response = apiInstance.AppsGameCenterEnabledVersionsGetToManyRelatedWithHttpInfo(id, filterPlatform, filterVersionString, filterId, sort, fieldsGameCenterEnabledVersions, fieldsApps, limit, limitCompatibleVersions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsGameCenterEnabledVersionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |
| **filterVersionString** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;versionString&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsGameCenterEnabledVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterEnabledVersions | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitCompatibleVersions** | **int?** | maximum number of related compatibleVersions returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**GameCenterEnabledVersionsResponse**](GameCenterEnabledVersionsResponse.md)

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
| **200** | List of GameCenterEnabledVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetcollection"></a>
# **AppsGetCollection**
> AppsResponse AppsGetCollection (List<string>? filterAppStoreVersionsAppStoreState = null, List<string>? filterAppStoreVersionsPlatform = null, List<string>? filterBundleId = null, List<string>? filterName = null, List<string>? filterSku = null, List<string>? filterAppStoreVersions = null, List<string>? filterId = null, bool? existsGameCenterEnabledVersions = null, List<string>? sort = null, List<string>? fieldsApps = null, int? limit = null, List<string>? include = null, List<string>? fieldsBetaAppReviewDetails = null, List<string>? fieldsAppPriceSchedules = null, List<string>? fieldsCiProducts = null, List<string>? fieldsReviewSubmissions = null, List<string>? fieldsBetaGroups = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsAppAvailabilities = null, List<string>? fieldsCustomerReviews = null, List<string>? fieldsAppEvents = null, List<string>? fieldsBuilds = null, List<string>? fieldsBetaLicenseAgreements = null, List<string>? fieldsAppClips = null, List<string>? fieldsAppInfos = null, List<string>? fieldsBetaAppLocalizations = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsAppPricePoints2 = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsPreReleaseVersions = null, List<string>? fieldsInAppPurchases2 = null, List<string>? fieldsSubscriptionGroups = null, List<string>? fieldsAppPrices = null, List<string>? fieldsAppPreOrders = null, List<string>? fieldsGameCenterEnabledVersions = null, List<string>? fieldsSubscriptionGracePeriods = null, List<string>? fieldsEndUserLicenseAgreements = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppCustomProductPages = null, List<string>? fieldsTerritories = null, List<string>? fieldsPerfPowerMetrics = null, int? limitAppClips = null, int? limitAppCustomProductPages = null, int? limitAppEvents = null, int? limitAppInfos = null, int? limitAppStoreVersions = null, int? limitAvailableTerritories = null, int? limitBetaAppLocalizations = null, int? limitBetaGroups = null, int? limitBuilds = null, int? limitGameCenterEnabledVersions = null, int? limitInAppPurchases = null, int? limitInAppPurchasesV2 = null, int? limitPreReleaseVersions = null, int? limitPrices = null, int? limitPromotedPurchases = null, int? limitReviewSubmissions = null, int? limitSubscriptionGroups = null)



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
    public class AppsGetCollectionExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var filterAppStoreVersionsAppStoreState = new List<string>?(); // List<string>? | filter by attribute 'appStoreVersions.appStoreState' (optional) 
            var filterAppStoreVersionsPlatform = new List<string>?(); // List<string>? | filter by attribute 'appStoreVersions.platform' (optional) 
            var filterBundleId = new List<string>?(); // List<string>? | filter by attribute 'bundleId' (optional) 
            var filterName = new List<string>?(); // List<string>? | filter by attribute 'name' (optional) 
            var filterSku = new List<string>?(); // List<string>? | filter by attribute 'sku' (optional) 
            var filterAppStoreVersions = new List<string>?(); // List<string>? | filter by id(s) of related 'appStoreVersions' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var existsGameCenterEnabledVersions = true;  // bool? | filter by existence or non-existence of related 'gameCenterEnabledVersions' (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsBetaAppReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewDetails (optional) 
            var fieldsAppPriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceSchedules (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissions (optional) 
            var fieldsBetaGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaGroups (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsAppAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type appAvailabilities (optional) 
            var fieldsCustomerReviews = new List<string>?(); // List<string>? | the fields to include for returned resources of type customerReviews (optional) 
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var fieldsBetaLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaLicenseAgreements (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsAppInfos = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfos (optional) 
            var fieldsBetaAppLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppLocalizations (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsAppPricePoints2 = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 
            var fieldsInAppPurchases2 = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsAppPreOrders = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreOrders (optional) 
            var fieldsGameCenterEnabledVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterEnabledVersions (optional) 
            var fieldsSubscriptionGracePeriods = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGracePeriods (optional) 
            var fieldsEndUserLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type endUserLicenseAgreements (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppCustomProductPages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPages (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var fieldsPerfPowerMetrics = new List<string>?(); // List<string>? | the fields to include for returned resources of type perfPowerMetrics (optional) 
            var limitAppClips = 56;  // int? | maximum number of related appClips returned (when they are included) (optional) 
            var limitAppCustomProductPages = 56;  // int? | maximum number of related appCustomProductPages returned (when they are included) (optional) 
            var limitAppEvents = 56;  // int? | maximum number of related appEvents returned (when they are included) (optional) 
            var limitAppInfos = 56;  // int? | maximum number of related appInfos returned (when they are included) (optional) 
            var limitAppStoreVersions = 56;  // int? | maximum number of related appStoreVersions returned (when they are included) (optional) 
            var limitAvailableTerritories = 56;  // int? | maximum number of related availableTerritories returned (when they are included) (optional) 
            var limitBetaAppLocalizations = 56;  // int? | maximum number of related betaAppLocalizations returned (when they are included) (optional) 
            var limitBetaGroups = 56;  // int? | maximum number of related betaGroups returned (when they are included) (optional) 
            var limitBuilds = 56;  // int? | maximum number of related builds returned (when they are included) (optional) 
            var limitGameCenterEnabledVersions = 56;  // int? | maximum number of related gameCenterEnabledVersions returned (when they are included) (optional) 
            var limitInAppPurchases = 56;  // int? | maximum number of related inAppPurchases returned (when they are included) (optional) 
            var limitInAppPurchasesV2 = 56;  // int? | maximum number of related inAppPurchasesV2 returned (when they are included) (optional) 
            var limitPreReleaseVersions = 56;  // int? | maximum number of related preReleaseVersions returned (when they are included) (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var limitPromotedPurchases = 56;  // int? | maximum number of related promotedPurchases returned (when they are included) (optional) 
            var limitReviewSubmissions = 56;  // int? | maximum number of related reviewSubmissions returned (when they are included) (optional) 
            var limitSubscriptionGroups = 56;  // int? | maximum number of related subscriptionGroups returned (when they are included) (optional) 

            try
            {
                AppsResponse result = apiInstance.AppsGetCollection(filterAppStoreVersionsAppStoreState, filterAppStoreVersionsPlatform, filterBundleId, filterName, filterSku, filterAppStoreVersions, filterId, existsGameCenterEnabledVersions, sort, fieldsApps, limit, include, fieldsBetaAppReviewDetails, fieldsAppPriceSchedules, fieldsCiProducts, fieldsReviewSubmissions, fieldsBetaGroups, fieldsPromotedPurchases, fieldsAppAvailabilities, fieldsCustomerReviews, fieldsAppEvents, fieldsBuilds, fieldsBetaLicenseAgreements, fieldsAppClips, fieldsAppInfos, fieldsBetaAppLocalizations, fieldsAppPricePoints, fieldsAppPricePoints2, fieldsInAppPurchases, fieldsPreReleaseVersions, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsAppPrices, fieldsAppPreOrders, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsTerritories, fieldsPerfPowerMetrics, limitAppClips, limitAppCustomProductPages, limitAppEvents, limitAppInfos, limitAppStoreVersions, limitAvailableTerritories, limitBetaAppLocalizations, limitBetaGroups, limitBuilds, limitGameCenterEnabledVersions, limitInAppPurchases, limitInAppPurchasesV2, limitPreReleaseVersions, limitPrices, limitPromotedPurchases, limitReviewSubmissions, limitSubscriptionGroups);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppsResponse> response = apiInstance.AppsGetCollectionWithHttpInfo(filterAppStoreVersionsAppStoreState, filterAppStoreVersionsPlatform, filterBundleId, filterName, filterSku, filterAppStoreVersions, filterId, existsGameCenterEnabledVersions, sort, fieldsApps, limit, include, fieldsBetaAppReviewDetails, fieldsAppPriceSchedules, fieldsCiProducts, fieldsReviewSubmissions, fieldsBetaGroups, fieldsPromotedPurchases, fieldsAppAvailabilities, fieldsCustomerReviews, fieldsAppEvents, fieldsBuilds, fieldsBetaLicenseAgreements, fieldsAppClips, fieldsAppInfos, fieldsBetaAppLocalizations, fieldsAppPricePoints, fieldsAppPricePoints2, fieldsInAppPurchases, fieldsPreReleaseVersions, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsAppPrices, fieldsAppPreOrders, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsTerritories, fieldsPerfPowerMetrics, limitAppClips, limitAppCustomProductPages, limitAppEvents, limitAppInfos, limitAppStoreVersions, limitAvailableTerritories, limitBetaAppLocalizations, limitBetaGroups, limitBuilds, limitGameCenterEnabledVersions, limitInAppPurchases, limitInAppPurchasesV2, limitPreReleaseVersions, limitPrices, limitPromotedPurchases, limitReviewSubmissions, limitSubscriptionGroups);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterAppStoreVersionsAppStoreState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;appStoreVersions.appStoreState&#39; | [optional]  |
| **filterAppStoreVersionsPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;appStoreVersions.platform&#39; | [optional]  |
| **filterBundleId** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;bundleId&#39; | [optional]  |
| **filterName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;name&#39; | [optional]  |
| **filterSku** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;sku&#39; | [optional]  |
| **filterAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;appStoreVersions&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **existsGameCenterEnabledVersions** | **bool?** | filter by existence or non-existence of related &#39;gameCenterEnabledVersions&#39; | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsBetaAppReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewDetails | [optional]  |
| **fieldsAppPriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceSchedules | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissions | [optional]  |
| **fieldsBetaGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaGroups | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsAppAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appAvailabilities | [optional]  |
| **fieldsCustomerReviews** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type customerReviews | [optional]  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **fieldsBetaLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaLicenseAgreements | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsAppInfos** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfos | [optional]  |
| **fieldsBetaAppLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppLocalizations | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsAppPricePoints2** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |
| **fieldsInAppPurchases2** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsAppPreOrders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreOrders | [optional]  |
| **fieldsGameCenterEnabledVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterEnabledVersions | [optional]  |
| **fieldsSubscriptionGracePeriods** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGracePeriods | [optional]  |
| **fieldsEndUserLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type endUserLicenseAgreements | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppCustomProductPages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPages | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **fieldsPerfPowerMetrics** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type perfPowerMetrics | [optional]  |
| **limitAppClips** | **int?** | maximum number of related appClips returned (when they are included) | [optional]  |
| **limitAppCustomProductPages** | **int?** | maximum number of related appCustomProductPages returned (when they are included) | [optional]  |
| **limitAppEvents** | **int?** | maximum number of related appEvents returned (when they are included) | [optional]  |
| **limitAppInfos** | **int?** | maximum number of related appInfos returned (when they are included) | [optional]  |
| **limitAppStoreVersions** | **int?** | maximum number of related appStoreVersions returned (when they are included) | [optional]  |
| **limitAvailableTerritories** | **int?** | maximum number of related availableTerritories returned (when they are included) | [optional]  |
| **limitBetaAppLocalizations** | **int?** | maximum number of related betaAppLocalizations returned (when they are included) | [optional]  |
| **limitBetaGroups** | **int?** | maximum number of related betaGroups returned (when they are included) | [optional]  |
| **limitBuilds** | **int?** | maximum number of related builds returned (when they are included) | [optional]  |
| **limitGameCenterEnabledVersions** | **int?** | maximum number of related gameCenterEnabledVersions returned (when they are included) | [optional]  |
| **limitInAppPurchases** | **int?** | maximum number of related inAppPurchases returned (when they are included) | [optional]  |
| **limitInAppPurchasesV2** | **int?** | maximum number of related inAppPurchasesV2 returned (when they are included) | [optional]  |
| **limitPreReleaseVersions** | **int?** | maximum number of related preReleaseVersions returned (when they are included) | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **limitPromotedPurchases** | **int?** | maximum number of related promotedPurchases returned (when they are included) | [optional]  |
| **limitReviewSubmissions** | **int?** | maximum number of related reviewSubmissions returned (when they are included) | [optional]  |
| **limitSubscriptionGroups** | **int?** | maximum number of related subscriptionGroups returned (when they are included) | [optional]  |

### Return type

[**AppsResponse**](AppsResponse.md)

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
| **200** | List of Apps |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetinstance"></a>
# **AppsGetInstance**
> AppResponse AppsGetInstance (string id, List<string>? fieldsApps = null, List<string>? include = null, List<string>? fieldsBetaAppReviewDetails = null, List<string>? fieldsAppPriceSchedules = null, List<string>? fieldsCiProducts = null, List<string>? fieldsReviewSubmissions = null, List<string>? fieldsBetaGroups = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsAppAvailabilities = null, List<string>? fieldsCustomerReviews = null, List<string>? fieldsAppEvents = null, List<string>? fieldsBuilds = null, List<string>? fieldsBetaLicenseAgreements = null, List<string>? fieldsAppClips = null, List<string>? fieldsAppInfos = null, List<string>? fieldsBetaAppLocalizations = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsAppPricePoints2 = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsPreReleaseVersions = null, List<string>? fieldsInAppPurchases2 = null, List<string>? fieldsSubscriptionGroups = null, List<string>? fieldsAppPrices = null, List<string>? fieldsAppPreOrders = null, List<string>? fieldsGameCenterEnabledVersions = null, List<string>? fieldsSubscriptionGracePeriods = null, List<string>? fieldsEndUserLicenseAgreements = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppCustomProductPages = null, List<string>? fieldsTerritories = null, List<string>? fieldsPerfPowerMetrics = null, int? limitAppClips = null, int? limitAppCustomProductPages = null, int? limitAppEvents = null, int? limitAppInfos = null, int? limitAppStoreVersions = null, int? limitAvailableTerritories = null, int? limitBetaAppLocalizations = null, int? limitBetaGroups = null, int? limitBuilds = null, int? limitGameCenterEnabledVersions = null, int? limitInAppPurchases = null, int? limitInAppPurchasesV2 = null, int? limitPreReleaseVersions = null, int? limitPrices = null, int? limitPromotedPurchases = null, int? limitReviewSubmissions = null, int? limitSubscriptionGroups = null)



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
    public class AppsGetInstanceExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsBetaAppReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewDetails (optional) 
            var fieldsAppPriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceSchedules (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissions (optional) 
            var fieldsBetaGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaGroups (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsAppAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type appAvailabilities (optional) 
            var fieldsCustomerReviews = new List<string>?(); // List<string>? | the fields to include for returned resources of type customerReviews (optional) 
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var fieldsBetaLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaLicenseAgreements (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsAppInfos = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfos (optional) 
            var fieldsBetaAppLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppLocalizations (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsAppPricePoints2 = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 
            var fieldsInAppPurchases2 = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsAppPreOrders = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreOrders (optional) 
            var fieldsGameCenterEnabledVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterEnabledVersions (optional) 
            var fieldsSubscriptionGracePeriods = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGracePeriods (optional) 
            var fieldsEndUserLicenseAgreements = new List<string>?(); // List<string>? | the fields to include for returned resources of type endUserLicenseAgreements (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppCustomProductPages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPages (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var fieldsPerfPowerMetrics = new List<string>?(); // List<string>? | the fields to include for returned resources of type perfPowerMetrics (optional) 
            var limitAppClips = 56;  // int? | maximum number of related appClips returned (when they are included) (optional) 
            var limitAppCustomProductPages = 56;  // int? | maximum number of related appCustomProductPages returned (when they are included) (optional) 
            var limitAppEvents = 56;  // int? | maximum number of related appEvents returned (when they are included) (optional) 
            var limitAppInfos = 56;  // int? | maximum number of related appInfos returned (when they are included) (optional) 
            var limitAppStoreVersions = 56;  // int? | maximum number of related appStoreVersions returned (when they are included) (optional) 
            var limitAvailableTerritories = 56;  // int? | maximum number of related availableTerritories returned (when they are included) (optional) 
            var limitBetaAppLocalizations = 56;  // int? | maximum number of related betaAppLocalizations returned (when they are included) (optional) 
            var limitBetaGroups = 56;  // int? | maximum number of related betaGroups returned (when they are included) (optional) 
            var limitBuilds = 56;  // int? | maximum number of related builds returned (when they are included) (optional) 
            var limitGameCenterEnabledVersions = 56;  // int? | maximum number of related gameCenterEnabledVersions returned (when they are included) (optional) 
            var limitInAppPurchases = 56;  // int? | maximum number of related inAppPurchases returned (when they are included) (optional) 
            var limitInAppPurchasesV2 = 56;  // int? | maximum number of related inAppPurchasesV2 returned (when they are included) (optional) 
            var limitPreReleaseVersions = 56;  // int? | maximum number of related preReleaseVersions returned (when they are included) (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var limitPromotedPurchases = 56;  // int? | maximum number of related promotedPurchases returned (when they are included) (optional) 
            var limitReviewSubmissions = 56;  // int? | maximum number of related reviewSubmissions returned (when they are included) (optional) 
            var limitSubscriptionGroups = 56;  // int? | maximum number of related subscriptionGroups returned (when they are included) (optional) 

            try
            {
                AppResponse result = apiInstance.AppsGetInstance(id, fieldsApps, include, fieldsBetaAppReviewDetails, fieldsAppPriceSchedules, fieldsCiProducts, fieldsReviewSubmissions, fieldsBetaGroups, fieldsPromotedPurchases, fieldsAppAvailabilities, fieldsCustomerReviews, fieldsAppEvents, fieldsBuilds, fieldsBetaLicenseAgreements, fieldsAppClips, fieldsAppInfos, fieldsBetaAppLocalizations, fieldsAppPricePoints, fieldsAppPricePoints2, fieldsInAppPurchases, fieldsPreReleaseVersions, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsAppPrices, fieldsAppPreOrders, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsTerritories, fieldsPerfPowerMetrics, limitAppClips, limitAppCustomProductPages, limitAppEvents, limitAppInfos, limitAppStoreVersions, limitAvailableTerritories, limitBetaAppLocalizations, limitBetaGroups, limitBuilds, limitGameCenterEnabledVersions, limitInAppPurchases, limitInAppPurchasesV2, limitPreReleaseVersions, limitPrices, limitPromotedPurchases, limitReviewSubmissions, limitSubscriptionGroups);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppResponse> response = apiInstance.AppsGetInstanceWithHttpInfo(id, fieldsApps, include, fieldsBetaAppReviewDetails, fieldsAppPriceSchedules, fieldsCiProducts, fieldsReviewSubmissions, fieldsBetaGroups, fieldsPromotedPurchases, fieldsAppAvailabilities, fieldsCustomerReviews, fieldsAppEvents, fieldsBuilds, fieldsBetaLicenseAgreements, fieldsAppClips, fieldsAppInfos, fieldsBetaAppLocalizations, fieldsAppPricePoints, fieldsAppPricePoints2, fieldsInAppPurchases, fieldsPreReleaseVersions, fieldsInAppPurchases2, fieldsSubscriptionGroups, fieldsAppPrices, fieldsAppPreOrders, fieldsGameCenterEnabledVersions, fieldsSubscriptionGracePeriods, fieldsEndUserLicenseAgreements, fieldsAppStoreVersions, fieldsAppCustomProductPages, fieldsTerritories, fieldsPerfPowerMetrics, limitAppClips, limitAppCustomProductPages, limitAppEvents, limitAppInfos, limitAppStoreVersions, limitAvailableTerritories, limitBetaAppLocalizations, limitBetaGroups, limitBuilds, limitGameCenterEnabledVersions, limitInAppPurchases, limitInAppPurchasesV2, limitPreReleaseVersions, limitPrices, limitPromotedPurchases, limitReviewSubmissions, limitSubscriptionGroups);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsBetaAppReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewDetails | [optional]  |
| **fieldsAppPriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceSchedules | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissions | [optional]  |
| **fieldsBetaGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaGroups | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsAppAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appAvailabilities | [optional]  |
| **fieldsCustomerReviews** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type customerReviews | [optional]  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **fieldsBetaLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaLicenseAgreements | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsAppInfos** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfos | [optional]  |
| **fieldsBetaAppLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppLocalizations | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsAppPricePoints2** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |
| **fieldsInAppPurchases2** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsAppPreOrders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreOrders | [optional]  |
| **fieldsGameCenterEnabledVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterEnabledVersions | [optional]  |
| **fieldsSubscriptionGracePeriods** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGracePeriods | [optional]  |
| **fieldsEndUserLicenseAgreements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type endUserLicenseAgreements | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppCustomProductPages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPages | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **fieldsPerfPowerMetrics** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type perfPowerMetrics | [optional]  |
| **limitAppClips** | **int?** | maximum number of related appClips returned (when they are included) | [optional]  |
| **limitAppCustomProductPages** | **int?** | maximum number of related appCustomProductPages returned (when they are included) | [optional]  |
| **limitAppEvents** | **int?** | maximum number of related appEvents returned (when they are included) | [optional]  |
| **limitAppInfos** | **int?** | maximum number of related appInfos returned (when they are included) | [optional]  |
| **limitAppStoreVersions** | **int?** | maximum number of related appStoreVersions returned (when they are included) | [optional]  |
| **limitAvailableTerritories** | **int?** | maximum number of related availableTerritories returned (when they are included) | [optional]  |
| **limitBetaAppLocalizations** | **int?** | maximum number of related betaAppLocalizations returned (when they are included) | [optional]  |
| **limitBetaGroups** | **int?** | maximum number of related betaGroups returned (when they are included) | [optional]  |
| **limitBuilds** | **int?** | maximum number of related builds returned (when they are included) | [optional]  |
| **limitGameCenterEnabledVersions** | **int?** | maximum number of related gameCenterEnabledVersions returned (when they are included) | [optional]  |
| **limitInAppPurchases** | **int?** | maximum number of related inAppPurchases returned (when they are included) | [optional]  |
| **limitInAppPurchasesV2** | **int?** | maximum number of related inAppPurchasesV2 returned (when they are included) | [optional]  |
| **limitPreReleaseVersions** | **int?** | maximum number of related preReleaseVersions returned (when they are included) | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **limitPromotedPurchases** | **int?** | maximum number of related promotedPurchases returned (when they are included) | [optional]  |
| **limitReviewSubmissions** | **int?** | maximum number of related reviewSubmissions returned (when they are included) | [optional]  |
| **limitSubscriptionGroups** | **int?** | maximum number of related subscriptionGroups returned (when they are included) | [optional]  |

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

<a name="appsinapppurchasesgettomanyrelated"></a>
# **AppsInAppPurchasesGetToManyRelated**
> InAppPurchasesResponse AppsInAppPurchasesGetToManyRelated (string id, List<string>? filterInAppPurchaseType = null, List<string>? filterCanBeSubmitted = null, List<string>? sort = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsApps = null, int? limit = null, int? limitApps = null, List<string>? include = null)



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
    public class AppsInAppPurchasesGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterInAppPurchaseType = new List<string>?(); // List<string>? | filter by attribute 'inAppPurchaseType' (optional) 
            var filterCanBeSubmitted = new List<string>?(); // List<string>? | filter by canBeSubmitted (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitApps = 56;  // int? | maximum number of related apps returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchasesResponse result = apiInstance.AppsInAppPurchasesGetToManyRelated(id, filterInAppPurchaseType, filterCanBeSubmitted, sort, fieldsInAppPurchases, fieldsApps, limit, limitApps, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsInAppPurchasesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsInAppPurchasesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasesResponse> response = apiInstance.AppsInAppPurchasesGetToManyRelatedWithHttpInfo(id, filterInAppPurchaseType, filterCanBeSubmitted, sort, fieldsInAppPurchases, fieldsApps, limit, limitApps, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsInAppPurchasesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterInAppPurchaseType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;inAppPurchaseType&#39; | [optional]  |
| **filterCanBeSubmitted** | [**List&lt;string&gt;?**](string.md) | filter by canBeSubmitted | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitApps** | **int?** | maximum number of related apps returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchasesResponse**](InAppPurchasesResponse.md)

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
| **200** | List of InAppPurchases |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsinapppurchasesv2gettomanyrelated"></a>
# **AppsInAppPurchasesV2GetToManyRelated**
> InAppPurchasesV2Response AppsInAppPurchasesV2GetToManyRelated (string id, List<string>? filterInAppPurchaseType = null, List<string>? filterName = null, List<string>? filterProductId = null, List<string>? filterState = null, List<string>? sort = null, List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null, List<string>? fieldsInAppPurchasePricePoints = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsInAppPurchaseLocalizations = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsInAppPurchasePriceSchedules = null, List<string>? fieldsInAppPurchaseContents = null, int? limit = null, int? limitInAppPurchaseLocalizations = null, int? limitPricePoints = null, List<string>? include = null)



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
    public class AppsInAppPurchasesV2GetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterInAppPurchaseType = new List<string>?(); // List<string>? | filter by attribute 'inAppPurchaseType' (optional) 
            var filterName = new List<string>?(); // List<string>? | filter by attribute 'name' (optional) 
            var filterProductId = new List<string>?(); // List<string>? | filter by attribute 'productId' (optional) 
            var filterState = new List<string>?(); // List<string>? | filter by attribute 'state' (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsInAppPurchaseAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots (optional) 
            var fieldsInAppPurchasePricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePricePoints (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsInAppPurchaseLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseLocalizations (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsInAppPurchasePriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePriceSchedules (optional) 
            var fieldsInAppPurchaseContents = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseContents (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitInAppPurchaseLocalizations = 56;  // int? | maximum number of related inAppPurchaseLocalizations returned (when they are included) (optional) 
            var limitPricePoints = 56;  // int? | maximum number of related pricePoints returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchasesV2Response result = apiInstance.AppsInAppPurchasesV2GetToManyRelated(id, filterInAppPurchaseType, filterName, filterProductId, filterState, sort, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsInAppPurchasePricePoints, fieldsPromotedPurchases, fieldsInAppPurchaseLocalizations, fieldsInAppPurchases, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchaseContents, limit, limitInAppPurchaseLocalizations, limitPricePoints, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsInAppPurchasesV2GetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsInAppPurchasesV2GetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasesV2Response> response = apiInstance.AppsInAppPurchasesV2GetToManyRelatedWithHttpInfo(id, filterInAppPurchaseType, filterName, filterProductId, filterState, sort, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsInAppPurchasePricePoints, fieldsPromotedPurchases, fieldsInAppPurchaseLocalizations, fieldsInAppPurchases, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchaseContents, limit, limitInAppPurchaseLocalizations, limitPricePoints, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsInAppPurchasesV2GetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterInAppPurchaseType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;inAppPurchaseType&#39; | [optional]  |
| **filterName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;name&#39; | [optional]  |
| **filterProductId** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;productId&#39; | [optional]  |
| **filterState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;state&#39; | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsInAppPurchaseAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots | [optional]  |
| **fieldsInAppPurchasePricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePricePoints | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsInAppPurchaseLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseLocalizations | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsInAppPurchasePriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePriceSchedules | [optional]  |
| **fieldsInAppPurchaseContents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseContents | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitInAppPurchaseLocalizations** | **int?** | maximum number of related inAppPurchaseLocalizations returned (when they are included) | [optional]  |
| **limitPricePoints** | **int?** | maximum number of related pricePoints returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchasesV2Response**](InAppPurchasesV2Response.md)

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
| **200** | List of InAppPurchases |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsperfpowermetricsgettomanyrelated"></a>
# **AppsPerfPowerMetricsGetToManyRelated**
> XcodeMetrics AppsPerfPowerMetricsGetToManyRelated (string id, List<string>? filterDeviceType = null, List<string>? filterMetricType = null, List<string>? filterPlatform = null)



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
    public class AppsPerfPowerMetricsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterDeviceType = new List<string>?(); // List<string>? | filter by attribute 'deviceType' (optional) 
            var filterMetricType = new List<string>?(); // List<string>? | filter by attribute 'metricType' (optional) 
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 

            try
            {
                XcodeMetrics result = apiInstance.AppsPerfPowerMetricsGetToManyRelated(id, filterDeviceType, filterMetricType, filterPlatform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPerfPowerMetricsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPerfPowerMetricsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<XcodeMetrics> response = apiInstance.AppsPerfPowerMetricsGetToManyRelatedWithHttpInfo(id, filterDeviceType, filterMetricType, filterPlatform);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPerfPowerMetricsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterDeviceType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;deviceType&#39; | [optional]  |
| **filterMetricType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;metricType&#39; | [optional]  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |

### Return type

[**XcodeMetrics**](XcodeMetrics.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.apple.xcode-metrics+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of PerfPowerMetrics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspreordergettoonerelated"></a>
# **AppsPreOrderGetToOneRelated**
> AppPreOrderResponse AppsPreOrderGetToOneRelated (string id, List<string>? fieldsAppPreOrders = null)



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
    public class AppsPreOrderGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppPreOrders = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreOrders (optional) 

            try
            {
                AppPreOrderResponse result = apiInstance.AppsPreOrderGetToOneRelated(id, fieldsAppPreOrders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPreOrderGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPreOrderGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPreOrderResponse> response = apiInstance.AppsPreOrderGetToOneRelatedWithHttpInfo(id, fieldsAppPreOrders);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPreOrderGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppPreOrders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreOrders | [optional]  |

### Return type

[**AppPreOrderResponse**](AppPreOrderResponse.md)

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
| **200** | Single AppPreOrder |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsprereleaseversionsgettomanyrelated"></a>
# **AppsPreReleaseVersionsGetToManyRelated**
> PreReleaseVersionsResponse AppsPreReleaseVersionsGetToManyRelated (string id, List<string>? fieldsPreReleaseVersions = null, int? limit = null)



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
    public class AppsPreReleaseVersionsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                PreReleaseVersionsResponse result = apiInstance.AppsPreReleaseVersionsGetToManyRelated(id, fieldsPreReleaseVersions, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPreReleaseVersionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPreReleaseVersionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PreReleaseVersionsResponse> response = apiInstance.AppsPreReleaseVersionsGetToManyRelatedWithHttpInfo(id, fieldsPreReleaseVersions, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPreReleaseVersionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**PreReleaseVersionsResponse**](PreReleaseVersionsResponse.md)

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
| **200** | List of PreReleaseVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspricepointsgettomanyrelated"></a>
# **AppsPricePointsGetToManyRelated**
> AppPricePointsV2Response AppsPricePointsGetToManyRelated (string id, List<string>? filterPriceTier = null, List<string>? filterTerritory = null, List<string>? fieldsAppPriceTiers = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsApps = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class AppsPricePointsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterPriceTier = new List<string>?(); // List<string>? | filter by id(s) of related 'priceTier' (optional) 
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsAppPriceTiers = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceTiers (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPricePointsV2Response result = apiInstance.AppsPricePointsGetToManyRelated(id, filterPriceTier, filterTerritory, fieldsAppPriceTiers, fieldsAppPricePoints, fieldsApps, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPricePointsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPricePointsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPricePointsV2Response> response = apiInstance.AppsPricePointsGetToManyRelatedWithHttpInfo(id, filterPriceTier, filterTerritory, fieldsAppPriceTiers, fieldsAppPricePoints, fieldsApps, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPricePointsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterPriceTier** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;priceTier&#39; | [optional]  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsAppPriceTiers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceTiers | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPricePointsV2Response**](AppPricePointsV2Response.md)

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
| **200** | List of AppPricePoints |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspricesgettomanyrelated"></a>
# **AppsPricesGetToManyRelated**
> AppPricesResponse AppsPricesGetToManyRelated (string id, List<string>? fieldsAppPriceTiers = null, List<string>? fieldsApps = null, List<string>? fieldsAppPrices = null, int? limit = null, List<string>? include = null)



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
    public class AppsPricesGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppPriceTiers = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceTiers (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPricesResponse result = apiInstance.AppsPricesGetToManyRelated(id, fieldsAppPriceTiers, fieldsApps, fieldsAppPrices, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPricesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPricesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPricesResponse> response = apiInstance.AppsPricesGetToManyRelatedWithHttpInfo(id, fieldsAppPriceTiers, fieldsApps, fieldsAppPrices, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPricesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppPriceTiers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceTiers | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPricesResponse**](AppPricesResponse.md)

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
| **200** | List of AppPrices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspromotedpurchasesgettomanyrelated"></a>
# **AppsPromotedPurchasesGetToManyRelated**
> PromotedPurchasesResponse AppsPromotedPurchasesGetToManyRelated (string id, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsPromotedPurchaseImages = null, int? limit = null, int? limitPromotionImages = null, List<string>? include = null)



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
    public class AppsPromotedPurchasesGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsPromotedPurchaseImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchaseImages (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitPromotionImages = 56;  // int? | maximum number of related promotionImages returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                PromotedPurchasesResponse result = apiInstance.AppsPromotedPurchasesGetToManyRelated(id, fieldsPromotedPurchases, fieldsSubscriptions, fieldsInAppPurchases, fieldsPromotedPurchaseImages, limit, limitPromotionImages, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPromotedPurchasesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPromotedPurchasesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PromotedPurchasesResponse> response = apiInstance.AppsPromotedPurchasesGetToManyRelatedWithHttpInfo(id, fieldsPromotedPurchases, fieldsSubscriptions, fieldsInAppPurchases, fieldsPromotedPurchaseImages, limit, limitPromotionImages, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPromotedPurchasesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsPromotedPurchaseImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchaseImages | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitPromotionImages** | **int?** | maximum number of related promotionImages returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**PromotedPurchasesResponse**](PromotedPurchasesResponse.md)

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
| **200** | List of PromotedPurchases |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspromotedpurchasesgettomanyrelationship"></a>
# **AppsPromotedPurchasesGetToManyRelationship**
> AppPromotedPurchasesLinkagesResponse AppsPromotedPurchasesGetToManyRelationship (string id, int? limit = null)



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
    public class AppsPromotedPurchasesGetToManyRelationshipExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                AppPromotedPurchasesLinkagesResponse result = apiInstance.AppsPromotedPurchasesGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPromotedPurchasesGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPromotedPurchasesGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPromotedPurchasesLinkagesResponse> response = apiInstance.AppsPromotedPurchasesGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPromotedPurchasesGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**AppPromotedPurchasesLinkagesResponse**](AppPromotedPurchasesLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspromotedpurchasesreplacetomanyrelationship"></a>
# **AppsPromotedPurchasesReplaceToManyRelationship**
> void AppsPromotedPurchasesReplaceToManyRelationship (string id, AppPromotedPurchasesLinkagesRequest appPromotedPurchasesLinkagesRequest)



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
    public class AppsPromotedPurchasesReplaceToManyRelationshipExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appPromotedPurchasesLinkagesRequest = new AppPromotedPurchasesLinkagesRequest(); // AppPromotedPurchasesLinkagesRequest | List of related linkages

            try
            {
                apiInstance.AppsPromotedPurchasesReplaceToManyRelationship(id, appPromotedPurchasesLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPromotedPurchasesReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsPromotedPurchasesReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppsPromotedPurchasesReplaceToManyRelationshipWithHttpInfo(id, appPromotedPurchasesLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsPromotedPurchasesReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appPromotedPurchasesLinkagesRequest** | [**AppPromotedPurchasesLinkagesRequest**](AppPromotedPurchasesLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsreviewsubmissionsgettomanyrelated"></a>
# **AppsReviewSubmissionsGetToManyRelated**
> ReviewSubmissionsResponse AppsReviewSubmissionsGetToManyRelated (string id, List<string>? filterPlatform = null, List<string>? filterState = null, List<string>? fieldsReviewSubmissionItems = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsApps = null, List<string>? fieldsReviewSubmissions = null, int? limit = null, int? limitItems = null, List<string>? include = null)



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
    public class AppsReviewSubmissionsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 
            var filterState = new List<string>?(); // List<string>? | filter by attribute 'state' (optional) 
            var fieldsReviewSubmissionItems = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissionItems (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissions (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitItems = 56;  // int? | maximum number of related items returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                ReviewSubmissionsResponse result = apiInstance.AppsReviewSubmissionsGetToManyRelated(id, filterPlatform, filterState, fieldsReviewSubmissionItems, fieldsAppStoreVersions, fieldsApps, fieldsReviewSubmissions, limit, limitItems, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsReviewSubmissionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsReviewSubmissionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionsResponse> response = apiInstance.AppsReviewSubmissionsGetToManyRelatedWithHttpInfo(id, filterPlatform, filterState, fieldsReviewSubmissionItems, fieldsAppStoreVersions, fieldsApps, fieldsReviewSubmissions, limit, limitItems, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsReviewSubmissionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |
| **filterState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;state&#39; | [optional]  |
| **fieldsReviewSubmissionItems** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissionItems | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissions | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitItems** | **int?** | maximum number of related items returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**ReviewSubmissionsResponse**](ReviewSubmissionsResponse.md)

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
| **200** | List of ReviewSubmissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appssubscriptiongraceperiodgettoonerelated"></a>
# **AppsSubscriptionGracePeriodGetToOneRelated**
> SubscriptionGracePeriodResponse AppsSubscriptionGracePeriodGetToOneRelated (string id, List<string>? fieldsSubscriptionGracePeriods = null)



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
    public class AppsSubscriptionGracePeriodGetToOneRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionGracePeriods = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGracePeriods (optional) 

            try
            {
                SubscriptionGracePeriodResponse result = apiInstance.AppsSubscriptionGracePeriodGetToOneRelated(id, fieldsSubscriptionGracePeriods);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsSubscriptionGracePeriodGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsSubscriptionGracePeriodGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGracePeriodResponse> response = apiInstance.AppsSubscriptionGracePeriodGetToOneRelatedWithHttpInfo(id, fieldsSubscriptionGracePeriods);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsSubscriptionGracePeriodGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionGracePeriods** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGracePeriods | [optional]  |

### Return type

[**SubscriptionGracePeriodResponse**](SubscriptionGracePeriodResponse.md)

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
| **200** | Single SubscriptionGracePeriod |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appssubscriptiongroupsgettomanyrelated"></a>
# **AppsSubscriptionGroupsGetToManyRelated**
> SubscriptionGroupsResponse AppsSubscriptionGroupsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterSubscriptionsState = null, List<string>? sort = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionGroups = null, List<string>? fieldsSubscriptionGroupLocalizations = null, int? limit = null, int? limitSubscriptions = null, int? limitSubscriptionGroupLocalizations = null, List<string>? include = null)



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
    public class AppsSubscriptionGroupsGetToManyRelatedExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterReferenceName = new List<string>?(); // List<string>? | filter by attribute 'referenceName' (optional) 
            var filterSubscriptionsState = new List<string>?(); // List<string>? | filter by attribute 'subscriptions.state' (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var fieldsSubscriptionGroupLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroupLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitSubscriptions = 56;  // int? | maximum number of related subscriptions returned (when they are included) (optional) 
            var limitSubscriptionGroupLocalizations = 56;  // int? | maximum number of related subscriptionGroupLocalizations returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionGroupsResponse result = apiInstance.AppsSubscriptionGroupsGetToManyRelated(id, filterReferenceName, filterSubscriptionsState, sort, fieldsSubscriptions, fieldsSubscriptionGroups, fieldsSubscriptionGroupLocalizations, limit, limitSubscriptions, limitSubscriptionGroupLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsSubscriptionGroupsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsSubscriptionGroupsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGroupsResponse> response = apiInstance.AppsSubscriptionGroupsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterSubscriptionsState, sort, fieldsSubscriptions, fieldsSubscriptionGroups, fieldsSubscriptionGroupLocalizations, limit, limitSubscriptions, limitSubscriptionGroupLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsSubscriptionGroupsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterReferenceName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;referenceName&#39; | [optional]  |
| **filterSubscriptionsState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;subscriptions.state&#39; | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **fieldsSubscriptionGroupLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroupLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitSubscriptions** | **int?** | maximum number of related subscriptions returned (when they are included) | [optional]  |
| **limitSubscriptionGroupLocalizations** | **int?** | maximum number of related subscriptionGroupLocalizations returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionGroupsResponse**](SubscriptionGroupsResponse.md)

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
| **200** | List of SubscriptionGroups |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsupdateinstance"></a>
# **AppsUpdateInstance**
> AppResponse AppsUpdateInstance (string id, AppUpdateRequest appUpdateRequest)



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
    public class AppsUpdateInstanceExample
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
            var apiInstance = new AppsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appUpdateRequest = new AppUpdateRequest(); // AppUpdateRequest | App representation

            try
            {
                AppResponse result = apiInstance.AppsUpdateInstance(id, appUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppsApi.AppsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppResponse> response = apiInstance.AppsUpdateInstanceWithHttpInfo(id, appUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppsApi.AppsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appUpdateRequest** | [**AppUpdateRequest**](AppUpdateRequest.md) | App representation |  |

### Return type

[**AppResponse**](AppResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single App |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

