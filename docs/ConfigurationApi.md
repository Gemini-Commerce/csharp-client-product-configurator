# product-configurator.Api.ConfigurationApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorGetAvailableConfiguration**](ConfigurationApi.md#productconfiguratorgetavailableconfiguration) | **GET** /v1/{tenantId}/product/{productId}/configuration | Get Available Configuration |
| [**ProductConfiguratorGetAvailableConfiguration2**](ConfigurationApi.md#productconfiguratorgetavailableconfiguration2) | **POST** /v1/{tenantId}/product/{productId}/configuration | Get Available Configuration |
| [**ProductConfiguratorGetConfigurationFromSelections**](ConfigurationApi.md#productconfiguratorgetconfigurationfromselections) | **POST** /v1/{tenantId}/product/{productId}/configuration-from-selections | Get Configuration from Selections |

<a id="productconfiguratorgetavailableconfiguration"></a>
# **ProductConfiguratorGetAvailableConfiguration**
> ConfigurationGetAvailableConfigurationResponse ProductConfiguratorGetAvailableConfiguration (string tenantId, string productId, string? configuratorId = null)

Get Available Configuration

Retrieve available configurations for a specific product and tenant. Use a GET request for read-only access or submit additional criteria in the body of a POST request for tailored configuration results. Streamline the retrieval of configurations effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorGetAvailableConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigurationApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string? | If not set, the service returns the active configurator (optional) 

            try
            {
                // Get Available Configuration
                ConfigurationGetAvailableConfigurationResponse result = apiInstance.ProductConfiguratorGetAvailableConfiguration(tenantId, productId, configuratorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ProductConfiguratorGetAvailableConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetAvailableConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Available Configuration
    ApiResponse<ConfigurationGetAvailableConfigurationResponse> response = apiInstance.ProductConfiguratorGetAvailableConfigurationWithHttpInfo(tenantId, productId, configuratorId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationApi.ProductConfiguratorGetAvailableConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **configuratorId** | **string?** | If not set, the service returns the active configurator | [optional]  |

### Return type

[**ConfigurationGetAvailableConfigurationResponse**](ConfigurationGetAvailableConfigurationResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorgetavailableconfiguration2"></a>
# **ProductConfiguratorGetAvailableConfiguration2**
> ConfigurationGetAvailableConfigurationResponse ProductConfiguratorGetAvailableConfiguration2 (string tenantId, string productId, ProductConfiguratorGetAvailableConfiguration2Request body)

Get Available Configuration

Retrieve available configurations for a specific product and tenant. Use a GET request for read-only access or submit additional criteria in the body of a POST request for tailored configuration results. Streamline the retrieval of configurations effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorGetAvailableConfiguration2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigurationApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var body = new ProductConfiguratorGetAvailableConfiguration2Request(); // ProductConfiguratorGetAvailableConfiguration2Request | 

            try
            {
                // Get Available Configuration
                ConfigurationGetAvailableConfigurationResponse result = apiInstance.ProductConfiguratorGetAvailableConfiguration2(tenantId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ProductConfiguratorGetAvailableConfiguration2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetAvailableConfiguration2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Available Configuration
    ApiResponse<ConfigurationGetAvailableConfigurationResponse> response = apiInstance.ProductConfiguratorGetAvailableConfiguration2WithHttpInfo(tenantId, productId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationApi.ProductConfiguratorGetAvailableConfiguration2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **body** | [**ProductConfiguratorGetAvailableConfiguration2Request**](ProductConfiguratorGetAvailableConfiguration2Request.md) |  |  |

### Return type

[**ConfigurationGetAvailableConfigurationResponse**](ConfigurationGetAvailableConfigurationResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorgetconfigurationfromselections"></a>
# **ProductConfiguratorGetConfigurationFromSelections**
> ConfigurationGetConfigurationFromSelectionsResponse ProductConfiguratorGetConfigurationFromSelections (string tenantId, string productId, ProductConfiguratorGetConfigurationFromSelectionsRequest body)

Get Configuration from Selections

Retrieve a configuration based on user selections for a specific product and tenant. Submit a POST request with user selections in the body to receive a tailored configuration. Enhance the user experience by dynamically generating configurations based on user input.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorGetConfigurationFromSelectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigurationApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var body = new ProductConfiguratorGetConfigurationFromSelectionsRequest(); // ProductConfiguratorGetConfigurationFromSelectionsRequest | 

            try
            {
                // Get Configuration from Selections
                ConfigurationGetConfigurationFromSelectionsResponse result = apiInstance.ProductConfiguratorGetConfigurationFromSelections(tenantId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ProductConfiguratorGetConfigurationFromSelections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetConfigurationFromSelectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Configuration from Selections
    ApiResponse<ConfigurationGetConfigurationFromSelectionsResponse> response = apiInstance.ProductConfiguratorGetConfigurationFromSelectionsWithHttpInfo(tenantId, productId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationApi.ProductConfiguratorGetConfigurationFromSelectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **body** | [**ProductConfiguratorGetConfigurationFromSelectionsRequest**](ProductConfiguratorGetConfigurationFromSelectionsRequest.md) |  |  |

### Return type

[**ConfigurationGetConfigurationFromSelectionsResponse**](ConfigurationGetConfigurationFromSelectionsResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

