// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// Properties for a registry image.
/// </summary>
public partial class ContainerRegistryImageDescriptor : ProvisionableConstruct
{
    /// <summary>
    /// The registry login server.
    /// </summary>
    public BicepValue<string> Registry { get => _registry; set => _registry.Assign(value); }
    private readonly BicepValue<string> _registry;

    /// <summary>
    /// The repository name.
    /// </summary>
    public BicepValue<string> Repository { get => _repository; set => _repository.Assign(value); }
    private readonly BicepValue<string> _repository;

    /// <summary>
    /// The tag name.
    /// </summary>
    public BicepValue<string> Tag { get => _tag; set => _tag.Assign(value); }
    private readonly BicepValue<string> _tag;

    /// <summary>
    /// The sha256-based digest of the image manifest.
    /// </summary>
    public BicepValue<string> Digest { get => _digest; set => _digest.Assign(value); }
    private readonly BicepValue<string> _digest;

    /// <summary>
    /// Creates a new ContainerRegistryImageDescriptor.
    /// </summary>
    public ContainerRegistryImageDescriptor()
    {
        _registry = BicepValue<string>.DefineProperty(this, "Registry", ["registry"]);
        _repository = BicepValue<string>.DefineProperty(this, "Repository", ["repository"]);
        _tag = BicepValue<string>.DefineProperty(this, "Tag", ["tag"]);
        _digest = BicepValue<string>.DefineProperty(this, "Digest", ["digest"]);
    }
}
