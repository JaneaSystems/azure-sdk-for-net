// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The StoragePermissionScope.
/// </summary>
public partial class StoragePermissionScope : ProvisionableConstruct
{
    /// <summary>
    /// The permissions for the local user. Possible values include: Read (r),
    /// Write (w), Delete (d), List (l), and Create (c).
    /// </summary>
    public BicepValue<string> Permissions { get => _permissions; set => _permissions.Assign(value); }
    private readonly BicepValue<string> _permissions;

    /// <summary>
    /// The service used by the local user, e.g. blob, file.
    /// </summary>
    public BicepValue<string> Service { get => _service; set => _service.Assign(value); }
    private readonly BicepValue<string> _service;

    /// <summary>
    /// The name of resource, normally the container name or the file share
    /// name, used by the local user.
    /// </summary>
    public BicepValue<string> ResourceName { get => _resourceName; set => _resourceName.Assign(value); }
    private readonly BicepValue<string> _resourceName;

    /// <summary>
    /// Creates a new StoragePermissionScope.
    /// </summary>
    public StoragePermissionScope()
    {
        _permissions = BicepValue<string>.DefineProperty(this, "Permissions", ["permissions"]);
        _service = BicepValue<string>.DefineProperty(this, "Service", ["service"]);
        _resourceName = BicepValue<string>.DefineProperty(this, "ResourceName", ["resourceName"]);
    }
}
