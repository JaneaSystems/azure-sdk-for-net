// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class StaticSiteLinkedBackendOperationSource : IOperationSource<StaticSiteLinkedBackendResource>
    {
        private readonly ArmClient _client;

        internal StaticSiteLinkedBackendOperationSource(ArmClient client)
        {
            _client = client;
        }

        StaticSiteLinkedBackendResource IOperationSource<StaticSiteLinkedBackendResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StaticSiteLinkedBackendData.DeserializeStaticSiteLinkedBackendData(document.RootElement);
            return new StaticSiteLinkedBackendResource(_client, data);
        }

        async ValueTask<StaticSiteLinkedBackendResource> IOperationSource<StaticSiteLinkedBackendResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StaticSiteLinkedBackendData.DeserializeStaticSiteLinkedBackendData(document.RootElement);
            return new StaticSiteLinkedBackendResource(_client, data);
        }
    }
}
