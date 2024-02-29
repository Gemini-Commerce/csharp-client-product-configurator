# product-configurator.Api.DependencyApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorCreateDependency**](DependencyApi.md#productconfiguratorcreatedependency) | **POST** /v1/{tenantId}/step/{stepId}/dependency/create | Create Dependency |
| [**ProductConfiguratorDeleteDependency**](DependencyApi.md#productconfiguratordeletedependency) | **DELETE** /v1/{tenantId}/dependency/{dependencyId} | Delete Dependency |
| [**ProductConfiguratorListDependencies**](DependencyApi.md#productconfiguratorlistdependencies) | **POST** /v1/{tenantId}/page-size/{pageSize}/dependencies | List Dependencies |
| [**ProductConfiguratorUpdateDependency**](DependencyApi.md#productconfiguratorupdatedependency) | **PUT** /v1/{tenantId}/dependency/{dependencyId} | Update Dependency |

<a id="productconfiguratorcreatedependency"></a>
# **ProductConfiguratorCreateDependency**
> ProductconfiguratordependencyEntity ProductConfiguratorCreateDependency (string tenantId, string stepId, ProductConfiguratorCreateDependencyRequest body)

Create Dependency

Establish a new dependency for an existing step by specifying the tenant and step IDs. Utilize a POST request with the required dependency details in the body to seamlessly enhance the configuration logic of your product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorCreateDependencyExample
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

            var apiInstance = new DependencyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepId = "stepId_example";  // string | 
            var body = new ProductConfiguratorCreateDependencyRequest(); // ProductConfiguratorCreateDependencyRequest | 

            try
            {
                // Create Dependency
                ProductconfiguratordependencyEntity result = apiInstance.ProductConfiguratorCreateDependency(tenantId, stepId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DependencyApi.ProductConfiguratorCreateDependency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCreateDependencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Dependency
    ApiResponse<ProductconfiguratordependencyEntity> response = apiInstance.ProductConfiguratorCreateDependencyWithHttpInfo(tenantId, stepId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DependencyApi.ProductConfiguratorCreateDependencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepId** | **string** |  |  |
| **body** | [**ProductConfiguratorCreateDependencyRequest**](ProductConfiguratorCreateDependencyRequest.md) |  |  |

### Return type

[**ProductconfiguratordependencyEntity**](ProductconfiguratordependencyEntity.md)

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

<a id="productconfiguratordeletedependency"></a>
# **ProductConfiguratorDeleteDependency**
> Object ProductConfiguratorDeleteDependency (string tenantId, string dependencyId)

Delete Dependency

Remove a specific dependency by specifying the tenant and dependency IDs. Ensure precision in dependency management with a straightforward DELETE request, simplifying the elimination of unwanted configuration logic.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorDeleteDependencyExample
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

            var apiInstance = new DependencyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var dependencyId = "dependencyId_example";  // string | 

            try
            {
                // Delete Dependency
                Object result = apiInstance.ProductConfiguratorDeleteDependency(tenantId, dependencyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DependencyApi.ProductConfiguratorDeleteDependency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorDeleteDependencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Dependency
    ApiResponse<Object> response = apiInstance.ProductConfiguratorDeleteDependencyWithHttpInfo(tenantId, dependencyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DependencyApi.ProductConfiguratorDeleteDependencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **dependencyId** | **string** |  |  |

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
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorlistdependencies"></a>
# **ProductConfiguratorListDependencies**
> DependencyListDependenciesResponse ProductConfiguratorListDependencies (string tenantId, long pageSize, ProductConfiguratorListDependenciesRequest body)

List Dependencies

Retrieve a list of dependencies based on the specified tenant ID. Customize results by specifying page size for efficient pagination. Submit an empty body to get all dependencies associated with the configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorListDependenciesExample
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

            var apiInstance = new DependencyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 789L;  // long | 
            var body = new ProductConfiguratorListDependenciesRequest(); // ProductConfiguratorListDependenciesRequest | 

            try
            {
                // List Dependencies
                DependencyListDependenciesResponse result = apiInstance.ProductConfiguratorListDependencies(tenantId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DependencyApi.ProductConfiguratorListDependencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorListDependenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Dependencies
    ApiResponse<DependencyListDependenciesResponse> response = apiInstance.ProductConfiguratorListDependenciesWithHttpInfo(tenantId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DependencyApi.ProductConfiguratorListDependenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **long** |  |  |
| **body** | [**ProductConfiguratorListDependenciesRequest**](ProductConfiguratorListDependenciesRequest.md) |  |  |

### Return type

[**DependencyListDependenciesResponse**](DependencyListDependenciesResponse.md)

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

<a id="productconfiguratorupdatedependency"></a>
# **ProductConfiguratorUpdateDependency**
> ProductconfiguratordependencyEntity ProductConfiguratorUpdateDependency (string tenantId, string dependencyId, ProductConfiguratorUpdateDependencyRequest body)

Update Dependency

Modify an existing dependency by specifying the tenant and dependency IDs. Utilize a PUT request with updated dependency details in the body for seamless customization and fine-tuning of your product configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorUpdateDependencyExample
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

            var apiInstance = new DependencyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var dependencyId = "dependencyId_example";  // string | 
            var body = new ProductConfiguratorUpdateDependencyRequest(); // ProductConfiguratorUpdateDependencyRequest | 

            try
            {
                // Update Dependency
                ProductconfiguratordependencyEntity result = apiInstance.ProductConfiguratorUpdateDependency(tenantId, dependencyId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DependencyApi.ProductConfiguratorUpdateDependency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorUpdateDependencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Dependency
    ApiResponse<ProductconfiguratordependencyEntity> response = apiInstance.ProductConfiguratorUpdateDependencyWithHttpInfo(tenantId, dependencyId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DependencyApi.ProductConfiguratorUpdateDependencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **dependencyId** | **string** |  |  |
| **body** | [**ProductConfiguratorUpdateDependencyRequest**](ProductConfiguratorUpdateDependencyRequest.md) |  |  |

### Return type

[**ProductconfiguratordependencyEntity**](ProductconfiguratordependencyEntity.md)

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

