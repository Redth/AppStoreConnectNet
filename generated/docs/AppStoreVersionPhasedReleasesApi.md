# AppStoreConnect.Net.Api.AppStoreVersionPhasedReleasesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppStoreVersionPhasedReleasesCreateInstance**](AppStoreVersionPhasedReleasesApi.md#appstoreversionphasedreleasescreateinstance) | **POST** /v1/appStoreVersionPhasedReleases |  |
| [**AppStoreVersionPhasedReleasesDeleteInstance**](AppStoreVersionPhasedReleasesApi.md#appstoreversionphasedreleasesdeleteinstance) | **DELETE** /v1/appStoreVersionPhasedReleases/{id} |  |
| [**AppStoreVersionPhasedReleasesUpdateInstance**](AppStoreVersionPhasedReleasesApi.md#appstoreversionphasedreleasesupdateinstance) | **PATCH** /v1/appStoreVersionPhasedReleases/{id} |  |

<a name="appstoreversionphasedreleasescreateinstance"></a>
# **AppStoreVersionPhasedReleasesCreateInstance**
> AppStoreVersionPhasedReleaseResponse AppStoreVersionPhasedReleasesCreateInstance (AppStoreVersionPhasedReleaseCreateRequest appStoreVersionPhasedReleaseCreateRequest)



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
    public class AppStoreVersionPhasedReleasesCreateInstanceExample
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
            var apiInstance = new AppStoreVersionPhasedReleasesApi(httpClient, config, httpClientHandler);
            var appStoreVersionPhasedReleaseCreateRequest = new AppStoreVersionPhasedReleaseCreateRequest(); // AppStoreVersionPhasedReleaseCreateRequest | AppStoreVersionPhasedRelease representation

            try
            {
                AppStoreVersionPhasedReleaseResponse result = apiInstance.AppStoreVersionPhasedReleasesCreateInstance(appStoreVersionPhasedReleaseCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionPhasedReleasesApi.AppStoreVersionPhasedReleasesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionPhasedReleasesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionPhasedReleaseResponse> response = apiInstance.AppStoreVersionPhasedReleasesCreateInstanceWithHttpInfo(appStoreVersionPhasedReleaseCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionPhasedReleasesApi.AppStoreVersionPhasedReleasesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appStoreVersionPhasedReleaseCreateRequest** | [**AppStoreVersionPhasedReleaseCreateRequest**](AppStoreVersionPhasedReleaseCreateRequest.md) | AppStoreVersionPhasedRelease representation |  |

### Return type

[**AppStoreVersionPhasedReleaseResponse**](AppStoreVersionPhasedReleaseResponse.md)

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
| **201** | Single AppStoreVersionPhasedRelease |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstoreversionphasedreleasesdeleteinstance"></a>
# **AppStoreVersionPhasedReleasesDeleteInstance**
> void AppStoreVersionPhasedReleasesDeleteInstance (string id)



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
    public class AppStoreVersionPhasedReleasesDeleteInstanceExample
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
            var apiInstance = new AppStoreVersionPhasedReleasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppStoreVersionPhasedReleasesDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionPhasedReleasesApi.AppStoreVersionPhasedReleasesDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionPhasedReleasesDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppStoreVersionPhasedReleasesDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionPhasedReleasesApi.AppStoreVersionPhasedReleasesDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appstoreversionphasedreleasesupdateinstance"></a>
# **AppStoreVersionPhasedReleasesUpdateInstance**
> AppStoreVersionPhasedReleaseResponse AppStoreVersionPhasedReleasesUpdateInstance (string id, AppStoreVersionPhasedReleaseUpdateRequest appStoreVersionPhasedReleaseUpdateRequest)



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
    public class AppStoreVersionPhasedReleasesUpdateInstanceExample
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
            var apiInstance = new AppStoreVersionPhasedReleasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreVersionPhasedReleaseUpdateRequest = new AppStoreVersionPhasedReleaseUpdateRequest(); // AppStoreVersionPhasedReleaseUpdateRequest | AppStoreVersionPhasedRelease representation

            try
            {
                AppStoreVersionPhasedReleaseResponse result = apiInstance.AppStoreVersionPhasedReleasesUpdateInstance(id, appStoreVersionPhasedReleaseUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionPhasedReleasesApi.AppStoreVersionPhasedReleasesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionPhasedReleasesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionPhasedReleaseResponse> response = apiInstance.AppStoreVersionPhasedReleasesUpdateInstanceWithHttpInfo(id, appStoreVersionPhasedReleaseUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionPhasedReleasesApi.AppStoreVersionPhasedReleasesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreVersionPhasedReleaseUpdateRequest** | [**AppStoreVersionPhasedReleaseUpdateRequest**](AppStoreVersionPhasedReleaseUpdateRequest.md) | AppStoreVersionPhasedRelease representation |  |

### Return type

[**AppStoreVersionPhasedReleaseResponse**](AppStoreVersionPhasedReleaseResponse.md)

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
| **200** | Single AppStoreVersionPhasedRelease |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

