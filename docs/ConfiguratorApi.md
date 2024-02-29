# product-configurator.Api.ConfiguratorApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorCopyConfigurator**](ConfiguratorApi.md#productconfiguratorcopyconfigurator) | **POST** /v1/{tenantId}/product/{sourceConfiguratorId}/copy | Copy Configurator |
| [**ProductConfiguratorCreateConfigurator**](ConfiguratorApi.md#productconfiguratorcreateconfigurator) | **POST** /v1/{tenantId}/product/{productId}/create | Create Configurator |
| [**ProductConfiguratorDeleteConfigurator**](ConfiguratorApi.md#productconfiguratordeleteconfigurator) | **DELETE** /v1/{tenantId}/configurator/{configuratorId} | Delete Configurator |
| [**ProductConfiguratorGetConfiguratorByProductId**](ConfiguratorApi.md#productconfiguratorgetconfiguratorbyproductid) | **GET** /v1/{tenantId}/product/{productId} | Get Configurator by Product ID |
| [**ProductConfiguratorGetConfiguratorByProductId2**](ConfiguratorApi.md#productconfiguratorgetconfiguratorbyproductid2) | **GET** /v1/{tenantId}/product/{productId}/status/{status} | Get Configurator by Product ID |
| [**ProductConfiguratorListConfigurators**](ConfiguratorApi.md#productconfiguratorlistconfigurators) | **POST** /v1/{tenantId}/product/{productId}/page-size/{pageSize}/configurators | List Product Configurators |
| [**ProductConfiguratorUpdateConfigurator**](ConfiguratorApi.md#productconfiguratorupdateconfigurator) | **PUT** /v1/{tenantId}/configurator/{configuratorId} | Update Configurator |

<a id="productconfiguratorcopyconfigurator"></a>
# **ProductConfiguratorCopyConfigurator**
> ProductconfiguratorconfiguratorEntity ProductConfiguratorCopyConfigurator (string tenantId, string sourceConfiguratorId, ProductConfiguratorCopyConfiguratorRequest body)

Copy Configurator

Duplicate an existing product configurator from the source to the specified tenant and product. Submit an empty body to initiate the copy process, creating a new configuration based on the source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorCopyConfiguratorExample
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var sourceConfiguratorId = "sourceConfiguratorId_example";  // string | 
            var body = new ProductConfiguratorCopyConfiguratorRequest(); // ProductConfiguratorCopyConfiguratorRequest | 

            try
            {
                // Copy Configurator
                ProductconfiguratorconfiguratorEntity result = apiInstance.ProductConfiguratorCopyConfigurator(tenantId, sourceConfiguratorId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorCopyConfigurator: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCopyConfiguratorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy Configurator
    ApiResponse<ProductconfiguratorconfiguratorEntity> response = apiInstance.ProductConfiguratorCopyConfiguratorWithHttpInfo(tenantId, sourceConfiguratorId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorCopyConfiguratorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **sourceConfiguratorId** | **string** |  |  |
| **body** | [**ProductConfiguratorCopyConfiguratorRequest**](ProductConfiguratorCopyConfiguratorRequest.md) |  |  |

### Return type

[**ProductconfiguratorconfiguratorEntity**](ProductconfiguratorconfiguratorEntity.md)

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

<a id="productconfiguratorcreateconfigurator"></a>
# **ProductConfiguratorCreateConfigurator**
> ProductconfiguratorconfiguratorEntity ProductConfiguratorCreateConfigurator (string tenantId, string productId, ProductConfiguratorCreateConfiguratorRequest body)

Create Configurator

Create a new product configurator for a specified tenant and product. Submit the desired configuration details in the request body to initiate the creation process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorCreateConfiguratorExample
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var body = new ProductConfiguratorCreateConfiguratorRequest(); // ProductConfiguratorCreateConfiguratorRequest | 

            try
            {
                // Create Configurator
                ProductconfiguratorconfiguratorEntity result = apiInstance.ProductConfiguratorCreateConfigurator(tenantId, productId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorCreateConfigurator: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCreateConfiguratorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Configurator
    ApiResponse<ProductconfiguratorconfiguratorEntity> response = apiInstance.ProductConfiguratorCreateConfiguratorWithHttpInfo(tenantId, productId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorCreateConfiguratorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **body** | [**ProductConfiguratorCreateConfiguratorRequest**](ProductConfiguratorCreateConfiguratorRequest.md) |  |  |

### Return type

[**ProductconfiguratorconfiguratorEntity**](ProductconfiguratorconfiguratorEntity.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratordeleteconfigurator"></a>
# **ProductConfiguratorDeleteConfigurator**
> Object ProductConfiguratorDeleteConfigurator (string tenantId, string configuratorId)

Delete Configurator

Delete a product configurator by specifying the tenant and configurator IDs. Ensure precise removal of unwanted configurations with a straightforward DELETE request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorDeleteConfiguratorExample
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string | 

            try
            {
                // Delete Configurator
                Object result = apiInstance.ProductConfiguratorDeleteConfigurator(tenantId, configuratorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorDeleteConfigurator: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorDeleteConfiguratorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Configurator
    ApiResponse<Object> response = apiInstance.ProductConfiguratorDeleteConfiguratorWithHttpInfo(tenantId, configuratorId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorDeleteConfiguratorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **configuratorId** | **string** |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorgetconfiguratorbyproductid"></a>
# **ProductConfiguratorGetConfiguratorByProductId**
> ProductconfiguratorconfiguratorEntity ProductConfiguratorGetConfiguratorByProductId (string tenantId, string productId, string? status = null)

Get Configurator by Product ID

Retrieve product configurations with status details, filtered by product and tenant IDs. Flexible options for specifying additional status parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorGetConfiguratorByProductIdExample
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var status = "UNKNOWN";  // string? |  (optional)  (default to UNKNOWN)

            try
            {
                // Get Configurator by Product ID
                ProductconfiguratorconfiguratorEntity result = apiInstance.ProductConfiguratorGetConfiguratorByProductId(tenantId, productId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorGetConfiguratorByProductId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetConfiguratorByProductIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Configurator by Product ID
    ApiResponse<ProductconfiguratorconfiguratorEntity> response = apiInstance.ProductConfiguratorGetConfiguratorByProductIdWithHttpInfo(tenantId, productId, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorGetConfiguratorByProductIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **status** | **string?** |  | [optional] [default to UNKNOWN] |

### Return type

[**ProductconfiguratorconfiguratorEntity**](ProductconfiguratorconfiguratorEntity.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorgetconfiguratorbyproductid2"></a>
# **ProductConfiguratorGetConfiguratorByProductId2**
> ProductconfiguratorconfiguratorEntity ProductConfiguratorGetConfiguratorByProductId2 (string tenantId, string productId, string status)

Get Configurator by Product ID

Retrieve product configurations with status details, filtered by product and tenant IDs. Flexible options for specifying additional status parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorGetConfiguratorByProductId2Example
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var status = "UNKNOWN";  // string | 

            try
            {
                // Get Configurator by Product ID
                ProductconfiguratorconfiguratorEntity result = apiInstance.ProductConfiguratorGetConfiguratorByProductId2(tenantId, productId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorGetConfiguratorByProductId2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetConfiguratorByProductId2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Configurator by Product ID
    ApiResponse<ProductconfiguratorconfiguratorEntity> response = apiInstance.ProductConfiguratorGetConfiguratorByProductId2WithHttpInfo(tenantId, productId, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorGetConfiguratorByProductId2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **status** | **string** |  |  |

### Return type

[**ProductconfiguratorconfiguratorEntity**](ProductconfiguratorconfiguratorEntity.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorlistconfigurators"></a>
# **ProductConfiguratorListConfigurators**
> ConfiguratorListResponse ProductConfiguratorListConfigurators (string tenantId, string productId, long pageSize, ProductConfiguratorListPropertiesRequest body)

List Product Configurators

List all product configurators.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorListConfiguratorsExample
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var productId = "productId_example";  // string | 
            var pageSize = 789L;  // long | 
            var body = new ProductConfiguratorListPropertiesRequest(); // ProductConfiguratorListPropertiesRequest | 

            try
            {
                // List Product Configurators
                ConfiguratorListResponse result = apiInstance.ProductConfiguratorListConfigurators(tenantId, productId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorListConfigurators: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorListConfiguratorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Product Configurators
    ApiResponse<ConfiguratorListResponse> response = apiInstance.ProductConfiguratorListConfiguratorsWithHttpInfo(tenantId, productId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorListConfiguratorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **productId** | **string** |  |  |
| **pageSize** | **long** |  |  |
| **body** | [**ProductConfiguratorListPropertiesRequest**](ProductConfiguratorListPropertiesRequest.md) |  |  |

### Return type

[**ConfiguratorListResponse**](ConfiguratorListResponse.md)

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

<a id="productconfiguratorupdateconfigurator"></a>
# **ProductConfiguratorUpdateConfigurator**
> ProductconfiguratorconfiguratorEntity ProductConfiguratorUpdateConfigurator (string tenantId, string configuratorId, ProductConfiguratorUpdateConfiguratorRequest body)

Update Configurator

Modify an existing product configurator by specifying the tenant and configurator IDs. Use a PUT request with the updated configuration details in the body to seamlessly update and manage product configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorUpdateConfiguratorExample
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

            var apiInstance = new ConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string | 
            var body = new ProductConfiguratorUpdateConfiguratorRequest(); // ProductConfiguratorUpdateConfiguratorRequest | 

            try
            {
                // Update Configurator
                ProductconfiguratorconfiguratorEntity result = apiInstance.ProductConfiguratorUpdateConfigurator(tenantId, configuratorId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorUpdateConfigurator: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorUpdateConfiguratorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Configurator
    ApiResponse<ProductconfiguratorconfiguratorEntity> response = apiInstance.ProductConfiguratorUpdateConfiguratorWithHttpInfo(tenantId, configuratorId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfiguratorApi.ProductConfiguratorUpdateConfiguratorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **configuratorId** | **string** |  |  |
| **body** | [**ProductConfiguratorUpdateConfiguratorRequest**](ProductConfiguratorUpdateConfiguratorRequest.md) |  |  |

### Return type

[**ProductconfiguratorconfiguratorEntity**](ProductconfiguratorconfiguratorEntity.md)

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

