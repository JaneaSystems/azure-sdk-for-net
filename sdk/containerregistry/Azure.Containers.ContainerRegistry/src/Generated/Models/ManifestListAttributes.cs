// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ManifestListAttributes. </summary>
    internal partial class ManifestListAttributes
    {
        /// <summary> Initializes a new instance of ManifestListAttributes. </summary>
        public ManifestListAttributes()
        {
        }

        /// <summary> Initializes a new instance of ManifestListAttributes. </summary>
        /// <param name="mediaType"> The MIME type of the referenced object. This will generally be application/vnd.docker.image.manifest.v2+json, but it could also be application/vnd.docker.image.manifest.v1+json. </param>
        /// <param name="size"> The size in bytes of the object. </param>
        /// <param name="digest"> The digest of the content, as defined by the Registry V2 HTTP API Specification. </param>
        /// <param name="platform"> The platform object describes the platform which the image in the manifest runs on. A full list of valid operating system and architecture values are listed in the Go language documentation for $GOOS and $GOARCH. </param>
        internal ManifestListAttributes(string mediaType, long? size, string digest, Platform platform)
        {
            MediaType = mediaType;
            Size = size;
            Digest = digest;
            Platform = platform;
        }

        /// <summary> The MIME type of the referenced object. This will generally be application/vnd.docker.image.manifest.v2+json, but it could also be application/vnd.docker.image.manifest.v1+json. </summary>
        public string MediaType { get; set; }
        /// <summary> The size in bytes of the object. </summary>
        public long? Size { get; set; }
        /// <summary> The digest of the content, as defined by the Registry V2 HTTP API Specification. </summary>
        public string Digest { get; set; }
        /// <summary> The platform object describes the platform which the image in the manifest runs on. A full list of valid operating system and architecture values are listed in the Go language documentation for $GOOS and $GOARCH. </summary>
        public Platform Platform { get; set; }
    }
}
