# AppStoreConnect.Net.Api.BundleIdCapabilitiesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BundleIdCapabilitiesCreateInstance**](BundleIdCapabilitiesApi.md#bundleidcapabilitiescreateinstance) | **POST** /v1/bundleIdCapabilities |  |
| [**BundleIdCapabilitiesDeleteInstance**](BundleIdCapabilitiesApi.md#bundleidcapabilitiesdeleteinstance) | **DELETE** /v1/bundleIdCapabilities/{id} |  |
| [**BundleIdCapabilitiesUpdateInstance**](BundleIdCapabilitiesApi.md#bundleidcapabilitiesupdateinstance) | **PATCH** /v1/bundleIdCapabilities/{id} |  |

<a name="bundleidcapabilitiescreateinstance"></a>
# **BundleIdCapabilitiesCreateInstance**
> BundleIdCapabilityResponse BundleIdCapabilitiesCreateInstance (BundleIdCapabilityCreateRequest bundleIdCapabilityCreateRequest)



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
    public class BundleIdCapabilitiesCreateInstanceExample
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
            var apiInstance = new BundleIdCapabilitiesApi(httpClient, config, httpClientHandler);
            var bundleIdCapabilityCreateRequest = new BundleIdCapabilityCreateRequest(); // BundleIdCapabilityCreateRequest | BundleIdCapability representation

            try
            {
                BundleIdCapabilityResponse result = apiInstance.BundleIdCapabilitiesCreateInstance(bundleIdCapabilityCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdCapabilitiesApi.BundleIdCapabilitiesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdCapabilitiesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdCapabilityResponse> response = apiInstance.BundleIdCapabilitiesCreateInstanceWithHttpInfo(bundleIdCapabilityCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdCapabilitiesApi.BundleIdCapabilitiesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bundleIdCapabilityCreateRequest** | [**BundleIdCapabilityCreateRequest**](BundleIdCapabilityCreateRequest.md) | BundleIdCapability representation |  |

### Return type

[**BundleIdCapabilityResponse**](BundleIdCapabilityResponse.md)

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
| **201** | Single BundleIdCapability |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidcapabilitiesdeleteinstance"></a>
# **BundleIdCapabilitiesDeleteInstance**
> void BundleIdCapabilitiesDeleteInstance (string id)



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
    public class BundleIdCapabilitiesDeleteInstanceExample
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
            var apiInstance = new BundleIdCapabilitiesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.BundleIdCapabilitiesDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdCapabilitiesApi.BundleIdCapabilitiesDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdCapabilitiesDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BundleIdCapabilitiesDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdCapabilitiesApi.BundleIdCapabilitiesDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="bundleidcapabilitiesupdateinstance"></a>
# **BundleIdCapabilitiesUpdateInstance**
> BundleIdCapabilityResponse BundleIdCapabilitiesUpdateInstance (string id, BundleIdCapabilityUpdateRequest bundleIdCapabilityUpdateRequest)



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
    public class BundleIdCapabilitiesUpdateInstanceExample
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
            var apiInstance = new BundleIdCapabilitiesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var bundleIdCapabilityUpdateRequest = new BundleIdCapabilityUpdateRequest(); // BundleIdCapabilityUpdateRequest | BundleIdCapability representation

            try
            {
                BundleIdCapabilityResponse result = apiInstance.BundleIdCapabilitiesUpdateInstance(id, bundleIdCapabilityUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdCapabilitiesApi.BundleIdCapabilitiesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdCapabilitiesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdCapabilityResponse> response = apiInstance.BundleIdCapabilitiesUpdateInstanceWithHttpInfo(id, bundleIdCapabilityUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdCapabilitiesApi.BundleIdCapabilitiesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **bundleIdCapabilityUpdateRequest** | [**BundleIdCapabilityUpdateRequest**](BundleIdCapabilityUpdateRequest.md) | BundleIdCapability representation |  |

### Return type

[**BundleIdCapabilityResponse**](BundleIdCapabilityResponse.md)

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
| **200** | Single BundleIdCapability |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

