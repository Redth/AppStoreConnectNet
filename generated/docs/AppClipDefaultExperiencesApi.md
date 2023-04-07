# AppStoreConnect.Net.Api.AppClipDefaultExperiencesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesappclipappstorereviewdetailgettoonerelated) | **GET** /v1/appClipDefaultExperiences/{id}/appClipAppStoreReviewDetail |  |
| [**AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesappclipdefaultexperiencelocalizationsgettomanyrelated) | **GET** /v1/appClipDefaultExperiences/{id}/appClipDefaultExperienceLocalizations |  |
| [**AppClipDefaultExperiencesCreateInstance**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencescreateinstance) | **POST** /v1/appClipDefaultExperiences |  |
| [**AppClipDefaultExperiencesDeleteInstance**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesdeleteinstance) | **DELETE** /v1/appClipDefaultExperiences/{id} |  |
| [**AppClipDefaultExperiencesGetInstance**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesgetinstance) | **GET** /v1/appClipDefaultExperiences/{id} |  |
| [**AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesreleasewithappstoreversiongettoonerelated) | **GET** /v1/appClipDefaultExperiences/{id}/releaseWithAppStoreVersion |  |
| [**AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesreleasewithappstoreversiongettoonerelationship) | **GET** /v1/appClipDefaultExperiences/{id}/relationships/releaseWithAppStoreVersion |  |
| [**AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesreleasewithappstoreversionupdatetoonerelationship) | **PATCH** /v1/appClipDefaultExperiences/{id}/relationships/releaseWithAppStoreVersion |  |
| [**AppClipDefaultExperiencesUpdateInstance**](AppClipDefaultExperiencesApi.md#appclipdefaultexperiencesupdateinstance) | **PATCH** /v1/appClipDefaultExperiences/{id} |  |

<a name="appclipdefaultexperiencesappclipappstorereviewdetailgettoonerelated"></a>
# **AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated**
> AppClipAppStoreReviewDetailResponse AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated (string id, List<string>? fieldsAppClipAppStoreReviewDetails = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? include = null)



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
    public class AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAppStoreReviewDetails (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipAppStoreReviewDetailResponse result = apiInstance.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated(id, fieldsAppClipAppStoreReviewDetails, fieldsAppClipDefaultExperiences, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAppStoreReviewDetailResponse> response = apiInstance.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedWithHttpInfo(id, fieldsAppClipAppStoreReviewDetails, fieldsAppClipDefaultExperiences, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAppStoreReviewDetails | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipAppStoreReviewDetailResponse**](AppClipAppStoreReviewDetailResponse.md)

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
| **200** | Single AppClipAppStoreReviewDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencesappclipdefaultexperiencelocalizationsgettomanyrelated"></a>
# **AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated**
> AppClipDefaultExperienceLocalizationsResponse AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated (string id, List<string>? filterLocale = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppClipDefaultExperienceLocalizations = null, List<string>? fieldsAppClipHeaderImages = null, int? limit = null, List<string>? include = null)



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
    public class AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLocale = new List<string>?(); // List<string>? | filter by attribute 'locale' (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var fieldsAppClipDefaultExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperienceLocalizations (optional) 
            var fieldsAppClipHeaderImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipHeaderImages (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipDefaultExperienceLocalizationsResponse result = apiInstance.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated(id, filterLocale, fieldsAppClipDefaultExperiences, fieldsAppClipDefaultExperienceLocalizations, fieldsAppClipHeaderImages, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceLocalizationsResponse> response = apiInstance.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedWithHttpInfo(id, filterLocale, fieldsAppClipDefaultExperiences, fieldsAppClipDefaultExperienceLocalizations, fieldsAppClipHeaderImages, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLocale** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;locale&#39; | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **fieldsAppClipDefaultExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperienceLocalizations | [optional]  |
| **fieldsAppClipHeaderImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipHeaderImages | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipDefaultExperienceLocalizationsResponse**](AppClipDefaultExperienceLocalizationsResponse.md)

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
| **200** | List of AppClipDefaultExperienceLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencescreateinstance"></a>
# **AppClipDefaultExperiencesCreateInstance**
> AppClipDefaultExperienceResponse AppClipDefaultExperiencesCreateInstance (AppClipDefaultExperienceCreateRequest appClipDefaultExperienceCreateRequest)



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
    public class AppClipDefaultExperiencesCreateInstanceExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var appClipDefaultExperienceCreateRequest = new AppClipDefaultExperienceCreateRequest(); // AppClipDefaultExperienceCreateRequest | AppClipDefaultExperience representation

            try
            {
                AppClipDefaultExperienceResponse result = apiInstance.AppClipDefaultExperiencesCreateInstance(appClipDefaultExperienceCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceResponse> response = apiInstance.AppClipDefaultExperiencesCreateInstanceWithHttpInfo(appClipDefaultExperienceCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appClipDefaultExperienceCreateRequest** | [**AppClipDefaultExperienceCreateRequest**](AppClipDefaultExperienceCreateRequest.md) | AppClipDefaultExperience representation |  |

### Return type

[**AppClipDefaultExperienceResponse**](AppClipDefaultExperienceResponse.md)

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
| **201** | Single AppClipDefaultExperience |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencesdeleteinstance"></a>
# **AppClipDefaultExperiencesDeleteInstance**
> void AppClipDefaultExperiencesDeleteInstance (string id)



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
    public class AppClipDefaultExperiencesDeleteInstanceExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppClipDefaultExperiencesDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppClipDefaultExperiencesDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appclipdefaultexperiencesgetinstance"></a>
# **AppClipDefaultExperiencesGetInstance**
> AppClipDefaultExperienceResponse AppClipDefaultExperiencesGetInstance (string id, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? include = null, List<string>? fieldsAppClipAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppClipDefaultExperienceLocalizations = null, int? limitAppClipDefaultExperienceLocalizations = null)



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
    public class AppClipDefaultExperiencesGetInstanceExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppClipAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAppStoreReviewDetails (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppClipDefaultExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperienceLocalizations (optional) 
            var limitAppClipDefaultExperienceLocalizations = 56;  // int? | maximum number of related appClipDefaultExperienceLocalizations returned (when they are included) (optional) 

            try
            {
                AppClipDefaultExperienceResponse result = apiInstance.AppClipDefaultExperiencesGetInstance(id, fieldsAppClipDefaultExperiences, include, fieldsAppClipAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppClipDefaultExperienceLocalizations, limitAppClipDefaultExperienceLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceResponse> response = apiInstance.AppClipDefaultExperiencesGetInstanceWithHttpInfo(id, fieldsAppClipDefaultExperiences, include, fieldsAppClipAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppClipDefaultExperienceLocalizations, limitAppClipDefaultExperienceLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppClipAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAppStoreReviewDetails | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppClipDefaultExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperienceLocalizations | [optional]  |
| **limitAppClipDefaultExperienceLocalizations** | **int?** | maximum number of related appClipDefaultExperienceLocalizations returned (when they are included) | [optional]  |

### Return type

[**AppClipDefaultExperienceResponse**](AppClipDefaultExperienceResponse.md)

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
| **200** | Single AppClipDefaultExperience |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencesreleasewithappstoreversiongettoonerelated"></a>
# **AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated**
> AppStoreVersionResponse AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated (string id, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsAgeRatingDeclarations = null, List<string>? fieldsAppStoreVersionSubmissions = null, List<string>? fieldsAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsApps = null, List<string>? fieldsRoutingAppCoverages = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppStoreVersionPhasedReleases = null, List<string>? fieldsBuilds = null, List<string>? fieldsAppStoreVersionLocalizations = null, int? limitAppStoreVersionLocalizations = null, int? limitAppStoreVersionExperiments = null, List<string>? include = null)



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
    public class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
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
            var limitAppStoreVersionLocalizations = 56;  // int? | maximum number of related appStoreVersionLocalizations returned (when they are included) (optional) 
            var limitAppStoreVersionExperiments = 56;  // int? | maximum number of related appStoreVersionExperiments returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreVersionResponse result = apiInstance.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated(id, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionResponse> response = apiInstance.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedWithHttpInfo(id, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
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
| **limitAppStoreVersionLocalizations** | **int?** | maximum number of related appStoreVersionLocalizations returned (when they are included) | [optional]  |
| **limitAppStoreVersionExperiments** | **int?** | maximum number of related appStoreVersionExperiments returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreVersionResponse**](AppStoreVersionResponse.md)

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
| **200** | Single AppStoreVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencesreleasewithappstoreversiongettoonerelationship"></a>
# **AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship**
> AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponse AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship (string id)



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
    public class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationshipExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponse result = apiInstance.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponse> response = apiInstance.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationshipWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

[**AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponse**](AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponse.md)

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
| **200** | Related linkage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencesreleasewithappstoreversionupdatetoonerelationship"></a>
# **AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship**
> void AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship (string id, AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest)



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
    public class AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest = new AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest(); // AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest | Related linkage

            try
            {
                apiInstance.AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship(id, appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipWithHttpInfo(id, appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest** | [**AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest**](AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest.md) | Related linkage |  |

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

<a name="appclipdefaultexperiencesupdateinstance"></a>
# **AppClipDefaultExperiencesUpdateInstance**
> AppClipDefaultExperienceResponse AppClipDefaultExperiencesUpdateInstance (string id, AppClipDefaultExperienceUpdateRequest appClipDefaultExperienceUpdateRequest)



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
    public class AppClipDefaultExperiencesUpdateInstanceExample
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
            var apiInstance = new AppClipDefaultExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appClipDefaultExperienceUpdateRequest = new AppClipDefaultExperienceUpdateRequest(); // AppClipDefaultExperienceUpdateRequest | AppClipDefaultExperience representation

            try
            {
                AppClipDefaultExperienceResponse result = apiInstance.AppClipDefaultExperiencesUpdateInstance(id, appClipDefaultExperienceUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperiencesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceResponse> response = apiInstance.AppClipDefaultExperiencesUpdateInstanceWithHttpInfo(id, appClipDefaultExperienceUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperiencesApi.AppClipDefaultExperiencesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appClipDefaultExperienceUpdateRequest** | [**AppClipDefaultExperienceUpdateRequest**](AppClipDefaultExperienceUpdateRequest.md) | AppClipDefaultExperience representation |  |

### Return type

[**AppClipDefaultExperienceResponse**](AppClipDefaultExperienceResponse.md)

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
| **200** | Single AppClipDefaultExperience |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

