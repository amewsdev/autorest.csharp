// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureCompositeModelClient
{
    using Fixtures.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Composite Swagger Client that represents merging body complex and
    /// complex model swagger clients
    /// </summary>
    public partial interface IAzureCompositeModelClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Subscription ID.
        /// </summary>
        string SubscriptionId { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IBasicOperations.
        /// </summary>
        IBasicOperations Basic { get; }

        /// <summary>
        /// Gets the IPrimitiveOperations.
        /// </summary>
        IPrimitiveOperations Primitive { get; }

        /// <summary>
        /// Gets the IArrayOperations.
        /// </summary>
        IArrayOperations Array { get; }

        /// <summary>
        /// Gets the IDictionaryOperations.
        /// </summary>
        IDictionaryOperations Dictionary { get; }

        /// <summary>
        /// Gets the IInheritanceOperations.
        /// </summary>
        IInheritanceOperations Inheritance { get; }

        /// <summary>
        /// Gets the IPolymorphismOperations.
        /// </summary>
        IPolymorphismOperations Polymorphism { get; }

        /// <summary>
        /// Gets the IPolymorphicrecursiveOperations.
        /// </summary>
        IPolymorphicrecursiveOperations Polymorphicrecursive { get; }

        /// <summary>
        /// Gets the IReadonlypropertyOperations.
        /// </summary>
        IReadonlypropertyOperations Readonlyproperty { get; }

        /// <summary>
        /// Product Types
        /// </summary>
        /// <remarks>
        /// The Products endpoint returns information about the Uber products
        /// offered at a given location. The response includes the display name
        /// and other details about each product, and lists the products in the
        /// proper display order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource Group ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CatalogArray>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create products
        /// </summary>
        /// <remarks>
        /// Resets products.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Subscription ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource Group ID.
        /// </param>
        /// <param name='productDictionaryOfArray'>
        /// Dictionary of Array of product
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CatalogDictionary>> CreateWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, IDictionary<string, IList<Product>> productDictionaryOfArray = default(IDictionary<string, IList<Product>>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update products
        /// </summary>
        /// <remarks>
        /// Resets products.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Subscription ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource Group ID.
        /// </param>
        /// <param name='productArrayOfDictionary'>
        /// Array of dictionary of products
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CatalogArray>> UpdateWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, IList<IDictionary<string, Product>> productArrayOfDictionary = default(IList<IDictionary<string, Product>>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
