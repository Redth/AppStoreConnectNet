# AppStoreConnect.Net.Api.AppEventLocalizationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppEventLocalizationsAppEventScreenshotsGetToManyRelated**](AppEventLocalizationsApi.md#appeventlocalizationsappeventscreenshotsgettomanyrelated) | **GET** /v1/appEventLocalizations/{id}/appEventScreenshots |  |
| [**AppEventLocalizationsAppEventVideoClipsGetToManyRelated**](AppEventLocalizationsApi.md#appeventlocalizationsappeventvideoclipsgettomanyrelated) | **GET** /v1/appEventLocalizations/{id}/appEventVideoClips |  |
| [**AppEventLocalizationsCreateInstance**](AppEventLocalizationsApi.md#appeventlocalizationscreateinstance) | **POST** /v1/appEventLocalizations |  |
| [**AppEventLocalizationsDeleteInstance**](AppEventLocalizationsApi.md#appeventlocalizationsdeleteinstance) | **DELETE** /v1/appEventLocalizations/{id} |  |
| [**AppEventLocalizationsGetInstance**](AppEventLocalizationsApi.md#appeventlocalizationsgetinstance) | **GET** /v1/appEventLocalizations/{id} |  |
| [**AppEventLocalizationsUpdateInstance**](AppEventLocalizationsApi.md#appeventlocalizationsupdateinstance) | **PATCH** /v1/appEventLocalizations/{id} |  |

<a name="appeventlocalizationsappeventscreenshotsgettomanyrelated"></a>
# **AppEventLocalizationsAppEventScreenshotsGetToManyRelated**
> AppEventScreenshotsResponse AppEventLocalizationsAppEventScreenshotsGetToManyRelated (string id, List<string>? fieldsAppEventScreenshots = null, List<string>? fieldsAppEventLocalizations = null, int? limit = null, List<string>? include = null)



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
    public class AppEventLocalizationsAppEventScreenshotsGetToManyRelatedExample
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
            var apiInstance = new AppEventLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEventScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventScreenshots (optional) 
            var fieldsAppEventLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppEventScreenshotsResponse result = apiInstance.AppEventLocalizationsAppEventScreenshotsGetToManyRelated(id, fieldsAppEventScreenshots, fieldsAppEventLocalizations, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsAppEventScreenshotsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventLocalizationsAppEventScreenshotsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventScreenshotsResponse> response = apiInstance.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedWithHttpInfo(id, fieldsAppEventScreenshots, fieldsAppEventLocalizations, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEventScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventScreenshots | [optional]  |
| **fieldsAppEventLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppEventScreenshotsResponse**](AppEventScreenshotsResponse.md)

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
| **200** | List of AppEventScreenshots |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventlocalizationsappeventvideoclipsgettomanyrelated"></a>
# **AppEventLocalizationsAppEventVideoClipsGetToManyRelated**
> AppEventVideoClipsResponse AppEventLocalizationsAppEventVideoClipsGetToManyRelated (string id, List<string>? fieldsAppEventVideoClips = null, List<string>? fieldsAppEventLocalizations = null, int? limit = null, List<string>? include = null)



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
    public class AppEventLocalizationsAppEventVideoClipsGetToManyRelatedExample
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
            var apiInstance = new AppEventLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEventVideoClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventVideoClips (optional) 
            var fieldsAppEventLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppEventVideoClipsResponse result = apiInstance.AppEventLocalizationsAppEventVideoClipsGetToManyRelated(id, fieldsAppEventVideoClips, fieldsAppEventLocalizations, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsAppEventVideoClipsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventLocalizationsAppEventVideoClipsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventVideoClipsResponse> response = apiInstance.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedWithHttpInfo(id, fieldsAppEventVideoClips, fieldsAppEventLocalizations, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsAppEventVideoClipsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEventVideoClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventVideoClips | [optional]  |
| **fieldsAppEventLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppEventVideoClipsResponse**](AppEventVideoClipsResponse.md)

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
| **200** | List of AppEventVideoClips |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventlocalizationscreateinstance"></a>
# **AppEventLocalizationsCreateInstance**
> AppEventLocalizationResponse AppEventLocalizationsCreateInstance (AppEventLocalizationCreateRequest appEventLocalizationCreateRequest)



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
    public class AppEventLocalizationsCreateInstanceExample
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
            var apiInstance = new AppEventLocalizationsApi(httpClient, config, httpClientHandler);
            var appEventLocalizationCreateRequest = new AppEventLocalizationCreateRequest(); // AppEventLocalizationCreateRequest | AppEventLocalization representation

            try
            {
                AppEventLocalizationResponse result = apiInstance.AppEventLocalizationsCreateInstance(appEventLocalizationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventLocalizationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventLocalizationResponse> response = apiInstance.AppEventLocalizationsCreateInstanceWithHttpInfo(appEventLocalizationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appEventLocalizationCreateRequest** | [**AppEventLocalizationCreateRequest**](AppEventLocalizationCreateRequest.md) | AppEventLocalization representation |  |

### Return type

[**AppEventLocalizationResponse**](AppEventLocalizationResponse.md)

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
| **201** | Single AppEventLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventlocalizationsdeleteinstance"></a>
# **AppEventLocalizationsDeleteInstance**
> void AppEventLocalizationsDeleteInstance (string id)



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
    public class AppEventLocalizationsDeleteInstanceExample
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
            var apiInstance = new AppEventLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppEventLocalizationsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventLocalizationsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppEventLocalizationsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appeventlocalizationsgetinstance"></a>
# **AppEventLocalizationsGetInstance**
> AppEventLocalizationResponse AppEventLocalizationsGetInstance (string id, List<string>? fieldsAppEventLocalizations = null, List<string>? include = null, List<string>? fieldsAppEventScreenshots = null, List<string>? fieldsAppEventVideoClips = null, int? limitAppEventScreenshots = null, int? limitAppEventVideoClips = null)



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
    public class AppEventLocalizationsGetInstanceExample
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
            var apiInstance = new AppEventLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEventLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventLocalizations (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppEventScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventScreenshots (optional) 
            var fieldsAppEventVideoClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventVideoClips (optional) 
            var limitAppEventScreenshots = 56;  // int? | maximum number of related appEventScreenshots returned (when they are included) (optional) 
            var limitAppEventVideoClips = 56;  // int? | maximum number of related appEventVideoClips returned (when they are included) (optional) 

            try
            {
                AppEventLocalizationResponse result = apiInstance.AppEventLocalizationsGetInstance(id, fieldsAppEventLocalizations, include, fieldsAppEventScreenshots, fieldsAppEventVideoClips, limitAppEventScreenshots, limitAppEventVideoClips);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventLocalizationsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventLocalizationResponse> response = apiInstance.AppEventLocalizationsGetInstanceWithHttpInfo(id, fieldsAppEventLocalizations, include, fieldsAppEventScreenshots, fieldsAppEventVideoClips, limitAppEventScreenshots, limitAppEventVideoClips);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEventLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventLocalizations | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppEventScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventScreenshots | [optional]  |
| **fieldsAppEventVideoClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventVideoClips | [optional]  |
| **limitAppEventScreenshots** | **int?** | maximum number of related appEventScreenshots returned (when they are included) | [optional]  |
| **limitAppEventVideoClips** | **int?** | maximum number of related appEventVideoClips returned (when they are included) | [optional]  |

### Return type

[**AppEventLocalizationResponse**](AppEventLocalizationResponse.md)

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
| **200** | Single AppEventLocalization |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventlocalizationsupdateinstance"></a>
# **AppEventLocalizationsUpdateInstance**
> AppEventLocalizationResponse AppEventLocalizationsUpdateInstance (string id, AppEventLocalizationUpdateRequest appEventLocalizationUpdateRequest)



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
    public class AppEventLocalizationsUpdateInstanceExample
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
            var apiInstance = new AppEventLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appEventLocalizationUpdateRequest = new AppEventLocalizationUpdateRequest(); // AppEventLocalizationUpdateRequest | AppEventLocalization representation

            try
            {
                AppEventLocalizationResponse result = apiInstance.AppEventLocalizationsUpdateInstance(id, appEventLocalizationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventLocalizationsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventLocalizationResponse> response = apiInstance.AppEventLocalizationsUpdateInstanceWithHttpInfo(id, appEventLocalizationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventLocalizationsApi.AppEventLocalizationsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appEventLocalizationUpdateRequest** | [**AppEventLocalizationUpdateRequest**](AppEventLocalizationUpdateRequest.md) | AppEventLocalization representation |  |

### Return type

[**AppEventLocalizationResponse**](AppEventLocalizationResponse.md)

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
| **200** | Single AppEventLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

