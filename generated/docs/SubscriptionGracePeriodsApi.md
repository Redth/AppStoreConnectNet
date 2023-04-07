# AppStoreConnect.Net.Api.SubscriptionGracePeriodsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionGracePeriodsGetInstance**](SubscriptionGracePeriodsApi.md#subscriptiongraceperiodsgetinstance) | **GET** /v1/subscriptionGracePeriods/{id} |  |
| [**SubscriptionGracePeriodsUpdateInstance**](SubscriptionGracePeriodsApi.md#subscriptiongraceperiodsupdateinstance) | **PATCH** /v1/subscriptionGracePeriods/{id} |  |

<a name="subscriptiongraceperiodsgetinstance"></a>
# **SubscriptionGracePeriodsGetInstance**
> SubscriptionGracePeriodResponse SubscriptionGracePeriodsGetInstance (string id, List<string>? fieldsSubscriptionGracePeriods = null)



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
    public class SubscriptionGracePeriodsGetInstanceExample
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
            var apiInstance = new SubscriptionGracePeriodsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionGracePeriods = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGracePeriods (optional) 

            try
            {
                SubscriptionGracePeriodResponse result = apiInstance.SubscriptionGracePeriodsGetInstance(id, fieldsSubscriptionGracePeriods);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGracePeriodsApi.SubscriptionGracePeriodsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGracePeriodsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGracePeriodResponse> response = apiInstance.SubscriptionGracePeriodsGetInstanceWithHttpInfo(id, fieldsSubscriptionGracePeriods);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGracePeriodsApi.SubscriptionGracePeriodsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionGracePeriods** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGracePeriods | [optional]  |

### Return type

[**SubscriptionGracePeriodResponse**](SubscriptionGracePeriodResponse.md)

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
| **200** | Single SubscriptionGracePeriod |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptiongraceperiodsupdateinstance"></a>
# **SubscriptionGracePeriodsUpdateInstance**
> SubscriptionGracePeriodResponse SubscriptionGracePeriodsUpdateInstance (string id, SubscriptionGracePeriodUpdateRequest subscriptionGracePeriodUpdateRequest)



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
    public class SubscriptionGracePeriodsUpdateInstanceExample
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
            var apiInstance = new SubscriptionGracePeriodsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionGracePeriodUpdateRequest = new SubscriptionGracePeriodUpdateRequest(); // SubscriptionGracePeriodUpdateRequest | SubscriptionGracePeriod representation

            try
            {
                SubscriptionGracePeriodResponse result = apiInstance.SubscriptionGracePeriodsUpdateInstance(id, subscriptionGracePeriodUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGracePeriodsApi.SubscriptionGracePeriodsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGracePeriodsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGracePeriodResponse> response = apiInstance.SubscriptionGracePeriodsUpdateInstanceWithHttpInfo(id, subscriptionGracePeriodUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGracePeriodsApi.SubscriptionGracePeriodsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionGracePeriodUpdateRequest** | [**SubscriptionGracePeriodUpdateRequest**](SubscriptionGracePeriodUpdateRequest.md) | SubscriptionGracePeriod representation |  |

### Return type

[**SubscriptionGracePeriodResponse**](SubscriptionGracePeriodResponse.md)

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
| **200** | Single SubscriptionGracePeriod |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

