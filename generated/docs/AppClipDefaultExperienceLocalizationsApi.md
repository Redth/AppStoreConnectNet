# AppStoreConnect.Net.Api.AppClipDefaultExperienceLocalizationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelated**](AppClipDefaultExperienceLocalizationsApi.md#appclipdefaultexperiencelocalizationsappclipheaderimagegettoonerelated) | **GET** /v1/appClipDefaultExperienceLocalizations/{id}/appClipHeaderImage |  |
| [**AppClipDefaultExperienceLocalizationsCreateInstance**](AppClipDefaultExperienceLocalizationsApi.md#appclipdefaultexperiencelocalizationscreateinstance) | **POST** /v1/appClipDefaultExperienceLocalizations |  |
| [**AppClipDefaultExperienceLocalizationsDeleteInstance**](AppClipDefaultExperienceLocalizationsApi.md#appclipdefaultexperiencelocalizationsdeleteinstance) | **DELETE** /v1/appClipDefaultExperienceLocalizations/{id} |  |
| [**AppClipDefaultExperienceLocalizationsGetInstance**](AppClipDefaultExperienceLocalizationsApi.md#appclipdefaultexperiencelocalizationsgetinstance) | **GET** /v1/appClipDefaultExperienceLocalizations/{id} |  |
| [**AppClipDefaultExperienceLocalizationsUpdateInstance**](AppClipDefaultExperienceLocalizationsApi.md#appclipdefaultexperiencelocalizationsupdateinstance) | **PATCH** /v1/appClipDefaultExperienceLocalizations/{id} |  |

<a name="appclipdefaultexperiencelocalizationsappclipheaderimagegettoonerelated"></a>
# **AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelated**
> AppClipHeaderImageResponse AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelated (string id, List<string>? fieldsAppClipHeaderImages = null, List<string>? fieldsAppClipDefaultExperienceLocalizations = null, List<string>? include = null)



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
    public class AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedExample
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
            var apiInstance = new AppClipDefaultExperienceLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipHeaderImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipHeaderImages (optional) 
            var fieldsAppClipDefaultExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperienceLocalizations (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipHeaderImageResponse result = apiInstance.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelated(id, fieldsAppClipHeaderImages, fieldsAppClipDefaultExperienceLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipHeaderImageResponse> response = apiInstance.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedWithHttpInfo(id, fieldsAppClipHeaderImages, fieldsAppClipDefaultExperienceLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipHeaderImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipHeaderImages | [optional]  |
| **fieldsAppClipDefaultExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperienceLocalizations | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipHeaderImageResponse**](AppClipHeaderImageResponse.md)

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
| **200** | Single AppClipHeaderImage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencelocalizationscreateinstance"></a>
# **AppClipDefaultExperienceLocalizationsCreateInstance**
> AppClipDefaultExperienceLocalizationResponse AppClipDefaultExperienceLocalizationsCreateInstance (AppClipDefaultExperienceLocalizationCreateRequest appClipDefaultExperienceLocalizationCreateRequest)



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
    public class AppClipDefaultExperienceLocalizationsCreateInstanceExample
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
            var apiInstance = new AppClipDefaultExperienceLocalizationsApi(httpClient, config, httpClientHandler);
            var appClipDefaultExperienceLocalizationCreateRequest = new AppClipDefaultExperienceLocalizationCreateRequest(); // AppClipDefaultExperienceLocalizationCreateRequest | AppClipDefaultExperienceLocalization representation

            try
            {
                AppClipDefaultExperienceLocalizationResponse result = apiInstance.AppClipDefaultExperienceLocalizationsCreateInstance(appClipDefaultExperienceLocalizationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperienceLocalizationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceLocalizationResponse> response = apiInstance.AppClipDefaultExperienceLocalizationsCreateInstanceWithHttpInfo(appClipDefaultExperienceLocalizationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appClipDefaultExperienceLocalizationCreateRequest** | [**AppClipDefaultExperienceLocalizationCreateRequest**](AppClipDefaultExperienceLocalizationCreateRequest.md) | AppClipDefaultExperienceLocalization representation |  |

### Return type

[**AppClipDefaultExperienceLocalizationResponse**](AppClipDefaultExperienceLocalizationResponse.md)

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
| **201** | Single AppClipDefaultExperienceLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencelocalizationsdeleteinstance"></a>
# **AppClipDefaultExperienceLocalizationsDeleteInstance**
> void AppClipDefaultExperienceLocalizationsDeleteInstance (string id)



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
    public class AppClipDefaultExperienceLocalizationsDeleteInstanceExample
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
            var apiInstance = new AppClipDefaultExperienceLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppClipDefaultExperienceLocalizationsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperienceLocalizationsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppClipDefaultExperienceLocalizationsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appclipdefaultexperiencelocalizationsgetinstance"></a>
# **AppClipDefaultExperienceLocalizationsGetInstance**
> AppClipDefaultExperienceLocalizationResponse AppClipDefaultExperienceLocalizationsGetInstance (string id, List<string>? fieldsAppClipDefaultExperienceLocalizations = null, List<string>? include = null, List<string>? fieldsAppClipHeaderImages = null)



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
    public class AppClipDefaultExperienceLocalizationsGetInstanceExample
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
            var apiInstance = new AppClipDefaultExperienceLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipDefaultExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperienceLocalizations (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppClipHeaderImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipHeaderImages (optional) 

            try
            {
                AppClipDefaultExperienceLocalizationResponse result = apiInstance.AppClipDefaultExperienceLocalizationsGetInstance(id, fieldsAppClipDefaultExperienceLocalizations, include, fieldsAppClipHeaderImages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperienceLocalizationsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceLocalizationResponse> response = apiInstance.AppClipDefaultExperienceLocalizationsGetInstanceWithHttpInfo(id, fieldsAppClipDefaultExperienceLocalizations, include, fieldsAppClipHeaderImages);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipDefaultExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperienceLocalizations | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppClipHeaderImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipHeaderImages | [optional]  |

### Return type

[**AppClipDefaultExperienceLocalizationResponse**](AppClipDefaultExperienceLocalizationResponse.md)

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
| **200** | Single AppClipDefaultExperienceLocalization |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipdefaultexperiencelocalizationsupdateinstance"></a>
# **AppClipDefaultExperienceLocalizationsUpdateInstance**
> AppClipDefaultExperienceLocalizationResponse AppClipDefaultExperienceLocalizationsUpdateInstance (string id, AppClipDefaultExperienceLocalizationUpdateRequest appClipDefaultExperienceLocalizationUpdateRequest)



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
    public class AppClipDefaultExperienceLocalizationsUpdateInstanceExample
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
            var apiInstance = new AppClipDefaultExperienceLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appClipDefaultExperienceLocalizationUpdateRequest = new AppClipDefaultExperienceLocalizationUpdateRequest(); // AppClipDefaultExperienceLocalizationUpdateRequest | AppClipDefaultExperienceLocalization representation

            try
            {
                AppClipDefaultExperienceLocalizationResponse result = apiInstance.AppClipDefaultExperienceLocalizationsUpdateInstance(id, appClipDefaultExperienceLocalizationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipDefaultExperienceLocalizationsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceLocalizationResponse> response = apiInstance.AppClipDefaultExperienceLocalizationsUpdateInstanceWithHttpInfo(id, appClipDefaultExperienceLocalizationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipDefaultExperienceLocalizationsApi.AppClipDefaultExperienceLocalizationsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appClipDefaultExperienceLocalizationUpdateRequest** | [**AppClipDefaultExperienceLocalizationUpdateRequest**](AppClipDefaultExperienceLocalizationUpdateRequest.md) | AppClipDefaultExperienceLocalization representation |  |

### Return type

[**AppClipDefaultExperienceLocalizationResponse**](AppClipDefaultExperienceLocalizationResponse.md)

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
| **200** | Single AppClipDefaultExperienceLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

