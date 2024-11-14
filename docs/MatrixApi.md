# productconfigurator.Api.MatrixApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorCreateMatrix**](MatrixApi.md#productconfiguratorcreatematrix) | **POST** /v1/{tenantId}/matrix/create | Create Matrix |
| [**ProductConfiguratorDeleteMatrix**](MatrixApi.md#productconfiguratordeletematrix) | **DELETE** /v1/{tenantId}/matrix/{matrixId} | Delete Matrix |
| [**ProductConfiguratorGetMatrix**](MatrixApi.md#productconfiguratorgetmatrix) | **GET** /v1/{tenantId}/matrix/{matrixId} | Get Matrix |
| [**ProductConfiguratorListMatrices**](MatrixApi.md#productconfiguratorlistmatrices) | **POST** /v1/{tenantId}/configurator/{configuratorId}/page-size/{pageSize}/matrices | List Matrices |
| [**ProductConfiguratorRemovePricelistFromMatrix**](MatrixApi.md#productconfiguratorremovepricelistfrommatrix) | **DELETE** /v1/{tenantId}/matrix/{matrixId}/pricelist/{pricelistGrn} | Remove Pricelist from Matrix |
| [**ProductConfiguratorUpdateMatrix**](MatrixApi.md#productconfiguratorupdatematrix) | **PUT** /v1/{tenantId}/matrix/{matrixId} | Update Matrix |

<a id="productconfiguratorcreatematrix"></a>
# **ProductConfiguratorCreateMatrix**
> ProductconfiguratormatrixEntity ProductConfiguratorCreateMatrix (string tenantId, ProductConfiguratorCreateMatrixRequest body)

Create Matrix

Establish a new matrix by specifying the tenant ID. Utilize a POST request with the required matrix details in the body for seamless customization and expansion of matrix configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorCreateMatrixExample
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

            var apiInstance = new MatrixApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorCreateMatrixRequest(); // ProductConfiguratorCreateMatrixRequest | 

            try
            {
                // Create Matrix
                ProductconfiguratormatrixEntity result = apiInstance.ProductConfiguratorCreateMatrix(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MatrixApi.ProductConfiguratorCreateMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCreateMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Matrix
    ApiResponse<ProductconfiguratormatrixEntity> response = apiInstance.ProductConfiguratorCreateMatrixWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MatrixApi.ProductConfiguratorCreateMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorCreateMatrixRequest**](ProductConfiguratorCreateMatrixRequest.md) |  |  |

### Return type

[**ProductconfiguratormatrixEntity**](ProductconfiguratormatrixEntity.md)

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

<a id="productconfiguratordeletematrix"></a>
# **ProductConfiguratorDeleteMatrix**
> Object ProductConfiguratorDeleteMatrix (string tenantId, string matrixId)

Delete Matrix

Remove a specific matrix by specifying the tenant and matrix IDs. Ensure precision in matrix management with a straightforward DELETE request, simplifying the elimination of unwanted matrix configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorDeleteMatrixExample
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

            var apiInstance = new MatrixApi(config);
            var tenantId = "tenantId_example";  // string | 
            var matrixId = "matrixId_example";  // string | 

            try
            {
                // Delete Matrix
                Object result = apiInstance.ProductConfiguratorDeleteMatrix(tenantId, matrixId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MatrixApi.ProductConfiguratorDeleteMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorDeleteMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Matrix
    ApiResponse<Object> response = apiInstance.ProductConfiguratorDeleteMatrixWithHttpInfo(tenantId, matrixId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MatrixApi.ProductConfiguratorDeleteMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **matrixId** | **string** |  |  |

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

<a id="productconfiguratorgetmatrix"></a>
# **ProductConfiguratorGetMatrix**
> ProductconfiguratormatrixEntity ProductConfiguratorGetMatrix (string tenantId, string matrixId)

Get Matrix

Retrieve matrix details by specifying the tenant and matrix IDs. Utilize a GET request for a comprehensive view of matrix configurations within your product configurator service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorGetMatrixExample
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

            var apiInstance = new MatrixApi(config);
            var tenantId = "tenantId_example";  // string | 
            var matrixId = "matrixId_example";  // string | 

            try
            {
                // Get Matrix
                ProductconfiguratormatrixEntity result = apiInstance.ProductConfiguratorGetMatrix(tenantId, matrixId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MatrixApi.ProductConfiguratorGetMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Matrix
    ApiResponse<ProductconfiguratormatrixEntity> response = apiInstance.ProductConfiguratorGetMatrixWithHttpInfo(tenantId, matrixId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MatrixApi.ProductConfiguratorGetMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **matrixId** | **string** |  |  |

### Return type

[**ProductconfiguratormatrixEntity**](ProductconfiguratormatrixEntity.md)

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

<a id="productconfiguratorlistmatrices"></a>
# **ProductConfiguratorListMatrices**
> MatrixListMatricesResponse ProductConfiguratorListMatrices (string tenantId, string configuratorId, string pageSize, ProductConfiguratorListMatricesRequest body)

List Matrices

Retrieve a list of matrices for a specific configurator based on tenant and configurator IDs. Customize results by specifying page size for efficient pagination. Submit an empty body to get all matrices associated with the configurator. Streamline matrix management effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorListMatricesExample
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

            var apiInstance = new MatrixApi(config);
            var tenantId = "tenantId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string | 
            var pageSize = "pageSize_example";  // string | 
            var body = new ProductConfiguratorListMatricesRequest(); // ProductConfiguratorListMatricesRequest | 

            try
            {
                // List Matrices
                MatrixListMatricesResponse result = apiInstance.ProductConfiguratorListMatrices(tenantId, configuratorId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MatrixApi.ProductConfiguratorListMatrices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorListMatricesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Matrices
    ApiResponse<MatrixListMatricesResponse> response = apiInstance.ProductConfiguratorListMatricesWithHttpInfo(tenantId, configuratorId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MatrixApi.ProductConfiguratorListMatricesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **configuratorId** | **string** |  |  |
| **pageSize** | **string** |  |  |
| **body** | [**ProductConfiguratorListMatricesRequest**](ProductConfiguratorListMatricesRequest.md) |  |  |

### Return type

[**MatrixListMatricesResponse**](MatrixListMatricesResponse.md)

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

<a id="productconfiguratorremovepricelistfrommatrix"></a>
# **ProductConfiguratorRemovePricelistFromMatrix**
> ProductconfiguratormatrixEntity ProductConfiguratorRemovePricelistFromMatrix (string tenantId, string matrixId, string pricelistGrn)

Remove Pricelist from Matrix

Remove a specific pricelist from a matrix by specifying the tenant, matrix, and pricelist IDs. Use a DELETE request for precise management of pricelist configurations within your product configurator service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorRemovePricelistFromMatrixExample
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

            var apiInstance = new MatrixApi(config);
            var tenantId = "tenantId_example";  // string | 
            var matrixId = "matrixId_example";  // string | 
            var pricelistGrn = "pricelistGrn_example";  // string | 

            try
            {
                // Remove Pricelist from Matrix
                ProductconfiguratormatrixEntity result = apiInstance.ProductConfiguratorRemovePricelistFromMatrix(tenantId, matrixId, pricelistGrn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MatrixApi.ProductConfiguratorRemovePricelistFromMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorRemovePricelistFromMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Pricelist from Matrix
    ApiResponse<ProductconfiguratormatrixEntity> response = apiInstance.ProductConfiguratorRemovePricelistFromMatrixWithHttpInfo(tenantId, matrixId, pricelistGrn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MatrixApi.ProductConfiguratorRemovePricelistFromMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **matrixId** | **string** |  |  |
| **pricelistGrn** | **string** |  |  |

### Return type

[**ProductconfiguratormatrixEntity**](ProductconfiguratormatrixEntity.md)

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

<a id="productconfiguratorupdatematrix"></a>
# **ProductConfiguratorUpdateMatrix**
> ProductconfiguratormatrixEntity ProductConfiguratorUpdateMatrix (string tenantId, string matrixId, ProductConfiguratorUpdateMatrixRequest body)

Update Matrix

Modify an existing matrix by specifying the tenant and matrix IDs. Utilize a PUT request with updated matrix details in the body for seamless customization and fine-tuning of your product configurations. Keep your matrices in sync effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorUpdateMatrixExample
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

            var apiInstance = new MatrixApi(config);
            var tenantId = "tenantId_example";  // string | 
            var matrixId = "matrixId_example";  // string | 
            var body = new ProductConfiguratorUpdateMatrixRequest(); // ProductConfiguratorUpdateMatrixRequest | 

            try
            {
                // Update Matrix
                ProductconfiguratormatrixEntity result = apiInstance.ProductConfiguratorUpdateMatrix(tenantId, matrixId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MatrixApi.ProductConfiguratorUpdateMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorUpdateMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Matrix
    ApiResponse<ProductconfiguratormatrixEntity> response = apiInstance.ProductConfiguratorUpdateMatrixWithHttpInfo(tenantId, matrixId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MatrixApi.ProductConfiguratorUpdateMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **matrixId** | **string** |  |  |
| **body** | [**ProductConfiguratorUpdateMatrixRequest**](ProductConfiguratorUpdateMatrixRequest.md) |  |  |

### Return type

[**ProductconfiguratormatrixEntity**](ProductconfiguratormatrixEntity.md)

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

