# AppStoreConnect.Net.Api.BetaAppClipInvocationLocalizationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BetaAppClipInvocationLocalizationsCreateInstance**](BetaAppClipInvocationLocalizationsApi.md#betaappclipinvocationlocalizationscreateinstance) | **POST** /v1/betaAppClipInvocationLocalizations |  |
| [**BetaAppClipInvocationLocalizationsDeleteInstance**](BetaAppClipInvocationLocalizationsApi.md#betaappclipinvocationlocalizationsdeleteinstance) | **DELETE** /v1/betaAppClipInvocationLocalizations/{id} |  |
| [**BetaAppClipInvocationLocalizationsUpdateInstance**](BetaAppClipInvocationLocalizationsApi.md#betaappclipinvocationlocalizationsupdateinstance) | **PATCH** /v1/betaAppClipInvocationLocalizations/{id} |  |

<a name="betaappclipinvocationlocalizationscreateinstance"></a>
# **BetaAppClipInvocationLocalizationsCreateInstance**
> BetaAppClipInvocationLocalizationResponse BetaAppClipInvocationLocalizationsCreateInstance (BetaAppClipInvocationLocalizationCreateRequest betaAppClipInvocationLocalizationCreateRequest)



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
    public class BetaAppClipInvocationLocalizationsCreateInstanceExample
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
            var apiInstance = new BetaAppClipInvocationLocalizationsApi(httpClient, config, httpClientHandler);
            var betaAppClipInvocationLocalizationCreateRequest = new BetaAppClipInvocationLocalizationCreateRequest(); // BetaAppClipInvocationLocalizationCreateRequest | BetaAppClipInvocationLocalization representation

            try
            {
                BetaAppClipInvocationLocalizationResponse result = apiInstance.BetaAppClipInvocationLocalizationsCreateInstance(betaAppClipInvocationLocalizationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationLocalizationsApi.BetaAppClipInvocationLocalizationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationLocalizationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppClipInvocationLocalizationResponse> response = apiInstance.BetaAppClipInvocationLocalizationsCreateInstanceWithHttpInfo(betaAppClipInvocationLocalizationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationLocalizationsApi.BetaAppClipInvocationLocalizationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **betaAppClipInvocationLocalizationCreateRequest** | [**BetaAppClipInvocationLocalizationCreateRequest**](BetaAppClipInvocationLocalizationCreateRequest.md) | BetaAppClipInvocationLocalization representation |  |

### Return type

[**BetaAppClipInvocationLocalizationResponse**](BetaAppClipInvocationLocalizationResponse.md)

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
| **201** | Single BetaAppClipInvocationLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="betaappclipinvocationlocalizationsdeleteinstance"></a>
# **BetaAppClipInvocationLocalizationsDeleteInstance**
> void BetaAppClipInvocationLocalizationsDeleteInstance (string id)



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
    public class BetaAppClipInvocationLocalizationsDeleteInstanceExample
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
            var apiInstance = new BetaAppClipInvocationLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.BetaAppClipInvocationLocalizationsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationLocalizationsApi.BetaAppClipInvocationLocalizationsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationLocalizationsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BetaAppClipInvocationLocalizationsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationLocalizationsApi.BetaAppClipInvocationLocalizationsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="betaappclipinvocationlocalizationsupdateinstance"></a>
# **BetaAppClipInvocationLocalizationsUpdateInstance**
> BetaAppClipInvocationLocalizationResponse BetaAppClipInvocationLocalizationsUpdateInstance (string id, BetaAppClipInvocationLocalizationUpdateRequest betaAppClipInvocationLocalizationUpdateRequest)



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
    public class BetaAppClipInvocationLocalizationsUpdateInstanceExample
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
            var apiInstance = new BetaAppClipInvocationLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var betaAppClipInvocationLocalizationUpdateRequest = new BetaAppClipInvocationLocalizationUpdateRequest(); // BetaAppClipInvocationLocalizationUpdateRequest | BetaAppClipInvocationLocalization representation

            try
            {
                BetaAppClipInvocationLocalizationResponse result = apiInstance.BetaAppClipInvocationLocalizationsUpdateInstance(id, betaAppClipInvocationLocalizationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationLocalizationsApi.BetaAppClipInvocationLocalizationsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationLocalizationsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppClipInvocationLocalizationResponse> response = apiInstance.BetaAppClipInvocationLocalizationsUpdateInstanceWithHttpInfo(id, betaAppClipInvocationLocalizationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationLocalizationsApi.BetaAppClipInvocationLocalizationsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **betaAppClipInvocationLocalizationUpdateRequest** | [**BetaAppClipInvocationLocalizationUpdateRequest**](BetaAppClipInvocationLocalizationUpdateRequest.md) | BetaAppClipInvocationLocalization representation |  |

### Return type

[**BetaAppClipInvocationLocalizationResponse**](BetaAppClipInvocationLocalizationResponse.md)

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
| **200** | Single BetaAppClipInvocationLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

