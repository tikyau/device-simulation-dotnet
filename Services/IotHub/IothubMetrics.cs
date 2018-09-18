﻿// Copyright (c) Microsoft. All rights reserved.

using System.Threading.Tasks;
using Microsoft.Azure.IoTSolutions.DeviceSimulation.Services.AzureManagementAdapter;

namespace Microsoft.Azure.IoTSolutions.DeviceSimulation.Services.IotHub
{
    // retrieves Iot Hub metrics from Azure management API
    public interface IIothubMetrics
    {
        Task<MetricsResponseModel> GetIothubMetricsAsync(MetricsRequestsModel requests);
    }

    public class IotHubMetrics : IIothubMetrics
    {
        private readonly IAzureManagementAdapterClient azureManagementAdapter;

        public IotHubMetrics(IAzureManagementAdapterClient azureManagementAdapter)
        {
            this.azureManagementAdapter = azureManagementAdapter;
        }

        /// <summary>
        /// Query Azure management API for the iothub metrics.
        /// </summary>
        /// <returns>Responses from the Azure management API</returns>
        public async Task<MetricsResponseModel> GetIothubMetricsAsync(MetricsRequestsModel requests)
        {
            return await this.azureManagementAdapter.PostAsync(requests);
        }
    }
}
