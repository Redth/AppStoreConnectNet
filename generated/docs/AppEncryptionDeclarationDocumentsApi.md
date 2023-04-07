# AppStoreConnect.Net.Api.AppEncryptionDeclarationDocumentsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppEncryptionDeclarationDocumentsCreateInstance**](AppEncryptionDeclarationDocumentsApi.md#appencryptiondeclarationdocumentscreateinstance) | **POST** /v1/appEncryptionDeclarationDocuments |  |
| [**AppEncryptionDeclarationDocumentsGetInstance**](AppEncryptionDeclarationDocumentsApi.md#appencryptiondeclarationdocumentsgetinstance) | **GET** /v1/appEncryptionDeclarationDocuments/{id} |  |
| [**AppEncryptionDeclarationDocumentsUpdateInstance**](AppEncryptionDeclarationDocumentsApi.md#appencryptiondeclarationdocumentsupdateinstance) | **PATCH** /v1/appEncryptionDeclarationDocuments/{id} |  |

<a name="appencryptiondeclarationdocumentscreateinstance"></a>
# **AppEncryptionDeclarationDocumentsCreateInstance**
> AppEncryptionDeclarationDocumentResponse AppEncryptionDeclarationDocumentsCreateInstance (AppEncryptionDeclarationDocumentCreateRequest appEncryptionDeclarationDocumentCreateRequest)



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
    public class AppEncryptionDeclarationDocumentsCreateInstanceExample
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
            var apiInstance = new AppEncryptionDeclarationDocumentsApi(httpClient, config, httpClientHandler);
            var appEncryptionDeclarationDocumentCreateRequest = new AppEncryptionDeclarationDocumentCreateRequest(); // AppEncryptionDeclarationDocumentCreateRequest | AppEncryptionDeclarationDocument representation

            try
            {
                AppEncryptionDeclarationDocumentResponse result = apiInstance.AppEncryptionDeclarationDocumentsCreateInstance(appEncryptionDeclarationDocumentCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEncryptionDeclarationDocumentsApi.AppEncryptionDeclarationDocumentsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEncryptionDeclarationDocumentsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEncryptionDeclarationDocumentResponse> response = apiInstance.AppEncryptionDeclarationDocumentsCreateInstanceWithHttpInfo(appEncryptionDeclarationDocumentCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEncryptionDeclarationDocumentsApi.AppEncryptionDeclarationDocumentsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appEncryptionDeclarationDocumentCreateRequest** | [**AppEncryptionDeclarationDocumentCreateRequest**](AppEncryptionDeclarationDocumentCreateRequest.md) | AppEncryptionDeclarationDocument representation |  |

### Return type

[**AppEncryptionDeclarationDocumentResponse**](AppEncryptionDeclarationDocumentResponse.md)

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
| **201** | Single AppEncryptionDeclarationDocument |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appencryptiondeclarationdocumentsgetinstance"></a>
# **AppEncryptionDeclarationDocumentsGetInstance**
> AppEncryptionDeclarationDocumentResponse AppEncryptionDeclarationDocumentsGetInstance (string id, List<string>? fieldsAppEncryptionDeclarationDocuments = null)



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
    public class AppEncryptionDeclarationDocumentsGetInstanceExample
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
            var apiInstance = new AppEncryptionDeclarationDocumentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEncryptionDeclarationDocuments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEncryptionDeclarationDocuments (optional) 

            try
            {
                AppEncryptionDeclarationDocumentResponse result = apiInstance.AppEncryptionDeclarationDocumentsGetInstance(id, fieldsAppEncryptionDeclarationDocuments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEncryptionDeclarationDocumentsApi.AppEncryptionDeclarationDocumentsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEncryptionDeclarationDocumentsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEncryptionDeclarationDocumentResponse> response = apiInstance.AppEncryptionDeclarationDocumentsGetInstanceWithHttpInfo(id, fieldsAppEncryptionDeclarationDocuments);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEncryptionDeclarationDocumentsApi.AppEncryptionDeclarationDocumentsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEncryptionDeclarationDocuments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEncryptionDeclarationDocuments | [optional]  |

### Return type

[**AppEncryptionDeclarationDocumentResponse**](AppEncryptionDeclarationDocumentResponse.md)

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
| **200** | Single AppEncryptionDeclarationDocument |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appencryptiondeclarationdocumentsupdateinstance"></a>
# **AppEncryptionDeclarationDocumentsUpdateInstance**
> AppEncryptionDeclarationDocumentResponse AppEncryptionDeclarationDocumentsUpdateInstance (string id, AppEncryptionDeclarationDocumentUpdateRequest appEncryptionDeclarationDocumentUpdateRequest)



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
    public class AppEncryptionDeclarationDocumentsUpdateInstanceExample
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
            var apiInstance = new AppEncryptionDeclarationDocumentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appEncryptionDeclarationDocumentUpdateRequest = new AppEncryptionDeclarationDocumentUpdateRequest(); // AppEncryptionDeclarationDocumentUpdateRequest | AppEncryptionDeclarationDocument representation

            try
            {
                AppEncryptionDeclarationDocumentResponse result = apiInstance.AppEncryptionDeclarationDocumentsUpdateInstance(id, appEncryptionDeclarationDocumentUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppEncryptionDeclarationDocumentsApi.AppEncryptionDeclarationDocumentsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppEncryptionDeclarationDocumentsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEncryptionDeclarationDocumentResponse> response = apiInstance.AppEncryptionDeclarationDocumentsUpdateInstanceWithHttpInfo(id, appEncryptionDeclarationDocumentUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppEncryptionDeclarationDocumentsApi.AppEncryptionDeclarationDocumentsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appEncryptionDeclarationDocumentUpdateRequest** | [**AppEncryptionDeclarationDocumentUpdateRequest**](AppEncryptionDeclarationDocumentUpdateRequest.md) | AppEncryptionDeclarationDocument representation |  |

### Return type

[**AppEncryptionDeclarationDocumentResponse**](AppEncryptionDeclarationDocumentResponse.md)

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
| **200** | Single AppEncryptionDeclarationDocument |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

