# AppStoreConnect.Net.Api.AppEventsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppEventsCreateInstance**](AppEventsApi.md#appeventscreateinstance) | **POST** /v1/appEvents |  |
| [**AppEventsDeleteInstance**](AppEventsApi.md#appeventsdeleteinstance) | **DELETE** /v1/appEvents/{id} |  |
| [**AppEventsGetInstance**](AppEventsApi.md#appeventsgetinstance) | **GET** /v1/appEvents/{id} |  |
| [**AppEventsLocalizationsGetToManyRelated**](AppEventsApi.md#appeventslocalizationsgettomanyrelated) | **GET** /v1/appEvents/{id}/localizations |  |
| [**AppEventsUpdateInstance**](AppEventsApi.md#appeventsupdateinstance) | **PATCH** /v1/appEvents/{id} |  |

<a name="appeventscreateinstance"></a>
# **AppEventsCreateInstance**
> AppEventResponse AppEventsCreateInstance (AppEventCreateRequest appEventCreateRequest)



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
    public class AppEventsCreateInstanceExample
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
            var apiInstance = new AppEventsApi(httpClient, config, httpClientHandler);
            var appEventCreateRequest = new AppEventCreateRequest(); // AppEventCreateRequest | AppEvent representation

            try
            {
                AppEventResponse result = apiInstance.AppEventsCreateInstance(appEventCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventsApi.AppEventsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventResponse> response = apiInstance.AppEventsCreateInstanceWithHttpInfo(appEventCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventsApi.AppEventsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appEventCreateRequest** | [**AppEventCreateRequest**](AppEventCreateRequest.md) | AppEvent representation |  |

### Return type

[**AppEventResponse**](AppEventResponse.md)

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
| **201** | Single AppEvent |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventsdeleteinstance"></a>
# **AppEventsDeleteInstance**
> void AppEventsDeleteInstance (string id)



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
    public class AppEventsDeleteInstanceExample
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
            var apiInstance = new AppEventsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppEventsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventsApi.AppEventsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppEventsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventsApi.AppEventsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appeventsgetinstance"></a>
# **AppEventsGetInstance**
> AppEventResponse AppEventsGetInstance (string id, List<string>? fieldsAppEvents = null, List<string>? include = null, List<string>? fieldsAppEventLocalizations = null, int? limitLocalizations = null)



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
    public class AppEventsGetInstanceExample
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
            var apiInstance = new AppEventsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppEventLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventLocalizations (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 

            try
            {
                AppEventResponse result = apiInstance.AppEventsGetInstance(id, fieldsAppEvents, include, fieldsAppEventLocalizations, limitLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventsApi.AppEventsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventResponse> response = apiInstance.AppEventsGetInstanceWithHttpInfo(id, fieldsAppEvents, include, fieldsAppEventLocalizations, limitLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventsApi.AppEventsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppEventLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventLocalizations | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |

### Return type

[**AppEventResponse**](AppEventResponse.md)

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
| **200** | Single AppEvent |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventslocalizationsgettomanyrelated"></a>
# **AppEventsLocalizationsGetToManyRelated**
> AppEventLocalizationsResponse AppEventsLocalizationsGetToManyRelated (string id, List<string>? fieldsAppEventScreenshots = null, List<string>? fieldsAppEventVideoClips = null, List<string>? fieldsAppEventLocalizations = null, List<string>? fieldsAppEvents = null, int? limit = null, int? limitAppEventScreenshots = null, int? limitAppEventVideoClips = null, List<string>? include = null)



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
    public class AppEventsLocalizationsGetToManyRelatedExample
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
            var apiInstance = new AppEventsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEventScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventScreenshots (optional) 
            var fieldsAppEventVideoClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventVideoClips (optional) 
            var fieldsAppEventLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEventLocalizations (optional) 
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppEventScreenshots = 56;  // int? | maximum number of related appEventScreenshots returned (when they are included) (optional) 
            var limitAppEventVideoClips = 56;  // int? | maximum number of related appEventVideoClips returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppEventLocalizationsResponse result = apiInstance.AppEventsLocalizationsGetToManyRelated(id, fieldsAppEventScreenshots, fieldsAppEventVideoClips, fieldsAppEventLocalizations, fieldsAppEvents, limit, limitAppEventScreenshots, limitAppEventVideoClips, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventsApi.AppEventsLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventsLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventLocalizationsResponse> response = apiInstance.AppEventsLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsAppEventScreenshots, fieldsAppEventVideoClips, fieldsAppEventLocalizations, fieldsAppEvents, limit, limitAppEventScreenshots, limitAppEventVideoClips, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventsApi.AppEventsLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEventScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventScreenshots | [optional]  |
| **fieldsAppEventVideoClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventVideoClips | [optional]  |
| **fieldsAppEventLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEventLocalizations | [optional]  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppEventScreenshots** | **int?** | maximum number of related appEventScreenshots returned (when they are included) | [optional]  |
| **limitAppEventVideoClips** | **int?** | maximum number of related appEventVideoClips returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppEventLocalizationsResponse**](AppEventLocalizationsResponse.md)

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
| **200** | List of AppEventLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appeventsupdateinstance"></a>
# **AppEventsUpdateInstance**
> AppEventResponse AppEventsUpdateInstance (string id, AppEventUpdateRequest appEventUpdateRequest)



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
    public class AppEventsUpdateInstanceExample
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
            var apiInstance = new AppEventsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appEventUpdateRequest = new AppEventUpdateRequest(); // AppEventUpdateRequest | AppEvent representation

            try
            {
                AppEventResponse result = apiInstance.AppEventsUpdateInstance(id, appEventUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEventsApi.AppEventsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEventsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEventResponse> response = apiInstance.AppEventsUpdateInstanceWithHttpInfo(id, appEventUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEventsApi.AppEventsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appEventUpdateRequest** | [**AppEventUpdateRequest**](AppEventUpdateRequest.md) | AppEvent representation |  |

### Return type

[**AppEventResponse**](AppEventResponse.md)

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
| **200** | Single AppEvent |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

