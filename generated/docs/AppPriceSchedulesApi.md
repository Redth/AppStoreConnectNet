# AppStoreConnect.Net.Api.AppPriceSchedulesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppPriceSchedulesAutomaticPricesGetToManyRelated**](AppPriceSchedulesApi.md#apppriceschedulesautomaticpricesgettomanyrelated) | **GET** /v1/appPriceSchedules/{id}/automaticPrices |  |
| [**AppPriceSchedulesBaseTerritoryGetToOneRelated**](AppPriceSchedulesApi.md#apppriceschedulesbaseterritorygettoonerelated) | **GET** /v1/appPriceSchedules/{id}/baseTerritory |  |
| [**AppPriceSchedulesCreateInstance**](AppPriceSchedulesApi.md#apppriceschedulescreateinstance) | **POST** /v1/appPriceSchedules |  |
| [**AppPriceSchedulesGetInstance**](AppPriceSchedulesApi.md#apppriceschedulesgetinstance) | **GET** /v1/appPriceSchedules/{id} |  |
| [**AppPriceSchedulesManualPricesGetToManyRelated**](AppPriceSchedulesApi.md#apppriceschedulesmanualpricesgettomanyrelated) | **GET** /v1/appPriceSchedules/{id}/manualPrices |  |

<a name="apppriceschedulesautomaticpricesgettomanyrelated"></a>
# **AppPriceSchedulesAutomaticPricesGetToManyRelated**
> AppPricesV2Response AppPriceSchedulesAutomaticPricesGetToManyRelated (string id, List<string>? filterEndDate = null, List<string>? filterStartDate = null, List<string>? filterTerritory = null, List<string>? fieldsAppPrices = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class AppPriceSchedulesAutomaticPricesGetToManyRelatedExample
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
            var apiInstance = new AppPriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterEndDate = new List<string>?(); // List<string>? | filter by attribute 'endDate' (optional) 
            var filterStartDate = new List<string>?(); // List<string>? | filter by attribute 'startDate' (optional) 
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPricesV2Response result = apiInstance.AppPriceSchedulesAutomaticPricesGetToManyRelated(id, filterEndDate, filterStartDate, filterTerritory, fieldsAppPrices, fieldsAppPricePoints, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesAutomaticPricesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceSchedulesAutomaticPricesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPricesV2Response> response = apiInstance.AppPriceSchedulesAutomaticPricesGetToManyRelatedWithHttpInfo(id, filterEndDate, filterStartDate, filterTerritory, fieldsAppPrices, fieldsAppPricePoints, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesAutomaticPricesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterEndDate** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;endDate&#39; | [optional]  |
| **filterStartDate** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;startDate&#39; | [optional]  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPricesV2Response**](AppPricesV2Response.md)

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
| **200** | List of AppPrices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apppriceschedulesbaseterritorygettoonerelated"></a>
# **AppPriceSchedulesBaseTerritoryGetToOneRelated**
> TerritoryResponse AppPriceSchedulesBaseTerritoryGetToOneRelated (string id, List<string>? fieldsTerritories = null)



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
    public class AppPriceSchedulesBaseTerritoryGetToOneRelatedExample
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
            var apiInstance = new AppPriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 

            try
            {
                TerritoryResponse result = apiInstance.AppPriceSchedulesBaseTerritoryGetToOneRelated(id, fieldsTerritories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesBaseTerritoryGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceSchedulesBaseTerritoryGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TerritoryResponse> response = apiInstance.AppPriceSchedulesBaseTerritoryGetToOneRelatedWithHttpInfo(id, fieldsTerritories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesBaseTerritoryGetToOneRelatedWithHttpInfo: " + e.Message);
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

<a name="apppriceschedulescreateinstance"></a>
# **AppPriceSchedulesCreateInstance**
> AppPriceScheduleResponse AppPriceSchedulesCreateInstance (AppPriceScheduleCreateRequest appPriceScheduleCreateRequest)



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
    public class AppPriceSchedulesCreateInstanceExample
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
            var apiInstance = new AppPriceSchedulesApi(httpClient, config, httpClientHandler);
            var appPriceScheduleCreateRequest = new AppPriceScheduleCreateRequest(); // AppPriceScheduleCreateRequest | AppPriceSchedule representation

            try
            {
                AppPriceScheduleResponse result = apiInstance.AppPriceSchedulesCreateInstance(appPriceScheduleCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceSchedulesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPriceScheduleResponse> response = apiInstance.AppPriceSchedulesCreateInstanceWithHttpInfo(appPriceScheduleCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appPriceScheduleCreateRequest** | [**AppPriceScheduleCreateRequest**](AppPriceScheduleCreateRequest.md) | AppPriceSchedule representation |  |

### Return type

[**AppPriceScheduleResponse**](AppPriceScheduleResponse.md)

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
| **201** | Single AppPriceSchedule |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apppriceschedulesgetinstance"></a>
# **AppPriceSchedulesGetInstance**
> AppPriceScheduleResponse AppPriceSchedulesGetInstance (string id, List<string>? fieldsAppPriceSchedules = null, List<string>? include = null, List<string>? fieldsAppPrices = null, List<string>? fieldsTerritories = null, int? limitAutomaticPrices = null, int? limitManualPrices = null)



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
    public class AppPriceSchedulesGetInstanceExample
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
            var apiInstance = new AppPriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppPriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPriceSchedules (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limitAutomaticPrices = 56;  // int? | maximum number of related automaticPrices returned (when they are included) (optional) 
            var limitManualPrices = 56;  // int? | maximum number of related manualPrices returned (when they are included) (optional) 

            try
            {
                AppPriceScheduleResponse result = apiInstance.AppPriceSchedulesGetInstance(id, fieldsAppPriceSchedules, include, fieldsAppPrices, fieldsTerritories, limitAutomaticPrices, limitManualPrices);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceSchedulesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPriceScheduleResponse> response = apiInstance.AppPriceSchedulesGetInstanceWithHttpInfo(id, fieldsAppPriceSchedules, include, fieldsAppPrices, fieldsTerritories, limitAutomaticPrices, limitManualPrices);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppPriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPriceSchedules | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limitAutomaticPrices** | **int?** | maximum number of related automaticPrices returned (when they are included) | [optional]  |
| **limitManualPrices** | **int?** | maximum number of related manualPrices returned (when they are included) | [optional]  |

### Return type

[**AppPriceScheduleResponse**](AppPriceScheduleResponse.md)

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
| **200** | Single AppPriceSchedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apppriceschedulesmanualpricesgettomanyrelated"></a>
# **AppPriceSchedulesManualPricesGetToManyRelated**
> AppPricesV2Response AppPriceSchedulesManualPricesGetToManyRelated (string id, List<string>? filterEndDate = null, List<string>? filterStartDate = null, List<string>? filterTerritory = null, List<string>? fieldsAppPrices = null, List<string>? fieldsAppPricePoints = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class AppPriceSchedulesManualPricesGetToManyRelatedExample
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
            var apiInstance = new AppPriceSchedulesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterEndDate = new List<string>?(); // List<string>? | filter by attribute 'endDate' (optional) 
            var filterStartDate = new List<string>?(); // List<string>? | filter by attribute 'startDate' (optional) 
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsAppPrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPrices (optional) 
            var fieldsAppPricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPricePoints (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPricesV2Response result = apiInstance.AppPriceSchedulesManualPricesGetToManyRelated(id, filterEndDate, filterStartDate, filterTerritory, fieldsAppPrices, fieldsAppPricePoints, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesManualPricesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppPriceSchedulesManualPricesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPricesV2Response> response = apiInstance.AppPriceSchedulesManualPricesGetToManyRelatedWithHttpInfo(id, filterEndDate, filterStartDate, filterTerritory, fieldsAppPrices, fieldsAppPricePoints, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppPriceSchedulesApi.AppPriceSchedulesManualPricesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterEndDate** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;endDate&#39; | [optional]  |
| **filterStartDate** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;startDate&#39; | [optional]  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsAppPrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPrices | [optional]  |
| **fieldsAppPricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPricePoints | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPricesV2Response**](AppPricesV2Response.md)

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
| **200** | List of AppPrices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

