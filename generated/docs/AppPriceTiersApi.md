# AppStoreConnect.Net.Api.AppPriceTiersApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppPriceTiersGetCollection**](AppPriceTiersApi.md#apppricetiersgetcollection) | **GET** /v1/appPriceTiers |  |
| [**AppPriceTiersGetInstance**](AppPriceTiersApi.md#apppricetiersgetinstance) | **GET** /v1/appPriceTiers/{id} |  |
| [**AppPriceTiersPricePointsGetToManyRelated**](AppPriceTiersApi.md#apppricetierspricepointsgettomanyrelated) | **GET** /v1/appPriceTiers/{id}/pricePoints |  |

<a name="apppricetiersgetcollection"></a>
# **AppPriceTiersGetCollection**
> AppPriceTiersResponse AppPriceTiersGetCollection (List<string>? filterId = null, List<string>? fieldsAppPriceTiers = null, int? limit = null, List<string>? include = null, List<string>? fieldsAppPricePoints = null, int? limitPricePoints = null)



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
    public class AppPriceTiersGetCollectionExample
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
            var apiInstance = new AppPriceTiersApi(httpClient, config, httpClientHandler);
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsAppPriceTiers = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceTiers (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var limitPricePoints = 56;  // int? | maximum number of related pricePoints returned (when they are included) (optional) 

            try
            {
                AppPriceTiersResponse result = apiInstance.AppPriceTiersGetCollection(filterId, fieldsAppPriceTiers, limit, include, fieldsAppPricePoints, limitPricePoints);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceTiersApi.AppPriceTiersGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceTiersGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPriceTiersResponse> response = apiInstance.AppPriceTiersGetCollectionWithHttpInfo(filterId, fieldsAppPriceTiers, limit, include, fieldsAppPricePoints, limitPricePoints);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceTiersApi.AppPriceTiersGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsAppPriceTiers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceTiers | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **limitPricePoints** | **int?** | maximum number of related pricePoints returned (when they are included) | [optional]  |

### Return type

[**AppPriceTiersResponse**](AppPriceTiersResponse.md)

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
| **200** | List of AppPriceTiers |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apppricetiersgetinstance"></a>
# **AppPriceTiersGetInstance**
> AppPriceTierResponse AppPriceTiersGetInstance (string id, List<string>? fieldsAppPriceTiers = null, List<string>? include = null, List<string>? fieldsAppPricePoints = null, int? limitPricePoints = null)



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
    public class AppPriceTiersGetInstanceExample
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
            var apiInstance = new AppPriceTiersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppPriceTiers = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceTiers (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var limitPricePoints = 56;  // int? | maximum number of related pricePoints returned (when they are included) (optional) 

            try
            {
                AppPriceTierResponse result = apiInstance.AppPriceTiersGetInstance(id, fieldsAppPriceTiers, include, fieldsAppPricePoints, limitPricePoints);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceTiersApi.AppPriceTiersGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceTiersGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPriceTierResponse> response = apiInstance.AppPriceTiersGetInstanceWithHttpInfo(id, fieldsAppPriceTiers, include, fieldsAppPricePoints, limitPricePoints);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceTiersApi.AppPriceTiersGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppPriceTiers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceTiers | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **limitPricePoints** | **int?** | maximum number of related pricePoints returned (when they are included) | [optional]  |

### Return type

[**AppPriceTierResponse**](AppPriceTierResponse.md)

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
| **200** | Single AppPriceTier |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apppricetierspricepointsgettomanyrelated"></a>
# **AppPriceTiersPricePointsGetToManyRelated**
> AppPricePointsResponse AppPriceTiersPricePointsGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsAppPriceTiers = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class AppPriceTiersPricePointsGetToManyRelatedExample
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
            var apiInstance = new AppPriceTiersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsAppPriceTiers = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceTiers (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPricePointsResponse result = apiInstance.AppPriceTiersPricePointsGetToManyRelated(id, filterTerritory, fieldsAppPriceTiers, fieldsAppPricePoints, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceTiersApi.AppPriceTiersPricePointsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceTiersPricePointsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPricePointsResponse> response = apiInstance.AppPriceTiersPricePointsGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsAppPriceTiers, fieldsAppPricePoints, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceTiersApi.AppPriceTiersPricePointsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsAppPriceTiers** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceTiers | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPricePointsResponse**](AppPricePointsResponse.md)

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
| **200** | List of AppPricePoints |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

