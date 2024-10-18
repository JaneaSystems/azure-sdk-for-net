// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Communication;

/// <summary>
/// SenderUsername.
/// </summary>
public partial class SenderUsername : ProvisionableResource
{
    /// <summary>
    /// The valid sender Username.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The display name for the senderUsername.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// A sender senderUsername to be used when sending emails.
    /// </summary>
    public BicepValue<string> Username { get => _username; set => _username.Assign(value); }
    private readonly BicepValue<string> _username;

    /// <summary>
    /// The location where the SenderUsername resource data is stored at rest.
    /// </summary>
    public BicepValue<string> DataLocation { get => _dataLocation; }
    private readonly BicepValue<string> _dataLocation;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the resource. Unknown is the default state for
    /// Communication Services.
    /// </summary>
    public BicepValue<CommunicationServiceProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<CommunicationServiceProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent CommunicationDomain.
    /// </summary>
    public CommunicationDomain? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CommunicationDomain> _parent;

    /// <summary>
    /// Creates a new SenderUsername.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SenderUsername resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SenderUsername.</param>
    public SenderUsername(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Communication/emailServices/domains/senderUsernames", resourceVersion ?? "2023-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _username = BicepValue<string>.DefineProperty(this, "Username", ["properties", "username"]);
        _dataLocation = BicepValue<string>.DefineProperty(this, "DataLocation", ["properties", "dataLocation"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<CommunicationServiceProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CommunicationDomain>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SenderUsername resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-06-01-preview.
        /// </summary>
        public static readonly string V2023_06_01_preview = "2023-06-01-preview";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-31.
        /// </summary>
        public static readonly string V2023_03_31 = "2023-03-31";
    }

    /// <summary>
    /// Creates a reference to an existing SenderUsername.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SenderUsername resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SenderUsername.</param>
    /// <returns>The existing SenderUsername resource.</returns>
    public static SenderUsername FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
