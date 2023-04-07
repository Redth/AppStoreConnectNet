# AppStoreConnect.Net.Api.SubscriptionOfferCodeOneTimeUseCodesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionOfferCodeOneTimeUseCodesCreateInstance**](SubscriptionOfferCodeOneTimeUseCodesApi.md#subscriptionoffercodeonetimeusecodescreateinstance) | **POST** /v1/subscriptionOfferCodeOneTimeUseCodes |  |
| [**SubscriptionOfferCodeOneTimeUseCodesGetInstance**](SubscriptionOfferCodeOneTimeUseCodesApi.md#subscriptionoffercodeonetimeusecodesgetinstance) | **GET** /v1/subscriptionOfferCodeOneTimeUseCodes/{id} |  |
| [**SubscriptionOfferCodeOneTimeUseCodesUpdateInstance**](SubscriptionOfferCodeOneTimeUseCodesApi.md#subscriptionoffercodeonetimeusecodesupdateinstance) | **PATCH** /v1/subscriptionOfferCodeOneTimeUseCodes/{id} |  |
| [**SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelated**](SubscriptionOfferCodeOneTimeUseCodesApi.md#subscriptionoffercodeonetimeusecodesvaluesgettoonerelated) | **GET** /v1/subscriptionOfferCodeOneTimeUseCodes/{id}/values |  |

<a name="subscriptionoffercodeonetimeusecodescreateinstance"></a>
# **SubscriptionOfferCodeOneTimeUseCodesCreateInstance**
> SubscriptionOfferCodeOneTimeUseCodeResponse SubscriptionOfferCodeOneTimeUseCodesCreateInstance (SubscriptionOfferCodeOneTimeUseCodeCreateRequest subscriptionOfferCodeOneTimeUseCodeCreateRequest)



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
    public class SubscriptionOfferCodeOneTimeUseCodesCreateInstanceExample
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
            var apiInstance = new SubscriptionOfferCodeOneTimeUseCodesApi(httpClient, config, httpClientHandler);
            var subscriptionOfferCodeOneTimeUseCodeCreateRequest = new SubscriptionOfferCodeOneTimeUseCodeCreateRequest(); // SubscriptionOfferCodeOneTimeUseCodeCreateRequest | SubscriptionOfferCodeOneTimeUseCode representation

            try
            {
                SubscriptionOfferCodeOneTimeUseCodeResponse result = apiInstance.SubscriptionOfferCodeOneTimeUseCodesCreateInstance(subscriptionOfferCodeOneTimeUseCodeCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeOneTimeUseCodesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodeOneTimeUseCodeResponse> response = apiInstance.SubscriptionOfferCodeOneTimeUseCodesCreateInstanceWithHttpInfo(subscriptionOfferCodeOneTimeUseCodeCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionOfferCodeOneTimeUseCodeCreateRequest** | [**SubscriptionOfferCodeOneTimeUseCodeCreateRequest**](SubscriptionOfferCodeOneTimeUseCodeCreateRequest.md) | SubscriptionOfferCodeOneTimeUseCode representation |  |

### Return type

[**SubscriptionOfferCodeOneTimeUseCodeResponse**](SubscriptionOfferCodeOneTimeUseCodeResponse.md)

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
| **201** | Single SubscriptionOfferCodeOneTimeUseCode |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionoffercodeonetimeusecodesgetinstance"></a>
# **SubscriptionOfferCodeOneTimeUseCodesGetInstance**
> SubscriptionOfferCodeOneTimeUseCodeResponse SubscriptionOfferCodeOneTimeUseCodesGetInstance (string id, List<string>? fieldsSubscriptionOfferCodeOneTimeUseCodes = null, List<string>? include = null, List<string>? fieldsSubscriptionOfferCodeOneTimeUseCodeValues = null)



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
    public class SubscriptionOfferCodeOneTimeUseCodesGetInstanceExample
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
            var apiInstance = new SubscriptionOfferCodeOneTimeUseCodesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionOfferCodeOneTimeUseCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodeOneTimeUseCodes (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsSubscriptionOfferCodeOneTimeUseCodeValues = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodeOneTimeUseCodeValues (optional) 

            try
            {
                SubscriptionOfferCodeOneTimeUseCodeResponse result = apiInstance.SubscriptionOfferCodeOneTimeUseCodesGetInstance(id, fieldsSubscriptionOfferCodeOneTimeUseCodes, include, fieldsSubscriptionOfferCodeOneTimeUseCodeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeOneTimeUseCodesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodeOneTimeUseCodeResponse> response = apiInstance.SubscriptionOfferCodeOneTimeUseCodesGetInstanceWithHttpInfo(id, fieldsSubscriptionOfferCodeOneTimeUseCodes, include, fieldsSubscriptionOfferCodeOneTimeUseCodeValues);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionOfferCodeOneTimeUseCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodeOneTimeUseCodes | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsSubscriptionOfferCodeOneTimeUseCodeValues** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodeOneTimeUseCodeValues | [optional]  |

### Return type

[**SubscriptionOfferCodeOneTimeUseCodeResponse**](SubscriptionOfferCodeOneTimeUseCodeResponse.md)

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
| **200** | Single SubscriptionOfferCodeOneTimeUseCode |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionoffercodeonetimeusecodesupdateinstance"></a>
# **SubscriptionOfferCodeOneTimeUseCodesUpdateInstance**
> SubscriptionOfferCodeOneTimeUseCodeResponse SubscriptionOfferCodeOneTimeUseCodesUpdateInstance (string id, SubscriptionOfferCodeOneTimeUseCodeUpdateRequest subscriptionOfferCodeOneTimeUseCodeUpdateRequest)



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
    public class SubscriptionOfferCodeOneTimeUseCodesUpdateInstanceExample
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
            var apiInstance = new SubscriptionOfferCodeOneTimeUseCodesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionOfferCodeOneTimeUseCodeUpdateRequest = new SubscriptionOfferCodeOneTimeUseCodeUpdateRequest(); // SubscriptionOfferCodeOneTimeUseCodeUpdateRequest | SubscriptionOfferCodeOneTimeUseCode representation

            try
            {
                SubscriptionOfferCodeOneTimeUseCodeResponse result = apiInstance.SubscriptionOfferCodeOneTimeUseCodesUpdateInstance(id, subscriptionOfferCodeOneTimeUseCodeUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeOneTimeUseCodesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodeOneTimeUseCodeResponse> response = apiInstance.SubscriptionOfferCodeOneTimeUseCodesUpdateInstanceWithHttpInfo(id, subscriptionOfferCodeOneTimeUseCodeUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionOfferCodeOneTimeUseCodeUpdateRequest** | [**SubscriptionOfferCodeOneTimeUseCodeUpdateRequest**](SubscriptionOfferCodeOneTimeUseCodeUpdateRequest.md) | SubscriptionOfferCodeOneTimeUseCode representation |  |

### Return type

[**SubscriptionOfferCodeOneTimeUseCodeResponse**](SubscriptionOfferCodeOneTimeUseCodeResponse.md)

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
| **200** | Single SubscriptionOfferCodeOneTimeUseCode |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionoffercodeonetimeusecodesvaluesgettoonerelated"></a>
# **SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelated**
> string SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelated (string id)



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
    public class SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelatedExample
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
            var apiInstance = new SubscriptionOfferCodeOneTimeUseCodesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                string result = apiInstance.SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelated(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelatedWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionOfferCodeOneTimeUseCodesApi.SubscriptionOfferCodeOneTimeUseCodesValuesGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

**string**

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single SubscriptionOfferCodeOneTimeUseCodeValue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

