# AppStoreConnect.Net.Api.AppClipsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppClipsAppClipAdvancedExperiencesGetToManyRelated**](AppClipsApi.md#appclipsappclipadvancedexperiencesgettomanyrelated) | **GET** /v1/appClips/{id}/appClipAdvancedExperiences |  |
| [**AppClipsAppClipDefaultExperiencesGetToManyRelated**](AppClipsApi.md#appclipsappclipdefaultexperiencesgettomanyrelated) | **GET** /v1/appClips/{id}/appClipDefaultExperiences |  |
| [**AppClipsGetInstance**](AppClipsApi.md#appclipsgetinstance) | **GET** /v1/appClips/{id} |  |

<a name="appclipsappclipadvancedexperiencesgettomanyrelated"></a>
# **AppClipsAppClipAdvancedExperiencesGetToManyRelated**
> AppClipAdvancedExperiencesResponse AppClipsAppClipAdvancedExperiencesGetToManyRelated (string id, List<string>? filterAction = null, List<string>? filterPlaceStatus = null, List<string>? filterStatus = null, List<string>? fieldsAppClipAdvancedExperiences = null, List<string>? fieldsAppClips = null, List<string>? fieldsAppClipAdvancedExperienceImages = null, List<string>? fieldsAppClipAdvancedExperienceLocalizations = null, int? limit = null, int? limitLocalizations = null, List<string>? include = null)



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
    public class AppClipsAppClipAdvancedExperiencesGetToManyRelatedExample
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
            var apiInstance = new AppClipsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterAction = new List<string>?(); // List<string>? | filter by attribute 'action' (optional) 
            var filterPlaceStatus = new List<string>?(); // List<string>? | filter by attribute 'placeStatus' (optional) 
            var filterStatus = new List<string>?(); // List<string>? | filter by attribute 'status' (optional) 
            var fieldsAppClipAdvancedExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAdvancedExperiences (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsAppClipAdvancedExperienceImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAdvancedExperienceImages (optional) 
            var fieldsAppClipAdvancedExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAdvancedExperienceLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipAdvancedExperiencesResponse result = apiInstance.AppClipsAppClipAdvancedExperiencesGetToManyRelated(id, filterAction, filterPlaceStatus, filterStatus, fieldsAppClipAdvancedExperiences, fieldsAppClips, fieldsAppClipAdvancedExperienceImages, fieldsAppClipAdvancedExperienceLocalizations, limit, limitLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipsApi.AppClipsAppClipAdvancedExperiencesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipsAppClipAdvancedExperiencesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperiencesResponse> response = apiInstance.AppClipsAppClipAdvancedExperiencesGetToManyRelatedWithHttpInfo(id, filterAction, filterPlaceStatus, filterStatus, fieldsAppClipAdvancedExperiences, fieldsAppClips, fieldsAppClipAdvancedExperienceImages, fieldsAppClipAdvancedExperienceLocalizations, limit, limitLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipsApi.AppClipsAppClipAdvancedExperiencesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterAction** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;action&#39; | [optional]  |
| **filterPlaceStatus** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;placeStatus&#39; | [optional]  |
| **filterStatus** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;status&#39; | [optional]  |
| **fieldsAppClipAdvancedExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAdvancedExperiences | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsAppClipAdvancedExperienceImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAdvancedExperienceImages | [optional]  |
| **fieldsAppClipAdvancedExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAdvancedExperienceLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipAdvancedExperiencesResponse**](AppClipAdvancedExperiencesResponse.md)

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
| **200** | List of AppClipAdvancedExperiences |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipsappclipdefaultexperiencesgettomanyrelated"></a>
# **AppClipsAppClipDefaultExperiencesGetToManyRelated**
> AppClipDefaultExperiencesResponse AppClipsAppClipDefaultExperiencesGetToManyRelated (string id, bool? existsReleaseWithAppStoreVersion = null, List<string>? fieldsAppClips = null, List<string>? fieldsAppClipAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppClipDefaultExperienceLocalizations = null, int? limit = null, int? limitAppClipDefaultExperienceLocalizations = null, List<string>? include = null)



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
    public class AppClipsAppClipDefaultExperiencesGetToManyRelatedExample
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
            var apiInstance = new AppClipsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var existsReleaseWithAppStoreVersion = true;  // bool? | filter by existence or non-existence of related 'releaseWithAppStoreVersion' (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsAppClipAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAppStoreReviewDetails (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var fieldsAppClipDefaultExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperienceLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppClipDefaultExperienceLocalizations = 56;  // int? | maximum number of related appClipDefaultExperienceLocalizations returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipDefaultExperiencesResponse result = apiInstance.AppClipsAppClipDefaultExperiencesGetToManyRelated(id, existsReleaseWithAppStoreVersion, fieldsAppClips, fieldsAppClipAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppClipDefaultExperiences, fieldsAppClipDefaultExperienceLocalizations, limit, limitAppClipDefaultExperienceLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipsApi.AppClipsAppClipDefaultExperiencesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipsAppClipDefaultExperiencesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperiencesResponse> response = apiInstance.AppClipsAppClipDefaultExperiencesGetToManyRelatedWithHttpInfo(id, existsReleaseWithAppStoreVersion, fieldsAppClips, fieldsAppClipAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppClipDefaultExperiences, fieldsAppClipDefaultExperienceLocalizations, limit, limitAppClipDefaultExperienceLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipsApi.AppClipsAppClipDefaultExperiencesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **existsReleaseWithAppStoreVersion** | **bool?** | filter by existence or non-existence of related &#39;releaseWithAppStoreVersion&#39; | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsAppClipAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAppStoreReviewDetails | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **fieldsAppClipDefaultExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperienceLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppClipDefaultExperienceLocalizations** | **int?** | maximum number of related appClipDefaultExperienceLocalizations returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipDefaultExperiencesResponse**](AppClipDefaultExperiencesResponse.md)

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
| **200** | List of AppClipDefaultExperiences |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipsgetinstance"></a>
# **AppClipsGetInstance**
> AppClipResponse AppClipsGetInstance (string id, List<string>? fieldsAppClips = null, List<string>? include = null, List<string>? fieldsAppClipAdvancedExperiences = null, List<string>? fieldsAppClipDefaultExperiences = null, int? limitAppClipDefaultExperiences = null)



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
    public class AppClipsGetInstanceExample
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
            var apiInstance = new AppClipsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppClipAdvancedExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAdvancedExperiences (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var limitAppClipDefaultExperiences = 56;  // int? | maximum number of related appClipDefaultExperiences returned (when they are included) (optional) 

            try
            {
                AppClipResponse result = apiInstance.AppClipsGetInstance(id, fieldsAppClips, include, fieldsAppClipAdvancedExperiences, fieldsAppClipDefaultExperiences, limitAppClipDefaultExperiences);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipsApi.AppClipsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipResponse> response = apiInstance.AppClipsGetInstanceWithHttpInfo(id, fieldsAppClips, include, fieldsAppClipAdvancedExperiences, fieldsAppClipDefaultExperiences, limitAppClipDefaultExperiences);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipsApi.AppClipsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppClipAdvancedExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAdvancedExperiences | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **limitAppClipDefaultExperiences** | **int?** | maximum number of related appClipDefaultExperiences returned (when they are included) | [optional]  |

### Return type

[**AppClipResponse**](AppClipResponse.md)

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
| **200** | Single AppClip |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

