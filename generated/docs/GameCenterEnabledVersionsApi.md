# AppStoreConnect.Net.Api.GameCenterEnabledVersionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationship**](GameCenterEnabledVersionsApi.md#gamecenterenabledversionscompatibleversionscreatetomanyrelationship) | **POST** /v1/gameCenterEnabledVersions/{id}/relationships/compatibleVersions |  |
| [**GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationship**](GameCenterEnabledVersionsApi.md#gamecenterenabledversionscompatibleversionsdeletetomanyrelationship) | **DELETE** /v1/gameCenterEnabledVersions/{id}/relationships/compatibleVersions |  |
| [**GameCenterEnabledVersionsCompatibleVersionsGetToManyRelated**](GameCenterEnabledVersionsApi.md#gamecenterenabledversionscompatibleversionsgettomanyrelated) | **GET** /v1/gameCenterEnabledVersions/{id}/compatibleVersions |  |
| [**GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationship**](GameCenterEnabledVersionsApi.md#gamecenterenabledversionscompatibleversionsgettomanyrelationship) | **GET** /v1/gameCenterEnabledVersions/{id}/relationships/compatibleVersions |  |
| [**GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationship**](GameCenterEnabledVersionsApi.md#gamecenterenabledversionscompatibleversionsreplacetomanyrelationship) | **PATCH** /v1/gameCenterEnabledVersions/{id}/relationships/compatibleVersions |  |

<a name="gamecenterenabledversionscompatibleversionscreatetomanyrelationship"></a>
# **GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationship**
> void GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationship (string id, GameCenterEnabledVersionCompatibleVersionsLinkagesRequest gameCenterEnabledVersionCompatibleVersionsLinkagesRequest)



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
    public class GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationshipExample
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
            var apiInstance = new GameCenterEnabledVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterEnabledVersionCompatibleVersionsLinkagesRequest = new GameCenterEnabledVersionCompatibleVersionsLinkagesRequest(); // GameCenterEnabledVersionCompatibleVersionsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationship(id, gameCenterEnabledVersionCompatibleVersionsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationshipWithHttpInfo(id, gameCenterEnabledVersionCompatibleVersionsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsCreateToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterEnabledVersionCompatibleVersionsLinkagesRequest** | [**GameCenterEnabledVersionCompatibleVersionsLinkagesRequest**](GameCenterEnabledVersionCompatibleVersionsLinkagesRequest.md) | List of related linkages |  |

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

<a name="gamecenterenabledversionscompatibleversionsdeletetomanyrelationship"></a>
# **GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationship**
> void GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationship (string id, GameCenterEnabledVersionCompatibleVersionsLinkagesRequest gameCenterEnabledVersionCompatibleVersionsLinkagesRequest)



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
    public class GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationshipExample
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
            var apiInstance = new GameCenterEnabledVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterEnabledVersionCompatibleVersionsLinkagesRequest = new GameCenterEnabledVersionCompatibleVersionsLinkagesRequest(); // GameCenterEnabledVersionCompatibleVersionsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationship(id, gameCenterEnabledVersionCompatibleVersionsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationshipWithHttpInfo(id, gameCenterEnabledVersionCompatibleVersionsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsDeleteToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterEnabledVersionCompatibleVersionsLinkagesRequest** | [**GameCenterEnabledVersionCompatibleVersionsLinkagesRequest**](GameCenterEnabledVersionCompatibleVersionsLinkagesRequest.md) | List of related linkages |  |

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

<a name="gamecenterenabledversionscompatibleversionsgettomanyrelated"></a>
# **GameCenterEnabledVersionsCompatibleVersionsGetToManyRelated**
> GameCenterEnabledVersionsResponse GameCenterEnabledVersionsCompatibleVersionsGetToManyRelated (string id, List<string>? filterPlatform = null, List<string>? filterVersionString = null, List<string>? filterApp = null, List<string>? filterId = null, List<string>? sort = null, List<string>? fieldsGameCenterEnabledVersions = null, List<string>? fieldsApps = null, int? limit = null, int? limitCompatibleVersions = null, List<string>? include = null)



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
    public class GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedExample
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
            var apiInstance = new GameCenterEnabledVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 
            var filterVersionString = new List<string>?(); // List<string>? | filter by attribute 'versionString' (optional) 
            var filterApp = new List<string>?(); // List<string>? | filter by id(s) of related 'app' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsGameCenterEnabledVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterEnabledVersions (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitCompatibleVersions = 56;  // int? | maximum number of related compatibleVersions returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterEnabledVersionsResponse result = apiInstance.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelated(id, filterPlatform, filterVersionString, filterApp, filterId, sort, fieldsGameCenterEnabledVersions, fieldsApps, limit, limitCompatibleVersions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterEnabledVersionsResponse> response = apiInstance.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedWithHttpInfo(id, filterPlatform, filterVersionString, filterApp, filterId, sort, fieldsGameCenterEnabledVersions, fieldsApps, limit, limitCompatibleVersions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |
| **filterVersionString** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;versionString&#39; | [optional]  |
| **filterApp** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;app&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsGameCenterEnabledVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterEnabledVersions | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitCompatibleVersions** | **int?** | maximum number of related compatibleVersions returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**GameCenterEnabledVersionsResponse**](GameCenterEnabledVersionsResponse.md)

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
| **200** | List of GameCenterEnabledVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gamecenterenabledversionscompatibleversionsgettomanyrelationship"></a>
# **GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationship**
> GameCenterEnabledVersionCompatibleVersionsLinkagesResponse GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterEnabledVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterEnabledVersionCompatibleVersionsLinkagesResponse result = apiInstance.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterEnabledVersionCompatibleVersionsLinkagesResponse> response = apiInstance.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsGetToManyRelationshipWithHttpInfo: " + e.Message);
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

[**GameCenterEnabledVersionCompatibleVersionsLinkagesResponse**](GameCenterEnabledVersionCompatibleVersionsLinkagesResponse.md)

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

<a name="gamecenterenabledversionscompatibleversionsreplacetomanyrelationship"></a>
# **GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationship**
> void GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationship (string id, GameCenterEnabledVersionCompatibleVersionsLinkagesRequest gameCenterEnabledVersionCompatibleVersionsLinkagesRequest)



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
    public class GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterEnabledVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterEnabledVersionCompatibleVersionsLinkagesRequest = new GameCenterEnabledVersionCompatibleVersionsLinkagesRequest(); // GameCenterEnabledVersionCompatibleVersionsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationship(id, gameCenterEnabledVersionCompatibleVersionsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationshipWithHttpInfo(id, gameCenterEnabledVersionCompatibleVersionsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterEnabledVersionsApi.GameCenterEnabledVersionsCompatibleVersionsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterEnabledVersionCompatibleVersionsLinkagesRequest** | [**GameCenterEnabledVersionCompatibleVersionsLinkagesRequest**](GameCenterEnabledVersionCompatibleVersionsLinkagesRequest.md) | List of related linkages |  |

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

