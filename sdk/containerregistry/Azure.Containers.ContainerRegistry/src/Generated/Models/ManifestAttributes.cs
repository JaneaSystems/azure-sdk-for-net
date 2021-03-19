// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest attributes details. </summary>
    internal partial class ManifestAttributes
    {
        /// <summary> Initializes a new instance of ManifestAttributes. </summary>
        internal ManifestAttributes()
        {
        }

        /// <summary> Initializes a new instance of ManifestAttributes. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="imageName"> Image name. </param>
        /// <param name="attributes"> Manifest attributes. </param>
        internal ManifestAttributes(string registry, string imageName, ManifestAttributesBase attributes)
        {
            Registry = registry;
            ImageName = imageName;
            Attributes = attributes;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
        /// <summary> Image name. </summary>
        public string ImageName { get; }
        /// <summary> Manifest attributes. </summary>
        public ManifestAttributesBase Attributes { get; }
    }
}
