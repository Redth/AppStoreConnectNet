# AppStoreConnect.Net.Api.AppStoreVersionExperimentTreatmentsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated**](AppStoreVersionExperimentTreatmentsApi.md#appstoreversionexperimenttreatmentsappstoreversionexperimenttreatmentlocalizationsgettomanyrelated) | **GET** /v1/appStoreVersionExperimentTreatments/{id}/appStoreVersionExperimentTreatmentLocalizations |  |
| [**AppStoreVersionExperimentTreatmentsCreateInstance**](AppStoreVersionExperimentTreatmentsApi.md#appstoreversionexperimenttreatmentscreateinstance) | **POST** /v1/appStoreVersionExperimentTreatments |  |
| [**AppStoreVersionExperimentTreatmentsDeleteInstance**](AppStoreVersionExperimentTreatmentsApi.md#appstoreversionexperimenttreatmentsdeleteinstance) | **DELETE** /v1/appStoreVersionExperimentTreatments/{id} |  |
| [**AppStoreVersionExperimentTreatmentsGetInstance**](AppStoreVersionExperimentTreatmentsApi.md#appstoreversionexperimenttreatmentsgetinstance) | **GET** /v1/appStoreVersionExperimentTreatments/{id} |  |
| [**AppStoreVersionExperimentTreatmentsUpdateInstance**](AppStoreVersionExperimentTreatmentsApi.md#appstoreversionexperimenttreatmentsupdateinstance) | **PATCH** /v1/appStoreVersionExperimentTreatments/{id} |  |

<a name="appstoreversionexperimenttreatmentsappstoreversionexperimenttreatmentlocalizationsgettomanyrelated"></a>
# **AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated**
> AppStoreVersionExperimentTreatmentLocalizationsResponse AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated (string id, List<string>? filterLocale = null, List<string>? fieldsAppScreenshotSets = null, List<string>? fieldsAppStoreVersionExperimentTreatments = null, List<string>? fieldsAppStoreVersionExperimentTreatmentLocalizations = null, List<string>? fieldsAppPreviewSets = null, int? limit = null, int? limitAppScreenshotSets = null, int? limitAppPreviewSets = null, List<string>? include = null)



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
    public class AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedExample
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
            var apiInstance = new AppStoreVersionExperimentTreatmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLocale = new List<string>?(); // List<string>? | filter by attribute 'locale' (optional) 
            var fieldsAppScreenshotSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appScreenshotSets (optional) 
            var fieldsAppStoreVersionExperimentTreatments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatments (optional) 
            var fieldsAppStoreVersionExperimentTreatmentLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations (optional) 
            var fieldsAppPreviewSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreviewSets (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppScreenshotSets = 56;  // int? | maximum number of related appScreenshotSets returned (when they are included) (optional) 
            var limitAppPreviewSets = 56;  // int? | maximum number of related appPreviewSets returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreVersionExperimentTreatmentLocalizationsResponse result = apiInstance.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated(id, filterLocale, fieldsAppScreenshotSets, fieldsAppStoreVersionExperimentTreatments, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppPreviewSets, limit, limitAppScreenshotSets, limitAppPreviewSets, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionExperimentTreatmentLocalizationsResponse> response = apiInstance.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedWithHttpInfo(id, filterLocale, fieldsAppScreenshotSets, fieldsAppStoreVersionExperimentTreatments, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppPreviewSets, limit, limitAppScreenshotSets, limitAppPreviewSets, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLocale** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;locale&#39; | [optional]  |
| **fieldsAppScreenshotSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appScreenshotSets | [optional]  |
| **fieldsAppStoreVersionExperimentTreatments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatments | [optional]  |
| **fieldsAppStoreVersionExperimentTreatmentLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations | [optional]  |
| **fieldsAppPreviewSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreviewSets | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppScreenshotSets** | **int?** | maximum number of related appScreenshotSets returned (when they are included) | [optional]  |
| **limitAppPreviewSets** | **int?** | maximum number of related appPreviewSets returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreVersionExperimentTreatmentLocalizationsResponse**](AppStoreVersionExperimentTreatmentLocalizationsResponse.md)

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
| **200** | List of AppStoreVersionExperimentTreatmentLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstoreversionexperimenttreatmentscreateinstance"></a>
# **AppStoreVersionExperimentTreatmentsCreateInstance**
> AppStoreVersionExperimentTreatmentResponse AppStoreVersionExperimentTreatmentsCreateInstance (AppStoreVersionExperimentTreatmentCreateRequest appStoreVersionExperimentTreatmentCreateRequest)



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
    public class AppStoreVersionExperimentTreatmentsCreateInstanceExample
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
            var apiInstance = new AppStoreVersionExperimentTreatmentsApi(httpClient, config, httpClientHandler);
            var appStoreVersionExperimentTreatmentCreateRequest = new AppStoreVersionExperimentTreatmentCreateRequest(); // AppStoreVersionExperimentTreatmentCreateRequest | AppStoreVersionExperimentTreatment representation

            try
            {
                AppStoreVersionExperimentTreatmentResponse result = apiInstance.AppStoreVersionExperimentTreatmentsCreateInstance(appStoreVersionExperimentTreatmentCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionExperimentTreatmentsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionExperimentTreatmentResponse> response = apiInstance.AppStoreVersionExperimentTreatmentsCreateInstanceWithHttpInfo(appStoreVersionExperimentTreatmentCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appStoreVersionExperimentTreatmentCreateRequest** | [**AppStoreVersionExperimentTreatmentCreateRequest**](AppStoreVersionExperimentTreatmentCreateRequest.md) | AppStoreVersionExperimentTreatment representation |  |

### Return type

[**AppStoreVersionExperimentTreatmentResponse**](AppStoreVersionExperimentTreatmentResponse.md)

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
| **201** | Single AppStoreVersionExperimentTreatment |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstoreversionexperimenttreatmentsdeleteinstance"></a>
# **AppStoreVersionExperimentTreatmentsDeleteInstance**
> void AppStoreVersionExperimentTreatmentsDeleteInstance (string id)



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
    public class AppStoreVersionExperimentTreatmentsDeleteInstanceExample
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
            var apiInstance = new AppStoreVersionExperimentTreatmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppStoreVersionExperimentTreatmentsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionExperimentTreatmentsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppStoreVersionExperimentTreatmentsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appstoreversionexperimenttreatmentsgetinstance"></a>
# **AppStoreVersionExperimentTreatmentsGetInstance**
> AppStoreVersionExperimentTreatmentResponse AppStoreVersionExperimentTreatmentsGetInstance (string id, List<string>? fieldsAppStoreVersionExperimentTreatments = null, List<string>? include = null, List<string>? fieldsAppStoreVersionExperimentTreatmentLocalizations = null, int? limitAppStoreVersionExperimentTreatmentLocalizations = null)



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
    public class AppStoreVersionExperimentTreatmentsGetInstanceExample
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
            var apiInstance = new AppStoreVersionExperimentTreatmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreVersionExperimentTreatments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatments (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppStoreVersionExperimentTreatmentLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations (optional) 
            var limitAppStoreVersionExperimentTreatmentLocalizations = 56;  // int? | maximum number of related appStoreVersionExperimentTreatmentLocalizations returned (when they are included) (optional) 

            try
            {
                AppStoreVersionExperimentTreatmentResponse result = apiInstance.AppStoreVersionExperimentTreatmentsGetInstance(id, fieldsAppStoreVersionExperimentTreatments, include, fieldsAppStoreVersionExperimentTreatmentLocalizations, limitAppStoreVersionExperimentTreatmentLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionExperimentTreatmentsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionExperimentTreatmentResponse> response = apiInstance.AppStoreVersionExperimentTreatmentsGetInstanceWithHttpInfo(id, fieldsAppStoreVersionExperimentTreatments, include, fieldsAppStoreVersionExperimentTreatmentLocalizations, limitAppStoreVersionExperimentTreatmentLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreVersionExperimentTreatments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatments | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppStoreVersionExperimentTreatmentLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations | [optional]  |
| **limitAppStoreVersionExperimentTreatmentLocalizations** | **int?** | maximum number of related appStoreVersionExperimentTreatmentLocalizations returned (when they are included) | [optional]  |

### Return type

[**AppStoreVersionExperimentTreatmentResponse**](AppStoreVersionExperimentTreatmentResponse.md)

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
| **200** | Single AppStoreVersionExperimentTreatment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstoreversionexperimenttreatmentsupdateinstance"></a>
# **AppStoreVersionExperimentTreatmentsUpdateInstance**
> AppStoreVersionExperimentTreatmentResponse AppStoreVersionExperimentTreatmentsUpdateInstance (string id, AppStoreVersionExperimentTreatmentUpdateRequest appStoreVersionExperimentTreatmentUpdateRequest)



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
    public class AppStoreVersionExperimentTreatmentsUpdateInstanceExample
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
            var apiInstance = new AppStoreVersionExperimentTreatmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreVersionExperimentTreatmentUpdateRequest = new AppStoreVersionExperimentTreatmentUpdateRequest(); // AppStoreVersionExperimentTreatmentUpdateRequest | AppStoreVersionExperimentTreatment representation

            try
            {
                AppStoreVersionExperimentTreatmentResponse result = apiInstance.AppStoreVersionExperimentTreatmentsUpdateInstance(id, appStoreVersionExperimentTreatmentUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionExperimentTreatmentsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionExperimentTreatmentResponse> response = apiInstance.AppStoreVersionExperimentTreatmentsUpdateInstanceWithHttpInfo(id, appStoreVersionExperimentTreatmentUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionExperimentTreatmentsApi.AppStoreVersionExperimentTreatmentsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreVersionExperimentTreatmentUpdateRequest** | [**AppStoreVersionExperimentTreatmentUpdateRequest**](AppStoreVersionExperimentTreatmentUpdateRequest.md) | AppStoreVersionExperimentTreatment representation |  |

### Return type

[**AppStoreVersionExperimentTreatmentResponse**](AppStoreVersionExperimentTreatmentResponse.md)

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
| **200** | Single AppStoreVersionExperimentTreatment |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

