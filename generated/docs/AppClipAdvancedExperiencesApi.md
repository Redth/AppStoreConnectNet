# AppStoreConnect.Net.Api.AppClipAdvancedExperiencesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppClipAdvancedExperiencesCreateInstance**](AppClipAdvancedExperiencesApi.md#appclipadvancedexperiencescreateinstance) | **POST** /v1/appClipAdvancedExperiences |  |
| [**AppClipAdvancedExperiencesGetInstance**](AppClipAdvancedExperiencesApi.md#appclipadvancedexperiencesgetinstance) | **GET** /v1/appClipAdvancedExperiences/{id} |  |
| [**AppClipAdvancedExperiencesUpdateInstance**](AppClipAdvancedExperiencesApi.md#appclipadvancedexperiencesupdateinstance) | **PATCH** /v1/appClipAdvancedExperiences/{id} |  |

<a name="appclipadvancedexperiencescreateinstance"></a>
# **AppClipAdvancedExperiencesCreateInstance**
> AppClipAdvancedExperienceResponse AppClipAdvancedExperiencesCreateInstance (AppClipAdvancedExperienceCreateRequest appClipAdvancedExperienceCreateRequest)



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
    public class AppClipAdvancedExperiencesCreateInstanceExample
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
            var apiInstance = new AppClipAdvancedExperiencesApi(httpClient, config, httpClientHandler);
            var appClipAdvancedExperienceCreateRequest = new AppClipAdvancedExperienceCreateRequest(); // AppClipAdvancedExperienceCreateRequest | AppClipAdvancedExperience representation

            try
            {
                AppClipAdvancedExperienceResponse result = apiInstance.AppClipAdvancedExperiencesCreateInstance(appClipAdvancedExperienceCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAdvancedExperiencesApi.AppClipAdvancedExperiencesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAdvancedExperiencesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperienceResponse> response = apiInstance.AppClipAdvancedExperiencesCreateInstanceWithHttpInfo(appClipAdvancedExperienceCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAdvancedExperiencesApi.AppClipAdvancedExperiencesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appClipAdvancedExperienceCreateRequest** | [**AppClipAdvancedExperienceCreateRequest**](AppClipAdvancedExperienceCreateRequest.md) | AppClipAdvancedExperience representation |  |

### Return type

[**AppClipAdvancedExperienceResponse**](AppClipAdvancedExperienceResponse.md)

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
| **201** | Single AppClipAdvancedExperience |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipadvancedexperiencesgetinstance"></a>
# **AppClipAdvancedExperiencesGetInstance**
> AppClipAdvancedExperienceResponse AppClipAdvancedExperiencesGetInstance (string id, List<string>? fieldsAppClipAdvancedExperiences = null, List<string>? include = null, int? limitLocalizations = null)



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
    public class AppClipAdvancedExperiencesGetInstanceExample
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
            var apiInstance = new AppClipAdvancedExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipAdvancedExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAdvancedExperiences (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 

            try
            {
                AppClipAdvancedExperienceResponse result = apiInstance.AppClipAdvancedExperiencesGetInstance(id, fieldsAppClipAdvancedExperiences, include, limitLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAdvancedExperiencesApi.AppClipAdvancedExperiencesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAdvancedExperiencesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperienceResponse> response = apiInstance.AppClipAdvancedExperiencesGetInstanceWithHttpInfo(id, fieldsAppClipAdvancedExperiences, include, limitLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAdvancedExperiencesApi.AppClipAdvancedExperiencesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipAdvancedExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAdvancedExperiences | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |

### Return type

[**AppClipAdvancedExperienceResponse**](AppClipAdvancedExperienceResponse.md)

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
| **200** | Single AppClipAdvancedExperience |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipadvancedexperiencesupdateinstance"></a>
# **AppClipAdvancedExperiencesUpdateInstance**
> AppClipAdvancedExperienceResponse AppClipAdvancedExperiencesUpdateInstance (string id, AppClipAdvancedExperienceUpdateRequest appClipAdvancedExperienceUpdateRequest)



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
    public class AppClipAdvancedExperiencesUpdateInstanceExample
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
            var apiInstance = new AppClipAdvancedExperiencesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appClipAdvancedExperienceUpdateRequest = new AppClipAdvancedExperienceUpdateRequest(); // AppClipAdvancedExperienceUpdateRequest | AppClipAdvancedExperience representation

            try
            {
                AppClipAdvancedExperienceResponse result = apiInstance.AppClipAdvancedExperiencesUpdateInstance(id, appClipAdvancedExperienceUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAdvancedExperiencesApi.AppClipAdvancedExperiencesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAdvancedExperiencesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperienceResponse> response = apiInstance.AppClipAdvancedExperiencesUpdateInstanceWithHttpInfo(id, appClipAdvancedExperienceUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAdvancedExperiencesApi.AppClipAdvancedExperiencesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appClipAdvancedExperienceUpdateRequest** | [**AppClipAdvancedExperienceUpdateRequest**](AppClipAdvancedExperienceUpdateRequest.md) | AppClipAdvancedExperience representation |  |

### Return type

[**AppClipAdvancedExperienceResponse**](AppClipAdvancedExperienceResponse.md)

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
| **200** | Single AppClipAdvancedExperience |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

