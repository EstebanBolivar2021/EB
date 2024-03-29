// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The MetricAlerts service client. </summary>
    public partial class MetricAlertsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MetricAlertsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of MetricAlertsOperations for mocking. </summary>
        protected MetricAlertsOperations()
        {
        }
        /// <summary> Initializes a new instance of MetricAlertsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal MetricAlertsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new MetricAlertsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieve an alert rule definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetricAlertResource>> GetAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve an alert rule definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetricAlertResource> Get(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, ruleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an metric alert definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetricAlertResource>> CreateOrUpdateAsync(string resourceGroupName, string ruleName, MetricAlertResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, ruleName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an metric alert definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetricAlertResource> CreateOrUpdate(string resourceGroupName, string ruleName, MetricAlertResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, ruleName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an metric alert definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetricAlertResource>> UpdateAsync(string resourceGroupName, string ruleName, MetricAlertResourcePatch parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, ruleName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an metric alert definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetricAlertResource> Update(string resourceGroupName, string ruleName, MetricAlertResourcePatch parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, ruleName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an alert rule definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an alert rule definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, ruleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve alert rule definitions in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<MetricAlertResource> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MetricAlertResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieve alert rule definitions in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<MetricAlertResource> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<MetricAlertResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieve alert rule definitions in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<MetricAlertResource> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<MetricAlertResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieve alert rule definitions in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<MetricAlertResource> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<MetricAlertResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MetricAlertsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
