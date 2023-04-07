# AppStoreConnect.Net.Api.SalesReportsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SalesReportsGetCollection**](SalesReportsApi.md#salesreportsgetcollection) | **GET** /v1/salesReports |  |

<a name="salesreportsgetcollection"></a>
# **SalesReportsGetCollection**
> FileParameter SalesReportsGetCollection (List<string> filterFrequency, List<string> filterReportSubType, List<string> filterReportType, List<string> filterVendorNumber, List<string>? filterReportDate = null, List<string>? filterVersion = null)



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
    public class SalesReportsGetCollectionExample
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
            var apiInstance = new SalesReportsApi(httpClient, config, httpClientHandler);
            var filterFrequency = new List<string>(); // List<string> | filter by attribute 'frequency'
            var filterReportSubType = new List<string>(); // List<string> | filter by attribute 'reportSubType'
            var filterReportType = new List<string>(); // List<string> | filter by attribute 'reportType'
            var filterVendorNumber = new List<string>(); // List<string> | filter by attribute 'vendorNumber'
            var filterReportDate = new List<string>?(); // List<string>? | filter by attribute 'reportDate' (optional) 
            var filterVersion = new List<string>?(); // List<string>? | filter by attribute 'version' (optional) 

            try
            {
                FileParameter result = apiInstance.SalesReportsGetCollection(filterFrequency, filterReportSubType, filterReportType, filterVendorNumber, filterReportDate, filterVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesReportsApi.SalesReportsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesReportsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileParameter> response = apiInstance.SalesReportsGetCollectionWithHttpInfo(filterFrequency, filterReportSubType, filterReportType, filterVendorNumber, filterReportDate, filterVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesReportsApi.SalesReportsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterFrequency** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;frequency&#39; |  |
| **filterReportSubType** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;reportSubType&#39; |  |
| **filterReportType** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;reportType&#39; |  |
| **filterVendorNumber** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;vendorNumber&#39; |  |
| **filterReportDate** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;reportDate&#39; | [optional]  |
| **filterVersion** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;version&#39; | [optional]  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/a-gzip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **200** | List of SalesReports |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

