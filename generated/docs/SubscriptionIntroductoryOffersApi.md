# AppStoreConnect.Net.Api.SubscriptionIntroductoryOffersApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionIntroductoryOffersCreateInstance**](SubscriptionIntroductoryOffersApi.md#subscriptionintroductoryofferscreateinstance) | **POST** /v1/subscriptionIntroductoryOffers |  |
| [**SubscriptionIntroductoryOffersDeleteInstance**](SubscriptionIntroductoryOffersApi.md#subscriptionintroductoryoffersdeleteinstance) | **DELETE** /v1/subscriptionIntroductoryOffers/{id} |  |
| [**SubscriptionIntroductoryOffersUpdateInstance**](SubscriptionIntroductoryOffersApi.md#subscriptionintroductoryoffersupdateinstance) | **PATCH** /v1/subscriptionIntroductoryOffers/{id} |  |

<a name="subscriptionintroductoryofferscreateinstance"></a>
# **SubscriptionIntroductoryOffersCreateInstance**
> SubscriptionIntroductoryOfferResponse SubscriptionIntroductoryOffersCreateInstance (SubscriptionIntroductoryOfferCreateRequest subscriptionIntroductoryOfferCreateRequest)



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
    public class SubscriptionIntroductoryOffersCreateInstanceExample
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
            var apiInstance = new SubscriptionIntroductoryOffersApi(httpClient, config, httpClientHandler);
            var subscriptionIntroductoryOfferCreateRequest = new SubscriptionIntroductoryOfferCreateRequest(); // SubscriptionIntroductoryOfferCreateRequest | SubscriptionIntroductoryOffer representation

            try
            {
                SubscriptionIntroductoryOfferResponse result = apiInstance.SubscriptionIntroductoryOffersCreateInstance(subscriptionIntroductoryOfferCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionIntroductoryOffersApi.SubscriptionIntroductoryOffersCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionIntroductoryOffersCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionIntroductoryOfferResponse> response = apiInstance.SubscriptionIntroductoryOffersCreateInstanceWithHttpInfo(subscriptionIntroductoryOfferCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionIntroductoryOffersApi.SubscriptionIntroductoryOffersCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionIntroductoryOfferCreateRequest** | [**SubscriptionIntroductoryOfferCreateRequest**](SubscriptionIntroductoryOfferCreateRequest.md) | SubscriptionIntroductoryOffer representation |  |

### Return type

[**SubscriptionIntroductoryOfferResponse**](SubscriptionIntroductoryOfferResponse.md)

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
| **201** | Single SubscriptionIntroductoryOffer |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionintroductoryoffersdeleteinstance"></a>
# **SubscriptionIntroductoryOffersDeleteInstance**
> void SubscriptionIntroductoryOffersDeleteInstance (string id)



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
    public class SubscriptionIntroductoryOffersDeleteInstanceExample
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
            var apiInstance = new SubscriptionIntroductoryOffersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.SubscriptionIntroductoryOffersDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionIntroductoryOffersApi.SubscriptionIntroductoryOffersDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionIntroductoryOffersDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscriptionIntroductoryOffersDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionIntroductoryOffersApi.SubscriptionIntroductoryOffersDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="subscriptionintroductoryoffersupdateinstance"></a>
# **SubscriptionIntroductoryOffersUpdateInstance**
> SubscriptionIntroductoryOfferResponse SubscriptionIntroductoryOffersUpdateInstance (string id, SubscriptionIntroductoryOfferUpdateRequest subscriptionIntroductoryOfferUpdateRequest)



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
    public class SubscriptionIntroductoryOffersUpdateInstanceExample
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
            var apiInstance = new SubscriptionIntroductoryOffersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionIntroductoryOfferUpdateRequest = new SubscriptionIntroductoryOfferUpdateRequest(); // SubscriptionIntroductoryOfferUpdateRequest | SubscriptionIntroductoryOffer representation

            try
            {
                SubscriptionIntroductoryOfferResponse result = apiInstance.SubscriptionIntroductoryOffersUpdateInstance(id, subscriptionIntroductoryOfferUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionIntroductoryOffersApi.SubscriptionIntroductoryOffersUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionIntroductoryOffersUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionIntroductoryOfferResponse> response = apiInstance.SubscriptionIntroductoryOffersUpdateInstanceWithHttpInfo(id, subscriptionIntroductoryOfferUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionIntroductoryOffersApi.SubscriptionIntroductoryOffersUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionIntroductoryOfferUpdateRequest** | [**SubscriptionIntroductoryOfferUpdateRequest**](SubscriptionIntroductoryOfferUpdateRequest.md) | SubscriptionIntroductoryOffer representation |  |

### Return type

[**SubscriptionIntroductoryOfferResponse**](SubscriptionIntroductoryOfferResponse.md)

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
| **200** | Single SubscriptionIntroductoryOffer |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

