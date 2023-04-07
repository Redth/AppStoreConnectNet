# AppStoreConnect.Net.Api.AppCustomProductPageLocalizationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelated**](AppCustomProductPageLocalizationsApi.md#appcustomproductpagelocalizationsapppreviewsetsgettomanyrelated) | **GET** /v1/appCustomProductPageLocalizations/{id}/appPreviewSets |  |
| [**AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelated**](AppCustomProductPageLocalizationsApi.md#appcustomproductpagelocalizationsappscreenshotsetsgettomanyrelated) | **GET** /v1/appCustomProductPageLocalizations/{id}/appScreenshotSets |  |
| [**AppCustomProductPageLocalizationsCreateInstance**](AppCustomProductPageLocalizationsApi.md#appcustomproductpagelocalizationscreateinstance) | **POST** /v1/appCustomProductPageLocalizations |  |
| [**AppCustomProductPageLocalizationsDeleteInstance**](AppCustomProductPageLocalizationsApi.md#appcustomproductpagelocalizationsdeleteinstance) | **DELETE** /v1/appCustomProductPageLocalizations/{id} |  |
| [**AppCustomProductPageLocalizationsGetInstance**](AppCustomProductPageLocalizationsApi.md#appcustomproductpagelocalizationsgetinstance) | **GET** /v1/appCustomProductPageLocalizations/{id} |  |
| [**AppCustomProductPageLocalizationsUpdateInstance**](AppCustomProductPageLocalizationsApi.md#appcustomproductpagelocalizationsupdateinstance) | **PATCH** /v1/appCustomProductPageLocalizations/{id} |  |

<a name="appcustomproductpagelocalizationsapppreviewsetsgettomanyrelated"></a>
# **AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelated**
> AppPreviewSetsResponse AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelated (string id, List<string>? filterPreviewType = null, List<string>? filterAppStoreVersionExperimentTreatmentLocalization = null, List<string>? filterAppStoreVersionLocalization = null, List<string>? fieldsAppCustomProductPageLocalizations = null, List<string>? fieldsAppStoreVersionExperimentTreatmentLocalizations = null, List<string>? fieldsAppPreviews = null, List<string>? fieldsAppPreviewSets = null, List<string>? fieldsAppStoreVersionLocalizations = null, int? limit = null, int? limitAppPreviews = null, List<string>? include = null)



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
    public class AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedExample
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
            var apiInstance = new AppCustomProductPageLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterPreviewType = new List<string>?(); // List<string>? | filter by attribute 'previewType' (optional) 
            var filterAppStoreVersionExperimentTreatmentLocalization = new List<string>?(); // List<string>? | filter by id(s) of related 'appStoreVersionExperimentTreatmentLocalization' (optional) 
            var filterAppStoreVersionLocalization = new List<string>?(); // List<string>? | filter by id(s) of related 'appStoreVersionLocalization' (optional) 
            var fieldsAppCustomProductPageLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPageLocalizations (optional) 
            var fieldsAppStoreVersionExperimentTreatmentLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations (optional) 
            var fieldsAppPreviews = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreviews (optional) 
            var fieldsAppPreviewSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreviewSets (optional) 
            var fieldsAppStoreVersionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppPreviews = 56;  // int? | maximum number of related appPreviews returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppPreviewSetsResponse result = apiInstance.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelated(id, filterPreviewType, filterAppStoreVersionExperimentTreatmentLocalization, filterAppStoreVersionLocalization, fieldsAppCustomProductPageLocalizations, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppPreviews, fieldsAppPreviewSets, fieldsAppStoreVersionLocalizations, limit, limitAppPreviews, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppPreviewSetsResponse> response = apiInstance.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedWithHttpInfo(id, filterPreviewType, filterAppStoreVersionExperimentTreatmentLocalization, filterAppStoreVersionLocalization, fieldsAppCustomProductPageLocalizations, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppPreviews, fieldsAppPreviewSets, fieldsAppStoreVersionLocalizations, limit, limitAppPreviews, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterPreviewType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;previewType&#39; | [optional]  |
| **filterAppStoreVersionExperimentTreatmentLocalization** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;appStoreVersionExperimentTreatmentLocalization&#39; | [optional]  |
| **filterAppStoreVersionLocalization** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;appStoreVersionLocalization&#39; | [optional]  |
| **fieldsAppCustomProductPageLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPageLocalizations | [optional]  |
| **fieldsAppStoreVersionExperimentTreatmentLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations | [optional]  |
| **fieldsAppPreviews** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreviews | [optional]  |
| **fieldsAppPreviewSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreviewSets | [optional]  |
| **fieldsAppStoreVersionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppPreviews** | **int?** | maximum number of related appPreviews returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppPreviewSetsResponse**](AppPreviewSetsResponse.md)

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
| **200** | List of AppPreviewSets |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcustomproductpagelocalizationsappscreenshotsetsgettomanyrelated"></a>
# **AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelated**
> AppScreenshotSetsResponse AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelated (string id, List<string>? filterScreenshotDisplayType = null, List<string>? filterAppStoreVersionExperimentTreatmentLocalization = null, List<string>? filterAppStoreVersionLocalization = null, List<string>? fieldsAppScreenshotSets = null, List<string>? fieldsAppCustomProductPageLocalizations = null, List<string>? fieldsAppStoreVersionExperimentTreatmentLocalizations = null, List<string>? fieldsAppScreenshots = null, List<string>? fieldsAppStoreVersionLocalizations = null, int? limit = null, int? limitAppScreenshots = null, List<string>? include = null)



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
    public class AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedExample
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
            var apiInstance = new AppCustomProductPageLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterScreenshotDisplayType = new List<string>?(); // List<string>? | filter by attribute 'screenshotDisplayType' (optional) 
            var filterAppStoreVersionExperimentTreatmentLocalization = new List<string>?(); // List<string>? | filter by id(s) of related 'appStoreVersionExperimentTreatmentLocalization' (optional) 
            var filterAppStoreVersionLocalization = new List<string>?(); // List<string>? | filter by id(s) of related 'appStoreVersionLocalization' (optional) 
            var fieldsAppScreenshotSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appScreenshotSets (optional) 
            var fieldsAppCustomProductPageLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPageLocalizations (optional) 
            var fieldsAppStoreVersionExperimentTreatmentLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations (optional) 
            var fieldsAppScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type appScreenshots (optional) 
            var fieldsAppStoreVersionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitAppScreenshots = 56;  // int? | maximum number of related appScreenshots returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppScreenshotSetsResponse result = apiInstance.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelated(id, filterScreenshotDisplayType, filterAppStoreVersionExperimentTreatmentLocalization, filterAppStoreVersionLocalization, fieldsAppScreenshotSets, fieldsAppCustomProductPageLocalizations, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppScreenshots, fieldsAppStoreVersionLocalizations, limit, limitAppScreenshots, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppScreenshotSetsResponse> response = apiInstance.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedWithHttpInfo(id, filterScreenshotDisplayType, filterAppStoreVersionExperimentTreatmentLocalization, filterAppStoreVersionLocalization, fieldsAppScreenshotSets, fieldsAppCustomProductPageLocalizations, fieldsAppStoreVersionExperimentTreatmentLocalizations, fieldsAppScreenshots, fieldsAppStoreVersionLocalizations, limit, limitAppScreenshots, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterScreenshotDisplayType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;screenshotDisplayType&#39; | [optional]  |
| **filterAppStoreVersionExperimentTreatmentLocalization** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;appStoreVersionExperimentTreatmentLocalization&#39; | [optional]  |
| **filterAppStoreVersionLocalization** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;appStoreVersionLocalization&#39; | [optional]  |
| **fieldsAppScreenshotSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appScreenshotSets | [optional]  |
| **fieldsAppCustomProductPageLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPageLocalizations | [optional]  |
| **fieldsAppStoreVersionExperimentTreatmentLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatmentLocalizations | [optional]  |
| **fieldsAppScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appScreenshots | [optional]  |
| **fieldsAppStoreVersionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitAppScreenshots** | **int?** | maximum number of related appScreenshots returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppScreenshotSetsResponse**](AppScreenshotSetsResponse.md)

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
| **200** | List of AppScreenshotSets |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcustomproductpagelocalizationscreateinstance"></a>
# **AppCustomProductPageLocalizationsCreateInstance**
> AppCustomProductPageLocalizationResponse AppCustomProductPageLocalizationsCreateInstance (AppCustomProductPageLocalizationCreateRequest appCustomProductPageLocalizationCreateRequest)



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
    public class AppCustomProductPageLocalizationsCreateInstanceExample
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
            var apiInstance = new AppCustomProductPageLocalizationsApi(httpClient, config, httpClientHandler);
            var appCustomProductPageLocalizationCreateRequest = new AppCustomProductPageLocalizationCreateRequest(); // AppCustomProductPageLocalizationCreateRequest | AppCustomProductPageLocalization representation

            try
            {
                AppCustomProductPageLocalizationResponse result = apiInstance.AppCustomProductPageLocalizationsCreateInstance(appCustomProductPageLocalizationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCustomProductPageLocalizationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCustomProductPageLocalizationResponse> response = apiInstance.AppCustomProductPageLocalizationsCreateInstanceWithHttpInfo(appCustomProductPageLocalizationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appCustomProductPageLocalizationCreateRequest** | [**AppCustomProductPageLocalizationCreateRequest**](AppCustomProductPageLocalizationCreateRequest.md) | AppCustomProductPageLocalization representation |  |

### Return type

[**AppCustomProductPageLocalizationResponse**](AppCustomProductPageLocalizationResponse.md)

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
| **201** | Single AppCustomProductPageLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcustomproductpagelocalizationsdeleteinstance"></a>
# **AppCustomProductPageLocalizationsDeleteInstance**
> void AppCustomProductPageLocalizationsDeleteInstance (string id)



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
    public class AppCustomProductPageLocalizationsDeleteInstanceExample
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
            var apiInstance = new AppCustomProductPageLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppCustomProductPageLocalizationsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCustomProductPageLocalizationsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppCustomProductPageLocalizationsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appcustomproductpagelocalizationsgetinstance"></a>
# **AppCustomProductPageLocalizationsGetInstance**
> AppCustomProductPageLocalizationResponse AppCustomProductPageLocalizationsGetInstance (string id, List<string>? fieldsAppCustomProductPageLocalizations = null, List<string>? include = null, List<string>? fieldsAppScreenshotSets = null, List<string>? fieldsAppPreviewSets = null, int? limitAppPreviewSets = null, int? limitAppScreenshotSets = null)



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
    public class AppCustomProductPageLocalizationsGetInstanceExample
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
            var apiInstance = new AppCustomProductPageLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCustomProductPageLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPageLocalizations (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppScreenshotSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appScreenshotSets (optional) 
            var fieldsAppPreviewSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreviewSets (optional) 
            var limitAppPreviewSets = 56;  // int? | maximum number of related appPreviewSets returned (when they are included) (optional) 
            var limitAppScreenshotSets = 56;  // int? | maximum number of related appScreenshotSets returned (when they are included) (optional) 

            try
            {
                AppCustomProductPageLocalizationResponse result = apiInstance.AppCustomProductPageLocalizationsGetInstance(id, fieldsAppCustomProductPageLocalizations, include, fieldsAppScreenshotSets, fieldsAppPreviewSets, limitAppPreviewSets, limitAppScreenshotSets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCustomProductPageLocalizationsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCustomProductPageLocalizationResponse> response = apiInstance.AppCustomProductPageLocalizationsGetInstanceWithHttpInfo(id, fieldsAppCustomProductPageLocalizations, include, fieldsAppScreenshotSets, fieldsAppPreviewSets, limitAppPreviewSets, limitAppScreenshotSets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCustomProductPageLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPageLocalizations | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppScreenshotSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appScreenshotSets | [optional]  |
| **fieldsAppPreviewSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreviewSets | [optional]  |
| **limitAppPreviewSets** | **int?** | maximum number of related appPreviewSets returned (when they are included) | [optional]  |
| **limitAppScreenshotSets** | **int?** | maximum number of related appScreenshotSets returned (when they are included) | [optional]  |

### Return type

[**AppCustomProductPageLocalizationResponse**](AppCustomProductPageLocalizationResponse.md)

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
| **200** | Single AppCustomProductPageLocalization |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcustomproductpagelocalizationsupdateinstance"></a>
# **AppCustomProductPageLocalizationsUpdateInstance**
> AppCustomProductPageLocalizationResponse AppCustomProductPageLocalizationsUpdateInstance (string id, AppCustomProductPageLocalizationUpdateRequest appCustomProductPageLocalizationUpdateRequest)



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
    public class AppCustomProductPageLocalizationsUpdateInstanceExample
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
            var apiInstance = new AppCustomProductPageLocalizationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appCustomProductPageLocalizationUpdateRequest = new AppCustomProductPageLocalizationUpdateRequest(); // AppCustomProductPageLocalizationUpdateRequest | AppCustomProductPageLocalization representation

            try
            {
                AppCustomProductPageLocalizationResponse result = apiInstance.AppCustomProductPageLocalizationsUpdateInstance(id, appCustomProductPageLocalizationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCustomProductPageLocalizationsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCustomProductPageLocalizationResponse> response = apiInstance.AppCustomProductPageLocalizationsUpdateInstanceWithHttpInfo(id, appCustomProductPageLocalizationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCustomProductPageLocalizationsApi.AppCustomProductPageLocalizationsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appCustomProductPageLocalizationUpdateRequest** | [**AppCustomProductPageLocalizationUpdateRequest**](AppCustomProductPageLocalizationUpdateRequest.md) | AppCustomProductPageLocalization representation |  |

### Return type

[**AppCustomProductPageLocalizationResponse**](AppCustomProductPageLocalizationResponse.md)

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
| **200** | Single AppCustomProductPageLocalization |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

