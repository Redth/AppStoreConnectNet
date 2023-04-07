# AppStoreConnect.Net.Api.SubscriptionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionsAppStoreReviewScreenshotGetToOneRelated**](SubscriptionsApi.md#subscriptionsappstorereviewscreenshotgettoonerelated) | **GET** /v1/subscriptions/{id}/appStoreReviewScreenshot |  |
| [**SubscriptionsCreateInstance**](SubscriptionsApi.md#subscriptionscreateinstance) | **POST** /v1/subscriptions |  |
| [**SubscriptionsDeleteInstance**](SubscriptionsApi.md#subscriptionsdeleteinstance) | **DELETE** /v1/subscriptions/{id} |  |
| [**SubscriptionsGetInstance**](SubscriptionsApi.md#subscriptionsgetinstance) | **GET** /v1/subscriptions/{id} |  |
| [**SubscriptionsIntroductoryOffersDeleteToManyRelationship**](SubscriptionsApi.md#subscriptionsintroductoryoffersdeletetomanyrelationship) | **DELETE** /v1/subscriptions/{id}/relationships/introductoryOffers |  |
| [**SubscriptionsIntroductoryOffersGetToManyRelated**](SubscriptionsApi.md#subscriptionsintroductoryoffersgettomanyrelated) | **GET** /v1/subscriptions/{id}/introductoryOffers |  |
| [**SubscriptionsIntroductoryOffersGetToManyRelationship**](SubscriptionsApi.md#subscriptionsintroductoryoffersgettomanyrelationship) | **GET** /v1/subscriptions/{id}/relationships/introductoryOffers |  |
| [**SubscriptionsOfferCodesGetToManyRelated**](SubscriptionsApi.md#subscriptionsoffercodesgettomanyrelated) | **GET** /v1/subscriptions/{id}/offerCodes |  |
| [**SubscriptionsPricePointsGetToManyRelated**](SubscriptionsApi.md#subscriptionspricepointsgettomanyrelated) | **GET** /v1/subscriptions/{id}/pricePoints |  |
| [**SubscriptionsPricesDeleteToManyRelationship**](SubscriptionsApi.md#subscriptionspricesdeletetomanyrelationship) | **DELETE** /v1/subscriptions/{id}/relationships/prices |  |
| [**SubscriptionsPricesGetToManyRelated**](SubscriptionsApi.md#subscriptionspricesgettomanyrelated) | **GET** /v1/subscriptions/{id}/prices |  |
| [**SubscriptionsPricesGetToManyRelationship**](SubscriptionsApi.md#subscriptionspricesgettomanyrelationship) | **GET** /v1/subscriptions/{id}/relationships/prices |  |
| [**SubscriptionsPromotedPurchaseGetToOneRelated**](SubscriptionsApi.md#subscriptionspromotedpurchasegettoonerelated) | **GET** /v1/subscriptions/{id}/promotedPurchase |  |
| [**SubscriptionsPromotionalOffersGetToManyRelated**](SubscriptionsApi.md#subscriptionspromotionaloffersgettomanyrelated) | **GET** /v1/subscriptions/{id}/promotionalOffers |  |
| [**SubscriptionsSubscriptionLocalizationsGetToManyRelated**](SubscriptionsApi.md#subscriptionssubscriptionlocalizationsgettomanyrelated) | **GET** /v1/subscriptions/{id}/subscriptionLocalizations |  |
| [**SubscriptionsUpdateInstance**](SubscriptionsApi.md#subscriptionsupdateinstance) | **PATCH** /v1/subscriptions/{id} |  |

<a name="subscriptionsappstorereviewscreenshotgettoonerelated"></a>
# **SubscriptionsAppStoreReviewScreenshotGetToOneRelated**
> SubscriptionAppStoreReviewScreenshotResponse SubscriptionsAppStoreReviewScreenshotGetToOneRelated (string id, List<string>? fieldsSubscriptionAppStoreReviewScreenshots = null, List<string>? fieldsSubscriptions = null, List<string>? include = null)



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
    public class SubscriptionsAppStoreReviewScreenshotGetToOneRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionAppStoreReviewScreenshotResponse result = apiInstance.SubscriptionsAppStoreReviewScreenshotGetToOneRelated(id, fieldsSubscriptionAppStoreReviewScreenshots, fieldsSubscriptions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsAppStoreReviewScreenshotGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsAppStoreReviewScreenshotGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionAppStoreReviewScreenshotResponse> response = apiInstance.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedWithHttpInfo(id, fieldsSubscriptionAppStoreReviewScreenshots, fieldsSubscriptions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionAppStoreReviewScreenshotResponse**](SubscriptionAppStoreReviewScreenshotResponse.md)

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
| **200** | Single SubscriptionAppStoreReviewScreenshot |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionscreateinstance"></a>
# **SubscriptionsCreateInstance**
> SubscriptionResponse SubscriptionsCreateInstance (SubscriptionCreateRequest subscriptionCreateRequest)



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
    public class SubscriptionsCreateInstanceExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var subscriptionCreateRequest = new SubscriptionCreateRequest(); // SubscriptionCreateRequest | Subscription representation

            try
            {
                SubscriptionResponse result = apiInstance.SubscriptionsCreateInstance(subscriptionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionResponse> response = apiInstance.SubscriptionsCreateInstanceWithHttpInfo(subscriptionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionCreateRequest** | [**SubscriptionCreateRequest**](SubscriptionCreateRequest.md) | Subscription representation |  |

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

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
| **201** | Single Subscription |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsdeleteinstance"></a>
# **SubscriptionsDeleteInstance**
> void SubscriptionsDeleteInstance (string id)



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
    public class SubscriptionsDeleteInstanceExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.SubscriptionsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscriptionsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="subscriptionsgetinstance"></a>
# **SubscriptionsGetInstance**
> SubscriptionResponse SubscriptionsGetInstance (string id, List<string>? fieldsSubscriptions = null, List<string>? include = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsSubscriptionPricePoints = null, List<string>? fieldsSubscriptionPromotionalOffers = null, List<string>? fieldsSubscriptionOfferCodes = null, List<string>? fieldsSubscriptionAppStoreReviewScreenshots = null, List<string>? fieldsSubscriptionPrices = null, List<string>? fieldsSubscriptionIntroductoryOffers = null, List<string>? fieldsSubscriptionLocalizations = null, int? limitIntroductoryOffers = null, int? limitOfferCodes = null, int? limitPrices = null, int? limitPromotionalOffers = null, int? limitSubscriptionLocalizations = null)



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
    public class SubscriptionsGetInstanceExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsSubscriptionPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPricePoints (optional) 
            var fieldsSubscriptionPromotionalOffers = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPromotionalOffers (optional) 
            var fieldsSubscriptionOfferCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodes (optional) 
            var fieldsSubscriptionAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots (optional) 
            var fieldsSubscriptionPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPrices (optional) 
            var fieldsSubscriptionIntroductoryOffers = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionIntroductoryOffers (optional) 
            var fieldsSubscriptionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionLocalizations (optional) 
            var limitIntroductoryOffers = 56;  // int? | maximum number of related introductoryOffers returned (when they are included) (optional) 
            var limitOfferCodes = 56;  // int? | maximum number of related offerCodes returned (when they are included) (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var limitPromotionalOffers = 56;  // int? | maximum number of related promotionalOffers returned (when they are included) (optional) 
            var limitSubscriptionLocalizations = 56;  // int? | maximum number of related subscriptionLocalizations returned (when they are included) (optional) 

            try
            {
                SubscriptionResponse result = apiInstance.SubscriptionsGetInstance(id, fieldsSubscriptions, include, fieldsPromotedPurchases, fieldsSubscriptionPricePoints, fieldsSubscriptionPromotionalOffers, fieldsSubscriptionOfferCodes, fieldsSubscriptionAppStoreReviewScreenshots, fieldsSubscriptionPrices, fieldsSubscriptionIntroductoryOffers, fieldsSubscriptionLocalizations, limitIntroductoryOffers, limitOfferCodes, limitPrices, limitPromotionalOffers, limitSubscriptionLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionResponse> response = apiInstance.SubscriptionsGetInstanceWithHttpInfo(id, fieldsSubscriptions, include, fieldsPromotedPurchases, fieldsSubscriptionPricePoints, fieldsSubscriptionPromotionalOffers, fieldsSubscriptionOfferCodes, fieldsSubscriptionAppStoreReviewScreenshots, fieldsSubscriptionPrices, fieldsSubscriptionIntroductoryOffers, fieldsSubscriptionLocalizations, limitIntroductoryOffers, limitOfferCodes, limitPrices, limitPromotionalOffers, limitSubscriptionLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsSubscriptionPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPricePoints | [optional]  |
| **fieldsSubscriptionPromotionalOffers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPromotionalOffers | [optional]  |
| **fieldsSubscriptionOfferCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodes | [optional]  |
| **fieldsSubscriptionAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots | [optional]  |
| **fieldsSubscriptionPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPrices | [optional]  |
| **fieldsSubscriptionIntroductoryOffers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionIntroductoryOffers | [optional]  |
| **fieldsSubscriptionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionLocalizations | [optional]  |
| **limitIntroductoryOffers** | **int?** | maximum number of related introductoryOffers returned (when they are included) | [optional]  |
| **limitOfferCodes** | **int?** | maximum number of related offerCodes returned (when they are included) | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **limitPromotionalOffers** | **int?** | maximum number of related promotionalOffers returned (when they are included) | [optional]  |
| **limitSubscriptionLocalizations** | **int?** | maximum number of related subscriptionLocalizations returned (when they are included) | [optional]  |

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

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
| **200** | Single Subscription |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsintroductoryoffersdeletetomanyrelationship"></a>
# **SubscriptionsIntroductoryOffersDeleteToManyRelationship**
> void SubscriptionsIntroductoryOffersDeleteToManyRelationship (string id, SubscriptionIntroductoryOffersLinkagesRequest subscriptionIntroductoryOffersLinkagesRequest)



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
    public class SubscriptionsIntroductoryOffersDeleteToManyRelationshipExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionIntroductoryOffersLinkagesRequest = new SubscriptionIntroductoryOffersLinkagesRequest(); // SubscriptionIntroductoryOffersLinkagesRequest | List of related linkages

            try
            {
                apiInstance.SubscriptionsIntroductoryOffersDeleteToManyRelationship(id, subscriptionIntroductoryOffersLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIntroductoryOffersDeleteToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsIntroductoryOffersDeleteToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscriptionsIntroductoryOffersDeleteToManyRelationshipWithHttpInfo(id, subscriptionIntroductoryOffersLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIntroductoryOffersDeleteToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionIntroductoryOffersLinkagesRequest** | [**SubscriptionIntroductoryOffersLinkagesRequest**](SubscriptionIntroductoryOffersLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsintroductoryoffersgettomanyrelated"></a>
# **SubscriptionsIntroductoryOffersGetToManyRelated**
> SubscriptionIntroductoryOffersResponse SubscriptionsIntroductoryOffersGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsSubscriptionPricePoints = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionIntroductoryOffers = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class SubscriptionsIntroductoryOffersGetToManyRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsSubscriptionPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPricePoints (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionIntroductoryOffers = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionIntroductoryOffers (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionIntroductoryOffersResponse result = apiInstance.SubscriptionsIntroductoryOffersGetToManyRelated(id, filterTerritory, fieldsSubscriptionPricePoints, fieldsSubscriptions, fieldsSubscriptionIntroductoryOffers, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIntroductoryOffersGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsIntroductoryOffersGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionIntroductoryOffersResponse> response = apiInstance.SubscriptionsIntroductoryOffersGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsSubscriptionPricePoints, fieldsSubscriptions, fieldsSubscriptionIntroductoryOffers, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIntroductoryOffersGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsSubscriptionPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPricePoints | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionIntroductoryOffers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionIntroductoryOffers | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionIntroductoryOffersResponse**](SubscriptionIntroductoryOffersResponse.md)

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
| **200** | List of SubscriptionIntroductoryOffers |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsintroductoryoffersgettomanyrelationship"></a>
# **SubscriptionsIntroductoryOffersGetToManyRelationship**
> SubscriptionIntroductoryOffersLinkagesResponse SubscriptionsIntroductoryOffersGetToManyRelationship (string id, int? limit = null)



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
    public class SubscriptionsIntroductoryOffersGetToManyRelationshipExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                SubscriptionIntroductoryOffersLinkagesResponse result = apiInstance.SubscriptionsIntroductoryOffersGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIntroductoryOffersGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsIntroductoryOffersGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionIntroductoryOffersLinkagesResponse> response = apiInstance.SubscriptionsIntroductoryOffersGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIntroductoryOffersGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**SubscriptionIntroductoryOffersLinkagesResponse**](SubscriptionIntroductoryOffersLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsoffercodesgettomanyrelated"></a>
# **SubscriptionsOfferCodesGetToManyRelated**
> SubscriptionOfferCodesResponse SubscriptionsOfferCodesGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsSubscriptionOfferCodeCustomCodes = null, List<string>? fieldsSubscriptionOfferCodes = null, List<string>? fieldsSubscriptionOfferCodeOneTimeUseCodes = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionOfferCodePrices = null, int? limit = null, int? limitOneTimeUseCodes = null, int? limitCustomCodes = null, int? limitPrices = null, List<string>? include = null)



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
    public class SubscriptionsOfferCodesGetToManyRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by territory (optional) 
            var fieldsSubscriptionOfferCodeCustomCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodeCustomCodes (optional) 
            var fieldsSubscriptionOfferCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodes (optional) 
            var fieldsSubscriptionOfferCodeOneTimeUseCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodeOneTimeUseCodes (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionOfferCodePrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodePrices (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitOneTimeUseCodes = 56;  // int? | maximum number of related oneTimeUseCodes returned (when they are included) (optional) 
            var limitCustomCodes = 56;  // int? | maximum number of related customCodes returned (when they are included) (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionOfferCodesResponse result = apiInstance.SubscriptionsOfferCodesGetToManyRelated(id, filterTerritory, fieldsSubscriptionOfferCodeCustomCodes, fieldsSubscriptionOfferCodes, fieldsSubscriptionOfferCodeOneTimeUseCodes, fieldsSubscriptions, fieldsSubscriptionOfferCodePrices, limit, limitOneTimeUseCodes, limitCustomCodes, limitPrices, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsOfferCodesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsOfferCodesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionOfferCodesResponse> response = apiInstance.SubscriptionsOfferCodesGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsSubscriptionOfferCodeCustomCodes, fieldsSubscriptionOfferCodes, fieldsSubscriptionOfferCodeOneTimeUseCodes, fieldsSubscriptions, fieldsSubscriptionOfferCodePrices, limit, limitOneTimeUseCodes, limitCustomCodes, limitPrices, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsOfferCodesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by territory | [optional]  |
| **fieldsSubscriptionOfferCodeCustomCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodeCustomCodes | [optional]  |
| **fieldsSubscriptionOfferCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodes | [optional]  |
| **fieldsSubscriptionOfferCodeOneTimeUseCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodeOneTimeUseCodes | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionOfferCodePrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodePrices | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitOneTimeUseCodes** | **int?** | maximum number of related oneTimeUseCodes returned (when they are included) | [optional]  |
| **limitCustomCodes** | **int?** | maximum number of related customCodes returned (when they are included) | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionOfferCodesResponse**](SubscriptionOfferCodesResponse.md)

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
| **200** | List of SubscriptionOfferCodes |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspricepointsgettomanyrelated"></a>
# **SubscriptionsPricePointsGetToManyRelated**
> SubscriptionPricePointsResponse SubscriptionsPricePointsGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsSubscriptionPricePoints = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class SubscriptionsPricePointsGetToManyRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsSubscriptionPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPricePoints (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionPricePointsResponse result = apiInstance.SubscriptionsPricePointsGetToManyRelated(id, filterTerritory, fieldsSubscriptionPricePoints, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricePointsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsPricePointsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionPricePointsResponse> response = apiInstance.SubscriptionsPricePointsGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsSubscriptionPricePoints, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricePointsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsSubscriptionPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPricePoints | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionPricePointsResponse**](SubscriptionPricePointsResponse.md)

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
| **200** | List of SubscriptionPricePoints |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspricesdeletetomanyrelationship"></a>
# **SubscriptionsPricesDeleteToManyRelationship**
> void SubscriptionsPricesDeleteToManyRelationship (string id, SubscriptionPricesLinkagesRequest subscriptionPricesLinkagesRequest)



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
    public class SubscriptionsPricesDeleteToManyRelationshipExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionPricesLinkagesRequest = new SubscriptionPricesLinkagesRequest(); // SubscriptionPricesLinkagesRequest | List of related linkages

            try
            {
                apiInstance.SubscriptionsPricesDeleteToManyRelationship(id, subscriptionPricesLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricesDeleteToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsPricesDeleteToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscriptionsPricesDeleteToManyRelationshipWithHttpInfo(id, subscriptionPricesLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricesDeleteToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionPricesLinkagesRequest** | [**SubscriptionPricesLinkagesRequest**](SubscriptionPricesLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspricesgettomanyrelated"></a>
# **SubscriptionsPricesGetToManyRelated**
> SubscriptionPricesResponse SubscriptionsPricesGetToManyRelated (string id, List<string>? filterSubscriptionPricePoint = null, List<string>? filterTerritory = null, List<string>? fieldsSubscriptionPricePoints = null, List<string>? fieldsSubscriptionPrices = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class SubscriptionsPricesGetToManyRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterSubscriptionPricePoint = new List<string>?(); // List<string>? | filter by id(s) of related 'subscriptionPricePoint' (optional) 
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsSubscriptionPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPricePoints (optional) 
            var fieldsSubscriptionPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPrices (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionPricesResponse result = apiInstance.SubscriptionsPricesGetToManyRelated(id, filterSubscriptionPricePoint, filterTerritory, fieldsSubscriptionPricePoints, fieldsSubscriptionPrices, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsPricesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionPricesResponse> response = apiInstance.SubscriptionsPricesGetToManyRelatedWithHttpInfo(id, filterSubscriptionPricePoint, filterTerritory, fieldsSubscriptionPricePoints, fieldsSubscriptionPrices, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterSubscriptionPricePoint** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;subscriptionPricePoint&#39; | [optional]  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsSubscriptionPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPricePoints | [optional]  |
| **fieldsSubscriptionPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPrices | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionPricesResponse**](SubscriptionPricesResponse.md)

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
| **200** | List of SubscriptionPrices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspricesgettomanyrelationship"></a>
# **SubscriptionsPricesGetToManyRelationship**
> SubscriptionPricesLinkagesResponse SubscriptionsPricesGetToManyRelationship (string id, int? limit = null)



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
    public class SubscriptionsPricesGetToManyRelationshipExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                SubscriptionPricesLinkagesResponse result = apiInstance.SubscriptionsPricesGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricesGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsPricesGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionPricesLinkagesResponse> response = apiInstance.SubscriptionsPricesGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPricesGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**SubscriptionPricesLinkagesResponse**](SubscriptionPricesLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspromotedpurchasegettoonerelated"></a>
# **SubscriptionsPromotedPurchaseGetToOneRelated**
> PromotedPurchaseResponse SubscriptionsPromotedPurchaseGetToOneRelated (string id, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsPromotedPurchaseImages = null, int? limitPromotionImages = null, List<string>? include = null)



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
    public class SubscriptionsPromotedPurchaseGetToOneRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsPromotedPurchaseImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchaseImages (optional) 
            var limitPromotionImages = 56;  // int? | maximum number of related promotionImages returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                PromotedPurchaseResponse result = apiInstance.SubscriptionsPromotedPurchaseGetToOneRelated(id, fieldsPromotedPurchases, fieldsSubscriptions, fieldsInAppPurchases, fieldsPromotedPurchaseImages, limitPromotionImages, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPromotedPurchaseGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsPromotedPurchaseGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PromotedPurchaseResponse> response = apiInstance.SubscriptionsPromotedPurchaseGetToOneRelatedWithHttpInfo(id, fieldsPromotedPurchases, fieldsSubscriptions, fieldsInAppPurchases, fieldsPromotedPurchaseImages, limitPromotionImages, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPromotedPurchaseGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsPromotedPurchaseImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchaseImages | [optional]  |
| **limitPromotionImages** | **int?** | maximum number of related promotionImages returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**PromotedPurchaseResponse**](PromotedPurchaseResponse.md)

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
| **200** | Single PromotedPurchase |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspromotionaloffersgettomanyrelated"></a>
# **SubscriptionsPromotionalOffersGetToManyRelated**
> SubscriptionPromotionalOffersResponse SubscriptionsPromotionalOffersGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsSubscriptionPromotionalOffers = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionPromotionalOfferPrices = null, int? limit = null, int? limitPrices = null, List<string>? include = null)



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
    public class SubscriptionsPromotionalOffersGetToManyRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by territory (optional) 
            var fieldsSubscriptionPromotionalOffers = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPromotionalOffers (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionPromotionalOfferPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPromotionalOfferPrices (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionPromotionalOffersResponse result = apiInstance.SubscriptionsPromotionalOffersGetToManyRelated(id, filterTerritory, fieldsSubscriptionPromotionalOffers, fieldsSubscriptions, fieldsSubscriptionPromotionalOfferPrices, limit, limitPrices, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPromotionalOffersGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsPromotionalOffersGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionPromotionalOffersResponse> response = apiInstance.SubscriptionsPromotionalOffersGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsSubscriptionPromotionalOffers, fieldsSubscriptions, fieldsSubscriptionPromotionalOfferPrices, limit, limitPrices, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPromotionalOffersGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by territory | [optional]  |
| **fieldsSubscriptionPromotionalOffers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPromotionalOffers | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionPromotionalOfferPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPromotionalOfferPrices | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionPromotionalOffersResponse**](SubscriptionPromotionalOffersResponse.md)

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
| **200** | List of SubscriptionPromotionalOffers |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionssubscriptionlocalizationsgettomanyrelated"></a>
# **SubscriptionsSubscriptionLocalizationsGetToManyRelated**
> SubscriptionLocalizationsResponse SubscriptionsSubscriptionLocalizationsGetToManyRelated (string id, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionLocalizations = null, int? limit = null, List<string>? include = null)



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
    public class SubscriptionsSubscriptionLocalizationsGetToManyRelatedExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionLocalizationsResponse result = apiInstance.SubscriptionsSubscriptionLocalizationsGetToManyRelated(id, fieldsSubscriptions, fieldsSubscriptionLocalizations, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsSubscriptionLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsSubscriptionLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionLocalizationsResponse> response = apiInstance.SubscriptionsSubscriptionLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsSubscriptions, fieldsSubscriptionLocalizations, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsSubscriptionLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionLocalizationsResponse**](SubscriptionLocalizationsResponse.md)

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
| **200** | List of SubscriptionLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsupdateinstance"></a>
# **SubscriptionsUpdateInstance**
> SubscriptionResponse SubscriptionsUpdateInstance (string id, SubscriptionUpdateRequest subscriptionUpdateRequest)



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
    public class SubscriptionsUpdateInstanceExample
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
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionUpdateRequest = new SubscriptionUpdateRequest(); // SubscriptionUpdateRequest | Subscription representation

            try
            {
                SubscriptionResponse result = apiInstance.SubscriptionsUpdateInstance(id, subscriptionUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionResponse> response = apiInstance.SubscriptionsUpdateInstanceWithHttpInfo(id, subscriptionUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionUpdateRequest** | [**SubscriptionUpdateRequest**](SubscriptionUpdateRequest.md) | Subscription representation |  |

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

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
| **200** | Single Subscription |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

