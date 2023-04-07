# AppStoreConnect.Net.Api.SubscriptionGroupsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionGroupsCreateInstance**](SubscriptionGroupsApi.md#subscriptiongroupscreateinstance) | **POST** /v1/subscriptionGroups |  |
| [**SubscriptionGroupsDeleteInstance**](SubscriptionGroupsApi.md#subscriptiongroupsdeleteinstance) | **DELETE** /v1/subscriptionGroups/{id} |  |
| [**SubscriptionGroupsGetInstance**](SubscriptionGroupsApi.md#subscriptiongroupsgetinstance) | **GET** /v1/subscriptionGroups/{id} |  |
| [**SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelated**](SubscriptionGroupsApi.md#subscriptiongroupssubscriptiongrouplocalizationsgettomanyrelated) | **GET** /v1/subscriptionGroups/{id}/subscriptionGroupLocalizations |  |
| [**SubscriptionGroupsSubscriptionsGetToManyRelated**](SubscriptionGroupsApi.md#subscriptiongroupssubscriptionsgettomanyrelated) | **GET** /v1/subscriptionGroups/{id}/subscriptions |  |
| [**SubscriptionGroupsUpdateInstance**](SubscriptionGroupsApi.md#subscriptiongroupsupdateinstance) | **PATCH** /v1/subscriptionGroups/{id} |  |

<a name="subscriptiongroupscreateinstance"></a>
# **SubscriptionGroupsCreateInstance**
> SubscriptionGroupResponse SubscriptionGroupsCreateInstance (SubscriptionGroupCreateRequest subscriptionGroupCreateRequest)



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
    public class SubscriptionGroupsCreateInstanceExample
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
            var apiInstance = new SubscriptionGroupsApi(httpClient, config, httpClientHandler);
            var subscriptionGroupCreateRequest = new SubscriptionGroupCreateRequest(); // SubscriptionGroupCreateRequest | SubscriptionGroup representation

            try
            {
                SubscriptionGroupResponse result = apiInstance.SubscriptionGroupsCreateInstance(subscriptionGroupCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGroupResponse> response = apiInstance.SubscriptionGroupsCreateInstanceWithHttpInfo(subscriptionGroupCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionGroupCreateRequest** | [**SubscriptionGroupCreateRequest**](SubscriptionGroupCreateRequest.md) | SubscriptionGroup representation |  |

### Return type

[**SubscriptionGroupResponse**](SubscriptionGroupResponse.md)

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
| **201** | Single SubscriptionGroup |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptiongroupsdeleteinstance"></a>
# **SubscriptionGroupsDeleteInstance**
> void SubscriptionGroupsDeleteInstance (string id)



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
    public class SubscriptionGroupsDeleteInstanceExample
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
            var apiInstance = new SubscriptionGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.SubscriptionGroupsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscriptionGroupsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="subscriptiongroupsgetinstance"></a>
# **SubscriptionGroupsGetInstance**
> SubscriptionGroupResponse SubscriptionGroupsGetInstance (string id, List<string>? fieldsSubscriptionGroups = null, List<string>? include = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionGroupLocalizations = null, int? limitSubscriptionGroupLocalizations = null, int? limitSubscriptions = null)



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
    public class SubscriptionGroupsGetInstanceExample
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
            var apiInstance = new SubscriptionGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionGroupLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroupLocalizations (optional) 
            var limitSubscriptionGroupLocalizations = 56;  // int? | maximum number of related subscriptionGroupLocalizations returned (when they are included) (optional) 
            var limitSubscriptions = 56;  // int? | maximum number of related subscriptions returned (when they are included) (optional) 

            try
            {
                SubscriptionGroupResponse result = apiInstance.SubscriptionGroupsGetInstance(id, fieldsSubscriptionGroups, include, fieldsSubscriptions, fieldsSubscriptionGroupLocalizations, limitSubscriptionGroupLocalizations, limitSubscriptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGroupResponse> response = apiInstance.SubscriptionGroupsGetInstanceWithHttpInfo(id, fieldsSubscriptionGroups, include, fieldsSubscriptions, fieldsSubscriptionGroupLocalizations, limitSubscriptionGroupLocalizations, limitSubscriptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionGroupLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroupLocalizations | [optional]  |
| **limitSubscriptionGroupLocalizations** | **int?** | maximum number of related subscriptionGroupLocalizations returned (when they are included) | [optional]  |
| **limitSubscriptions** | **int?** | maximum number of related subscriptions returned (when they are included) | [optional]  |

### Return type

[**SubscriptionGroupResponse**](SubscriptionGroupResponse.md)

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
| **200** | Single SubscriptionGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptiongroupssubscriptiongrouplocalizationsgettomanyrelated"></a>
# **SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelated**
> SubscriptionGroupLocalizationsResponse SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelated (string id, List<string>? fieldsSubscriptionGroups = null, List<string>? fieldsSubscriptionGroupLocalizations = null, int? limit = null, List<string>? include = null)



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
    public class SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedExample
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
            var apiInstance = new SubscriptionGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var fieldsSubscriptionGroupLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroupLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionGroupLocalizationsResponse result = apiInstance.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelated(id, fieldsSubscriptionGroups, fieldsSubscriptionGroupLocalizations, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGroupLocalizationsResponse> response = apiInstance.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsSubscriptionGroups, fieldsSubscriptionGroupLocalizations, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **fieldsSubscriptionGroupLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroupLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionGroupLocalizationsResponse**](SubscriptionGroupLocalizationsResponse.md)

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
| **200** | List of SubscriptionGroupLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptiongroupssubscriptionsgettomanyrelated"></a>
# **SubscriptionGroupsSubscriptionsGetToManyRelated**
> SubscriptionsResponse SubscriptionGroupsSubscriptionsGetToManyRelated (string id, List<string>? filterName = null, List<string>? filterProductId = null, List<string>? filterState = null, List<string>? sort = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsSubscriptionPromotionalOffers = null, List<string>? fieldsSubscriptionOfferCodes = null, List<string>? fieldsSubscriptionAppStoreReviewScreenshots = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsSubscriptionGroups = null, List<string>? fieldsSubscriptionIntroductoryOffers = null, List<string>? fieldsSubscriptionPrices = null, List<string>? fieldsSubscriptionLocalizations = null, int? limit = null, int? limitSubscriptionLocalizations = null, int? limitIntroductoryOffers = null, int? limitPromotionalOffers = null, int? limitOfferCodes = null, int? limitPrices = null, List<string>? include = null)



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
    public class SubscriptionGroupsSubscriptionsGetToManyRelatedExample
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
            var apiInstance = new SubscriptionGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterName = new List<string>?(); // List<string>? | filter by attribute 'name' (optional) 
            var filterProductId = new List<string>?(); // List<string>? | filter by attribute 'productId' (optional) 
            var filterState = new List<string>?(); // List<string>? | filter by attribute 'state' (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsSubscriptionPromotionalOffers = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPromotionalOffers (optional) 
            var fieldsSubscriptionOfferCodes = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionOfferCodes (optional) 
            var fieldsSubscriptionAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsSubscriptionGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionGroups (optional) 
            var fieldsSubscriptionIntroductoryOffers = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionIntroductoryOffers (optional) 
            var fieldsSubscriptionPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionPrices (optional) 
            var fieldsSubscriptionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitSubscriptionLocalizations = 56;  // int? | maximum number of related subscriptionLocalizations returned (when they are included) (optional) 
            var limitIntroductoryOffers = 56;  // int? | maximum number of related introductoryOffers returned (when they are included) (optional) 
            var limitPromotionalOffers = 56;  // int? | maximum number of related promotionalOffers returned (when they are included) (optional) 
            var limitOfferCodes = 56;  // int? | maximum number of related offerCodes returned (when they are included) (optional) 
            var limitPrices = 56;  // int? | maximum number of related prices returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionsResponse result = apiInstance.SubscriptionGroupsSubscriptionsGetToManyRelated(id, filterName, filterProductId, filterState, sort, fieldsPromotedPurchases, fieldsSubscriptionPromotionalOffers, fieldsSubscriptionOfferCodes, fieldsSubscriptionAppStoreReviewScreenshots, fieldsSubscriptions, fieldsSubscriptionGroups, fieldsSubscriptionIntroductoryOffers, fieldsSubscriptionPrices, fieldsSubscriptionLocalizations, limit, limitSubscriptionLocalizations, limitIntroductoryOffers, limitPromotionalOffers, limitOfferCodes, limitPrices, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsSubscriptionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupsSubscriptionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionsResponse> response = apiInstance.SubscriptionGroupsSubscriptionsGetToManyRelatedWithHttpInfo(id, filterName, filterProductId, filterState, sort, fieldsPromotedPurchases, fieldsSubscriptionPromotionalOffers, fieldsSubscriptionOfferCodes, fieldsSubscriptionAppStoreReviewScreenshots, fieldsSubscriptions, fieldsSubscriptionGroups, fieldsSubscriptionIntroductoryOffers, fieldsSubscriptionPrices, fieldsSubscriptionLocalizations, limit, limitSubscriptionLocalizations, limitIntroductoryOffers, limitPromotionalOffers, limitOfferCodes, limitPrices, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsSubscriptionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;name&#39; | [optional]  |
| **filterProductId** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;productId&#39; | [optional]  |
| **filterState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;state&#39; | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsSubscriptionPromotionalOffers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPromotionalOffers | [optional]  |
| **fieldsSubscriptionOfferCodes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionOfferCodes | [optional]  |
| **fieldsSubscriptionAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsSubscriptionGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionGroups | [optional]  |
| **fieldsSubscriptionIntroductoryOffers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionIntroductoryOffers | [optional]  |
| **fieldsSubscriptionPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionPrices | [optional]  |
| **fieldsSubscriptionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitSubscriptionLocalizations** | **int?** | maximum number of related subscriptionLocalizations returned (when they are included) | [optional]  |
| **limitIntroductoryOffers** | **int?** | maximum number of related introductoryOffers returned (when they are included) | [optional]  |
| **limitPromotionalOffers** | **int?** | maximum number of related promotionalOffers returned (when they are included) | [optional]  |
| **limitOfferCodes** | **int?** | maximum number of related offerCodes returned (when they are included) | [optional]  |
| **limitPrices** | **int?** | maximum number of related prices returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionsResponse**](SubscriptionsResponse.md)

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
| **200** | List of Subscriptions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptiongroupsupdateinstance"></a>
# **SubscriptionGroupsUpdateInstance**
> SubscriptionGroupResponse SubscriptionGroupsUpdateInstance (string id, SubscriptionGroupUpdateRequest subscriptionGroupUpdateRequest)



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
    public class SubscriptionGroupsUpdateInstanceExample
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
            var apiInstance = new SubscriptionGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionGroupUpdateRequest = new SubscriptionGroupUpdateRequest(); // SubscriptionGroupUpdateRequest | SubscriptionGroup representation

            try
            {
                SubscriptionGroupResponse result = apiInstance.SubscriptionGroupsUpdateInstance(id, subscriptionGroupUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGroupResponse> response = apiInstance.SubscriptionGroupsUpdateInstanceWithHttpInfo(id, subscriptionGroupUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupsApi.SubscriptionGroupsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionGroupUpdateRequest** | [**SubscriptionGroupUpdateRequest**](SubscriptionGroupUpdateRequest.md) | SubscriptionGroup representation |  |

### Return type

[**SubscriptionGroupResponse**](SubscriptionGroupResponse.md)

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
| **200** | Single SubscriptionGroup |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

