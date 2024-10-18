// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// The ManagedInstancePrivateLinkServiceConnectionStateProperty.
/// </summary>
public partial class ManagedInstancePrivateLinkServiceConnectionStateProperty : ProvisionableConstruct
{
    /// <summary>
    /// The private link service connection status.
    /// </summary>
    public BicepValue<string> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<string> _status;

    /// <summary>
    /// The private link service connection description.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The private link service connection description.
    /// </summary>
    public BicepValue<string> ActionsRequired { get => _actionsRequired; }
    private readonly BicepValue<string> _actionsRequired;

    /// <summary>
    /// Creates a new ManagedInstancePrivateLinkServiceConnectionStateProperty.
    /// </summary>
    public ManagedInstancePrivateLinkServiceConnectionStateProperty()
    {
        _status = BicepValue<string>.DefineProperty(this, "Status", ["status"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _actionsRequired = BicepValue<string>.DefineProperty(this, "ActionsRequired", ["actionsRequired"], isOutput: true);
    }
}
