# AppStoreConnect.Net.Api.SubscriptionOfferCodeCustomCodesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionOfferCodeCustomCodesCreateInstance**](SubscriptionOfferCodeCustomCodesApi.md#subscriptionoffercodecustomcodescreateinstance) | **POST** /v1/subscriptionOfferCodeCustomCodes |  |
| [**SubscriptionOfferCodeCustomCodesGetInstance**](SubscriptionOfferCodeCustomCodesApi.md#subscriptionoffercodecustomcodesgetinstance) | **GET** /v1/subscriptionOfferCodeCustomCodes/{id} |  |
| [**SubscriptionOfferCodeCustomCodesUpdateInstance**](SubscriptionOfferCodeCustomCodesApi.md#subscriptionoffercodecustomcodesupdateinstance) | **PATCH** /v1/subscriptionOfferCodeCustomCodes/{id} |  |

<a name="subscriptionoffercodecustomcodescreateinstance"></a>
# **SubscriptionOfferCodeCustomCodesCreateInstance**
> SubscriptionOfferCodeCustomCodeResponse SubscriptionOfferCodeCustomCodesCreateInstance (SubscriptionOfferCodeCustomCodeCreateRequest subscriptionOfferCodeCustomCodeCreateRequest)



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
    public class SubscriptionOfferCodeCustomCodesCreateInstanceExample
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
            var apiInstance = new SubscriptionOfferCodeCustomCodesApi(httpClient, config, httpClientHandler);
            var subscriptionOfferCodeCustomCodeCreateRequest = new SubscriptionOfferCodeCustomCodeCreateRequest(); // SubscriptionOfferCodeCustomCodeCreateRequest | SubscriptionOfferCodeCustomCode representation

            try
            {
                SubscriptionOfferCodeCustomCodeResponse result = apiInstance.SubscriptionOfferCodeCustomCodesCreateInstance(subscriptionOfferCodeCustomCodeCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeCustomCodesApi.SubscriptionOfferCodeCustomCodesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeCustomCodesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodeCustomCodeResponse> response = apiInstance.SubscriptionOfferCodeCustomCodesCreateInstanceWithHttpInfo(subscriptionOfferCodeCustomCodeCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeCustomCodesApi.SubscriptionOfferCodeCustomCodesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionOfferCodeCustomCodeCreateRequest** | [**SubscriptionOfferCodeCustomCodeCreateRequest**](SubscriptionOfferCodeCustomCodeCreateRequest.md) | SubscriptionOfferCodeCustomCode representation |  |

### Return type

[**SubscriptionOfferCodeCustomCodeResponse**](SubscriptionOfferCodeCustomCodeResponse.md)

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
| **201** | Single SubscriptionOfferCodeCustomCode |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionoffercodecustomcodesgetinstance"></a>
# **SubscriptionOfferCodeCustomCodesGetInstance**
> SubscriptionOfferCodeCustomCodeResponse SubscriptionOfferCodeCustomCodesGetInstance (string id, List<string>? fieldsSubscriptionOfferCodeCustomCodes = null, List<string>? include = null)



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
    public class SubscriptionOfferCodeCustomCodesGetInstanceExample
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
            var apiInstance = new SubscriptionOfferCodeCustomCodesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionOfferCodeCustomCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodeCustomCodes (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionOfferCodeCustomCodeResponse result = apiInstance.SubscriptionOfferCodeCustomCodesGetInstance(id, fieldsSubscriptionOfferCodeCustomCodes, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeCustomCodesApi.SubscriptionOfferCodeCustomCodesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeCustomCodesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodeCustomCodeResponse> response = apiInstance.SubscriptionOfferCodeCustomCodesGetInstanceWithHttpInfo(id, fieldsSubscriptionOfferCodeCustomCodes, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeCustomCodesApi.SubscriptionOfferCodeCustomCodesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionOfferCodeCustomCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodeCustomCodes | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionOfferCodeCustomCodeResponse**](SubscriptionOfferCodeCustomCodeResponse.md)

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
| **200** | Single SubscriptionOfferCodeCustomCode |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionoffercodecustomcodesupdateinstance"></a>
# **SubscriptionOfferCodeCustomCodesUpdateInstance**
> SubscriptionOfferCodeCustomCodeResponse SubscriptionOfferCodeCustomCodesUpdateInstance (string id, SubscriptionOfferCodeCustomCodeUpdateRequest subscriptionOfferCodeCustomCodeUpdateRequest)



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
    public class SubscriptionOfferCodeCustomCodesUpdateInstanceExample
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
            var apiInstance = new SubscriptionOfferCodeCustomCodesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionOfferCodeCustomCodeUpdateRequest = new SubscriptionOfferCodeCustomCodeUpdateRequest(); // SubscriptionOfferCodeCustomCodeUpdateRequest | SubscriptionOfferCodeCustomCode representation

            try
            {
                SubscriptionOfferCodeCustomCodeResponse result = apiInstance.SubscriptionOfferCodeCustomCodesUpdateInstance(id, subscriptionOfferCodeCustomCodeUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeCustomCodesApi.SubscriptionOfferCodeCustomCodesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeCustomCodesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodeCustomCodeResponse> response = apiInstance.SubscriptionOfferCodeCustomCodesUpdateInstanceWithHttpInfo(id, subscriptionOfferCodeCustomCodeUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeCustomCodesApi.SubscriptionOfferCodeCustomCodesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionOfferCodeCustomCodeUpdateRequest** | [**SubscriptionOfferCodeCustomCodeUpdateRequest**](SubscriptionOfferCodeCustomCodeUpdateRequest.md) | SubscriptionOfferCodeCustomCode representation |  |

### Return type

[**SubscriptionOfferCodeCustomCodeResponse**](SubscriptionOfferCodeCustomCodeResponse.md)

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
| **200** | Single SubscriptionOfferCodeCustomCode |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

