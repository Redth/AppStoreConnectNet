# AppStoreConnect.Net.Api.InAppPurchasePriceSchedulesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated**](InAppPurchasePriceSchedulesApi.md#inapppurchasepriceschedulesautomaticpricesgettomanyrelated) | **GET** /v1/inAppPurchasePriceSchedules/{id}/automaticPrices |  |
| [**InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated**](InAppPurchasePriceSchedulesApi.md#inapppurchasepriceschedulesbaseterritorygettoonerelated) | **GET** /v1/inAppPurchasePriceSchedules/{id}/baseTerritory |  |
| [**InAppPurchasePriceSchedulesCreateInstance**](InAppPurchasePriceSchedulesApi.md#inapppurchasepriceschedulescreateinstance) | **POST** /v1/inAppPurchasePriceSchedules |  |
| [**InAppPurchasePriceSchedulesGetInstance**](InAppPurchasePriceSchedulesApi.md#inapppurchasepriceschedulesgetinstance) | **GET** /v1/inAppPurchasePriceSchedules/{id} |  |
| [**InAppPurchasePriceSchedulesManualPricesGetToManyRelated**](InAppPurchasePriceSchedulesApi.md#inapppurchasepriceschedulesmanualpricesgettomanyrelated) | **GET** /v1/inAppPurchasePriceSchedules/{id}/manualPrices |  |

<a name="inapppurchasepriceschedulesautomaticpricesgettomanyrelated"></a>
# **InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated**
> InAppPurchasePricesResponse InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsInAppPurchasePricePoints = null, List<string>? fieldsInAppPurchasePrices = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedExample
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
            var apiInstance = new InAppPurchasePriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsInAppPurchasePricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePricePoints (optional) 
            var fieldsInAppPurchasePrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePrices (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchasePricesResponse result = apiInstance.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsInAppPurchasePrices, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasePricesResponse> response = apiInstance.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsInAppPurchasePrices, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsInAppPurchasePricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePricePoints | [optional]  |
| **fieldsInAppPurchasePrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePrices | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchasePricesResponse**](InAppPurchasePricesResponse.md)

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
| **200** | List of InAppPurchasePrices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inapppurchasepriceschedulesbaseterritorygettoonerelated"></a>
# **InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated**
> TerritoryResponse InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated (string id, List<string>? fieldsTerritories = null)



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
    public class InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelatedExample
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
            var apiInstance = new InAppPurchasePriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 

            try
            {
                TerritoryResponse result = apiInstance.InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated(id, fieldsTerritories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TerritoryResponse> response = apiInstance.InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelatedWithHttpInfo(id, fieldsTerritories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesBaseTerritoryGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |

### Return type

[**TerritoryResponse**](TerritoryResponse.md)

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
| **200** | Single Territory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inapppurchasepriceschedulescreateinstance"></a>
# **InAppPurchasePriceSchedulesCreateInstance**
> InAppPurchasePriceScheduleResponse InAppPurchasePriceSchedulesCreateInstance (InAppPurchasePriceScheduleCreateRequest inAppPurchasePriceScheduleCreateRequest)



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
    public class InAppPurchasePriceSchedulesCreateInstanceExample
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
            var apiInstance = new InAppPurchasePriceSchedulesApi(httpClient, config, httpClientHandler);
            var inAppPurchasePriceScheduleCreateRequest = new InAppPurchasePriceScheduleCreateRequest(); // InAppPurchasePriceScheduleCreateRequest | InAppPurchasePriceSchedule representation

            try
            {
                InAppPurchasePriceScheduleResponse result = apiInstance.InAppPurchasePriceSchedulesCreateInstance(inAppPurchasePriceScheduleCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasePriceSchedulesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasePriceScheduleResponse> response = apiInstance.InAppPurchasePriceSchedulesCreateInstanceWithHttpInfo(inAppPurchasePriceScheduleCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inAppPurchasePriceScheduleCreateRequest** | [**InAppPurchasePriceScheduleCreateRequest**](InAppPurchasePriceScheduleCreateRequest.md) | InAppPurchasePriceSchedule representation |  |

### Return type

[**InAppPurchasePriceScheduleResponse**](InAppPurchasePriceScheduleResponse.md)

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
| **201** | Single InAppPurchasePriceSchedule |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inapppurchasepriceschedulesgetinstance"></a>
# **InAppPurchasePriceSchedulesGetInstance**
> InAppPurchasePriceScheduleResponse InAppPurchasePriceSchedulesGetInstance (string id, List<string>? fieldsInAppPurchasePriceSchedules = null, List<string>? include = null, List<string>? fieldsInAppPurchasePrices = null, List<string>? fieldsTerritories = null, int? limitAutomaticPrices = null, int? limitManualPrices = null)



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
    public class InAppPurchasePriceSchedulesGetInstanceExample
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
            var apiInstance = new InAppPurchasePriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchasePriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePriceSchedules (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsInAppPurchasePrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePrices (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limitAutomaticPrices = 56;  // int? | maximum number of related automaticPrices returned (when they are included) (optional) 
            var limitManualPrices = 56;  // int? | maximum number of related manualPrices returned (when they are included) (optional) 

            try
            {
                InAppPurchasePriceScheduleResponse result = apiInstance.InAppPurchasePriceSchedulesGetInstance(id, fieldsInAppPurchasePriceSchedules, include, fieldsInAppPurchasePrices, fieldsTerritories, limitAutomaticPrices, limitManualPrices);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasePriceSchedulesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasePriceScheduleResponse> response = apiInstance.InAppPurchasePriceSchedulesGetInstanceWithHttpInfo(id, fieldsInAppPurchasePriceSchedules, include, fieldsInAppPurchasePrices, fieldsTerritories, limitAutomaticPrices, limitManualPrices);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchasePriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePriceSchedules | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsInAppPurchasePrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePrices | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limitAutomaticPrices** | **int?** | maximum number of related automaticPrices returned (when they are included) | [optional]  |
| **limitManualPrices** | **int?** | maximum number of related manualPrices returned (when they are included) | [optional]  |

### Return type

[**InAppPurchasePriceScheduleResponse**](InAppPurchasePriceScheduleResponse.md)

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
| **200** | Single InAppPurchasePriceSchedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inapppurchasepriceschedulesmanualpricesgettomanyrelated"></a>
# **InAppPurchasePriceSchedulesManualPricesGetToManyRelated**
> InAppPurchasePricesResponse InAppPurchasePriceSchedulesManualPricesGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsInAppPurchasePricePoints = null, List<string>? fieldsInAppPurchasePrices = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class InAppPurchasePriceSchedulesManualPricesGetToManyRelatedExample
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
            var apiInstance = new InAppPurchasePriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsInAppPurchasePricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePricePoints (optional) 
            var fieldsInAppPurchasePrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePrices (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchasePricesResponse result = apiInstance.InAppPurchasePriceSchedulesManualPricesGetToManyRelated(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsInAppPurchasePrices, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesManualPricesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasePriceSchedulesManualPricesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasePricesResponse> response = apiInstance.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsInAppPurchasePrices, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasePriceSchedulesApi.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsInAppPurchasePricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePricePoints | [optional]  |
| **fieldsInAppPurchasePrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePrices | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchasePricesResponse**](InAppPurchasePricesResponse.md)

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
| **200** | List of InAppPurchasePrices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

