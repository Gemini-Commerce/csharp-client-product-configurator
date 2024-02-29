/*
 * Product Configurator Service
 *
 * ## Introduction  This comprehensive guide will equip you with the knowledge to integrate and leverage our Product Configurator Service in your applications.  ## Quick Start  Get up and running in no time! Follow these steps to kickstart your integration:  1. **Authentication:** Obtain your integration JWT to authenticate your requests. 2. **Client Libraries:** Explore our GitHub repositories to grab client libraries in your preferred programming language. 3. **API Overview:** Familiarize yourself with our RESTful API using the OpenAPI specification.  ## Integration  ### API Overview  Our RESTful API is the gateway to unlocking the full potential of Product Configurator. Check out the detailed [API Reference](/docs/category/configurator) for a granular understanding of each endpoint and request/response format.  ### Client Libraries  To expedite your integration process, we provide client libraries for various programming languages. Find the one that suits your stack in our [GitHub repositories](https://github.com/Gemini-Commerce).  ### Authentication  Security is paramount. Learn how to authenticate your requests using JWT. This ensures a secure and reliable connection between your application and Product Configurator.  ## Configuration Management  ### Configurator Lifecycle  Understand the lifecycle of configurators, from draft to active and deleted. This flexibility allows you to manage configurations at your own pace.  ### Steps and Options  Configure product steps with ease and define options effortlessly. Explore the power of dependencies to create dynamic and intuitive configurations.  ### Matrices  Delve into matrices—your secret weapon. Explore price and weight matrices, and learn how configured steps influence properties and pricing.  ### Price Management  Unleash dynamic pricing with our versatile price matrices. From fixed prices to incremental structures, adapt to diverse pricing models effortlessly.  ## Security  Your data is in safe hands. Discover how Product Configurator ensures security through JWT authentication, safeguarding your sensitive information.  ## Backward Compatibility  Stay ahead of the curve. Learn about our versioning strategy, providing backward compatibility while allowing our service to evolve seamlessly.  ## Developer Support  Have questions? Need assistance? Write to us at [info@gemini-commerce.com](mailto:info@gemini-commerce.com) and we will get back to you.
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using product-configurator.Client;
using product-configurator.Api;
// uncomment below to import models
//using product-configurator.Model;

namespace product-configurator.Test.Api
{
    /// <summary>
    ///  Class for testing PropertyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PropertyApiTests : IDisposable
    {
        private PropertyApi instance;

        public PropertyApiTests()
        {
            instance = new PropertyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PropertyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PropertyApi
            //Assert.IsType<PropertyApi>(instance);
        }

        /// <summary>
        /// Test ProductConfiguratorBulkCreateProperties
        /// </summary>
        [Fact]
        public void ProductConfiguratorBulkCreatePropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //ProductConfiguratorBulkCreatePropertiesRequest body = null;
            //var response = instance.ProductConfiguratorBulkCreateProperties(tenantId, body);
            //Assert.IsType<ProductconfiguratorpropertyBulkCreateResponse>(response);
        }

        /// <summary>
        /// Test ProductConfiguratorBulkUpdateProperties
        /// </summary>
        [Fact]
        public void ProductConfiguratorBulkUpdatePropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //ProductConfiguratorBulkUpdatePropertiesRequest body = null;
            //var response = instance.ProductConfiguratorBulkUpdateProperties(tenantId, body);
            //Assert.IsType<ProductconfiguratorpropertyBulkUpdateResponse>(response);
        }

        /// <summary>
        /// Test ProductConfiguratorCreateProperty
        /// </summary>
        [Fact]
        public void ProductConfiguratorCreatePropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //ProductConfiguratorCreatePropertyRequest body = null;
            //var response = instance.ProductConfiguratorCreateProperty(tenantId, body);
            //Assert.IsType<ProductconfiguratorpropertyEntity>(response);
        }

        /// <summary>
        /// Test ProductConfiguratorListProperties
        /// </summary>
        [Fact]
        public void ProductConfiguratorListPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string matrixId = null;
            //string pageSize = null;
            //ProductConfiguratorListPropertiesRequest body = null;
            //var response = instance.ProductConfiguratorListProperties(tenantId, matrixId, pageSize, body);
            //Assert.IsType<PropertyListPropertiesResponse>(response);
        }

        /// <summary>
        /// Test ProductConfiguratorUpdateProperty
        /// </summary>
        [Fact]
        public void ProductConfiguratorUpdatePropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string propertyId = null;
            //ProductConfiguratorUpdatePropertyRequest body = null;
            //var response = instance.ProductConfiguratorUpdateProperty(tenantId, propertyId, body);
            //Assert.IsType<ProductconfiguratorpropertyEntity>(response);
        }
    }
}
