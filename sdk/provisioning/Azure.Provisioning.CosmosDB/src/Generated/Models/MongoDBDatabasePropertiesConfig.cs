// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The MongoDBDatabasePropertiesConfig.
/// </summary>
public partial class MongoDBDatabasePropertiesConfig : ProvisionableConstruct
{
    /// <summary>
    /// Value of the Cosmos DB resource throughput or autoscaleSettings. Use
    /// the ThroughputSetting resource when retrieving offer details.
    /// </summary>
    public BicepValue<int> Throughput { get => _throughput; set => _throughput.Assign(value); }
    private readonly BicepValue<int> _throughput;

    /// <summary>
    /// Represents maximum throughput, the resource can scale up to.
    /// </summary>
    public BicepValue<int> AutoscaleMaxThroughput { get => _autoscaleMaxThroughput; set => _autoscaleMaxThroughput.Assign(value); }
    private readonly BicepValue<int> _autoscaleMaxThroughput;

    /// <summary>
    /// Creates a new MongoDBDatabasePropertiesConfig.
    /// </summary>
    public MongoDBDatabasePropertiesConfig()
    {
        _throughput = BicepValue<int>.DefineProperty(this, "Throughput", ["throughput"]);
        _autoscaleMaxThroughput = BicepValue<int>.DefineProperty(this, "AutoscaleMaxThroughput", ["autoscaleSettings", "maxThroughput"]);
    }
}
