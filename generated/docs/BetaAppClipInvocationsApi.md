# AppStoreConnect.Net.Api.BetaAppClipInvocationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BetaAppClipInvocationsCreateInstance**](BetaAppClipInvocationsApi.md#betaappclipinvocationscreateinstance) | **POST** /v1/betaAppClipInvocations |  |
| [**BetaAppClipInvocationsDeleteInstance**](BetaAppClipInvocationsApi.md#betaappclipinvocationsdeleteinstance) | **DELETE** /v1/betaAppClipInvocations/{id} |  |
| [**BetaAppClipInvocationsGetInstance**](BetaAppClipInvocationsApi.md#betaappclipinvocationsgetinstance) | **GET** /v1/betaAppClipInvocations/{id} |  |
| [**BetaAppClipInvocationsUpdateInstance**](BetaAppClipInvocationsApi.md#betaappclipinvocationsupdateinstance) | **PATCH** /v1/betaAppClipInvocations/{id} |  |

<a name="betaappclipinvocationscreateinstance"></a>
# **BetaAppClipInvocationsCreateInstance**
> BetaAppClipInvocationResponse BetaAppClipInvocationsCreateInstance (BetaAppClipInvocationCreateRequest betaAppClipInvocationCreateRequest)



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
    public class BetaAppClipInvocationsCreateInstanceExample
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
            var apiInstance = new BetaAppClipInvocationsApi(httpClient, config, httpClientHandler);
            var betaAppClipInvocationCreateRequest = new BetaAppClipInvocationCreateRequest(); // BetaAppClipInvocationCreateRequest | BetaAppClipInvocation representation

            try
            {
                BetaAppClipInvocationResponse result = apiInstance.BetaAppClipInvocationsCreateInstance(betaAppClipInvocationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppClipInvocationResponse> response = apiInstance.BetaAppClipInvocationsCreateInstanceWithHttpInfo(betaAppClipInvocationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **betaAppClipInvocationCreateRequest** | [**BetaAppClipInvocationCreateRequest**](BetaAppClipInvocationCreateRequest.md) | BetaAppClipInvocation representation |  |

### Return type

[**BetaAppClipInvocationResponse**](BetaAppClipInvocationResponse.md)

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
| **201** | Single BetaAppClipInvocation |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="betaappclipinvocationsdeleteinstance"></a>
# **BetaAppClipInvocationsDeleteInstance**
> void BetaAppClipInvocationsDeleteInstance (string id)



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
    public class BetaAppClipInvocationsDeleteInstanceExample
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
            var apiInstance = new BetaAppClipInvocationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.BetaAppClipInvocationsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BetaAppClipInvocationsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="betaappclipinvocationsgetinstance"></a>
# **BetaAppClipInvocationsGetInstance**
> BetaAppClipInvocationResponse BetaAppClipInvocationsGetInstance (string id, List<string>? fieldsBetaAppClipInvocations = null, List<string>? include = null, int? limitBetaAppClipInvocationLocalizations = null)



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
    public class BetaAppClipInvocationsGetInstanceExample
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
            var apiInstance = new BetaAppClipInvocationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaAppClipInvocations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppClipInvocations (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitBetaAppClipInvocationLocalizations = 56;  // int? | maximum number of related betaAppClipInvocationLocalizations returned (when they are included) (optional) 

            try
            {
                BetaAppClipInvocationResponse result = apiInstance.BetaAppClipInvocationsGetInstance(id, fieldsBetaAppClipInvocations, include, limitBetaAppClipInvocationLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppClipInvocationResponse> response = apiInstance.BetaAppClipInvocationsGetInstanceWithHttpInfo(id, fieldsBetaAppClipInvocations, include, limitBetaAppClipInvocationLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaAppClipInvocations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppClipInvocations | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitBetaAppClipInvocationLocalizations** | **int?** | maximum number of related betaAppClipInvocationLocalizations returned (when they are included) | [optional]  |

### Return type

[**BetaAppClipInvocationResponse**](BetaAppClipInvocationResponse.md)

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
| **200** | Single BetaAppClipInvocation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="betaappclipinvocationsupdateinstance"></a>
# **BetaAppClipInvocationsUpdateInstance**
> BetaAppClipInvocationResponse BetaAppClipInvocationsUpdateInstance (string id, BetaAppClipInvocationUpdateRequest betaAppClipInvocationUpdateRequest)



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
    public class BetaAppClipInvocationsUpdateInstanceExample
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
            var apiInstance = new BetaAppClipInvocationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var betaAppClipInvocationUpdateRequest = new BetaAppClipInvocationUpdateRequest(); // BetaAppClipInvocationUpdateRequest | BetaAppClipInvocation representation

            try
            {
                BetaAppClipInvocationResponse result = apiInstance.BetaAppClipInvocationsUpdateInstance(id, betaAppClipInvocationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaAppClipInvocationsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppClipInvocationResponse> response = apiInstance.BetaAppClipInvocationsUpdateInstanceWithHttpInfo(id, betaAppClipInvocationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaAppClipInvocationsApi.BetaAppClipInvocationsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **betaAppClipInvocationUpdateRequest** | [**BetaAppClipInvocationUpdateRequest**](BetaAppClipInvocationUpdateRequest.md) | BetaAppClipInvocation representation |  |

### Return type

[**BetaAppClipInvocationResponse**](BetaAppClipInvocationResponse.md)

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
| **200** | Single BetaAppClipInvocation |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

