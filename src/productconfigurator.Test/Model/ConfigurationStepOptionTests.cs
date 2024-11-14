/*
 * Product Configurator Service
 *
 * ## Introduction  This comprehensive guide will equip you with the knowledge to integrate and leverage our Product Configurator Service in your applications.  ## Quick Start  Get up and running in no time! Follow these steps to kickstart your integration:  1. **Authentication:** Obtain your integration JWT to authenticate your requests. 2. **Client Libraries:** Explore our GitHub repositories to grab client libraries in your preferred programming language. 3. **API Overview:** Familiarize yourself with our RESTful API using the OpenAPI specification.  ## Integration  ### API Overview  Our RESTful API is the gateway to unlocking the full potential of Product Configurator. Check out the detailed [API Reference](/docs/category/configurator) for a granular understanding of each endpoint and request/response format.  ### Client Libraries  To expedite your integration process, we provide client libraries for various programming languages. Find the one that suits your stack in our [GitHub repositories](https://github.com/Gemini-Commerce).  ### Authentication  Security is paramount. Learn how to authenticate your requests using JWT. This ensures a secure and reliable connection between your application and Product Configurator.  ## Configuration Management  ### Configurator Lifecycle  Understand the lifecycle of configurators, from draft to active and deleted. This flexibility allows you to manage configurations at your own pace.  ### Steps and Options  Configure product steps with ease and define options effortlessly. Explore the power of dependencies to create dynamic and intuitive configurations.  ### Matrices  Delve into matrices—your secret weapon. Explore price and weight matrices, and learn how configured steps influence properties and pricing.  ### Price Management  Unleash dynamic pricing with our versatile price matrices. From fixed prices to incremental structures, adapt to diverse pricing models effortlessly.  ## Security  Your data is in safe hands. Discover how Product Configurator ensures security through JWT authentication, safeguarding your sensitive information.  ## Backward Compatibility  Stay ahead of the curve. Learn about our versioning strategy, providing backward compatibility while allowing our service to evolve seamlessly.  ## Developer Support  Have questions? Need assistance? Write to us at [info@gemini-commerce.com](mailto:info@gemini-commerce.com) and we will get back to you.
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using productconfigurator.Model;
using productconfigurator.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace productconfigurator.Test.Model
{
    /// <summary>
    ///  Class for testing ConfigurationStepOption
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConfigurationStepOptionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ConfigurationStepOption
        //private ConfigurationStepOption instance;

        public ConfigurationStepOptionTests()
        {
            // TODO uncomment below to create an instance of ConfigurationStepOption
            //instance = new ConfigurationStepOption();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConfigurationStepOption
        /// </summary>
        [Fact]
        public void ConfigurationStepOptionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ConfigurationStepOption
            //Assert.IsType<ConfigurationStepOption>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'Grn'
        /// </summary>
        [Fact]
        public void GrnTest()
        {
            // TODO unit test for the property 'Grn'
        }

        /// <summary>
        /// Test the property 'Label'
        /// </summary>
        [Fact]
        public void LabelTest()
        {
            // TODO unit test for the property 'Label'
        }

        /// <summary>
        /// Test the property 'Swatch'
        /// </summary>
        [Fact]
        public void SwatchTest()
        {
            // TODO unit test for the property 'Swatch'
        }

        /// <summary>
        /// Test the property 'OptionProperties'
        /// </summary>
        [Fact]
        public void OptionPropertiesTest()
        {
            // TODO unit test for the property 'OptionProperties'
        }

        /// <summary>
        /// Test the property 'HasQuantity'
        /// </summary>
        [Fact]
        public void HasQuantityTest()
        {
            // TODO unit test for the property 'HasQuantity'
        }
    }
}
